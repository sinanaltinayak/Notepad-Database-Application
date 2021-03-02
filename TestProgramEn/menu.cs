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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void BTNquit_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm = new login();
            frm.ShowDialog();
            this.Close();
        }

        private void BTNedit_Click(object sender, EventArgs e)
        {
            this.Hide();
            edit_screen frm = new edit_screen();
            frm.ShowDialog();
            this.Close();
        }

        private void BTNsearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            search_screen frm = new search_screen(1);
            frm.ShowDialog();
            this.Close();
        }

        private void menü_Load(object sender, EventArgs e)
        {

        }

    }
}
