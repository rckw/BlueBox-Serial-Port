using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

using textfiles = BlueBox_SerialPort.TextFiles;
using FSB = BlueBox_SerialPort.Fsb;
using Mode = BlueBox_SerialPort.Mode;


namespace BlueBox_SerialPort
{
    public partial class FormMaster : Form
    {
        FormMore More = new FormMore();

        Int64 TestCounter = 0;
       
        //Boolean Read = false;
        SerialPort serialport;
        
        public delegate void SerialPortDelegate(string SerialPortData);
        public SerialPortDelegate SerialDataDelegate;

        string receiveSerialData;

        string ret = "\r";
        
        public FormMaster()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(100, 100);
            
            serialport = new SerialPort();
            
            btndisconnect.Enabled = false;
            btnMore.Enabled = false;
            chkClear.Checked = true;
            GetPortNamesWithDescription();
            cmbPorts.TextChanged += new EventHandler(cmbPorts_TextChanged);

            if (!cmbPorts.Items.Contains(Properties.Settings.Default.ComPort))
            {
                cmbPorts.SelectedIndex = 0;
            }
            else
            {
                cmbPorts.Text = Properties.Settings.Default.ComPort;
            }

            this.KeyPreview = true;
            txtLog.KeyDown += new KeyEventHandler(txtLog_KeyDown);
            txtLog.KeyUp += new KeyEventHandler(txtLog_KeyUp);

            txtFunction.KeyDown += new KeyEventHandler(txtFunction_KeyDown);
            txtAction.KeyDown += new KeyEventHandler(txtAction_KeyDown);

            txtQuestion.KeyDown += new KeyEventHandler(txtQuestion_KeyDown);
            txtAnswer_m.KeyDown += new KeyEventHandler(txtAnswer_m_KeyDown);

            for (int i = 0; i <= 9; i++) { cmbSlaves.Items.Add(i); }
            cmbSlaves.TextChanged += new EventHandler(cmbSlaves_TextChanged);
            cmbSlaves.Text = Properties.Settings.Default.Slave;
            FSB.ActiveSlave = Convert.ToInt32(cmbSlaves.Text);
        }

        void cmbSlaves_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Slave = cmbSlaves.Text;
            Properties.Settings.Default.Save();
            FSB.ActiveSlave = Convert.ToInt32(cmbSlaves.Text);
        }

        public void GetPortNamesWithDescription()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort"))
            {
                string[] portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                var tList = (from n in portnames join p in ports on n equals p["DeviceID"].ToString() select n + " - " + p["Caption"]).ToList();

                foreach (string s in tList)
                {
                    cmbPorts.Items.Add(s);
                }
            }
        }

        void cmbPorts_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ComPort = cmbPorts.Text;
            Properties.Settings.Default.Save();
        }

        public void StartSerialPort()
        {
            serialport.PortName = cmbPorts.Text.Substring(0, 5);
            txtTerminal.AppendText(cmbPorts.Text.Substring(0, 5));
            serialport.BaudRate = 115200;
            serialport.Parity = Parity.None;
            serialport.DataBits = 8;
            serialport.StopBits = StopBits.One;
            //serialport.WriteBufferSize = 8192;

            if (!serialport.IsOpen)
            {
                try
                {
                    serialport.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Port already open!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //this.Close();
                    return;
                }
            }

            serialport.DiscardInBuffer();
            serialport.DataReceived += new SerialDataReceivedEventHandler(serialport_DataReceived);
            this.SerialDataDelegate = new SerialPortDelegate(UpdateTerminal);
        }

        void serialport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (FSB.ReadFlash)
            {
                Thread.Sleep(100);
            }
            else if (FSB.WriteFlash)
            {
                Thread.Sleep(100);
            }
            else if (FSB.ReadSdcard)
            {
                Thread.Sleep(300);
            }
            else
            {
                //Thread.Sleep(5);
            }

            SerialPort sp = (SerialPort)sender;
            receiveSerialData += sp.ReadExisting();

            if (chkLog.Checked)
            {
                WriteLogFile("log.log", receiveSerialData);
                
                //if (receiveSerialData.Contains("10108000") || receiveSerialData.Contains("rtc"))
                //{
                //    WriteLogFile("log.log", receiveSerialData);
                //}
                
            }
            

            if (FSB.ReadFlash)
            {
                WriteFile(receiveSerialData);
            }

            if (FSB.ReadSdcard)
            {
                WriteFile(receiveSerialData);
            }

            txtTerminal.Invoke(this.SerialDataDelegate, new object[] { receiveSerialData });
            receiveSerialData = string.Empty;
        }

        public void UpdateTerminal(string data)
        {
            txtTerminal.AppendText(data);
        }

        public void WriteLogFile(string FileName, string Text)
        {
            using (StreamWriter wr = File.AppendText(FileName))
            {
                wr.Write(Text);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialport.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            StartSerialPort();
            if (serialport.IsOpen) { serialport.Write("\r"); }

            btnConnect.Enabled = false;
            btndisconnect.Enabled = true;
            btnMore.Enabled = true;
        }

        private void btndisconnect_Click(object sender, EventArgs e)
        {
            serialport.Close();

            btnConnect.Enabled = true;
            btndisconnect.Enabled = false;
            btnMore.Enabled = false;
        }

        public void SendToSerialPort()
        {
            try
            {
                foreach (string s in txtLog.Lines)
                {
                    serialport.Write(s + ret);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SendToSerialPort();
                if (chkClear.Checked == true) { txtLog.Clear(); txtLog.Focus(); txtLog.Select(0, 0); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void txtLog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                try
                {
                    SendToSerialPort();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void txtLog_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                if (chkClear.Checked == true) { txtLog.Clear(); txtLog.Focus(); txtLog.Select(0, 0); }
            }
        }

        private void btnClearTerminal_Click(object sender, EventArgs e)
        {
            txtTerminal.Clear();
        }

        private void btnCtrolC_Click(object sender, EventArgs e)
        {
            try
            {
                serialport.Write("\x3");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActivateSlave_Click(object sender, EventArgs e)
        {
            try
            {
                serialport.Write("mfill -b 0x10108002 -p " + FSB.Slave_Control[cmbSlaves.SelectedIndex] + " -l 2 -2" + ret);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGetMiso_Click(object sender, EventArgs e)
        {
            try
            {
                serialport.Write("x -b " + FSB.Miso[cmbSlaves.SelectedIndex] + " -l 32 -2" + ret);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGetMosi_Click(object sender, EventArgs e)
        {
            try
            {
                serialport.Write("x -b " + FSB.Mosi[cmbSlaves.SelectedIndex] + " -l 64 -2" + ret);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSendCmd_Click(object sender, EventArgs e)
        {
            SendCmd();
        }

        void txtAction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendCmd();
            }
        }

        void txtFunction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendCmd();
            }
        }

        public void SendCmd()
        {
            try
            {
                if (serialport.IsOpen)
                {
                    if (txtFunction.Text.Length == 3 && txtAction.Text.Length == 4)
                    {
                        serialport.Write("mfill -b " + FSB.CmdFunction + " -p 0x" + cmbSlaves.SelectedIndex + txtFunction.Text + " -l 2 -2" + ret);
                        serialport.Write("mfill -b " + FSB.CmdAction + " -p 0x" + txtAction.Text + " -l 2 -2" + ret);
                    }
                    else
                    {
                        MessageBox.Show("Function = 3 Chars\r\nAction = 4 Chars", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Port not open!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSendQuestion_Click(object sender, EventArgs e)
        {
            SendQ_A();
        }

        void txtAnswer_m_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendQ_A();
            }
        }

        void txtQuestion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendQ_A();
            }
        }

        public void SendQ_A()
        {
            try
            {
                if (txtQuestion.Text.Length == 1 && txtAnswer_m.Text.Length == 1)
                {
                    serialport.Write("mfill -b " + FSB.Q_A_question[cmbSlaves.SelectedIndex] + " -p 0x000" + txtQuestion.Text + " -l 2 -2" + ret);
                    serialport.Write("mfill -b " + FSB.Q_A_Answer_m[cmbSlaves.SelectedIndex] + " -p 0x000" + txtAnswer_m.Text + " -l 2 -2" + ret);
                    serialport.Write("xblck -b " + FSB.Q_A_Answer_s[cmbSlaves.SelectedIndex] + " -2" + ret);
                }
                else if (txtQuestion.Text.Length == 4 && txtAnswer_m.Text.Length == 1)
                {
                    serialport.Write("mfill -b " + FSB.Q_A_question[cmbSlaves.SelectedIndex] + " -p 0x" + txtQuestion.Text + " -l 2 -2" + ret);
                    serialport.Write("mfill -b " + FSB.Q_A_Answer_m[cmbSlaves.SelectedIndex] + " -p 0x000" + txtAnswer_m.Text + " -l 2 -2" + ret);
                    serialport.Write("xblck -b " + FSB.Q_A_Answer_s[cmbSlaves.SelectedIndex] + " -2" + ret);
                }

                else
                {
                    MessageBox.Show("Question = 1..4 Char(s)\r\nAnswer_m = 1..4 Char(s)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRealTimeData_Click(object sender, EventArgs e)
        {
            try
            {
                serialport.Write("x -b " + FSB.RTD[cmbSlaves.SelectedIndex] + " -l 2 -2" + ret);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn26VEnable_Click(object sender, EventArgs e)
        {
            try
            {
                serialport.Write("mfill -b 0x101000D2 -p 0x0001 -l 2 -2" + ret);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnResolverInit_Click(object sender, EventArgs e)
        {
            try
            {
                serialport.Write("mfill -b 0x10100140 -p 0x0000 -l 2 -2" + ret);
                serialport.Write("xblck -b 0x10100140 -2" + ret);
                serialport.Write("mfill -b 0x10100042 -p 0x0000 -l 2 -2" + ret);
                serialport.Write("mfill -b 0x10100062 -p 0x0000 -l 2 -2" + ret);
                serialport.Write("xblck -b 0x10100000 -2" + ret);
                serialport.Write("mfill -b 0x10100004 -p 0x1000 -l 2 -2" + ret);
                serialport.Write("mfill -b 0x10100006 -p 0x1000 -l 2 -2" + ret);
                serialport.Write("mfill -b 0x10100046 -p 0x0001 -l 2 -2" + ret);
                serialport.Write("mfill -b 0x10100066 -p 0x0001 -l 2 -2" + ret);
                serialport.Write("xblck -b 0x10100046 -2" + ret);
                serialport.Write("xblck -b 0x10100066 -2" + ret);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void WriteFile(string Text)
        {
            using (StreamWriter wr = File.AppendText("FlashRead.txt"))
            {
                wr.Write(Text);
            }
        }


        void More_sendtomaster(int mode, string data)
        {
            switch (mode)
            {
                case 1:
                    try
                    {
                        serialport.Write(data + ret);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case 2: txtLog.AppendText(data);
                    break;
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            textfiles.Text = txtLog.Text;

            if (More == null || More.IsDisposed)
            {
                More = new FormMore();
            }
            
            More.sendtomaster +=new FormMore.SendToMaster(More_sendtomaster);
            More.Show();
        }

        private void btnExtMiso_Click(object sender, EventArgs e)
        {
            try
            {
                serialport.Write("mfill -b " + FSB.Q_A_question[cmbSlaves.SelectedIndex] + " -p 0x8008 -l 2 -2" + ret);
                serialport.Write("mfill -b " + FSB.Q_A_Answer_m[cmbSlaves.SelectedIndex] + " -p 0x0002 -l 2 -2" + ret);
                serialport.Write("xblck -b " + FSB.Q_A_Answer_s[cmbSlaves.SelectedIndex] + " -2" + ret);
                serialport.Write("x -b " + FSB.Miso[cmbSlaves.SelectedIndex] + " -l 64 -2" + ret);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
