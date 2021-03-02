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
using TestProgramEn;

namespace TestProgramEn
{
    public partial class edit_screen : Form
    {
        public edit_screen()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        int table_switch = 0;

        private void Form5_Load(object sender, EventArgs e)
        {
            table_clear_row();
            splitContainer2.Panel2Collapsed = true;
            this.Size = new Size(875, 350);
            splitContainer1.SplitterDistance = 113;
            splitContainer2.SplitterDistance = 310;

            table.Columns.Add("TEST #", typeof(int));
            table.Columns.Add("TEST NAME", typeof(string));
            table.Columns.Add("UNIT", typeof(string));
            table.Columns.Add("HOUR", typeof(string));
            table.Columns.Add("DAY", typeof(string));
            table.Columns.Add("LOCATION", typeof(string));
            table.Columns.Add("NOTE", typeof(string));

            dataGridView1.DataSource = table;
            this.dataGridView1.Sort(this.dataGridView1.Columns["TEST #"], ListSortDirection.Ascending);

            table_fill();
            table_switch = 1;
        }

        private void table_fill()
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
        private void find_data(int testNo)
        {
            BTNtest_save.Enabled = true;
            BTNtest_delete.Enabled = true;
            BTNtest_new.Enabled = true;
            BTNtestno_edit.Enabled = true;
            TBXtestno.Enabled = false;
            string test_name = " ";
            string unit = " ";
            string storage = " ";
            string note = " ";
            List<string> hours = new List<string>();
            List<string> days = new List<string>();

            var path = ".";
            string fullPath = Path.GetFullPath(path);

            string[] lines = File.ReadAllLines(fullPath + "\\database.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');

                if (int.Parse(values[0]) == testNo)
                {
                    test_name = values[1].ToString().Trim();
                    unit = values[2].ToString().Trim();
                    hours.Add(values[3].ToString().Trim());
                    days.Add(values[4].ToString().Trim());
                    storage = values[5].ToString().Trim();
                    note = values[6].ToString().Trim();
                }
            }

            TBXtestno.Text = testNo.ToString();
            TBXtest_name.Text = test_name;

            for (int i = 0; i < CMBunit.Items.Count; i++)
            {
                CMBunit.SelectedItem = null;

                if (CMBunit.Items[i].ToString() == unit.ToString())
                {
                    CMBunit.SelectedIndex = i;
                    break;
                }

            }

            for (int i = 0; i < CHKBXhour.Items.Count; i++)
            {
                if (hours.Contains(CHKBXhour.Items[i].ToString()))
                {
                    CHKBXhour.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    CHKBXhour.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (int i = 0; i < CHKBXday.Items.Count; i++)
            {
                if (hours.Contains(CHKBXday.Items[i].ToString()))
                {
                    CHKBXday.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    CHKBXday.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            for (int i = 0; i < CMBstorage.Items.Count; i++)
            {
                CMBstorage.SelectedItem = null;

                if (CMBstorage.Items[i].ToString() == storage.ToString())
                {
                    CMBstorage.SelectedIndex = i;
                    break;
                }
            }

            TBXnote.Text = note;
        }
        private void clear_boxes()
        {
            TBXtestno.Text = "";
            TBXtest_name.Clear();
            CMBunit.SelectedIndex = -1;
            CMBstorage.SelectedIndex = -1;
            for (int i = 0; i < CHKBXhour.Items.Count; i++)
            {
                CHKBXhour.SetItemCheckState(i, CheckState.Unchecked);
                CHKBXhour.SetSelected(i, false);
            }
            for (int i = 0; i < CHKBXday.Items.Count; i++)
            {
                CHKBXday.SetItemCheckState(i, CheckState.Unchecked);
                CHKBXday.SetSelected(i, false);
            }
            TBXnote.Clear();

            BTNtest_save.Enabled = false;
            BTNtest_delete.Enabled = false;
        }
        private bool data_exists(int testNo)
        {
            var path = ".";
            string fullPath = Path.GetFullPath(path);

            string[] lines = File.ReadAllLines(fullPath + "\\database.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');

                if (int.Parse(values[0]) == testNo)
                    return true;
            }
            return false;
        }
        private void write_to_file(List<data> s)
        {
            var path = ".";
            string fullPath = Path.GetFullPath(path);

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(fullPath + "\\database.txt").ToList();

            for (int i = 0; i < s.Count; i++)
            {
                lines.Add(s[i].to_string());
            }
            File.WriteAllLines(fullPath + "\\database.txt", lines);

        }
        private void delete_row(string testNo, string name, string hour, string day)
        {
            if (data_exists(Int32.Parse(testNo)))
            {
                var path = ".";
                string fullPath = Path.GetFullPath(path);

                List<string> oldLines = new List<string>();
                oldLines = File.ReadAllLines(fullPath + "\\database.txt").ToList();

                File.WriteAllText(fullPath + "\\database.txt", String.Empty);

                List<string> lines = new List<string>();
                List<string> hours = new List<string>();
                List<string> days = new List<string>();


                for (int i = 0; i < oldLines.Count; i++)
                {
                    if (oldLines[i].Contains(testNo + " / " + name) && oldLines[i].Contains(hour + " / " + day))
                    {
                        continue;
                    }
                    lines.Add(oldLines[i]);
                }

                File.WriteAllLines(fullPath + "\\database.txt", lines);

                table_fill();
            }
            else
            {
                MessageBox.Show("Test #" + testNo.ToString() + " could not be found.");
            }
        }

        private void delete_data(int testNo)
        {
            if (data_exists(testNo))
            {
                var path = ".";
                string fullPath = Path.GetFullPath(path);

                List<string> oldLines = new List<string>();
                oldLines = File.ReadAllLines(fullPath + "\\database.txt").ToList();

                File.WriteAllText(fullPath + "\\database.txt", String.Empty);

                List<string> lines = new List<string>();
                List<string> hours = new List<string>();
                List<string> days = new List<string>();


                for (int i = 0; i < oldLines.Count; i++)
                {
                    if (oldLines[i].Contains(testNo + " / " + TBXtest_name.Text))
                        continue;

                    lines.Add(oldLines[i]);
                }

                File.WriteAllLines(fullPath + "\\database.txt", lines);

                table_fill();
            }
            else
            {
                MessageBox.Show("Test #" + testNo.ToString() + " could not be found.");
            }
        }
        private void test_no_edit(int oldNo, int newNo)
        {
            var path = ".";
            string fullPath = Path.GetFullPath(path);

            List<string> oldLines = new List<string>();
            oldLines = File.ReadAllLines(fullPath + "\\database.txt").ToList();

            File.WriteAllText(fullPath + "\\database.txt", String.Empty);

            List<string> lines = new List<string>();
            List<string> hours = new List<string>();
            List<string> days = new List<string>();
            int testNo = Int32.Parse(TBXtestno.Text);
            string[] values;
            List<data> templist = new List<data>();

            for (int i = 0; i < oldLines.Count; i++)
            {
                values = oldLines[i].ToString().Split('/');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                if (row[0] == oldNo.ToString())
                {
                    row[0] = newNo.ToString();
                }
                data temp = new data();
                temp.testNo = Int32.Parse(row[0]);
                temp.name = row[1];
                temp.unit = row[2];
                temp.hour = row[3];
                temp.day = row[4];
                temp.storage = row[5];
                temp.note = row[6];

                templist.Add(temp);

            }

            write_to_file(templist);

            table_fill();
            clear_boxes();
            table_select_row(newNo);
            BTNtestno_edit.Enabled = false;
            BTNtest_delete.Enabled = false;
            TBXtestno.Enabled = true;
        }

        private void table_select_row(int testNo)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[0].Value.ToString().Trim() == testNo.ToString().Trim())
                {
                    dataGridView1.Rows[i].Selected = true;
                    break;
                }

            }
            change_table_position(testNo);
        }
        public void change_table_position(int testNo)
        {
            int scrollPosition = dataGridView1.FirstDisplayedScrollingRowIndex;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString().Trim() == testNo.ToString().Trim())
                {
                    scrollPosition = dataGridView1.Rows[i].Index;
                    break;
                }
            }
            dataGridView1.FirstDisplayedScrollingRowIndex = scrollPosition;
        }
        private void table_clear_row()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Selected = false;
            }
        }
        private void TBXtestno_TextChanged(object sender, EventArgs e)
        {
            table_switch = 0;

            if (TBXtestno.Text == "")
                TBXtestno.Text = "0";

            int check = Int32.Parse(TBXtestno.Text);

            if (data_exists(check))
            {
                find_data(check);
                table_select_row(check);
            }
            else
            {
                if (data_exists(check))
                {
                    MessageBox.Show("A test already exists in this test number");
                    TBXtestno.Enabled = false;
                    BTNtestno_edit.Enabled = true;
                    BTNtest_delete.Enabled = true;
                    table_switch = 1;
                    find_data(check);
                }
                else
                {
                    BTNtest_save.Enabled = true;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTNtest_save.Enabled = true;
            BTNtest_delete.Enabled = true;
            BTNtest_new.Enabled = true;
            BTNtestno_edit.Enabled = true;
            TBXtestno.Enabled = false;
            int row = dataGridView1.CurrentCell.RowIndex;
            for (int i = 0; i < CHKBXhour.Items.Count; i++)
            {
                CHKBXhour.SetSelected(i, false);
            }
            for (int i = 0; i < CHKBXday.Items.Count; i++)
            {
                CHKBXday.SetSelected(i, false);
            }
            if (dataGridView1.Rows[row].Cells[0].Value != null)
            {
                find_data((int)dataGridView1.Rows[row].Cells[0].Value);
            }
        }
        private void BTNclear_Click(object sender, EventArgs e)
        {
            BTNtestno_edit.Enabled = false;
            TBXtestno.Enabled = true;
            clear_boxes();
        }

        private void BTNmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu frm = new menu();
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

        private void BTNquit_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm = new login();
            frm.ShowDialog();
            this.Close();
        }

        private void BTNtablo_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel2Collapsed == true)
            {
                BTNtable.Text = "Show Table";
                splitContainer2.Panel2Collapsed = false;
                this.Size = new Size(875, 617);
                splitContainer2.SplitterDistance = 310;
            }
            else if (splitContainer2.Panel2Collapsed == false)
            {
                BTNtable.Text = "Hide Table";
                splitContainer2.Panel2Collapsed = true;
                this.Size = new Size(875, 350);
                splitContainer2.SplitterDistance = 310;
            }

        }

        private void BTNtest_delete_Click(object sender, EventArgs e)
        {
            int check = Int32.Parse(TBXtestno.Text);
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Test #" + check.ToString() + " will be deleted.", "Warning", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                delete_data(check);
                clear_boxes();
            }
            TBXtestno.Enabled = true;
        }

        private void BTNtestno_edit_Click(object sender, EventArgs e)
        {
            using (edit_test_no frm = new edit_test_no(Int32.Parse(TBXtestno.Text)))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int yeni_test_no = frm.GetValue;
                    int eski_test_no = Int32.Parse(TBXtestno.Text);
                    if (!data_exists(yeni_test_no))
                        test_no_edit(eski_test_no, yeni_test_no);
                    else
                    {
                        MessageBox.Show("A test already exists in this test number.");
                    }
                }

                else
                {
                    frm.Close();
                }
            }
        }

        private void BTNtest_save_Click(object sender, EventArgs e)
        {
            table_switch = 0;
            if (data_exists(Int32.Parse(TBXtestno.Text)))
            {
                if (TBXtest_name.Text == null || TBXtestno.Text == null || CMBunit.SelectedIndex == -1 || CMBstorage.SelectedIndex == -1 || CHKBXhour.CheckedItems.Count == 0 || CHKBXday.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please fill out all required fields.");
                }
                else
                {
                    var path = ".";
                    string fullPath = Path.GetFullPath(path);

                    List<string> oldLines = new List<string>();
                    oldLines = File.ReadAllLines(fullPath + "\\database.txt").ToList();
                    File.WriteAllText(fullPath + "\\database.txt", String.Empty);

                    List<string> lines = new List<string>();
                    List<string> hours = new List<string>();
                    List<string> days = new List<string>();
                    int testNo = Int32.Parse(TBXtestno.Text);
                    string name = TBXtest_name.Text;


                    for (int i = 0; i < oldLines.Count; i++)
                    {
                        if (oldLines[i].Contains(testNo + " / " + name))
                            continue;

                        lines.Add(oldLines[i]);
                    }

                    File.WriteAllLines(fullPath + "\\database.txt", lines);

                    List<data> templist = new List<data>();

                    for (int i = 0; i < CHKBXhour.CheckedItems.Count; i++)
                    {
                        for (int j = 0; j < CHKBXday.CheckedItems.Count; j++)
                        {
                            data temp = new data();
                            temp.testNo = testNo;
                            temp.name = TBXtest_name.Text;
                            temp.unit = CMBunit.Text;
                            temp.hour = CHKBXhour.CheckedItems[i].ToString();
                            temp.day = CHKBXday.CheckedItems[j].ToString();
                            temp.storage = CMBstorage.Text;
                            temp.note = TBXnote.Text;
                            templist.Add(temp);
                        }
                    }
                    write_to_file(templist);
                    table_fill();
                    table_select_row(testNo);
                }
            }

            else
            {
                if (TBXtest_name.Text == null || TBXtestno.Text == null || CMBunit.SelectedIndex == -1 || CMBstorage.SelectedIndex == -1 || CHKBXhour.CheckedItems.Count == 0 || CHKBXday.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please fill out all required fields.");
                }
                else
                {
                    int testNo;
                    List<data> dataList = new List<data>();

                    testNo = Int32.Parse(TBXtestno.Text);

                    for (int i = 0; i < CHKBXhour.CheckedItems.Count; i++)
                    {
                        for (int j = 0; j < CHKBXday.CheckedItems.Count; j++)
                        {
                            data temp = new data();
                            temp.testNo = Int32.Parse(TBXtestno.Text);
                            temp.name = TBXtest_name.Text;
                            temp.unit = CMBunit.Text;
                            temp.hour = CHKBXhour.CheckedItems[i].ToString();
                            temp.day = CHKBXday.CheckedItems[j].ToString();
                            temp.storage = CMBstorage.Text;
                            temp.note = TBXnote.Text;
                            dataList.Add(temp);
                        }
                    }
                    write_to_file(dataList);
                    table_fill();
                    table_select_row(testNo);
                }
            }
            table_switch = 1;
            dataGridView1.Select();
            BTNtest_new.Enabled = true;
            BTNtestno_edit.Enabled = true;
            TBXtestno.Enabled = false;
        }

        private void BTNrow_delete_Click(object sender, EventArgs e)
        {
            string testNo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim();
            string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
            string hour = dataGridView1.SelectedRows[0].Cells[3].Value.ToString().Trim();
            string day = dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim();

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Test # = " + testNo.ToString() + "\nTest Name = " + name + "\nHour = " + hour + "\nDay = " + day + "\nThis test will be deleted.", "Warning", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                delete_row(testNo, name, hour, day);
                clear_boxes();
            }
            TBXtestno.Enabled = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (table_switch == 1)
            {
                BTNtest_save.Enabled = true;
                BTNtest_delete.Enabled = true;
                BTNtest_new.Enabled = true;
                BTNtestno_edit.Enabled = true;
                TBXtestno.Enabled = false;
                if (dataGridView1.CurrentCell != null)
                {
                    int row = dataGridView1.CurrentCell.RowIndex;
                    for (int i = 0; i < CHKBXhour.Items.Count; i++)
                    {
                        CHKBXhour.SetSelected(i, false);
                    }
                    for (int i = 0; i < CHKBXday.Items.Count; i++)
                    {
                        CHKBXday.SetSelected(i, false);
                    }
                    if (dataGridView1.Rows[row].Cells[0].Value != null)
                    {
                        find_data((int)dataGridView1.Rows[row].Cells[0].Value);
                    }
                }
            }
        }

        private void TBXtestno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void TBXtestno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
