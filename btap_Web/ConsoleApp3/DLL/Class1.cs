using System;
using System.Collections.Generic;
using System.Text;

namespace DLL
{
    public class Class1
    {
        public string Input { get; set; }
        public string report { get;private set; }


        public string Caculate()
        {
            if (string.IsNullOrEmpty(Input))
            {
                report = "Vui long nhap du lieu";
            }
            int hash = 0;
            unchecked
            {
                foreach (char ch in Input)
                {
                    hash = hash * 31 + ch;
                }
            }
            if (hash < 0) hash = -hash;

            // 2. Sinh 4 chỉ số (0..100)
            int energy = (hash % 101);
            int luck = ((hash / 7) % 101);
            int charm = ((hash / 13) % 101);
            int chaos = ((hash / 17) % 101);

            // 3. Biểu đồ ASCII
            string energyBar = new string('=', energy / 5);
            string luckBar = new string('=', luck / 5);
            string charmBar = new string('=', charm / 5);
            string chaosBar = new string('=', chaos / 5);

            // 4. Ghép thành báo cáo
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cosmic Personal Index ");
            sb.AppendLine("Input: " + Input);
            sb.AppendLine("----------------------------");
            sb.AppendLine("suc manh: " + energy.ToString().PadLeft(3) + " | " + energyBar);
            sb.AppendLine("may man   : " + luck.ToString().PadLeft(3) + " | " + luckBar);
            sb.AppendLine("do ben  : " + charm.ToString().PadLeft(3) + " | " + charmBar);
            sb.AppendLine("toc do : " + chaos.ToString().PadLeft(3) + " | " + chaosBar);
            sb.AppendLine("----------------------------");
            sb.AppendLine("“ Chua te .NET TNUT ");
            sb.AppendLine("  AKA Thai Tu TNUT.”");
            sb.AppendLine();
            sb.AppendLine("   /\\_/\\  ");
            sb.AppendLine("  ( o.o )  mew~");
            sb.AppendLine("   > ^ <   mew");

            report = sb.ToString();
            return report;
        }
    }
}
