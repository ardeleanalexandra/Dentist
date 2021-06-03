
namespace Proiect
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_NrTel = new System.Windows.Forms.TextBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_ConfirmPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(134, 245);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(465, 20);
            this.textBox_Username.TabIndex = 0;
            this.textBox_Username.TextChanged += new System.EventHandler(this.textBox_UserName_TextChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(133, 337);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(465, 20);
            this.textBox_Password.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Proiect.Properties.Resources.Register;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(932, 577);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 39);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_NrTel
            // 
            this.textBox_NrTel.Location = new System.Drawing.Point(134, 538);
            this.textBox_NrTel.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NrTel.Name = "textBox_NrTel";
            this.textBox_NrTel.Size = new System.Drawing.Size(465, 20);
            this.textBox_NrTel.TabIndex = 8;
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(133, 630);
            this.textBox_Mail.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(465, 20);
            this.textBox_Mail.TabIndex = 10;
            // 
            // textBox_ConfirmPass
            // 
            this.textBox_ConfirmPass.Location = new System.Drawing.Point(133, 439);
            this.textBox_ConfirmPass.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ConfirmPass.Name = "textBox_ConfirmPass";
            this.textBox_ConfirmPass.PasswordChar = '*';
            this.textBox_ConfirmPass.Size = new System.Drawing.Size(465, 20);
            this.textBox_ConfirmPass.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Proiect.Properties.Resources.LogInOpt;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(856, 620);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 55);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect.Properties.Resources.RegistrarePacienti3;
            this.ClientSize = new System.Drawing.Size(1367, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_ConfirmPass);
            this.Controls.Add(this.textBox_Mail);
            this.Controls.Add(this.textBox_NrTel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1383, 800);
            this.MinimumSize = new System.Drawing.Size(1383, 800);
            this.Name = "Register";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_NrTel;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_ConfirmPass;
        private System.Windows.Forms.Button button1;
    }
}

