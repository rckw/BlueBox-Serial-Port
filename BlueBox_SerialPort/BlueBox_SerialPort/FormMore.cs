using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

using textfiles = BlueBox_SerialPort.TextFiles;
using FSB = BlueBox_SerialPort.Fsb;
using Mode = BlueBox_SerialPort.Mode;

namespace BlueBox_SerialPort
{
    
    public partial class FormMore : Form
    {
        public delegate void SendToMaster(int mode, string Data);
        public event SendToMaster sendtomaster;

        //public event TabControlEventHandler Selected;

        string MosiData;

        string ret = "\r\n";
        string hex;
        string f;
        string result;

        //string line;
        string CbSimLine;
        string[] CbSimLineItems;
        string Mosi;
        string output;
        FolderBrowserDialog FBD;

        Thread thr = null;
        Thread thr2 = null;
        Thread thr3 = null;
        Thread thr4 = null;
        Thread thr5 = null;
        
        public FormMore()
        {
            InitializeComponent();
        }

        private void FormMore_Load(object sender, EventArgs e)
        {
            this.Location = new Point (975,100);

            txtFileLocation.Text = Properties.Settings.Default.CBSIMFiles;
            
            txtToSave.Text = textfiles.Text;
            rdbtnSendToSendBox.Checked = true;

            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "C:\\Program Files\\Perforce\\p4v.exe";
            linkPerforce.Links.Add(link);

            linkPerforce.LinkClicked += new LinkLabelLinkClickedEventHandler(linkPerforce_LinkClicked);

            FillTreeNode();
            treeViewBitFiles.NodeMouseClick += new TreeNodeMouseClickEventHandler(treeViewBitFiles_NodeMouseClick);
        }

        void treeViewBitFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string r = e.Node.FullPath;
            txtPath.Text = r.Replace(@"\","");
        }

        public void FillTreeNode()
        {
            treeViewBitFiles.Nodes.Add("/sdcard");
            treeViewBitFiles.Nodes[0].Nodes.Add("/firmware");
            treeViewBitFiles.Nodes[0].Nodes[0].Nodes.Add("/fsb");
            treeViewBitFiles.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("/cbio");
            treeViewBitFiles.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("/cbmp");
            treeViewBitFiles.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("/absd");
            treeViewBitFiles.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("/cbsd");
            treeViewBitFiles.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("/rbsd");
        }

        void linkPerforce_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            sendtomaster(Mode.WriteSerialPort, "help");
        }

        public string OpenFile(string Filter)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = Filter + " files (*." + Filter + ")|*." + Filter;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                return openFile.FileName;
            }
            return "Invalid";

        }

        public string SaveFile(string Filter)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = Filter + " files (*." + Filter + ")|*." + Filter;
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                return saveFile.FileName;
            }
            return "Invalid";
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            string line;

            using (StreamReader Reader = new StreamReader(OpenFile("txt")))
            {
                while ((line = Reader.ReadLine()) != null)
                {
                    if (!line.StartsWith("---"))
                    {
                        if (rdbtnSendToSendBox.Checked == true)
                        {
                            sendtomaster(Mode.WriteSendBox, line + ret);
                        }
                        else
                        {
                            sendtomaster(Mode.WriteSerialPort, line + ret);
                        }
                    }
                }
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            WriteFile(SaveFile("txt"), txtToSave.Text);
        }

        public void WriteFile(string FileName, string Text)
        {
            using (StreamWriter wr = File.AppendText(FileName))
            {
                wr.Write(Text);
            }
        }

        private void btnReadFlash_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("FlashRead.txt");

                FSB.ReadFlash = true;

                sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_question[FSB.ActiveSlave] + " -p 0x8001 -l 2 -2");
                sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_Answer_m[FSB.ActiveSlave] + " -p 0x6000 -l 2 -2");
                sendtomaster(Mode.WriteSerialPort, "xblck -b " + FSB.Miso_Mass[FSB.ActiveSlave] + " -n 32 -1");

                sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_question[FSB.ActiveSlave] + " -p 0x8001 -l 2 -2");
                sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_Answer_m[FSB.ActiveSlave] + " -p 0x6001 -l 2 -2");
                sendtomaster(Mode.WriteSerialPort, "xblck -b " + FSB.Miso_Mass[FSB.ActiveSlave] + " -n 32 -1");

                sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_question[FSB.ActiveSlave] + " -p 0x8001 -l 2 -2");
                sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_Answer_m[FSB.ActiveSlave] + " -p 0x6002 -l 2 -2");
                sendtomaster(Mode.WriteSerialPort, "xblck -b " + FSB.Miso_Mass[FSB.ActiveSlave] + " -n 32 -1");

                sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_question[FSB.ActiveSlave] + " -p 0x8001 -l 2 -2");
                sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_Answer_m[FSB.ActiveSlave] + " -p 0x6003 -l 2 -2");
                sendtomaster(Mode.WriteSerialPort, "xblck -b " + FSB.Miso_Mass[FSB.ActiveSlave] + " -n 32 -1");

                //sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_question[FSB.ActiveSlave] + " -p 0x8001 -l 2 -2");
                //sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_Answer_m[FSB.ActiveSlave] + " -p 0x6004 -l 2 -2");
                //sendtomaster(Mode.WriteSerialPort, "xblck -b " + FSB.Miso_Mass[FSB.ActiveSlave] + " -n 32 -1");

                thr = new Thread(GetValidFlashData);
                thr.IsBackground = true;
                thr.Start();

                while (thr.IsAlive)
                {

                }

                if (f.Length == 48 && chkCbsio.Checked == false) //was 32
                {
                    txtBoardName.Text = f.Substring(0, 4);
                    txtFunction.Text = f.Substring(4, 2);
                    txtVersion.Text = f.Substring(6, 2);
                    txtHfiVersion.Text = f.Substring(8, 1);
                    txtHfiRevision.Text = f.Substring(9, 1);
                    txtBENumber.Text = f.Substring(10, 8);
                    txtSerialNumber.Text = f.Substring(18, 12);
                    txtRevision.Text = f.Substring(30, 2);
                    txtDna.Text = Ascii2Hex(f.Substring(32, 16));
                    
                }
                else
                {
                    txtToSave.Text = f;
                }
                if (f.Length == 49 && chkCbsio.Checked == true)
                {
                    txtBoardName.Text = f.Substring(0, 5);
                    txtFunction.Text = f.Substring(5, 2);
                    txtVersion.Text = f.Substring(7, 2);
                    txtHfiVersion.Text = f.Substring(9, 1);
                    txtHfiRevision.Text = f.Substring(10, 1);
                    txtBENumber.Text = f.Substring(11, 8);
                    txtSerialNumber.Text = f.Substring(19, 12);
                    txtRevision.Text = f.Substring(31, 2);
                    txtDna.Text = Ascii2Hex(f.Substring(33, 16));
                }
                else
                {
                    txtToSave.Text = f;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void GetValidFlashData()
        {
            Thread.Sleep(500);

            string[] ReadLines = File.ReadAllLines("FlashRead.txt");

            hex = string.Empty;

            foreach (string ReadLine in ReadLines)
            {
                if (ReadLine != string.Empty && ReadLine.Substring(0, 2).Contains("0x") && !ReadLine.Contains("RedBoot>"))
                {
                    string s = ReadLine.Remove(0, 2);

                    if (!s.Contains("00") && !s.Contains("20") && !s.Contains("ff"))
                    {
                        hex += s;
                    }
                }
            }

            f = Hex2Ascii(hex);

            Array.Clear(ReadLines, 0, ReadLines.Length);

            FSB.ReadFlash = false;

            thr.Abort();
        }

        public string Ascii2Hex(string AsciiString)
        {
            string hex = "";

            foreach (char c in AsciiString)
            {
                int tmp = c;
                hex += string.Format("{0:X2}", (uint)Convert.ToUInt32(tmp.ToString()));
            }
            
            return hex;
        }

        public string Hex2Ascii(string hex)
        {
            string res = string.Empty;

            for (int a = 0; a < hex.Length; a += 2)
            {
                string Char2Convert = hex.Substring(a, 2);

                int n = Convert.ToInt32(Char2Convert, 16);

                char c = (char)n;

                res += c.ToString();

            }
            return res;
        }

        private void btnWriteFlash_Click(object sender, EventArgs e)
        {
            if (txtBoardName.Text == "CBSIO")
            {
                if (txtBoardName.Text.Length != 5) { MessageBox.Show("Expected 5 Chars in Board Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            }
            else
            {
                if (txtBoardName.Text.Length != 4) { MessageBox.Show("Expected 4 Chars in Board Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            }
            
            if (txtBENumber.Text.Length != 8) { MessageBox.Show("Expected 8 Chars in BE number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txtSerialNumber.Text.Length != 12) { MessageBox.Show("Expected 12 Chars in Serial Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txtFunction.Text.Length != 2) { MessageBox.Show("Expected 2 Chars in Function Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txtVersion.Text.Length != 2) { MessageBox.Show("Expected 2 Chars in Version Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txtRevision.Text.Length != 2) { MessageBox.Show("Expected 2 Chars in Revision Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txtHfiVersion.Text.Length != 1) { MessageBox.Show("Expected 1 Char in HFI Version Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txtHfiRevision.Text.Length != 1) { MessageBox.Show("Expected 1 Char in HFI Revision Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txtDna.Text.Length != 32) { MessageBox.Show("Expected 16 Chars in DNA Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            FSB.WriteFlash = true;
            if (txtBoardName.Text == "CBSIO")
            {
                Flash.s1 = txtBoardName.Text + "           " + txtFunction.Text + txtVersion.Text + txtHfiVersion.Text + txtHfiRevision.Text;
            }
            else
            {
                Flash.s1 = txtBoardName.Text + "            " + txtFunction.Text + txtVersion.Text + txtHfiVersion.Text + txtHfiRevision.Text;
            }
            
            Flash.s2 = txtBENumber.Text + txtSerialNumber.Text + txtRevision.Text;
            Flash.s3 = txtDna.Text;

            thr4 = new Thread(WriteFlash);
            thr4.IsBackground = true;
            thr4.Start();

            FSB.WriteFlash = false;
        }

        public void WriteFlash()
        {
            char[] CharsS1 = Flash.s1.ToCharArray();
            string HexS1 = "";

            foreach (char Ch in CharsS1)
            {
                int value = Convert.ToInt32(Ch);
                HexS1 += string.Format("{0:X}", value);
            }

            char[] CharsS2 = Flash.s2.ToCharArray();
            string HexS2 = "";

            foreach (char Ch in CharsS2)
            {
                int value = Convert.ToInt32(Ch);
                HexS2 += string.Format("{0:X}", value);
            }

            HexS1 += "ffffffffffffffffffffffffffffffffffffffffffffffffffff";
            //HexS1 += "0000000000000000000000000000000000000000000000000000";
            HexS2 += "ffffffffffffffffffff";
            //HexS2 += "00000000000000000000";

            //Erase Sector 12
            sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_question[FSB.ActiveSlave] + " -p 0x0001 -l 2 -2");
            sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_Answer_m[FSB.ActiveSlave] + " -p 0x6000 -l 2 -2");
            sendtomaster(Mode.WriteSerialPort, "xblck -b " + FSB.Q_A_Answer_s[FSB.ActiveSlave] + " -2");

            Thread.Sleep(1500);

            //Sector 12 - Byte 0 - 63
            sendtomaster(Mode.WriteSerialPort, "fblck -b " + FSB.Mosi_Mass[FSB.ActiveSlave] + " -p " + HexS1 + " -2");
            sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_question[FSB.ActiveSlave] + " -p 0x8002 -l 2 -2");
            sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_Answer_m[FSB.ActiveSlave] + " -p 0x6000 -l 2 -2");
            sendtomaster(Mode.WriteSerialPort, "xblck -b " + FSB.Q_A_Answer_s[FSB.ActiveSlave] + " -2");

            Thread.Sleep(200);

            //Sector 12 - Byte 64 -127
            sendtomaster(Mode.WriteSerialPort, "fblck -b " + FSB.Mosi_Mass[FSB.ActiveSlave] + " -p " + HexS2 + Flash.s3 + " -2");
            sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_question[FSB.ActiveSlave] + " -p 0x8002 -l 2 -2");
            sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_Answer_m[FSB.ActiveSlave] + " -p 0x6002 -l 2 -2");
            sendtomaster(Mode.WriteSerialPort, "xblck -b " + FSB.Q_A_Answer_s[FSB.ActiveSlave] + " -2");

            //Thread.Sleep(200);

            ////Sector 12 - Byte 64 -127
            //sendtomaster(Mode.WriteSerialPort, "fblck -b " + FSB.Mosi_Mass[FSB.ActiveSlave] + " -p " + Flash.s3 + " -2");
            //sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_question[FSB.ActiveSlave] + " -p 0x8002 -l 2 -2");
            //sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_Answer_m[FSB.ActiveSlave] + " -p 0x6003 -l 2 -2");
            //sendtomaster(Mode.WriteSerialPort, "xblck -b " + FSB.Q_A_Answer_s[FSB.ActiveSlave] + " -2");

            //Thread.Sleep(200);

            ////Sector 12 - Byte 64 -127
            //sendtomaster(Mode.WriteSerialPort, "fblck -b " + FSB.Mosi_Mass[FSB.ActiveSlave] + " -p 0000 -2");
            //sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_question[FSB.ActiveSlave] + " -p 0x8002 -l 2 -2");
            //sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_Answer_m[FSB.ActiveSlave] + " -p 0x6004 -l 2 -2");
            //sendtomaster(Mode.WriteSerialPort, "xblck -b " + FSB.Q_A_Answer_s[FSB.ActiveSlave] + " -2");

            FSB.WriteFlash = false;
            
            thr4.Abort();
        }

        private void btnLoadFpga_Click(object sender, EventArgs e)
        {
            sendtomaster(Mode.WriteSerialPort, "mount -d /dev/mmc0/1 -t fatfs /sdcard");
            sendtomaster(Mode.WriteSerialPort, "fpgaload " + txtPath.Text);
            sendtomaster(Mode.WriteSerialPort, "umount /sdcard");
        }

        public void GetValidScardData()
        {
            try
            {
                Thread.Sleep(500);

                string[] ReadLines = File.ReadAllLines("FlashRead.txt");

                foreach (string ReadLine in ReadLines)
                {
                    if (ReadLine.Contains(".bit"))
                    {
                        string[] split = ReadLine.Split(' ');
                        f += split[split.Length - 1] + ret;
                    }
                }

                FSB.ReadSdcard = false;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("DWOAZ'N !\r\nLegt de spanning aan hé!", "Exception!");
            }

            finally
            {
                thr.Abort();
            }
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex == 3)
                {
                    //if (treeViewBitFiles.Nodes.Count > 0)
                    //{
                    //treeViewBitFiles.Nodes.Clear();
                    //}
                    File.Delete("FlashRead.txt");
                    f = string.Empty;
                    FSB.ReadSdcard = true;

                    sendtomaster(Mode.WriteSerialPort, "mount -d /dev/mmc0/1 -t fatfs /sdcard");
                    sendtomaster(Mode.WriteSerialPort, "ls -d /sdcard/firmware/fsb/cbmp");
                    sendtomaster(Mode.WriteSerialPort, "ls -d /sdcard/firmware/fsb/cbio");
                    sendtomaster(Mode.WriteSerialPort, "ls -d /sdcard/firmware/fsb/absd");
                    sendtomaster(Mode.WriteSerialPort, "ls -d /sdcard/firmware/fsb/cbsd");
                    sendtomaster(Mode.WriteSerialPort, "ls -d /sdcard/firmware/fsb/rbsd");

                    thr = new Thread(GetValidScardData);
                    thr.IsBackground = true;
                    thr.Start();

                    while (thr.IsAlive)
                    {

                    }

                    string[] bitfiles = f.Split('\r');
                    string s = string.Empty;

                    foreach (string line in bitfiles)
                    {
                        if (line.Contains("\n"))
                        {
                            s = line.Replace("\n", "");

                            if (s.Contains("cbio"))
                            {
                                treeViewBitFiles.Nodes[0].Nodes[0].Nodes[0].Nodes[0].Nodes.Add("/" + s);
                            }
                            if (s.Contains("cbmp"))
                            {
                                treeViewBitFiles.Nodes[0].Nodes[0].Nodes[0].Nodes[1].Nodes.Add("/" + s);
                            }
                            if (s.Contains("absd"))
                            {
                                treeViewBitFiles.Nodes[0].Nodes[0].Nodes[0].Nodes[2].Nodes.Add("/" + s);
                            }
                            if (s.Contains("cbsd"))
                            {
                                treeViewBitFiles.Nodes[0].Nodes[0].Nodes[0].Nodes[3].Nodes.Add("/" + s);
                            }
                            if (s.Contains("rbsd"))
                            {
                                treeViewBitFiles.Nodes[0].Nodes[0].Nodes[0].Nodes[4].Nodes.Add("/" + s);
                            }
                        }

                        else
                        {
                            if (line.Contains("cbio"))
                            {
                                treeViewBitFiles.Nodes[0].Nodes[0].Nodes[0].Nodes[0].Nodes.Add("/" + line);
                            }
                            if (line.Contains("cbmp"))
                            {
                                treeViewBitFiles.Nodes[0].Nodes[0].Nodes[0].Nodes[1].Nodes.Add("/" + line);
                            }
                            if (line.Contains("absd"))
                            {
                                treeViewBitFiles.Nodes[0].Nodes[0].Nodes[0].Nodes[2].Nodes.Add("/" + line);
                            }
                            if (line.Contains("cbsd"))
                            {
                                treeViewBitFiles.Nodes[0].Nodes[0].Nodes[0].Nodes[3].Nodes.Add("/" + line);
                            }
                            if (line.Contains("rbsd"))
                            {
                                treeViewBitFiles.Nodes[0].Nodes[0].Nodes[0].Nodes[4].Nodes.Add("/" + line);
                            }
                        }
                    }

                    sendtomaster(Mode.WriteSerialPort, "umount /sdcard");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception!");
            }
        }

        private void btnRunAutoTest_Click(object sender, EventArgs e)
        {
            thr3 = new Thread(RunAutoTest);
            thr3.IsBackground = true;
            thr3.Start();
            
        }

        public void RunAutoTest()
        {
            if (chbRepeat.Checked)
            {
                while (thr3.IsAlive)
                {
                    try
                    {
                        foreach (string line in txtAutoTest.Lines)
                        {
                            if (line != string.Empty & !line.Trim().StartsWith("#"))
                            {
                                int delay = Convert.ToInt32(line.Substring(line.LastIndexOf('<') + 1, line.LastIndexOf('>') - line.LastIndexOf('<') - 1));
                                string cmd = line.Substring(line.LastIndexOf('>') + 1, line.Length - line.LastIndexOf('>') - 1);
                                Thread.Sleep(delay);
                                sendtomaster(Mode.WriteSerialPort, cmd);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Exception!");
                    }
                }
            }
            else
            {
                try
                {
                    foreach (string line in txtAutoTest.Lines)
                    {
                        if (line != string.Empty & !line.Trim().StartsWith("#"))
                        {
                            int delay = Convert.ToInt32(line.Substring(line.LastIndexOf('<') + 1, line.LastIndexOf('>') - line.LastIndexOf('<') - 1));
                            string cmd = line.Substring(line.LastIndexOf('>') + 1, line.Length - line.LastIndexOf('>') - 1);
                            Thread.Sleep(delay);
                            sendtomaster(Mode.WriteSerialPort, cmd);
                        }
                    }
                    thr3.Abort();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception!");
                }
            }
            
            
        }

        private void btnStopAutoTest_Click(object sender, EventArgs e)
        {
            thr3.Abort();
        }

        private void btnOpenUploadFile_Click(object sender, EventArgs e)
        {
            txtUploadFilePath.Text = OpenFile("upload");
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            thr2 = new Thread(upload);
            thr2.IsBackground = true;
            thr2.Start();
        }

        public void upload()
        {
            string line;
            string address;
            string data;
            string trimdata;
            string byte2word = string.Empty;
            result = string.Empty;

            StreamReader UploadFile = new StreamReader(txtUploadFilePath.Text);

            Boolean firstline = true;

            while((line = UploadFile.ReadLine()) != null)
            {
                string[] splitted = line.Split(':');

                address = splitted[0];
                data = splitted[1];

                trimdata = data.Replace(" ", "");

                if (firstline)
                {
                    for (int x = 0; x < 64; x = x + 2)
                    {
                        byte2word = byte2word + trimdata.Substring(x, 2).PadLeft(4, '0');
                    }
                    WriteFile("byte2word.txt", byte2word);
                } 

                int decaddr = Convert.ToInt32(address, 16);

                decaddr = decaddr / 32;
                decaddr = decaddr + 32768;

                string hexaddr = decaddr.ToString("X");

                sendtomaster(Mode.WriteSerialPort, "fblck -b " + FSB.Mosi_Mass[FSB.ActiveSlave] + " -p " + trimdata + " -2");
                Thread.Sleep(10);
                sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_question[FSB.ActiveSlave] + " -p 0x8004 -l 2 -2");
                Thread.Sleep(10);
                sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_Answer_m[FSB.ActiveSlave] + " -p 0x" + hexaddr + " -l 2 -2");
                Thread.Sleep(10);
                sendtomaster(Mode.WriteSerialPort, "xblck -b " + FSB.Q_A_Answer_s[FSB.ActiveSlave] + " -2");
                Thread.Sleep(10);
                //sendtomaster(Mode.WriteSerialPort, "x -b " + FSB.Miso_Mass[FSB.ActiveSlave] + " -l 32 -2");
                //Thread.Sleep(10);

                firstline = false;
            }

            thr2.Abort();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            thr2 = new Thread(download);
            thr2.IsBackground = true;
            thr2.Start();
        }

        public void download()
        {
            sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_question[FSB.ActiveSlave] + " -p 0x8005 -l 2 -2");
            Thread.Sleep(10);
            sendtomaster(Mode.WriteSerialPort, "mfill -b " + FSB.Q_A_Answer_m[FSB.ActiveSlave] + " -p 0x8800 -l 2 -2");
            Thread.Sleep(10);
            sendtomaster(Mode.WriteSerialPort, "x -b " + FSB.Miso_Mass[FSB.ActiveSlave] + " -l 32 -2");
            Thread.Sleep(10);
            thr2.Abort();
        }
      

        private void btnOpenTest_Click(object sender, EventArgs e)
        {
            using (StreamReader Reader = new StreamReader(OpenFile("tst")))
            {
                txtAutoTest.Text = Reader.ReadToEnd();
            }
        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {
            WriteFile(SaveFile("tst"), txtAutoTest.Text);
        }

        private void btnCbSimRun_Click(object sender, EventArgs e)
        {
            
            thr5 = new Thread(RunCbSimTest);
            thr5.IsBackground = true;
            thr5.Start();
        }

        public void RunCbSimTest()
        {
            Mosi = "";
            output = "";
            
            while (thr5.IsAlive)
            {
                try
                {
                    foreach (string line in txtCbSimFiles.Lines)
                    {
                        if (line != string.Empty)
                        {
                            int delay = Convert.ToInt32(line.Substring(line.LastIndexOf('<') + 1, line.LastIndexOf('>') - line.LastIndexOf('<') - 1));
                            string file = line.Substring(line.LastIndexOf('>') + 1, line.Length - line.LastIndexOf('>') - 1);
                            Thread.Sleep(delay);

                            using (StreamReader Reader = new StreamReader(txtFileLocation.Text + "\\" + file))
                            {
                                while ((CbSimLine = Reader.ReadLine()) != null)
                                {
                                    CbSimLineItems = CbSimLine.Split(';');

                                    for (int i = 1; i <= 32; i = i + 2)
                                    {
                                        if (CbSimLineItems[i] == "x")
                                        {
                                            Mosi += "1";
                                        }
                                        else
                                        {
                                            Mosi += "0";
                                        }
                                    }

                                    Mosi += "0000000000000000";
                                }
                            }

                            int rest = Mosi.Length % 4;

                            if (rest != 0)
                            {
                                Mosi = new string('0', 4 - rest) + Mosi;
                            }

                            output = "";

                            for (int o = 0; o <= Mosi.Length - 4; o += 4)
                            {
                                output += string.Format("{0:X}", Convert.ToByte(Mosi.Substring(o, 4), 2));
                            }

                            if (chkMosiStringOnly.Checked)
                            {
                                //txtCbSimFiles.AppendText("\r\n" + output);
                                MosiData += "\r\n" + output;
                            }
                            else
                            {
                                string s = "fblck -b " + FSB.Mosi[FSB.ActiveSlave] + " -p 0x" + output + " -2";
                                sendtomaster(Mode.WriteSerialPort, s);
                            }

                            Mosi = "";
                            output = "";
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception!");
                }

            }
        }

        private void btnStopCbSimTest_Click(object sender, EventArgs e)
        {
            thr5.Abort();
            txtCbSimFiles.AppendText(MosiData);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FBD = new FolderBrowserDialog();
            DialogResult result = FBD.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileLocation.Text = FBD.SelectedPath;
                Properties.Settings.Default.CBSIMFiles = txtFileLocation.Text;
            }
        }

        

        
    }
}
