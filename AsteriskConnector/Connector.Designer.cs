namespace AsteriskConnector
{
    partial class Connector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxHost = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.LabelHost = new System.Windows.Forms.Label();
            this.LabelPort = new System.Windows.Forms.Label();
            this.LabelLoginName = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.NumericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.TextBoxOutput = new System.Windows.Forms.TextBox();
            this.ButtonCall = new System.Windows.Forms.Button();
            this.TextBoxCallTo = new System.Windows.Forms.TextBox();
            this.TextBoxCallFrom = new System.Windows.Forms.TextBox();
            this.LabelFrom = new System.Windows.Forms.Label();
            this.LabelCallTo = new System.Windows.Forms.Label();
            this.GroupBoxConnection = new System.Windows.Forms.GroupBox();
            this.GroupBoxCall = new System.Windows.Forms.GroupBox();
            this.CheckBoxInternal = new System.Windows.Forms.CheckBox();
            this.ButtonDecline = new System.Windows.Forms.Button();
            this.GroupBoxOutput = new System.Windows.Forms.GroupBox();
            this.ButtonClearOutput = new System.Windows.Forms.Button();
            this.GroupBoxCommand = new System.Windows.Forms.GroupBox();
            this.ComboBoxCommand = new System.Windows.Forms.ComboBox();
            this.ButtonExecuteCommand = new System.Windows.Forms.Button();
            this.GroupBoxState = new System.Windows.Forms.GroupBox();
            this.ButtonDNDOn = new System.Windows.Forms.Button();
            this.ButtonDNDOff = new System.Windows.Forms.Button();
            this.LabelStateExtension = new System.Windows.Forms.Label();
            this.ButtonStateDNDGet = new System.Windows.Forms.Button();
            this.TextBoxStateExtension = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPort)).BeginInit();
            this.GroupBoxConnection.SuspendLayout();
            this.GroupBoxCall.SuspendLayout();
            this.GroupBoxOutput.SuspendLayout();
            this.GroupBoxCommand.SuspendLayout();
            this.GroupBoxState.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxHost
            // 
            this.TextBoxHost.Location = new System.Drawing.Point(77, 14);
            this.TextBoxHost.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TextBoxHost.Name = "TextBoxHost";
            this.TextBoxHost.Size = new System.Drawing.Size(108, 20);
            this.TextBoxHost.TabIndex = 0;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(77, 76);
            this.TextBoxLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(110, 20);
            this.TextBoxLogin.TabIndex = 2;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(77, 107);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '●';
            this.TextBoxPassword.Size = new System.Drawing.Size(110, 20);
            this.TextBoxPassword.TabIndex = 3;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(14, 137);
            this.ButtonConnect.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(173, 32);
            this.ButtonConnect.TabIndex = 4;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // LabelHost
            // 
            this.LabelHost.AutoSize = true;
            this.LabelHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHost.Location = new System.Drawing.Point(46, 18);
            this.LabelHost.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelHost.Name = "LabelHost";
            this.LabelHost.Size = new System.Drawing.Size(29, 13);
            this.LabelHost.TabIndex = 5;
            this.LabelHost.Text = "Host";
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LabelPort.Location = new System.Drawing.Point(49, 49);
            this.LabelPort.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(26, 13);
            this.LabelPort.TabIndex = 6;
            this.LabelPort.Text = "Port";
            // 
            // LabelLoginName
            // 
            this.LabelLoginName.AutoSize = true;
            this.LabelLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LabelLoginName.Location = new System.Drawing.Point(11, 80);
            this.LabelLoginName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelLoginName.Name = "LabelLoginName";
            this.LabelLoginName.Size = new System.Drawing.Size(64, 13);
            this.LabelLoginName.TabIndex = 7;
            this.LabelLoginName.Text = "Login Name";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LabelPassword.Location = new System.Drawing.Point(22, 111);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(53, 13);
            this.LabelPassword.TabIndex = 8;
            this.LabelPassword.Text = "Password";
            // 
            // NumericUpDownPort
            // 
            this.NumericUpDownPort.Location = new System.Drawing.Point(77, 45);
            this.NumericUpDownPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericUpDownPort.Name = "NumericUpDownPort";
            this.NumericUpDownPort.Size = new System.Drawing.Size(82, 20);
            this.NumericUpDownPort.TabIndex = 9;
            // 
            // TextBoxOutput
            // 
            this.TextBoxOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxOutput.Location = new System.Drawing.Point(3, 16);
            this.TextBoxOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TextBoxOutput.Multiline = true;
            this.TextBoxOutput.Name = "TextBoxOutput";
            this.TextBoxOutput.ReadOnly = true;
            this.TextBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxOutput.Size = new System.Drawing.Size(337, 227);
            this.TextBoxOutput.TabIndex = 10;
            this.TextBoxOutput.WordWrap = false;
            // 
            // ButtonCall
            // 
            this.ButtonCall.Location = new System.Drawing.Point(6, 100);
            this.ButtonCall.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ButtonCall.Name = "ButtonCall";
            this.ButtonCall.Size = new System.Drawing.Size(117, 32);
            this.ButtonCall.TabIndex = 11;
            this.ButtonCall.Text = "Call";
            this.ButtonCall.UseVisualStyleBackColor = true;
            this.ButtonCall.Click += new System.EventHandler(this.ButtonCall_Click);
            // 
            // TextBoxCallTo
            // 
            this.TextBoxCallTo.Location = new System.Drawing.Point(35, 45);
            this.TextBoxCallTo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TextBoxCallTo.Name = "TextBoxCallTo";
            this.TextBoxCallTo.Size = new System.Drawing.Size(88, 20);
            this.TextBoxCallTo.TabIndex = 12;
            // 
            // TextBoxCallFrom
            // 
            this.TextBoxCallFrom.Location = new System.Drawing.Point(35, 14);
            this.TextBoxCallFrom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TextBoxCallFrom.Name = "TextBoxCallFrom";
            this.TextBoxCallFrom.Size = new System.Drawing.Size(88, 20);
            this.TextBoxCallFrom.TabIndex = 13;
            // 
            // LabelFrom
            // 
            this.LabelFrom.AutoSize = true;
            this.LabelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LabelFrom.Location = new System.Drawing.Point(3, 18);
            this.LabelFrom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Size = new System.Drawing.Size(30, 13);
            this.LabelFrom.TabIndex = 14;
            this.LabelFrom.Text = "From";
            // 
            // LabelCallTo
            // 
            this.LabelCallTo.AutoSize = true;
            this.LabelCallTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LabelCallTo.Location = new System.Drawing.Point(13, 49);
            this.LabelCallTo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelCallTo.Name = "LabelCallTo";
            this.LabelCallTo.Size = new System.Drawing.Size(20, 13);
            this.LabelCallTo.TabIndex = 15;
            this.LabelCallTo.Text = "To";
            // 
            // GroupBoxConnection
            // 
            this.GroupBoxConnection.Controls.Add(this.NumericUpDownPort);
            this.GroupBoxConnection.Controls.Add(this.TextBoxHost);
            this.GroupBoxConnection.Controls.Add(this.TextBoxLogin);
            this.GroupBoxConnection.Controls.Add(this.TextBoxPassword);
            this.GroupBoxConnection.Controls.Add(this.ButtonConnect);
            this.GroupBoxConnection.Controls.Add(this.LabelHost);
            this.GroupBoxConnection.Controls.Add(this.LabelPort);
            this.GroupBoxConnection.Controls.Add(this.LabelLoginName);
            this.GroupBoxConnection.Controls.Add(this.LabelPassword);
            this.GroupBoxConnection.Location = new System.Drawing.Point(13, 7);
            this.GroupBoxConnection.Name = "GroupBoxConnection";
            this.GroupBoxConnection.Size = new System.Drawing.Size(202, 175);
            this.GroupBoxConnection.TabIndex = 16;
            this.GroupBoxConnection.TabStop = false;
            this.GroupBoxConnection.Text = "Connection";
            // 
            // GroupBoxCall
            // 
            this.GroupBoxCall.Controls.Add(this.CheckBoxInternal);
            this.GroupBoxCall.Controls.Add(this.ButtonDecline);
            this.GroupBoxCall.Controls.Add(this.LabelFrom);
            this.GroupBoxCall.Controls.Add(this.ButtonCall);
            this.GroupBoxCall.Controls.Add(this.LabelCallTo);
            this.GroupBoxCall.Controls.Add(this.TextBoxCallTo);
            this.GroupBoxCall.Controls.Add(this.TextBoxCallFrom);
            this.GroupBoxCall.Enabled = false;
            this.GroupBoxCall.Location = new System.Drawing.Point(221, 7);
            this.GroupBoxCall.Name = "GroupBoxCall";
            this.GroupBoxCall.Size = new System.Drawing.Size(134, 175);
            this.GroupBoxCall.TabIndex = 17;
            this.GroupBoxCall.TabStop = false;
            this.GroupBoxCall.Text = "Call";
            // 
            // CheckBoxInternal
            // 
            this.CheckBoxInternal.AutoSize = true;
            this.CheckBoxInternal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckBoxInternal.Checked = true;
            this.CheckBoxInternal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxInternal.Location = new System.Drawing.Point(43, 76);
            this.CheckBoxInternal.Name = "CheckBoxInternal";
            this.CheckBoxInternal.Size = new System.Drawing.Size(80, 17);
            this.CheckBoxInternal.TabIndex = 17;
            this.CheckBoxInternal.Text = "Internal call";
            this.CheckBoxInternal.UseVisualStyleBackColor = true;
            // 
            // ButtonDecline
            // 
            this.ButtonDecline.Enabled = false;
            this.ButtonDecline.Location = new System.Drawing.Point(6, 137);
            this.ButtonDecline.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ButtonDecline.Name = "ButtonDecline";
            this.ButtonDecline.Size = new System.Drawing.Size(117, 32);
            this.ButtonDecline.TabIndex = 16;
            this.ButtonDecline.Text = "Decline";
            this.ButtonDecline.UseVisualStyleBackColor = true;
            this.ButtonDecline.Click += new System.EventHandler(this.ButtonDecline_Click);
            // 
            // GroupBoxOutput
            // 
            this.GroupBoxOutput.Controls.Add(this.ButtonClearOutput);
            this.GroupBoxOutput.Controls.Add(this.TextBoxOutput);
            this.GroupBoxOutput.Location = new System.Drawing.Point(12, 288);
            this.GroupBoxOutput.Name = "GroupBoxOutput";
            this.GroupBoxOutput.Size = new System.Drawing.Size(343, 274);
            this.GroupBoxOutput.TabIndex = 18;
            this.GroupBoxOutput.TabStop = false;
            this.GroupBoxOutput.Text = "Output";
            // 
            // ButtonClearOutput
            // 
            this.ButtonClearOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonClearOutput.Location = new System.Drawing.Point(3, 244);
            this.ButtonClearOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ButtonClearOutput.Name = "ButtonClearOutput";
            this.ButtonClearOutput.Size = new System.Drawing.Size(337, 27);
            this.ButtonClearOutput.TabIndex = 10;
            this.ButtonClearOutput.Text = "Empty";
            this.ButtonClearOutput.UseVisualStyleBackColor = true;
            this.ButtonClearOutput.Click += new System.EventHandler(this.ButtonClearOutput_Click);
            // 
            // GroupBoxCommand
            // 
            this.GroupBoxCommand.Controls.Add(this.ComboBoxCommand);
            this.GroupBoxCommand.Controls.Add(this.ButtonExecuteCommand);
            this.GroupBoxCommand.Enabled = false;
            this.GroupBoxCommand.Location = new System.Drawing.Point(13, 184);
            this.GroupBoxCommand.Name = "GroupBoxCommand";
            this.GroupBoxCommand.Size = new System.Drawing.Size(342, 50);
            this.GroupBoxCommand.TabIndex = 20;
            this.GroupBoxCommand.TabStop = false;
            this.GroupBoxCommand.Text = "Command";
            // 
            // ComboBoxCommand
            // 
            this.ComboBoxCommand.FormattingEnabled = true;
            this.ComboBoxCommand.Items.AddRange(new object[] {
            "core show help",
            "sip show channels",
            "sip show inuse",
            "sip show peers",
            "sip show registry",
            "sip show subscriptions",
            "sip show users",
            "manager show users",
            "database show"});
            this.ComboBoxCommand.Location = new System.Drawing.Point(14, 19);
            this.ComboBoxCommand.Name = "ComboBoxCommand";
            this.ComboBoxCommand.Size = new System.Drawing.Size(188, 21);
            this.ComboBoxCommand.TabIndex = 18;
            this.ComboBoxCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxCommand_KeyPress);
            // 
            // ButtonExecuteCommand
            // 
            this.ButtonExecuteCommand.Location = new System.Drawing.Point(214, 12);
            this.ButtonExecuteCommand.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ButtonExecuteCommand.Name = "ButtonExecuteCommand";
            this.ButtonExecuteCommand.Size = new System.Drawing.Size(117, 32);
            this.ButtonExecuteCommand.TabIndex = 17;
            this.ButtonExecuteCommand.Text = "Execute";
            this.ButtonExecuteCommand.UseVisualStyleBackColor = true;
            this.ButtonExecuteCommand.Click += new System.EventHandler(this.ButtonExecuteCommand_Click);
            // 
            // GroupBoxState
            // 
            this.GroupBoxState.Controls.Add(this.ButtonDNDOn);
            this.GroupBoxState.Controls.Add(this.ButtonDNDOff);
            this.GroupBoxState.Controls.Add(this.LabelStateExtension);
            this.GroupBoxState.Controls.Add(this.ButtonStateDNDGet);
            this.GroupBoxState.Controls.Add(this.TextBoxStateExtension);
            this.GroupBoxState.Enabled = false;
            this.GroupBoxState.Location = new System.Drawing.Point(12, 236);
            this.GroupBoxState.Name = "GroupBoxState";
            this.GroupBoxState.Size = new System.Drawing.Size(343, 50);
            this.GroupBoxState.TabIndex = 21;
            this.GroupBoxState.TabStop = false;
            this.GroupBoxState.Text = "Do not disturb";
            // 
            // ButtonDNDOn
            // 
            this.ButtonDNDOn.Location = new System.Drawing.Point(169, 10);
            this.ButtonDNDOn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ButtonDNDOn.Name = "ButtonDNDOn";
            this.ButtonDNDOn.Size = new System.Drawing.Size(82, 32);
            this.ButtonDNDOn.TabIndex = 21;
            this.ButtonDNDOn.Text = "Turn on DND";
            this.ButtonDNDOn.UseVisualStyleBackColor = true;
            this.ButtonDNDOn.Click += new System.EventHandler(this.ButtonDNDOn_Click);
            // 
            // ButtonDNDOff
            // 
            this.ButtonDNDOff.Location = new System.Drawing.Point(254, 10);
            this.ButtonDNDOff.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ButtonDNDOff.Name = "ButtonDNDOff";
            this.ButtonDNDOff.Size = new System.Drawing.Size(82, 32);
            this.ButtonDNDOff.TabIndex = 20;
            this.ButtonDNDOff.Text = "Turn off DND";
            this.ButtonDNDOff.UseVisualStyleBackColor = true;
            this.ButtonDNDOff.Click += new System.EventHandler(this.ButtonDNDOff_Click);
            // 
            // LabelStateExtension
            // 
            this.LabelStateExtension.AutoSize = true;
            this.LabelStateExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LabelStateExtension.Location = new System.Drawing.Point(10, 20);
            this.LabelStateExtension.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelStateExtension.Name = "LabelStateExtension";
            this.LabelStateExtension.Size = new System.Drawing.Size(53, 13);
            this.LabelStateExtension.TabIndex = 10;
            this.LabelStateExtension.Text = "Extension";
            // 
            // ButtonStateDNDGet
            // 
            this.ButtonStateDNDGet.Location = new System.Drawing.Point(103, 10);
            this.ButtonStateDNDGet.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ButtonStateDNDGet.Name = "ButtonStateDNDGet";
            this.ButtonStateDNDGet.Size = new System.Drawing.Size(63, 32);
            this.ButtonStateDNDGet.TabIndex = 19;
            this.ButtonStateDNDGet.Text = "Get state";
            this.ButtonStateDNDGet.UseVisualStyleBackColor = true;
            this.ButtonStateDNDGet.Click += new System.EventHandler(this.ButtonDNDGet_Click);
            // 
            // TextBoxStateExtension
            // 
            this.TextBoxStateExtension.Location = new System.Drawing.Point(65, 16);
            this.TextBoxStateExtension.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TextBoxStateExtension.Name = "TextBoxStateExtension";
            this.TextBoxStateExtension.Size = new System.Drawing.Size(35, 20);
            this.TextBoxStateExtension.TabIndex = 18;
            // 
            // Connector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 567);
            this.Controls.Add(this.GroupBoxState);
            this.Controls.Add(this.GroupBoxCommand);
            this.Controls.Add(this.GroupBoxOutput);
            this.Controls.Add(this.GroupBoxCall);
            this.Controls.Add(this.GroupBoxConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connector";
            this.Text = "Asterisk Connector";
            this.Load += new System.EventHandler(this.Connector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPort)).EndInit();
            this.GroupBoxConnection.ResumeLayout(false);
            this.GroupBoxConnection.PerformLayout();
            this.GroupBoxCall.ResumeLayout(false);
            this.GroupBoxCall.PerformLayout();
            this.GroupBoxOutput.ResumeLayout(false);
            this.GroupBoxOutput.PerformLayout();
            this.GroupBoxCommand.ResumeLayout(false);
            this.GroupBoxState.ResumeLayout(false);
            this.GroupBoxState.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxHost;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Label LabelHost;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.Label LabelLoginName;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.NumericUpDown NumericUpDownPort;
        private System.Windows.Forms.TextBox TextBoxOutput;
        private System.Windows.Forms.Button ButtonCall;
        private System.Windows.Forms.TextBox TextBoxCallTo;
        private System.Windows.Forms.TextBox TextBoxCallFrom;
        private System.Windows.Forms.Label LabelFrom;
        private System.Windows.Forms.Label LabelCallTo;
        private System.Windows.Forms.GroupBox GroupBoxConnection;
        private System.Windows.Forms.GroupBox GroupBoxCall;
        private System.Windows.Forms.GroupBox GroupBoxOutput;
        private System.Windows.Forms.Button ButtonClearOutput;
        private System.Windows.Forms.GroupBox GroupBoxCommand;
        private System.Windows.Forms.Button ButtonExecuteCommand;
        private System.Windows.Forms.Button ButtonDecline;
        private System.Windows.Forms.CheckBox CheckBoxInternal;
        private System.Windows.Forms.ComboBox ComboBoxCommand;
        private System.Windows.Forms.GroupBox GroupBoxState;
        private System.Windows.Forms.Label LabelStateExtension;
        private System.Windows.Forms.Button ButtonStateDNDGet;
        private System.Windows.Forms.TextBox TextBoxStateExtension;
        private System.Windows.Forms.Button ButtonDNDOn;
        private System.Windows.Forms.Button ButtonDNDOff;
    }
}

