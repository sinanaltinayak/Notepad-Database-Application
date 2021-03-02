
namespace TestProgramEn
{
    partial class edit_test_no
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_test_no));
            this.BTNcancel = new System.Windows.Forms.Button();
            this.TBXnewno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBXoldno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BTNsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNcancel
            // 
            this.BTNcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNcancel.Location = new System.Drawing.Point(117, 135);
            this.BTNcancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNcancel.Name = "BTNcancel";
            this.BTNcancel.Size = new System.Drawing.Size(100, 32);
            this.BTNcancel.TabIndex = 19;
            this.BTNcancel.Text = "Cancel";
            this.BTNcancel.UseVisualStyleBackColor = true;
            // 
            // TBXnewno
            // 
            this.TBXnewno.Location = new System.Drawing.Point(117, 69);
            this.TBXnewno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBXnewno.Name = "TBXnewno";
            this.TBXnewno.Size = new System.Drawing.Size(100, 22);
            this.TBXnewno.TabIndex = 17;
            this.TBXnewno.TextChanged += new System.EventHandler(this.TBXnewno_TextChanged);
            this.TBXnewno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBXnewno_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "New Test #:";
            // 
            // TBXoldno
            // 
            this.TBXoldno.Enabled = false;
            this.TBXoldno.Location = new System.Drawing.Point(117, 41);
            this.TBXoldno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBXoldno.Name = "TBXoldno";
            this.TBXoldno.Size = new System.Drawing.Size(100, 22);
            this.TBXoldno.TabIndex = 20;
            this.TBXoldno.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Old Test #:";
            // 
            // BTNsave
            // 
            this.BTNsave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTNsave.Location = new System.Drawing.Point(117, 97);
            this.BTNsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNsave.Name = "BTNsave";
            this.BTNsave.Size = new System.Drawing.Size(100, 32);
            this.BTNsave.TabIndex = 18;
            this.BTNsave.Text = "Save";
            this.BTNsave.UseVisualStyleBackColor = true;
            // 
            // edit_test_no
            // 
            this.AcceptButton = this.BTNsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNcancel;
            this.ClientSize = new System.Drawing.Size(281, 187);
            this.Controls.Add(this.BTNcancel);
            this.Controls.Add(this.TBXnewno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBXoldno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BTNsave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "edit_test_no";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Test #";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcancel;
        private System.Windows.Forms.TextBox TBXnewno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBXoldno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BTNsave;
    }
}