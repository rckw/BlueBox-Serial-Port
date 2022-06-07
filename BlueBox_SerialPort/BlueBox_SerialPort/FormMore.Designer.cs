namespace BlueBox_SerialPort
{
    partial class FormMore
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRedBootFiles = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtToSave = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtnSendToSendBox = new System.Windows.Forms.RadioButton();
            this.rdbtnSendToSerialPort = new System.Windows.Forms.RadioButton();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.tabPageFlash = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDna = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnWriteFlash = new System.Windows.Forms.Button();
            this.btnReadFlash = new System.Windows.Forms.Button();
            this.txtHfiRevision = new System.Windows.Forms.TextBox();
            this.txtHfiVersion = new System.Windows.Forms.TextBox();
            this.txtRevision = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.txtBENumber = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtBoardName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageLinks = new System.Windows.Forms.TabPage();
            this.linkPerforce = new System.Windows.Forms.LinkLabel();
            this.tabPageFPGA = new System.Windows.Forms.TabPage();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnLoadFpga = new System.Windows.Forms.Button();
            this.treeViewBitFiles = new System.Windows.Forms.TreeView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chbRepeat = new System.Windows.Forms.CheckBox();
            this.btnSaveTest = new System.Windows.Forms.Button();
            this.btnOpenTest = new System.Windows.Forms.Button();
            this.btnStopAutoTest = new System.Windows.Forms.Button();
            this.btnRunAutoTest = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAutoTest = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtUploadFilePath = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnOpenUploadFile = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chkMosiStringOnly = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.btnStopCbSimTest = new System.Windows.Forms.Button();
            this.btnCbSimRun = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCbSimFiles = new System.Windows.Forms.TextBox();
            this.chkCbsio = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPageRedBootFiles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageFlash.SuspendLayout();
            this.tabPageLinks.SuspendLayout();
            this.tabPageFPGA.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRedBootFiles);
            this.tabControl1.Controls.Add(this.tabPageFlash);
            this.tabControl1.Controls.Add(this.tabPageLinks);
            this.tabControl1.Controls.Add(this.tabPageFPGA);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(15, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(457, 394);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageRedBootFiles
            // 
            this.tabPageRedBootFiles.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageRedBootFiles.Controls.Add(this.groupBox1);
            this.tabPageRedBootFiles.Controls.Add(this.groupBox2);
            this.tabPageRedBootFiles.Controls.Add(this.btnSaveToFile);
            this.tabPageRedBootFiles.Controls.Add(this.btnOpenFile);
            this.tabPageRedBootFiles.Controls.Add(this.btnTest);
            this.tabPageRedBootFiles.Location = new System.Drawing.Point(4, 26);
            this.tabPageRedBootFiles.Name = "tabPageRedBootFiles";
            this.tabPageRedBootFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRedBootFiles.Size = new System.Drawing.Size(449, 364);
            this.tabPageRedBootFiles.TabIndex = 0;
            this.tabPageRedBootFiles.Text = "RedBoot Files";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtToSave);
            this.groupBox1.Location = new System.Drawing.Point(6, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From Master";
            // 
            // txtToSave
            // 
            this.txtToSave.BackColor = System.Drawing.Color.Black;
            this.txtToSave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToSave.ForeColor = System.Drawing.Color.Lime;
            this.txtToSave.Location = new System.Drawing.Point(6, 20);
            this.txtToSave.Multiline = true;
            this.txtToSave.Name = "txtToSave";
            this.txtToSave.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtToSave.Size = new System.Drawing.Size(425, 99);
            this.txtToSave.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtnSendToSendBox);
            this.groupBox2.Controls.Add(this.rdbtnSendToSerialPort);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 71);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Settings";
            // 
            // rdbtnSendToSendBox
            // 
            this.rdbtnSendToSendBox.AutoSize = true;
            this.rdbtnSendToSendBox.Location = new System.Drawing.Point(6, 43);
            this.rdbtnSendToSendBox.Name = "rdbtnSendToSendBox";
            this.rdbtnSendToSendBox.Size = new System.Drawing.Size(159, 21);
            this.rdbtnSendToSendBox.TabIndex = 0;
            this.rdbtnSendToSendBox.TabStop = true;
            this.rdbtnSendToSendBox.Text = "Send to Send Box";
            this.rdbtnSendToSendBox.UseVisualStyleBackColor = true;
            // 
            // rdbtnSendToSerialPort
            // 
            this.rdbtnSendToSerialPort.AutoSize = true;
            this.rdbtnSendToSerialPort.Location = new System.Drawing.Point(6, 20);
            this.rdbtnSendToSerialPort.Name = "rdbtnSendToSerialPort";
            this.rdbtnSendToSerialPort.Size = new System.Drawing.Size(162, 21);
            this.rdbtnSendToSerialPort.TabIndex = 0;
            this.rdbtnSendToSerialPort.TabStop = true;
            this.rdbtnSendToSerialPort.Text = "Send to Serial Port";
            this.rdbtnSendToSerialPort.UseVisualStyleBackColor = true;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToFile.Location = new System.Drawing.Point(172, 49);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(92, 23);
            this.btnSaveToFile.TabIndex = 3;
            this.btnSaveToFile.Text = "Save To File";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(172, 20);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(92, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(339, 26);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(87, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tabPageFlash
            // 
            this.tabPageFlash.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageFlash.Controls.Add(this.chkCbsio);
            this.tabPageFlash.Controls.Add(this.label19);
            this.tabPageFlash.Controls.Add(this.txtDna);
            this.tabPageFlash.Controls.Add(this.label20);
            this.tabPageFlash.Controls.Add(this.label16);
            this.tabPageFlash.Controls.Add(this.label15);
            this.tabPageFlash.Controls.Add(this.label14);
            this.tabPageFlash.Controls.Add(this.label13);
            this.tabPageFlash.Controls.Add(this.label12);
            this.tabPageFlash.Controls.Add(this.label11);
            this.tabPageFlash.Controls.Add(this.label10);
            this.tabPageFlash.Controls.Add(this.label9);
            this.tabPageFlash.Controls.Add(this.btnWriteFlash);
            this.tabPageFlash.Controls.Add(this.btnReadFlash);
            this.tabPageFlash.Controls.Add(this.txtHfiRevision);
            this.tabPageFlash.Controls.Add(this.txtHfiVersion);
            this.tabPageFlash.Controls.Add(this.txtRevision);
            this.tabPageFlash.Controls.Add(this.txtVersion);
            this.tabPageFlash.Controls.Add(this.txtFunction);
            this.tabPageFlash.Controls.Add(this.txtBENumber);
            this.tabPageFlash.Controls.Add(this.txtSerialNumber);
            this.tabPageFlash.Controls.Add(this.txtBoardName);
            this.tabPageFlash.Controls.Add(this.label8);
            this.tabPageFlash.Controls.Add(this.label7);
            this.tabPageFlash.Controls.Add(this.label6);
            this.tabPageFlash.Controls.Add(this.label5);
            this.tabPageFlash.Controls.Add(this.label4);
            this.tabPageFlash.Controls.Add(this.label3);
            this.tabPageFlash.Controls.Add(this.label2);
            this.tabPageFlash.Controls.Add(this.label1);
            this.tabPageFlash.Location = new System.Drawing.Point(4, 26);
            this.tabPageFlash.Name = "tabPageFlash";
            this.tabPageFlash.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFlash.Size = new System.Drawing.Size(449, 364);
            this.tabPageFlash.TabIndex = 1;
            this.tabPageFlash.Text = "Internal Flash";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 242);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 17);
            this.label19.TabIndex = 20;
            this.label19.Text = "DNA";
            // 
            // txtDna
            // 
            this.txtDna.Location = new System.Drawing.Point(101, 239);
            this.txtDna.Name = "txtDna";
            this.txtDna.Size = new System.Drawing.Size(243, 24);
            this.txtDna.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(350, 242);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 17);
            this.label20.TabIndex = 18;
            this.label20.Text = "[chars: 16]";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(350, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 17);
            this.label16.TabIndex = 18;
            this.label16.Text = "[chars: 1]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(350, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "[chars: 1]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(350, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "[chars: 2]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(350, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "[chars: 2]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "[chars: 2]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(350, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "[chars: 8]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "[chars: 12]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "[chars: 4]";
            // 
            // btnWriteFlash
            // 
            this.btnWriteFlash.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteFlash.Location = new System.Drawing.Point(101, 315);
            this.btnWriteFlash.Name = "btnWriteFlash";
            this.btnWriteFlash.Size = new System.Drawing.Size(122, 23);
            this.btnWriteFlash.TabIndex = 17;
            this.btnWriteFlash.Text = "Write";
            this.btnWriteFlash.UseVisualStyleBackColor = true;
            this.btnWriteFlash.Click += new System.EventHandler(this.btnWriteFlash_Click);
            // 
            // btnReadFlash
            // 
            this.btnReadFlash.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFlash.Location = new System.Drawing.Point(101, 285);
            this.btnReadFlash.Name = "btnReadFlash";
            this.btnReadFlash.Size = new System.Drawing.Size(122, 23);
            this.btnReadFlash.TabIndex = 16;
            this.btnReadFlash.Text = "Read";
            this.btnReadFlash.UseVisualStyleBackColor = true;
            this.btnReadFlash.Click += new System.EventHandler(this.btnReadFlash_Click);
            // 
            // txtHfiRevision
            // 
            this.txtHfiRevision.Location = new System.Drawing.Point(101, 211);
            this.txtHfiRevision.Name = "txtHfiRevision";
            this.txtHfiRevision.Size = new System.Drawing.Size(243, 24);
            this.txtHfiRevision.TabIndex = 15;
            // 
            // txtHfiVersion
            // 
            this.txtHfiVersion.Location = new System.Drawing.Point(101, 184);
            this.txtHfiVersion.Name = "txtHfiVersion";
            this.txtHfiVersion.Size = new System.Drawing.Size(243, 24);
            this.txtHfiVersion.TabIndex = 14;
            // 
            // txtRevision
            // 
            this.txtRevision.Location = new System.Drawing.Point(101, 157);
            this.txtRevision.Name = "txtRevision";
            this.txtRevision.Size = new System.Drawing.Size(243, 24);
            this.txtRevision.TabIndex = 13;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(101, 130);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(243, 24);
            this.txtVersion.TabIndex = 12;
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(101, 103);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(243, 24);
            this.txtFunction.TabIndex = 11;
            // 
            // txtBENumber
            // 
            this.txtBENumber.Location = new System.Drawing.Point(101, 76);
            this.txtBENumber.Name = "txtBENumber";
            this.txtBENumber.Size = new System.Drawing.Size(243, 24);
            this.txtBENumber.TabIndex = 10;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(101, 49);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(243, 24);
            this.txtSerialNumber.TabIndex = 9;
            // 
            // txtBoardName
            // 
            this.txtBoardName.Location = new System.Drawing.Point(101, 22);
            this.txtBoardName.Name = "txtBoardName";
            this.txtBoardName.Size = new System.Drawing.Size(243, 24);
            this.txtBoardName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "HFI Revision";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "HFI Version";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Revision";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Version";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Function";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "BE Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serial Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Board Name";
            // 
            // tabPageLinks
            // 
            this.tabPageLinks.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageLinks.Controls.Add(this.linkPerforce);
            this.tabPageLinks.Location = new System.Drawing.Point(4, 26);
            this.tabPageLinks.Name = "tabPageLinks";
            this.tabPageLinks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLinks.Size = new System.Drawing.Size(449, 364);
            this.tabPageLinks.TabIndex = 2;
            this.tabPageLinks.Text = "Links";
            // 
            // linkPerforce
            // 
            this.linkPerforce.AutoSize = true;
            this.linkPerforce.Location = new System.Drawing.Point(6, 25);
            this.linkPerforce.Name = "linkPerforce";
            this.linkPerforce.Size = new System.Drawing.Size(65, 17);
            this.linkPerforce.TabIndex = 1;
            this.linkPerforce.TabStop = true;
            this.linkPerforce.Text = "Perforce";
            // 
            // tabPageFPGA
            // 
            this.tabPageFPGA.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageFPGA.Controls.Add(this.txtPath);
            this.tabPageFPGA.Controls.Add(this.btnLoadFpga);
            this.tabPageFPGA.Controls.Add(this.treeViewBitFiles);
            this.tabPageFPGA.Location = new System.Drawing.Point(4, 26);
            this.tabPageFPGA.Name = "tabPageFPGA";
            this.tabPageFPGA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFPGA.Size = new System.Drawing.Size(449, 364);
            this.tabPageFPGA.TabIndex = 3;
            this.tabPageFPGA.Text = "FPGA";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(8, 272);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(436, 24);
            this.txtPath.TabIndex = 2;
            // 
            // btnLoadFpga
            // 
            this.btnLoadFpga.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFpga.Location = new System.Drawing.Point(171, 311);
            this.btnLoadFpga.Name = "btnLoadFpga";
            this.btnLoadFpga.Size = new System.Drawing.Size(121, 23);
            this.btnLoadFpga.TabIndex = 1;
            this.btnLoadFpga.Text = "Load FPGA";
            this.btnLoadFpga.UseVisualStyleBackColor = true;
            this.btnLoadFpga.Click += new System.EventHandler(this.btnLoadFpga_Click);
            // 
            // treeViewBitFiles
            // 
            this.treeViewBitFiles.Location = new System.Drawing.Point(6, 6);
            this.treeViewBitFiles.Name = "treeViewBitFiles";
            this.treeViewBitFiles.Size = new System.Drawing.Size(437, 243);
            this.treeViewBitFiles.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.chbRepeat);
            this.tabPage1.Controls.Add(this.btnSaveTest);
            this.tabPage1.Controls.Add(this.btnOpenTest);
            this.tabPage1.Controls.Add(this.btnStopAutoTest);
            this.tabPage1.Controls.Add(this.btnRunAutoTest);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.txtAutoTest);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(449, 364);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Auto Test";
            // 
            // chbRepeat
            // 
            this.chbRepeat.AutoSize = true;
            this.chbRepeat.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRepeat.Location = new System.Drawing.Point(8, 339);
            this.chbRepeat.Name = "chbRepeat";
            this.chbRepeat.Size = new System.Drawing.Size(74, 18);
            this.chbRepeat.TabIndex = 6;
            this.chbRepeat.Text = "Repeat";
            this.chbRepeat.UseVisualStyleBackColor = true;
            // 
            // btnSaveTest
            // 
            this.btnSaveTest.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTest.Location = new System.Drawing.Point(368, 339);
            this.btnSaveTest.Name = "btnSaveTest";
            this.btnSaveTest.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTest.TabIndex = 5;
            this.btnSaveTest.Text = "Save Test";
            this.btnSaveTest.UseVisualStyleBackColor = true;
            this.btnSaveTest.Click += new System.EventHandler(this.btnSaveTest_Click);
            // 
            // btnOpenTest
            // 
            this.btnOpenTest.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTest.Location = new System.Drawing.Point(288, 339);
            this.btnOpenTest.Name = "btnOpenTest";
            this.btnOpenTest.Size = new System.Drawing.Size(75, 23);
            this.btnOpenTest.TabIndex = 4;
            this.btnOpenTest.Text = "Open Test";
            this.btnOpenTest.UseVisualStyleBackColor = true;
            this.btnOpenTest.Click += new System.EventHandler(this.btnOpenTest_Click);
            // 
            // btnStopAutoTest
            // 
            this.btnStopAutoTest.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopAutoTest.Location = new System.Drawing.Point(369, 311);
            this.btnStopAutoTest.Name = "btnStopAutoTest";
            this.btnStopAutoTest.Size = new System.Drawing.Size(75, 23);
            this.btnStopAutoTest.TabIndex = 3;
            this.btnStopAutoTest.Text = "Stop Test";
            this.btnStopAutoTest.UseVisualStyleBackColor = true;
            this.btnStopAutoTest.Click += new System.EventHandler(this.btnStopAutoTest_Click);
            // 
            // btnRunAutoTest
            // 
            this.btnRunAutoTest.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunAutoTest.Location = new System.Drawing.Point(288, 311);
            this.btnRunAutoTest.Name = "btnRunAutoTest";
            this.btnRunAutoTest.Size = new System.Drawing.Size(75, 23);
            this.btnRunAutoTest.TabIndex = 2;
            this.btnRunAutoTest.Text = "Run Test";
            this.btnRunAutoTest.UseVisualStyleBackColor = true;
            this.btnRunAutoTest.Click += new System.EventHandler(this.btnRunAutoTest_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 316);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(174, 14);
            this.label17.TabIndex = 1;
            this.label17.Text = "Add delay: <time in msec>";
            // 
            // txtAutoTest
            // 
            this.txtAutoTest.Location = new System.Drawing.Point(6, 6);
            this.txtAutoTest.Multiline = true;
            this.txtAutoTest.Name = "txtAutoTest";
            this.txtAutoTest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAutoTest.Size = new System.Drawing.Size(437, 299);
            this.txtAutoTest.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btnDownload);
            this.tabPage2.Controls.Add(this.txtUploadFilePath);
            this.tabPage2.Controls.Add(this.btnUpload);
            this.tabPage2.Controls.Add(this.btnOpenUploadFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(449, 364);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "MotorData";
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(6, 99);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtUploadFilePath
            // 
            this.txtUploadFilePath.Location = new System.Drawing.Point(86, 43);
            this.txtUploadFilePath.Name = "txtUploadFilePath";
            this.txtUploadFilePath.Size = new System.Drawing.Size(357, 24);
            this.txtUploadFilePath.TabIndex = 2;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(6, 70);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnOpenUploadFile
            // 
            this.btnOpenUploadFile.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenUploadFile.Location = new System.Drawing.Point(6, 41);
            this.btnOpenUploadFile.Name = "btnOpenUploadFile";
            this.btnOpenUploadFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenUploadFile.TabIndex = 0;
            this.btnOpenUploadFile.Text = "Open File";
            this.btnOpenUploadFile.UseVisualStyleBackColor = true;
            this.btnOpenUploadFile.Click += new System.EventHandler(this.btnOpenUploadFile_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.chkMosiStringOnly);
            this.tabPage3.Controls.Add(this.btnBrowse);
            this.tabPage3.Controls.Add(this.txtFileLocation);
            this.tabPage3.Controls.Add(this.btnStopCbSimTest);
            this.tabPage3.Controls.Add(this.btnCbSimRun);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.txtCbSimFiles);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(449, 364);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "CBSIM";
            // 
            // chkMosiStringOnly
            // 
            this.chkMosiStringOnly.AutoSize = true;
            this.chkMosiStringOnly.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMosiStringOnly.Location = new System.Drawing.Point(8, 320);
            this.chkMosiStringOnly.Name = "chkMosiStringOnly";
            this.chkMosiStringOnly.Size = new System.Drawing.Size(188, 18);
            this.chkMosiStringOnly.TabIndex = 7;
            this.chkMosiStringOnly.Text = "Construct Only Mosi Data";
            this.chkMosiStringOnly.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(368, 339);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Location = new System.Drawing.Point(6, 341);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.Size = new System.Drawing.Size(356, 24);
            this.txtFileLocation.TabIndex = 5;
            // 
            // btnStopCbSimTest
            // 
            this.btnStopCbSimTest.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopCbSimTest.Location = new System.Drawing.Point(368, 299);
            this.btnStopCbSimTest.Name = "btnStopCbSimTest";
            this.btnStopCbSimTest.Size = new System.Drawing.Size(75, 23);
            this.btnStopCbSimTest.TabIndex = 4;
            this.btnStopCbSimTest.Text = "Stop";
            this.btnStopCbSimTest.UseVisualStyleBackColor = true;
            this.btnStopCbSimTest.Click += new System.EventHandler(this.btnStopCbSimTest_Click);
            // 
            // btnCbSimRun
            // 
            this.btnCbSimRun.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCbSimRun.Location = new System.Drawing.Point(287, 299);
            this.btnCbSimRun.Name = "btnCbSimRun";
            this.btnCbSimRun.Size = new System.Drawing.Size(75, 23);
            this.btnCbSimRun.TabIndex = 3;
            this.btnCbSimRun.Text = "Run";
            this.btnCbSimRun.UseVisualStyleBackColor = true;
            this.btnCbSimRun.Click += new System.EventHandler(this.btnCbSimRun_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 299);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(174, 14);
            this.label18.TabIndex = 2;
            this.label18.Text = "Add delay: <time in msec>";
            // 
            // txtCbSimFiles
            // 
            this.txtCbSimFiles.Location = new System.Drawing.Point(6, 6);
            this.txtCbSimFiles.Multiline = true;
            this.txtCbSimFiles.Name = "txtCbSimFiles";
            this.txtCbSimFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCbSimFiles.Size = new System.Drawing.Size(437, 287);
            this.txtCbSimFiles.TabIndex = 0;
            // 
            // chkCbsio
            // 
            this.chkCbsio.AutoSize = true;
            this.chkCbsio.Location = new System.Drawing.Point(352, 272);
            this.chkCbsio.Name = "chkCbsio";
            this.chkCbsio.Size = new System.Drawing.Size(76, 21);
            this.chkCbsio.TabIndex = 21;
            this.chkCbsio.Text = "CBSIO";
            this.chkCbsio.UseVisualStyleBackColor = true;
            // 
            // FormMore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 419);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMore";
            this.Text = "More";
            this.Load += new System.EventHandler(this.FormMore_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRedBootFiles.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageFlash.ResumeLayout(false);
            this.tabPageFlash.PerformLayout();
            this.tabPageLinks.ResumeLayout(false);
            this.tabPageLinks.PerformLayout();
            this.tabPageFPGA.ResumeLayout(false);
            this.tabPageFPGA.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRedBootFiles;
        private System.Windows.Forms.TabPage tabPageFlash;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtToSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbtnSendToSendBox;
        private System.Windows.Forms.RadioButton rdbtnSendToSerialPort;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtBoardName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWriteFlash;
        private System.Windows.Forms.Button btnReadFlash;
        private System.Windows.Forms.TextBox txtHfiRevision;
        private System.Windows.Forms.TextBox txtHfiVersion;
        private System.Windows.Forms.TextBox txtRevision;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.TextBox txtBENumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPageLinks;
        private System.Windows.Forms.LinkLabel linkPerforce;
        private System.Windows.Forms.TabPage tabPageFPGA;
        private System.Windows.Forms.Button btnLoadFpga;
        private System.Windows.Forms.TreeView treeViewBitFiles;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnStopAutoTest;
        private System.Windows.Forms.Button btnRunAutoTest;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAutoTest;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnOpenUploadFile;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtUploadFilePath;
        private System.Windows.Forms.Button btnSaveTest;
        private System.Windows.Forms.Button btnOpenTest;
        private System.Windows.Forms.CheckBox chbRepeat;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCbSimRun;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCbSimFiles;
        private System.Windows.Forms.Button btnStopCbSimTest;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.CheckBox chkMosiStringOnly;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDna;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.CheckBox chkCbsio;
    }
}