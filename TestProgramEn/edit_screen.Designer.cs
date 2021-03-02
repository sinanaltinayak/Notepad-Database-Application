
namespace TestProgramEn
{
    partial class edit_screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_screen));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNtable = new System.Windows.Forms.Button();
            this.TBXtestno = new System.Windows.Forms.TextBox();
            this.BTNtest_save = new System.Windows.Forms.Button();
            this.BTNrow_delete = new System.Windows.Forms.Button();
            this.CMBunit = new System.Windows.Forms.ComboBox();
            this.CHKBXday = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TBXtest_name = new System.Windows.Forms.TextBox();
            this.CHKBXhour = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CMBstorage = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBXnote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BTNquit = new System.Windows.Forms.Button();
            this.BTNmain_menu = new System.Windows.Forms.Button();
            this.BTNfilter_screen = new System.Windows.Forms.Button();
            this.BTNtestno_edit = new System.Windows.Forms.Button();
            this.BTNtest_new = new System.Windows.Forms.Button();
            this.BTNtest_delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(869, 181);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNtable);
            this.groupBox2.Controls.Add(this.TBXtestno);
            this.groupBox2.Controls.Add(this.BTNtest_save);
            this.groupBox2.Controls.Add(this.BTNrow_delete);
            this.groupBox2.Controls.Add(this.CMBunit);
            this.groupBox2.Controls.Add(this.CHKBXday);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TBXtest_name);
            this.groupBox2.Controls.Add(this.CHKBXhour);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CMBstorage);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TBXnote);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(688, 375);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create/Edit Test";
            // 
            // BTNtable
            // 
            this.BTNtable.Location = new System.Drawing.Point(88, 334);
            this.BTNtable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNtable.Name = "BTNtable";
            this.BTNtable.Size = new System.Drawing.Size(125, 34);
            this.BTNtable.TabIndex = 38;
            this.BTNtable.TabStop = false;
            this.BTNtable.Text = "Show Table";
            this.BTNtable.UseVisualStyleBackColor = true;
            this.BTNtable.Click += new System.EventHandler(this.BTNtablo_Click);
            // 
            // TBXtestno
            // 
            this.TBXtestno.Location = new System.Drawing.Point(88, 33);
            this.TBXtestno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBXtestno.Name = "TBXtestno";
            this.TBXtestno.Size = new System.Drawing.Size(221, 22);
            this.TBXtestno.TabIndex = 0;
            this.TBXtestno.Text = "0";
            this.TBXtestno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBXtestno_KeyDown);
            this.TBXtestno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBXtestno_KeyPress);
            this.TBXtestno.Leave += new System.EventHandler(this.TBXtestno_TextChanged);
            // 
            // BTNtest_save
            // 
            this.BTNtest_save.Enabled = false;
            this.BTNtest_save.Location = new System.Drawing.Point(88, 175);
            this.BTNtest_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNtest_save.Name = "BTNtest_save";
            this.BTNtest_save.Size = new System.Drawing.Size(125, 34);
            this.BTNtest_save.TabIndex = 5;
            this.BTNtest_save.Text = "Save";
            this.BTNtest_save.UseVisualStyleBackColor = true;
            this.BTNtest_save.Click += new System.EventHandler(this.BTNtest_save_Click);
            // 
            // BTNrow_delete
            // 
            this.BTNrow_delete.Location = new System.Drawing.Point(220, 334);
            this.BTNrow_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNrow_delete.Name = "BTNrow_delete";
            this.BTNrow_delete.Size = new System.Drawing.Size(125, 34);
            this.BTNrow_delete.TabIndex = 34;
            this.BTNrow_delete.TabStop = false;
            this.BTNrow_delete.Text = "Delete Row";
            this.BTNrow_delete.UseVisualStyleBackColor = true;
            this.BTNrow_delete.Click += new System.EventHandler(this.BTNrow_delete_Click);
            // 
            // CMBunit
            // 
            this.CMBunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBunit.FormattingEnabled = true;
            this.CMBunit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CMBunit.Items.AddRange(new object[] {
            "ADVANCED ANALYSIS",
            "BIOCHEMISTRY",
            "HEMATOLOGY",
            "IMMUNOLOGY",
            "MICROBIOLOGY",
            "MOLECULAR"});
            this.CMBunit.Location = new System.Drawing.Point(88, 89);
            this.CMBunit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBunit.Name = "CMBunit";
            this.CMBunit.Size = new System.Drawing.Size(221, 24);
            this.CMBunit.Sorted = true;
            this.CMBunit.TabIndex = 2;
            // 
            // CHKBXday
            // 
            this.CHKBXday.CheckOnClick = true;
            this.CHKBXday.FormattingEnabled = true;
            this.CHKBXday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.CHKBXday.Location = new System.Drawing.Point(315, 33);
            this.CHKBXday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CHKBXday.Name = "CHKBXday";
            this.CHKBXday.Size = new System.Drawing.Size(120, 123);
            this.CHKBXday.TabIndex = 24;
            this.CHKBXday.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Note:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Test #: ";
            // 
            // TBXtest_name
            // 
            this.TBXtest_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBXtest_name.Location = new System.Drawing.Point(88, 62);
            this.TBXtest_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBXtest_name.Name = "TBXtest_name";
            this.TBXtest_name.Size = new System.Drawing.Size(221, 22);
            this.TBXtest_name.TabIndex = 1;
            // 
            // CHKBXhour
            // 
            this.CHKBXhour.CheckOnClick = true;
            this.CHKBXhour.FormattingEnabled = true;
            this.CHKBXhour.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "09:30",
            "10:00",
            "11:00",
            "12:00",
            "14:00",
            "14:30",
            "15:00",
            "16:00",
            "17:00"});
            this.CHKBXhour.Location = new System.Drawing.Point(441, 33);
            this.CHKBXhour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CHKBXhour.Name = "CHKBXhour";
            this.CHKBXhour.Size = new System.Drawing.Size(120, 208);
            this.CHKBXhour.TabIndex = 25;
            this.CHKBXhour.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Test Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Unit: ";
            // 
            // CMBstorage
            // 
            this.CMBstorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBstorage.FormattingEnabled = true;
            this.CMBstorage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CMBstorage.Items.AddRange(new object[] {
            "Cold Room",
            "Desk",
            "Fridge",
            "Frozen"});
            this.CMBstorage.Location = new System.Drawing.Point(88, 117);
            this.CMBstorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBstorage.Name = "CMBstorage";
            this.CMBstorage.Size = new System.Drawing.Size(221, 24);
            this.CMBstorage.Sorted = true;
            this.CMBstorage.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Day: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Hour: ";
            // 
            // TBXnote
            // 
            this.TBXnote.Location = new System.Drawing.Point(88, 146);
            this.TBXnote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBXnote.Name = "TBXnote";
            this.TBXnote.Size = new System.Drawing.Size(221, 22);
            this.TBXnote.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Storage: ";
            // 
            // BTNquit
            // 
            this.BTNquit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNquit.Location = new System.Drawing.Point(12, 334);
            this.BTNquit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNquit.Name = "BTNquit";
            this.BTNquit.Size = new System.Drawing.Size(125, 34);
            this.BTNquit.TabIndex = 37;
            this.BTNquit.TabStop = false;
            this.BTNquit.Text = "Quit Program";
            this.BTNquit.UseVisualStyleBackColor = true;
            this.BTNquit.Click += new System.EventHandler(this.BTNquit_Click);
            // 
            // BTNmain_menu
            // 
            this.BTNmain_menu.Location = new System.Drawing.Point(12, 293);
            this.BTNmain_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNmain_menu.Name = "BTNmain_menu";
            this.BTNmain_menu.Size = new System.Drawing.Size(125, 34);
            this.BTNmain_menu.TabIndex = 36;
            this.BTNmain_menu.TabStop = false;
            this.BTNmain_menu.Text = "Main Menu";
            this.BTNmain_menu.UseVisualStyleBackColor = true;
            this.BTNmain_menu.Click += new System.EventHandler(this.BTNmenu_Click);
            // 
            // BTNfilter_screen
            // 
            this.BTNfilter_screen.Location = new System.Drawing.Point(12, 252);
            this.BTNfilter_screen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNfilter_screen.Name = "BTNfilter_screen";
            this.BTNfilter_screen.Size = new System.Drawing.Size(125, 34);
            this.BTNfilter_screen.TabIndex = 35;
            this.BTNfilter_screen.TabStop = false;
            this.BTNfilter_screen.Text = "Search";
            this.BTNfilter_screen.UseVisualStyleBackColor = true;
            this.BTNfilter_screen.Click += new System.EventHandler(this.BTNsearch_Click);
            // 
            // BTNtestno_edit
            // 
            this.BTNtestno_edit.Enabled = false;
            this.BTNtestno_edit.Location = new System.Drawing.Point(12, 33);
            this.BTNtestno_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNtestno_edit.Name = "BTNtestno_edit";
            this.BTNtestno_edit.Size = new System.Drawing.Size(125, 34);
            this.BTNtestno_edit.TabIndex = 33;
            this.BTNtestno_edit.TabStop = false;
            this.BTNtestno_edit.Text = "Edit Test #";
            this.BTNtestno_edit.UseVisualStyleBackColor = true;
            this.BTNtestno_edit.Click += new System.EventHandler(this.BTNtestno_edit_Click);
            // 
            // BTNtest_new
            // 
            this.BTNtest_new.Location = new System.Drawing.Point(12, 74);
            this.BTNtest_new.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNtest_new.Name = "BTNtest_new";
            this.BTNtest_new.Size = new System.Drawing.Size(125, 34);
            this.BTNtest_new.TabIndex = 32;
            this.BTNtest_new.TabStop = false;
            this.BTNtest_new.Text = "New Test";
            this.BTNtest_new.UseVisualStyleBackColor = true;
            this.BTNtest_new.Click += new System.EventHandler(this.BTNclear_Click);
            // 
            // BTNtest_delete
            // 
            this.BTNtest_delete.Enabled = false;
            this.BTNtest_delete.Location = new System.Drawing.Point(12, 114);
            this.BTNtest_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNtest_delete.Name = "BTNtest_delete";
            this.BTNtest_delete.Size = new System.Drawing.Size(125, 34);
            this.BTNtest_delete.TabIndex = 31;
            this.BTNtest_delete.TabStop = false;
            this.BTNtest_delete.Text = "Delete Test";
            this.BTNtest_delete.UseVisualStyleBackColor = true;
            this.BTNtest_delete.Click += new System.EventHandler(this.BTNtest_delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNquit);
            this.groupBox1.Controls.Add(this.BTNmain_menu);
            this.groupBox1.Controls.Add(this.BTNfilter_screen);
            this.groupBox1.Controls.Add(this.BTNtestno_edit);
            this.groupBox1.Controls.Add(this.BTNtest_new);
            this.groupBox1.Controls.Add(this.BTNtest_delete);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(177, 375);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(869, 375);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(869, 560);
            this.splitContainer2.SplitterDistance = 375;
            this.splitContainer2.TabIndex = 2;
            // 
            // edit_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNquit;
            this.ClientSize = new System.Drawing.Size(869, 560);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "edit_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Screen";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTNtable;
        private System.Windows.Forms.TextBox TBXtestno;
        private System.Windows.Forms.Button BTNtest_save;
        private System.Windows.Forms.Button BTNrow_delete;
        private System.Windows.Forms.ComboBox CMBunit;
        private System.Windows.Forms.CheckedListBox CHKBXday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBXtest_name;
        private System.Windows.Forms.CheckedListBox CHKBXhour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CMBstorage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBXnote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTNquit;
        private System.Windows.Forms.Button BTNmain_menu;
        private System.Windows.Forms.Button BTNfilter_screen;
        private System.Windows.Forms.Button BTNtestno_edit;
        private System.Windows.Forms.Button BTNtest_new;
        private System.Windows.Forms.Button BTNtest_delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}