using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Offset_Finder
{
    public partial class Form1 : Form
    {
        #region Convert Func
        private static string ConvertOffset(string offset)
        {
            int offsetHex = int.Parse(offset, System.Globalization.NumberStyles.HexNumber);

            offsetHex += 0x400000;
            string result = string.Format($"{offsetHex:X8}");

            var groups = new List<string>();
            for (int i = 0; i < result.Length; i += 2)
            {
                string item = new string(new char[] { result[i], result[i + 1] });
                groups.Add(item);
            }

            groups.Reverse();
            string resultLE = "";
            foreach (var item in groups)
                resultLE += item;

            return resultLE.ToString();
        }
        public Form1()
        {
            InitializeComponent();
            var ran = 123;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string offset = off_0.Text + off_1.Text + 
                            off_2.Text + off_3.Text;

            off_res.Text = ConvertOffset(offset);
        }
    }
}
