using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProgramEn
{
    public partial class edit_test_no : Form
    {
        public edit_test_no(int i)
        {
            InitializeComponent();
            TBXoldno.Text = i.ToString();
        }

        public int GetValue
        {
            get
            {
                return Int32.Parse(TBXnewno.Text);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TBXnewno.Text = "0";
        }


        private void TBXnewno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void TBXnewno_TextChanged(object sender, EventArgs e)
        {
            if (TBXnewno.Text == null)
                TBXnewno.Text = "0";
        }
    }
}
