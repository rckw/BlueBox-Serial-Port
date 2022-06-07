namespace BlueBox_SerialPort
{
    partial class FormMaster
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btndisconnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearTerminal = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkClear = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbSlaves = new System.Windows.Forms.ComboBox();
            this.btnGetMiso = new System.Windows.Forms.Button();
            this.btnGetMosi = new System.Windows.Forms.Button();
            this.btnActivateSlave = new System.Windows.Forms.Button();
            this.btnCtrolC = new System.Windows.Forms.Button();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnswer_m = new System.Windows.Forms.TextBox();
            this.btnSendQuestion = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnResolverInit = new System.Windows.Forms.Button();
            this.btn26VEnable = new System.Windows.Forms.Button();
            this.btnRealTimeData = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnExtMiso = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTerminal);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 570);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terminal";
            // 
            // txtTerminal
            // 
            this.txtTerminal.BackColor = System.Drawing.Color.Black;
            this.txtTerminal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerminal.ForeColor = System.Drawing.Color.Lime;
            this.txtTerminal.Location = new System.Drawing.Point(6, 20);
            this.txtTerminal.Multiline = true;
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.ReadOnly = true;
            this.txtTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTerminal.Size = new System.Drawing.Size(676, 544);
            this.txtTerminal.TabIndex = 16;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.Lime;
            this.txtLog.Location = new System.Drawing.Point(6, 20);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(684, 99);
            this.txtLog.TabIndex = 14;
            // 
            // cmbPorts
            // 
            this.cmbPorts.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(6, 20);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(331, 21);
            this.cmbPorts.TabIndex = 17;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(343, 18);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(109, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btndisconnect
            // 
            this.btndisconnect.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisconnect.Location = new System.Drawing.Point(458, 18);
            this.btndisconnect.Name = "btndisconnect";
            this.btndisconnect.Size = new System.Drawing.Size(109, 23);
            this.btndisconnect.TabIndex = 2;
            this.btndisconnect.Text = "Disconnect";
            this.btndisconnect.UseVisualStyleBackColor = true;
            this.btndisconnect.Click += new System.EventHandler(this.btndisconnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndisconnect);
            this.groupBox2.Controls.Add(this.btnClearTerminal);
            this.groupBox2.Controls.Add(this.cmbPorts);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 49);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port Settings and Control";
            // 
            // btnClearTerminal
            // 
            this.btnClearTerminal.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTerminal.Location = new System.Drawing.Point(573, 18);
            this.btnClearTerminal.Name = "btnClearTerminal";
            this.btnClearTerminal.Size = new System.Drawing.Size(109, 23);
            this.btnClearTerminal.TabIndex = 3;
            this.btnClearTerminal.Text = "Clear Terminal";
            this.btnClearTerminal.UseVisualStyleBackColor = true;
            this.btnClearTerminal.Click += new System.EventHandler(this.btnClearTerminal_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(702, 19);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 23);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkLog);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.chkClear);
            this.groupBox3.Controls.Add(this.txtLog);
            this.groupBox3.Location = new System.Drawing.Point(12, 643);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(851, 125);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send SerialPort";
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Location = new System.Drawing.Point(702, 79);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(120, 21);
            this.chkLog.TabIndex = 28;
            this.chkLog.Text = "Log Terminal";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(717, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "= Ctrl+Enter";
            // 
            // chkClear
            // 
            this.chkClear.AutoSize = true;
            this.chkClear.Location = new System.Drawing.Point(702, 102);
            this.chkClear.Name = "chkClear";
            this.chkClear.Size = new System.Drawing.Size(146, 21);
            this.chkClear.TabIndex = 2;
            this.chkClear.Text = "Clear After Send";
            this.chkClear.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbSlaves);
            this.groupBox4.Location = new System.Drawing.Point(708, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(137, 49);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Slave";
            // 
            // cmbSlaves
            // 
            this.cmbSlaves.FormattingEnabled = true;
            this.cmbSlaves.Location = new System.Drawing.Point(6, 19);
            this.cmbSlaves.Name = "cmbSlaves";
            this.cmbSlaves.Size = new System.Drawing.Size(121, 25);
            this.cmbSlaves.TabIndex = 18;
            // 
            // btnGetMiso
            // 
            this.btnGetMiso.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetMiso.Location = new System.Drawing.Point(6, 78);
            this.btnGetMiso.Name = "btnGetMiso";
            this.btnGetMiso.Size = new System.Drawing.Size(131, 23);
            this.btnGetMiso.TabIndex = 6;
            this.btnGetMiso.Text = "Get Miso";
            this.btnGetMiso.UseVisualStyleBackColor = true;
            this.btnGetMiso.Click += new System.EventHandler(this.btnGetMiso_Click);
            // 
            // btnGetMosi
            // 
            this.btnGetMosi.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetMosi.Location = new System.Drawing.Point(6, 107);
            this.btnGetMosi.Name = "btnGetMosi";
            this.btnGetMosi.Size = new System.Drawing.Size(131, 23);
            this.btnGetMosi.TabIndex = 7;
            this.btnGetMosi.Text = "Get Mosi";
            this.btnGetMosi.UseVisualStyleBackColor = true;
            this.btnGetMosi.Click += new System.EventHandler(this.btnGetMosi_Click);
            // 
            // btnActivateSlave
            // 
            this.btnActivateSlave.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivateSlave.Location = new System.Drawing.Point(6, 49);
            this.btnActivateSlave.Name = "btnActivateSlave";
            this.btnActivateSlave.Size = new System.Drawing.Size(131, 23);
            this.btnActivateSlave.TabIndex = 5;
            this.btnActivateSlave.Text = "Activate Slave";
            this.btnActivateSlave.UseVisualStyleBackColor = true;
            this.btnActivateSlave.Click += new System.EventHandler(this.btnActivateSlave_Click);
            // 
            // btnCtrolC
            // 
            this.btnCtrolC.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtrolC.Location = new System.Drawing.Point(6, 20);
            this.btnCtrolC.Name = "btnCtrolC";
            this.btnCtrolC.Size = new System.Drawing.Size(131, 23);
            this.btnCtrolC.TabIndex = 4;
            this.btnCtrolC.Text = "Ctrl+C";
            this.btnCtrolC.UseVisualStyleBackColor = true;
            this.btnCtrolC.Click += new System.EventHandler(this.btnCtrolC_Click);
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(9, 33);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(118, 24);
            this.txtFunction.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Function";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Action";
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(9, 73);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(118, 24);
            this.txtAction.TabIndex = 9;
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCmd.Location = new System.Drawing.Point(6, 100);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(121, 23);
            this.btnSendCmd.TabIndex = 10;
            this.btnSendCmd.Text = "Send Command";
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.btnSendCmd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Question";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(9, 33);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(118, 24);
            this.txtQuestion.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Answer_m";
            // 
            // txtAnswer_m
            // 
            this.txtAnswer_m.Location = new System.Drawing.Point(9, 73);
            this.txtAnswer_m.Name = "txtAnswer_m";
            this.txtAnswer_m.Size = new System.Drawing.Size(118, 24);
            this.txtAnswer_m.TabIndex = 12;
            // 
            // btnSendQuestion
            // 
            this.btnSendQuestion.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendQuestion.Location = new System.Drawing.Point(6, 100);
            this.btnSendQuestion.Name = "btnSendQuestion";
            this.btnSendQuestion.Size = new System.Drawing.Size(121, 23);
            this.btnSendQuestion.TabIndex = 13;
            this.btnSendQuestion.Text = "Send Question";
            this.btnSendQuestion.UseVisualStyleBackColor = true;
            this.btnSendQuestion.Click += new System.EventHandler(this.btnSendQuestion_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSendQuestion);
            this.groupBox5.Controls.Add(this.txtQuestion);
            this.groupBox5.Controls.Add(this.txtAnswer_m);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(708, 468);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(152, 134);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Q_A";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtFunction);
            this.groupBox6.Controls.Add(this.btnSendCmd);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtAction);
            this.groupBox6.Location = new System.Drawing.Point(708, 328);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(152, 134);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cmd";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnExtMiso);
            this.groupBox7.Controls.Add(this.btnResolverInit);
            this.groupBox7.Controls.Add(this.btn26VEnable);
            this.groupBox7.Controls.Add(this.btnRealTimeData);
            this.groupBox7.Controls.Add(this.btnCtrolC);
            this.groupBox7.Controls.Add(this.btnGetMiso);
            this.groupBox7.Controls.Add(this.btnGetMosi);
            this.groupBox7.Controls.Add(this.btnActivateSlave);
            this.groupBox7.Location = new System.Drawing.Point(708, 67);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(152, 255);
            this.groupBox7.TabIndex = 26;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Basics";
            // 
            // btnResolverInit
            // 
            this.btnResolverInit.Location = new System.Drawing.Point(9, 197);
            this.btnResolverInit.Name = "btnResolverInit";
            this.btnResolverInit.Size = new System.Drawing.Size(128, 23);
            this.btnResolverInit.TabIndex = 10;
            this.btnResolverInit.Text = "Init resolver";
            this.btnResolverInit.UseVisualStyleBackColor = true;
            this.btnResolverInit.Click += new System.EventHandler(this.btnResolverInit_Click);
            // 
            // btn26VEnable
            // 
            this.btn26VEnable.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn26VEnable.Location = new System.Drawing.Point(7, 167);
            this.btn26VEnable.Name = "btn26VEnable";
            this.btn26VEnable.Size = new System.Drawing.Size(130, 23);
            this.btn26VEnable.TabIndex = 9;
            this.btn26VEnable.Text = "Enable 26V";
            this.btn26VEnable.UseVisualStyleBackColor = true;
            this.btn26VEnable.Click += new System.EventHandler(this.btn26VEnable_Click);
            // 
            // btnRealTimeData
            // 
            this.btnRealTimeData.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealTimeData.Location = new System.Drawing.Point(7, 137);
            this.btnRealTimeData.Name = "btnRealTimeData";
            this.btnRealTimeData.Size = new System.Drawing.Size(130, 23);
            this.btnRealTimeData.TabIndex = 8;
            this.btnRealTimeData.Text = "Real Time Data";
            this.btnRealTimeData.UseVisualStyleBackColor = true;
            this.btnRealTimeData.Click += new System.EventHandler(this.btnRealTimeData_Click);
            // 
            // btnMore
            // 
            this.btnMore.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.Location = new System.Drawing.Point(714, 608);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(121, 23);
            this.btnMore.TabIndex = 27;
            this.btnMore.Text = "More";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnExtMiso
            // 
            this.btnExtMiso.Location = new System.Drawing.Point(9, 227);
            this.btnExtMiso.Name = "btnExtMiso";
            this.btnExtMiso.Size = new System.Drawing.Size(128, 23);
            this.btnExtMiso.TabIndex = 11;
            this.btnExtMiso.Text = "Get Ext Miso";
            this.btnExtMiso.UseVisualStyleBackColor = true;
            this.btnExtMiso.Click += new System.EventHandler(this.btnExtMiso_Click);
            // 
            // FormMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 780);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FormMaster";
            this.Text = "BlueBox SerialPort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btndisconnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkClear;
        private System.Windows.Forms.Button btnClearTerminal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbSlaves;
        private System.Windows.Forms.Button btnGetMiso;
        private System.Windows.Forms.Button btnGetMosi;
        private System.Windows.Forms.Button btnActivateSlave;
        private System.Windows.Forms.Button btnCtrolC;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.Button btnSendCmd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnswer_m;
        private System.Windows.Forms.Button btnSendQuestion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.Button btn26VEnable;
        private System.Windows.Forms.Button btnRealTimeData;
        private System.Windows.Forms.Button btnResolverInit;
        private System.Windows.Forms.Button btnExtMiso;
    }
}

