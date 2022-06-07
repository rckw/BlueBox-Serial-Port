using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueBox_SerialPort
{
    class Mode
    {
        public static int WriteSerialPort = 1;
        public static int WriteSendBox = 2;
    }
    
    
    class Fsb
    {
        public static string[] Miso = {"0x10108400","0x10108440","0x10108480","0x101084C0","0x10108500","0x10108540","0x10108580","0x101085C0","0x10108600",
                        "0x10108640","0x10108680","0x101086C0","0x10108700","0x10108740","0x10108780","0x101087C0"};

        public static string[] Miso_Mass = { "0x10108420","0x10108460","0x101084A0","0x101084E0","0x10108520","0x10108560","0x101085A0","0x101085E0","0x10108620",
                        "0x10108660","0x101086A0","0x101086E0","0x10108720","0x10108760","0x101087A0","0x101087E0"};

        public static string[] Mosi = {"0x10108800","0x10108880","0x10108900","0x10108980","0x10108A00","0x10108A80","0x10108B00","0x10108B80","0x10108C00",
                        "0x10108C80","0x10108D00","0x10108D80","0x10108E00","0x10108E80","0x10108F00","0x10108F80" };

        public static string[] Mosi_Mass = { "0x10108840","0x101088C0","0x10108940","0x101089C0","0x10108A40","0x10108AC0","0x10108B40","0x10108BC0","0x10108C40",
                        "0x10108CC0","0x10108D40","0x10108DC0","0x10108E40","0x10108EC0","0x10108F40","0x10108FC0"};

        public static string[] Q_A_question = {"0x10108080","0x10108088","0x10108090","0x10108098","0x101080A0","0x101080A8","0x101080B0","0x101080B8","0x101080C0",
                         "0x101080C8","0x101080D0","0x101080D8","0x101080E0","0x101080E8","0x101080F0","0x101080F8"};

        public static string[] Q_A_Answer_m = {"0x10108082","0x1010808A","0x10108092","0x1010809A","0x101080A2","0x101080AA","0x101080B2","0x101080BA","0x101080C2",
                         "0x101080CA","0x101080D2","0x101080DA","0x101080E2","0x101080EA","0x101080F2","0x101080FA"};

        public static string[] Q_A_Answer_s = {"0x10108084","0x1010808C","0x10108094","0x1010809C","0x101080A4","0x101080AC","0x101080B4","0x101080BC","0x101080C4",
                         "0x101080CC","0x101080D4","0x101080DC","0x101080E4","0x101080EC","0x101080F4","0x101080FC"};

        public static string CmdFunction = "0x1010800A";
        public static string CmdAction = "0x1010800C";

        public static string[] Slave_Control = { "0x0001", "0x0002" , "0x0004", "0x0008", "0x0010", "0x0020", "0x0040","0x0080", "0x0100","0x0200", "0x0400", "0x0800",
                         "0x1000","0x2000","0x4000","0x8000"};

        public static string[] RTD = { "0x10108040", "0x10108042", "0x10108044", "0x10108046", "0x10108048", "0x1010804A", "0x1010804C", "0x1010804E", "0x10108050", 
                                         "0x10108052", "0x10108054", "0x10108056", "0x10108058", "0x1010805A", "0x1010805C", "0x1010805E" };

        public static int ActiveSlave { get; set; }

        public static Boolean ReadFlash { get; set; }
        public static Boolean WriteFlash { get; set; }

        public static Boolean ReadSdcard { get; set; }
    }


    class Variable
    {
        public static Boolean ACPTest { get; set; }
    }

    class TextFiles
    {
        public static string Text { get; set; }
    }

    class Flash
    {
        public static string s1 { get; set; }
        public static string s2 { get; set; }
        public static string s3 { get; set; }
    }
}
