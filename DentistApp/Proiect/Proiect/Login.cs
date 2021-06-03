using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Login : Form
    {
        DentistEntities entities;
        int idUser;
     
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text != string.Empty && textBox_Password.Text != null)
            {
                using (entities = new DentistEntities())
                {
                    Users user = new Users();
                    user.Username = textBox_Username.Text;
                                  
                    var findUser = entities.Users.Where(u => u.Username == user.Username).FirstOrDefault();
                    if (findUser != null)
                    {
                        if (textBox_Username.Text.Equals("administrator"))
                        {
                            this.Hide();
                            Admin adim = new Admin();
                            adim.ShowDialog();
                        }
                        else
                        {
                            idUser = findUser.Id;
                            this.Hide();
                            ProfilPacient pacient = new ProfilPacient();
                            ProgramariPacienti programare = new ProgramariPacienti();
                            pacient.transmitId(idUser);
                            programare.transmitIdProg(idUser);
                            if (entities.ProfilMedical.Any(p => p.IdUser == idUser))
                            {
                                this.Hide();
                                programare.ShowDialog();
                            }
                            else
                            {
                                pacient.ShowDialog();
                            }
                        }
                    }
                    
                }
            }
        }
    }
}
