
namespace Proiect
{
    partial class ProfilPacient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilPacient));
            this.textBox_Nume = new System.Windows.Forms.TextBox();
            this.textBox_Boli = new System.Windows.Forms.TextBox();
            this.textBox_Alergii = new System.Windows.Forms.TextBox();
            this.comboBox_Gen = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_GrupaS = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_Nume
            // 
            this.textBox_Nume.Location = new System.Drawing.Point(130, 247);
            this.textBox_Nume.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Nume.Name = "textBox_Nume";
            this.textBox_Nume.Size = new System.Drawing.Size(436, 20);
            this.textBox_Nume.TabIndex = 0;
            this.textBox_Nume.TextChanged += new System.EventHandler(this.textBox_Nume_TextChanged);
            // 
            // textBox_Boli
            // 
            this.textBox_Boli.Location = new System.Drawing.Point(130, 538);
            this.textBox_Boli.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Boli.Name = "textBox_Boli";
            this.textBox_Boli.Size = new System.Drawing.Size(436, 20);
            this.textBox_Boli.TabIndex = 2;
            this.textBox_Boli.TextChanged += new System.EventHandler(this.textBox_Boli_TextChanged);
            // 
            // textBox_Alergii
            // 
            this.textBox_Alergii.Location = new System.Drawing.Point(130, 440);
            this.textBox_Alergii.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Alergii.Name = "textBox_Alergii";
            this.textBox_Alergii.Size = new System.Drawing.Size(436, 20);
            this.textBox_Alergii.TabIndex = 3;
            this.textBox_Alergii.TextChanged += new System.EventHandler(this.textBox_Alergii_TextChanged);
            // 
            // comboBox_Gen
            // 
            this.comboBox_Gen.FormattingEnabled = true;
            this.comboBox_Gen.Items.AddRange(new object[] {
            "F",
            "M"});
            this.comboBox_Gen.Location = new System.Drawing.Point(130, 336);
            this.comboBox_Gen.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Gen.Name = "comboBox_Gen";
            this.comboBox_Gen.Size = new System.Drawing.Size(92, 21);
            this.comboBox_Gen.TabIndex = 8;
            this.comboBox_Gen.SelectedIndexChanged += new System.EventHandler(this.comboBox_Gen_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Proiect.Properties.Resources.CreateBTN;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(957, 612);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 52);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_GrupaS
            // 
            this.comboBox_GrupaS.FormattingEnabled = true;
            this.comboBox_GrupaS.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "0+",
            "0-"});
            this.comboBox_GrupaS.Location = new System.Drawing.Point(130, 629);
            this.comboBox_GrupaS.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_GrupaS.Name = "comboBox_GrupaS";
            this.comboBox_GrupaS.Size = new System.Drawing.Size(92, 21);
            this.comboBox_GrupaS.TabIndex = 10;
            this.comboBox_GrupaS.SelectedIndexChanged += new System.EventHandler(this.comboBox_GrupaS_SelectedIndexChanged);
            // 
            // ProfilPacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect.Properties.Resources.CreareProfil2;
            this.ClientSize = new System.Drawing.Size(1367, 761);
            this.Controls.Add(this.comboBox_GrupaS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_Gen);
            this.Controls.Add(this.textBox_Alergii);
            this.Controls.Add(this.textBox_Boli);
            this.Controls.Add(this.textBox_Nume);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1383, 800);
            this.MinimumSize = new System.Drawing.Size(1383, 800);
            this.Name = "ProfilPacient";
            this.Text = "Profilul pacientului";
            this.Load += new System.EventHandler(this.ProfilPacient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nume;
        private System.Windows.Forms.TextBox textBox_Boli;
        private System.Windows.Forms.TextBox textBox_Alergii;
        private System.Windows.Forms.ComboBox comboBox_Gen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_GrupaS;
    }
}