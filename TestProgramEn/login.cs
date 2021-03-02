using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestProgramEn
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        string admin_id = "admin";
        string admin_pass = "123";
        string user_id = "user";
        string user_pass = "123";

        private void Form3_Load(object sender, EventArgs e)
        {
            var path = ".";
            string fullPath = Path.GetFullPath(path);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TXTusername.Text == admin_id)
            {
                if (TXTpass.Text == admin_pass)
                {
                    this.Hide();
                    menu frm = new menu();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Password.");
                }
            }
            else if (TXTusername.Text == user_id)
            {
                if (TXTpass.Text == user_pass)
                {
                    this.Hide();
                    search_screen frm = new search_screen(2);
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Password.");
                }
            }
            else if (TXTusername.Text != admin_id || TXTusername.Text != user_id)
                MessageBox.Show("Wrong Information.");

        }
    }
}
