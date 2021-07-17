using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;

namespace Offset_Finder
{
    public partial class Form1 : Form
    {
        #region Convert Func
        private static string ConvertOffset(string offset)
        {
            int offsetHex = int.Parse(offset, NumberStyles.HexNumber);

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
        #endregion
        
        #region Find original offset
        private static string ConvertToOffset(string value)
        {
            int offset = int.Parse(ConvertBigEndian(value), NumberStyles.HexNumber) - 0x400000;
            return string.Format($"{offset:X8}");
        }

        private static string ConvertBigEndian(string value)
        {
            var groups = new List<string>();
            for (int i = 0; i < value.Length; i += 2)
            {
                string item = new string(new char[] { value[i], value[i + 1] });
                groups.Add(item);
            }

            groups.Reverse();
            string valueBigEndian = "";
            foreach (var item in groups)
                valueBigEndian += item;
            return valueBigEndian;
        }
        #endregion
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string offset = off_0.Text + off_1.Text + 
                            off_2.Text + off_3.Text;

            off_res.Text = ConvertOffset(offset);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result2.Text = ConvertToOffset(CodeLine.Text);
        }
    }
}
