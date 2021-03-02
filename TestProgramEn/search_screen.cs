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
    public partial class search_screen : Form
    {
        public search_screen(int i)
        {
            if (i == 2)
            {
                userswitch = i;
            }
            InitializeComponent();
        }
        DataTable table = new DataTable();

        int userswitch;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (userswitch == 2)
            {
                BTNmain_menu.Enabled = false;
                BTNedit.Enabled = false;
            }
            table.Columns.Add("TEST #", typeof(int));
            table.Columns.Add("TEST NAME", typeof(string));
            table.Columns.Add("UNIT", typeof(string));
            table.Columns.Add("HOUR", typeof(string));
            table.Columns.Add("DAY", typeof(string));
            table.Columns.Add("STORAGE", typeof(string));
            table.Columns.Add("NOTE", typeof(string));

            dataGridView1.DataSource = table;
            this.dataGridView1.Sort(this.dataGridView1.Columns["TEST #"], ListSortDirection.Ascending);

            fill_table();

            splitContainer1.SplitterDistance = 220;
            splitContainer2.SplitterDistance = 125;
        }
        private void fill_table()
        {
            if (table != null)
                table.Clear();

            var path = ".";
            string fullPath = Path.GetFullPath(path);

            string[] lines = File.ReadAllLines(fullPath + "\\database.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }
        }
        private void tablo_filtrele(int testNo, string name, string storage, List<string> unit, List<string> day, List<string> hour)
        {
            if (table != null)
                table.Clear();

            var path = ".";
            string fullPath = Path.GetFullPath(path);

            string[] lines = File.ReadAllLines(fullPath + "\\database.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');
                string[] row = new string[values.Length];


                if ((testNo != 0 && int.Parse(values[0]) == testNo) || testNo == 0)
                {
                    if ((name != "" && values[1].Contains(name)) || name == "")
                    {
                        if ((storage != "" && values[5].Contains(storage)) || storage == "")
                        {
                            if ((unit.Count != 0 && unit.Contains(values[2].Trim())) || unit.Count == 0)
                            {
                                if ((day.Count != 0 && day.Contains(values[4].Trim())) || day.Count == 0)
                                {
                                    if ((hour.Count != 0 && hour.Contains(values[3].Trim())) || hour.Count == 0)
                                    {
                                        for (int j = 0; j < values.Length; j++)
                                            row[j] = values[j].Trim();
                                        table.Rows.Add(row);
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }
        private void BTNfilter_Click(object sender, EventArgs e)
        {
            int testNo = 0;
            string name = "";
            string storage = "";
            List<string> unit = new List<string>();
            List<string> hour = new List<string>();
            List<string> day = new List<string>();

            if (FLTtestno.Text == "")
                FLTtestno.Text = "0";
            if (FLTtestno.Text != "0")
                testNo = Int32.Parse(FLTtestno.Text);
            if (FLTtest_name.Text != null)
                name = FLTtest_name.Text;
            if (FLTstorage.Text != null)
                storage = FLTstorage.Text;
            if (FLTunit.CheckedItems.Count != 0)
            {
                for (int i = 0; i < FLTunit.CheckedItems.Count; i++)
                {
                    unit.Add(FLTunit.CheckedItems[i].ToString());
                }
            }
            if (FLTday.CheckedItems.Count != 0)
            {
                for (int i = 0; i < FLTday.CheckedItems.Count; i++)
                {
                    day.Add(FLTday.CheckedItems[i].ToString());
                }
            }
            if (FLThour.CheckedItems.Count != 0)
            {
                for (int i = 0; i < FLThour.CheckedItems.Count; i++)
                {
                    hour.Add(FLThour.CheckedItems[i].ToString());
                }
            }

            tablo_filtrele(testNo, name, storage, unit, day, hour);
        }


        private void BTNclear_filters_Click(object sender, EventArgs e)
        {
            FLTtestno.Text = "0";
            FLTtest_name.Text = "";
            FLTstorage.SelectedIndex = -1;
            for (int i = 0; i < FLTunit.Items.Count; i++)
                FLTunit.SetItemCheckState(i, CheckState.Unchecked);
            for (int i = 0; i < FLTday.Items.Count; i++)
                FLTday.SetItemCheckState(i, CheckState.Unchecked);
            for (int i = 0; i < FLThour.Items.Count; i++)
                FLThour.SetItemCheckState(i, CheckState.Unchecked);


            fill_table();
        }

        private void FLTtestno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void BTNedit_Click(object sender, EventArgs e)
        {
            this.Hide();
            edit_screen frm = new edit_screen();
            frm.ShowDialog();
            this.Close();
        }

        private void BTNmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu frm = new menu();
            frm.ShowDialog();
            this.Close();
        }

        private void BTNquit_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm = new login();
            frm.ShowDialog();
            this.Close();
        }
    }
}
