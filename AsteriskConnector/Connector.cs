using AsterNET.Manager;
using AsterNET.Manager.Action;
using AsterNET.Manager.Event;
using AsterNET.Manager.Response;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace AsteriskConnector
{
    public partial class Connector : Form
    {
        private ManagerConnection Manager;
        private string Host = string.Empty;
        private int Port = 0;
        private string LoginName = string.Empty;
        private string Password = string.Empty;

        public Connector()
        {
            InitializeComponent();
        }

        private void Connector_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["Host"]))
            {
                Host = ConfigurationManager.AppSettings["Host"];
            }

            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["Port"]))
            {
                Port = int.Parse(ConfigurationManager.AppSettings["Port"]);
            }

            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["Login"]))
            {
                LoginName = ConfigurationManager.AppSettings["Login"];
            }

            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["Password"]))
            {
                Password = ConfigurationManager.AppSettings["Password"];
            }

            TextBoxHost.Text = Host;
            NumericUpDownPort.Value = Port;
            TextBoxLogin.Text = LoginName;
            TextBoxPassword.Text = Password;
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            Manager = new ManagerConnection(Host, Port, LoginName, Password);
            Manager.FireAllEvents = true;
            Manager.PingInterval = 0;
            
            Manager.UnhandledEvent += UnhandledEvent;
            Manager.Hangup += Hangup;
            Manager.NewState += NewState;
            Manager.PeerlistComplete += PeerlistComplete;

            try
            {
                Manager.Login();
                GroupBoxCall.Enabled = true;
                GroupBoxCommand.Enabled = true;
                GroupBoxState.Enabled = true;
                TextBoxOutput.Text += "-----Connected-----" + Environment.NewLine + 
                    "Asterisk version : " + Manager.Version + Environment.NewLine + Environment.NewLine;
            }
            catch (Exception ex)
            {
                GroupBoxCall.Enabled = false;
                GroupBoxCommand.Enabled = false;
                GroupBoxState.Enabled = false;
                TextBoxOutput.Text += "-----Not connected-----" + Environment.NewLine +
                    ex.Message + Environment.NewLine + Environment.NewLine;
            }
            
        }

        string callerName;
        private void NewState(object sender, NewStateEvent e)
        {
            TextBoxOutput.Text += "-----State event detected-----" + Environment.NewLine +
                "Event code: " + e.ChannelState + Environment.NewLine +
                "Event description: " + e.ChannelStateDesc + Environment.NewLine +
                "from: " + e.CallerIdNum + " to " + e.Connectedlinenum + Environment.NewLine + Environment.NewLine;

            if (e.ChannelState == "5" && !string.IsNullOrEmpty(e.Channel))
            {
                callerName = e.Channel;
                ButtonDecline.Enabled = true;
            }
        }

        private void PeerlistComplete(object sender, PeerlistCompleteEvent e)
        {
        }

        private void Hangup(object sender, HangupEvent e)
        {
            //Cause code: 16
            //Cause description: Normal Clearing

            // Cause code: 17
            // Cause description: User busy

            TextBoxOutput.Text += "-----Hangup event detected-----" + Environment.NewLine +
                "Cause code: " + e.Cause + Environment.NewLine +
                "Cause description: " + e.CauseTxt + Environment.NewLine +
                "from: " + e.CallerIdNum + " to " + e.Connectedlinenum + Environment.NewLine + Environment.NewLine;
            
            ButtonDecline.Enabled = false;
        }

        private void ButtonCall_Click(object sender, EventArgs e)
        {
            var from = TextBoxCallFrom.Text.Trim();
            var to = TextBoxCallTo.Text.Trim();
            var context = CheckBoxInternal.Checked ? "from-internal" : "from-trunk";
            if (!string.IsNullOrEmpty(from) && !string.IsNullOrEmpty(to))
            {
                var originateAction = new OriginateAction();
                originateAction.Channel = "SIP/" + to;
                originateAction.CallerId = to;
                originateAction.Context = context;
                originateAction.Exten = from;
                originateAction.Priority = "1";
                originateAction.Timeout = 30000;
                originateAction.Async = true;
                var originateResponse = Manager.SendAction(originateAction);

                TextBoxOutput.Text += "-----Originating call-----" + Environment.NewLine + 
                    "from " + from + " to " + to + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                TextBoxOutput.Text += "Fill 'call from' and 'call to' fields. " + Environment.NewLine;
            }
        }

        private void ButtonClearOutput_Click(object sender, EventArgs e)
        {
            TextBoxOutput.Text = string.Empty;
        }

        private void ButtonExecuteCommand_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ComboBoxCommand.Text))
            {
                ExecuteCommand(ComboBoxCommand.Text);
            }
        }

        private string ExecuteCommand(string commandText)
        {
            // https://www.voip-info.org/asterisk-cli/#Generalcommands

            var command = new CommandAction();
            var response = new CommandResponse();
            command.Command = commandText;
            try
            {
                var result = string.Empty;
                TextBoxOutput.Text += "-----Executed '" + commandText + "' command -----" + Environment.NewLine;
                response = (CommandResponse)Manager.SendAction(command);
                foreach (var line in response.Result)
                {
                    result += line + Environment.NewLine;
                }
                TextBoxOutput.Text += result + Environment.NewLine;

                TextBoxOutput.SelectionStart = TextBoxOutput.TextLength;
                TextBoxOutput.ScrollToCaret();

                return result;
            }
            catch (Exception err)
            {
                Console.WriteLine("Command '" + commandText + "' failed: " + err + Environment.NewLine + Environment.NewLine);
                return "ERROR";
            }
        }

        private void UnhandledEvent(object sender, ManagerEvent e)
        {
            if (!(e is UnknownEvent || e is RegistryEvent || e is SuccessfulAuthEvent || e is VarSetEvent || e is NewExtenEvent))
            {
                
            }
        }

        private void ButtonDecline_Click(object sender, EventArgs e)
        {
            var hangupAction = new HangupAction();
            hangupAction.Channel = callerName;
            var hangupResponse = Manager.SendAction(hangupAction);
        }

        private void ComboBoxCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && !string.IsNullOrEmpty(ComboBoxCommand.Text))
            {
                ExecuteCommand(ComboBoxCommand.Text);
            }
        }

        private void ButtonDNDGet_Click(object sender, EventArgs e)
        {
            var number = TextBoxStateExtension.Text;
            if (!string.IsNullOrEmpty(number))
            {
                var get = new DBGetAction();
                get.Family = "DND";
                get.Key = number;
                var res = Manager.SendAction(get);
                if (res.Response == "Error")
                {
                    MessageBox.Show(number + " is active", "Extension state");
                }
                else
                {
                    MessageBox.Show(number + " is inactive", "Extension state");
                }
            }
        }

        private void ButtonDNDOn_Click(object sender, EventArgs e)
        {
            var number = TextBoxStateExtension.Text;
            if (!string.IsNullOrEmpty(number))
            {
                var put = new DBPutAction();
                put.Family = "DND";
                put.Key = number;
                put.Val = "YES";
                var response = Manager.SendAction(put);
            }
        }

        private void ButtonDNDOff_Click(object sender, EventArgs e)
        {
            var number = TextBoxStateExtension.Text;
            if (!string.IsNullOrEmpty(number))
            {
                var delete = new DBDelAction();
                delete.Family = "DND";
                delete.Key = number;
                var response = Manager.SendAction(delete);
            }
        }
    }
}