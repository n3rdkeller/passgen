using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passgen
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region variables declaration

        char[] UpperCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] LowerCharset = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        char[] NumberCharset = "1234567890".ToCharArray();
        char[] SymbolCharset = "-!?$§&*+#%".ToCharArray();

        #endregion

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (chkLowers.Checked | chkNumbers.Checked | chkSymbols.Checked | chkUppers.Checked)
            {
                tbxPasses.Lines = GenPasses(Convert.ToInt16(numLength.Value), Convert.ToInt16(numCount.Value), chkUppers.Checked, chkLowers.Checked, chkNumbers.Checked, chkSymbols.Checked);
            }
            else
            {
                tbxPasses.Text = "No option selected!";
            }
        }

        private string[] GenPasses(int Length, int Count, bool Uppers, bool Lowers, bool Numbers, bool Symbols)
        {
            string[] GeneratedPasses = new string[Count];
            Random rndChar = new Random(Environment.TickCount);
            Random rndOption = new Random(Environment.TickCount);

            for (int i = 0; i < Count; i++)
            {
                string CurrentPassword = string.Empty;

                for (int j = 0; j < Length; j++)
                {
                    char CurrentChar = Char.MinValue;
                    while (CurrentChar == Char.MinValue)
                    {
                        int option = rndOption.Next(4);
                        if (option == 0 && Uppers) { CurrentChar = UpperCharset[rndChar.Next(UpperCharset.Length)]; }
                        if (option == 1 && Lowers) { CurrentChar = LowerCharset[rndChar.Next(LowerCharset.Length)]; }
                        if (option == 2 && Numbers) { CurrentChar = NumberCharset[rndChar.Next(NumberCharset.Length)]; }
                        if (option == 3 && Symbols) { CurrentChar = SymbolCharset[rndChar.Next(SymbolCharset.Length)]; }

                    }
                    CurrentPassword += CurrentChar.ToString();
                }

                GeneratedPasses[i] = CurrentPassword;
            }

            return GeneratedPasses;
        }

    }
}
