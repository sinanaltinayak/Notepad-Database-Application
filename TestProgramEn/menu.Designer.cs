
namespace TestProgramEn
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.BTNquit = new System.Windows.Forms.Button();
            this.BTNsearch = new System.Windows.Forms.Button();
            this.BTNedit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNquit
            // 
            this.BTNquit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNquit.Location = new System.Drawing.Point(99, 124);
            this.BTNquit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNquit.Name = "BTNquit";
            this.BTNquit.Size = new System.Drawing.Size(125, 34);
            this.BTNquit.TabIndex = 41;
            this.BTNquit.TabStop = false;
            this.BTNquit.Text = "Quit";
            this.BTNquit.UseVisualStyleBackColor = true;
            this.BTNquit.Click += new System.EventHandler(this.BTNquit_Click);
            // 
            // BTNsearch
            // 
            this.BTNsearch.Location = new System.Drawing.Point(99, 83);
            this.BTNsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNsearch.Name = "BTNsearch";
            this.BTNsearch.Size = new System.Drawing.Size(125, 34);
            this.BTNsearch.TabIndex = 40;
            this.BTNsearch.TabStop = false;
            this.BTNsearch.Text = "Search";
            this.BTNsearch.UseVisualStyleBackColor = true;
            this.BTNsearch.Click += new System.EventHandler(this.BTNsearch_Click);
            // 
            // BTNedit
            // 
            this.BTNedit.Location = new System.Drawing.Point(99, 43);
            this.BTNedit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNedit.Name = "BTNedit";
            this.BTNedit.Size = new System.Drawing.Size(125, 34);
            this.BTNedit.TabIndex = 39;
            this.BTNedit.TabStop = false;
            this.BTNedit.Text = "Edit";
            this.BTNedit.UseVisualStyleBackColor = true;
            this.BTNedit.Click += new System.EventHandler(this.BTNedit_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNquit;
            this.ClientSize = new System.Drawing.Size(323, 197);
            this.Controls.Add(this.BTNquit);
            this.Controls.Add(this.BTNsearch);
            this.Controls.Add(this.BTNedit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.menü_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNquit;
        private System.Windows.Forms.Button BTNsearch;
        private System.Windows.Forms.Button BTNedit;
    }
}