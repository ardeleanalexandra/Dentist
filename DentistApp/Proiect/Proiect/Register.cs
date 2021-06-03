using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace Proiect
{
    public partial class Register : Form
    {
        DentistEntities entities;


        public void Clinici()
        {

        }



        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        static bool IsDigit(string input)
        {
            foreach(char c in input)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
        
        static bool IsPhoneNr(string nr)
        {
            return nr[0] == '0' && nr[1] == '7' && nr.Length == 10 && IsDigit(nr);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool okPass = false;
            bool okNrTel = false;
            bool okMail = false;
            if (textBox_Username.Text != string.Empty && textBox_Password.Text != null && textBox_NrTel.Text != null && textBox_Mail.Text != string.Empty )
            {
                using (entities = new DentistEntities())
                {
                    Users users = new Users();
                    users.Username = textBox_Username.Text;
                    if (entities.Users.Any(u => u.Username == textBox_Username.Text))
                    {
                        MessageBox.Show("Exista deja un utilizator cu acest username!");
                        this.Hide();
                        Login user = new Login();
                        user.ShowDialog();
                    }
                    else
                    {
                        users.PasswordUser = textBox_Password.Text;
                        users.ConfirmPassword = textBox_ConfirmPass.Text;
                        if (users.PasswordUser == users.ConfirmPassword)
                        {
                            okPass = true;

                        }
                        else
                        {
                            MessageBox.Show("Parolele nu coincid");
                            textBox_Password.Text = "";
                            textBox_ConfirmPass.Text = "";
                        }

                        users.NrTelefon = textBox_NrTel.Text;
                        if (IsPhoneNr(textBox_NrTel.Text) == true)
                        {
                            okNrTel = true;
                        }
                        else
                        {
                            MessageBox.Show("Numar de telefon invalid");
                            textBox_NrTel.Text = "";
                        }

                        users.Email = textBox_Mail.Text;

                        if (!this.textBox_Mail.Text.Contains('@') || !this.textBox_Mail.Text.Contains('.'))
                        {
                            MessageBox.Show("E-mail invalid");
                            textBox_Mail.Text = "";
                        }
                        else
                        {
                            okMail = true;
                        }

                        if (okMail && okNrTel && okPass)
                        {
                            entities.Users.Add(users);
                            entities.SaveChanges();
                            this.Hide();
                            Login user = new Login();
                            user.ShowDialog();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Introduceti date in toate campurile");
            }

        }

        private void textBox_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login user = new Login();
            user.ShowDialog();

        }
    }
}
