
namespace TestProgramEn
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.BTNlogin = new System.Windows.Forms.Button();
            this.TXTpass = new System.Windows.Forms.TextBox();
            this.TXTusername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNlogin
            // 
            this.BTNlogin.Location = new System.Drawing.Point(115, 122);
            this.BTNlogin.Name = "BTNlogin";
            this.BTNlogin.Size = new System.Drawing.Size(113, 30);
            this.BTNlogin.TabIndex = 11;
            this.BTNlogin.Text = "Log In";
            this.BTNlogin.UseVisualStyleBackColor = true;
            this.BTNlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXTpass
            // 
            this.TXTpass.Location = new System.Drawing.Point(115, 96);
            this.TXTpass.Name = "TXTpass";
            this.TXTpass.PasswordChar = '*';
            this.TXTpass.Size = new System.Drawing.Size(113, 22);
            this.TXTpass.TabIndex = 10;
            // 
            // TXTusername
            // 
            this.TXTusername.Location = new System.Drawing.Point(115, 70);
            this.TXTusername.Name = "TXTusername";
            this.TXTusername.Size = new System.Drawing.Size(113, 22);
            this.TXTusername.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "User Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Welcome back!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "(admin, 123)";
            // 
            // login
            // 
            this.AcceptButton = this.BTNlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNlogin);
            this.Controls.Add(this.TXTpass);
            this.Controls.Add(this.TXTusername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNlogin;
        private System.Windows.Forms.TextBox TXTpass;
        private System.Windows.Forms.TextBox TXTusername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}

