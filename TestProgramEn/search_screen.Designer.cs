
namespace TestProgramEn
{
    partial class search_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search_screen));
            this.BTNedit = new System.Windows.Forms.Button();
            this.BTNclear_filters = new System.Windows.Forms.Button();
            this.FLTstorage = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.FLTunit = new System.Windows.Forms.CheckedListBox();
            this.FLTtestno = new System.Windows.Forms.TextBox();
            this.BTNfilter = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTNquit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNmain_menu = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FLTtest_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.FLTday = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FLThour = new System.Windows.Forms.CheckedListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNedit
            // 
            this.BTNedit.Location = new System.Drawing.Point(12, 27);
            this.BTNedit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNedit.Name = "BTNedit";
            this.BTNedit.Size = new System.Drawing.Size(265, 34);
            this.BTNedit.TabIndex = 37;
            this.BTNedit.TabStop = false;
            this.BTNedit.Text = "Edit";
            this.BTNedit.UseVisualStyleBackColor = true;
            this.BTNedit.Click += new System.EventHandler(this.BTNedit_Click);
            // 
            // BTNclear_filters
            // 
            this.BTNclear_filters.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNclear_filters.Location = new System.Drawing.Point(92, 521);
            this.BTNclear_filters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNclear_filters.Name = "BTNclear_filters";
            this.BTNclear_filters.Size = new System.Drawing.Size(125, 34);
            this.BTNclear_filters.TabIndex = 4;
            this.BTNclear_filters.Text = "Clear Filters";
            this.BTNclear_filters.UseVisualStyleBackColor = true;
            // 
            // FLTstorage
            // 
            this.FLTstorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FLTstorage.FormattingEnabled = true;
            this.FLTstorage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FLTstorage.Items.AddRange(new object[] {
            "Cold Room",
            "Desk",
            "Fridge",
            "Frozen"});
            this.FLTstorage.Location = new System.Drawing.Point(93, 89);
            this.FLTstorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FLTstorage.Name = "FLTstorage";
            this.FLTstorage.Size = new System.Drawing.Size(185, 24);
            this.FLTstorage.Sorted = true;
            this.FLTstorage.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Storage:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Unit:";
            // 
            // FLTunit
            // 
            this.FLTunit.CheckOnClick = true;
            this.FLTunit.FormattingEnabled = true;
            this.FLTunit.Items.AddRange(new object[] {
            "ADVANCED ANALYSIS",
            "BIOCHEMISTRY",
            "HEMATOLOGY",
            "IMMUNOLOGY",
            "MICROBIOLOGY",
            "MOLECULAR"});
            this.FLTunit.Location = new System.Drawing.Point(93, 119);
            this.FLTunit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FLTunit.Name = "FLTunit";
            this.FLTunit.Size = new System.Drawing.Size(185, 123);
            this.FLTunit.TabIndex = 35;
            this.FLTunit.TabStop = false;
            // 
            // FLTtestno
            // 
            this.FLTtestno.Location = new System.Drawing.Point(93, 33);
            this.FLTtestno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FLTtestno.Name = "FLTtestno";
            this.FLTtestno.Size = new System.Drawing.Size(185, 22);
            this.FLTtestno.TabIndex = 0;
            this.FLTtestno.Text = "0";
            // 
            // BTNfilter
            // 
            this.BTNfilter.Location = new System.Drawing.Point(92, 483);
            this.BTNfilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNfilter.Name = "BTNfilter";
            this.BTNfilter.Size = new System.Drawing.Size(125, 34);
            this.BTNfilter.TabIndex = 3;
            this.BTNfilter.Text = "Filter";
            this.BTNfilter.UseVisualStyleBackColor = true;
            this.BTNfilter.Click += new System.EventHandler(this.BTNfilter_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Test #: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Day:";
            // 
            // BTNquit
            // 
            this.BTNquit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNquit.Location = new System.Drawing.Point(12, 110);
            this.BTNquit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNquit.Name = "BTNquit";
            this.BTNquit.Size = new System.Drawing.Size(265, 34);
            this.BTNquit.TabIndex = 39;
            this.BTNquit.TabStop = false;
            this.BTNquit.Text = "Quit";
            this.BTNquit.UseVisualStyleBackColor = true;
            this.BTNquit.Click += new System.EventHandler(this.BTNquit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNquit);
            this.groupBox1.Controls.Add(this.BTNmain_menu);
            this.groupBox1.Controls.Add(this.BTNedit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(329, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // BTNmain_menu
            // 
            this.BTNmain_menu.Location = new System.Drawing.Point(12, 68);
            this.BTNmain_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNmain_menu.Name = "BTNmain_menu";
            this.BTNmain_menu.Size = new System.Drawing.Size(266, 34);
            this.BTNmain_menu.TabIndex = 38;
            this.BTNmain_menu.TabStop = false;
            this.BTNmain_menu.Text = "Main Menu";
            this.BTNmain_menu.UseVisualStyleBackColor = true;
            this.BTNmain_menu.Click += new System.EventHandler(this.BTNmenu_Click);
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
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(329, 852);
            this.splitContainer2.SplitterDistance = 165;
            this.splitContainer2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTNclear_filters);
            this.groupBox3.Controls.Add(this.FLTstorage);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.FLTunit);
            this.groupBox3.Controls.Add(this.FLTtestno);
            this.groupBox3.Controls.Add(this.BTNfilter);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.FLTtest_name);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.FLTday);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.FLThour);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(329, 683);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Find";
            // 
            // FLTtest_name
            // 
            this.FLTtest_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FLTtest_name.Location = new System.Drawing.Point(93, 62);
            this.FLTtest_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FLTtest_name.Name = "FLTtest_name";
            this.FLTtest_name.Size = new System.Drawing.Size(185, 22);
            this.FLTtest_name.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Test Name:";
            // 
            // FLTday
            // 
            this.FLTday.CheckOnClick = true;
            this.FLTday.FormattingEnabled = true;
            this.FLTday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.FLTday.Location = new System.Drawing.Point(92, 246);
            this.FLTday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FLTday.Name = "FLTday";
            this.FLTday.Size = new System.Drawing.Size(185, 123);
            this.FLTday.TabIndex = 30;
            this.FLTday.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Hour:";
            // 
            // FLThour
            // 
            this.FLThour.CheckOnClick = true;
            this.FLThour.FormattingEnabled = true;
            this.FLThour.Items.AddRange(new object[] {
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
            this.FLThour.Location = new System.Drawing.Point(93, 373);
            this.FLThour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FLThour.Name = "FLThour";
            this.FLThour.Size = new System.Drawing.Size(185, 106);
            this.FLThour.TabIndex = 30;
            this.FLThour.TabStop = false;
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(834, 852);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.TabIndex = 39;
            this.splitContainer1.TabStop = false;
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
            this.dataGridView1.Size = new System.Drawing.Size(501, 852);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FLTtestno_KeyPress);
            // 
            // search_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNquit;
            this.ClientSize = new System.Drawing.Size(834, 852);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "search_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Screen";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNedit;
        private System.Windows.Forms.Button BTNclear_filters;
        private System.Windows.Forms.ComboBox FLTstorage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox FLTunit;
        private System.Windows.Forms.TextBox FLTtestno;
        private System.Windows.Forms.Button BTNfilter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTNquit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNmain_menu;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox FLTtest_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox FLTday;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox FLThour;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}