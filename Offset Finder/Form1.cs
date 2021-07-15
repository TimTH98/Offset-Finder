using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Offset_Finder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var ran = 123;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string offset = off_0.Text + off_1.Text + 
                            off_2.Text + off_3.Text;

            string sum = "00400000";
            var offsetHex = int.Parse(offset, System.Globalization.NumberStyles.HexNumber);
            var sumHex = int.Parse(offset, System.Globalization.NumberStyles.HexNumber);

            sumHex += offsetHex;
            var sumHex_1 = $"{sumHex:X}";
            off_res.Text = sumHex_1;
        }
    }
}
