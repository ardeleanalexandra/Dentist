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
    public partial class ProfilPacient : Form
    {
        DentistEntities entities;
        int idPacient;
        public ProfilPacient()
        {
            InitializeComponent();
        }

        private void ProfilPacient_Load(object sender, EventArgs e)
        {

        }
        public void transmitId(int idUser)
        {
            idPacient = idUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Nume.Text != string.Empty && comboBox_Gen.Text != null && comboBox_GrupaS.Text != null && textBox_Alergii.Text != string.Empty && textBox_Boli.Text != string.Empty)
            {
                using (entities = new DentistEntities())
                {
                    ProfilMedical pacient = new ProfilMedical();
                    pacient.IdUser = idPacient;                    
                    var findPacient = entities.ProfilMedical.Where(p => p.Id == pacient.IdUser).FirstOrDefault();
                    if (findPacient != null)
                    {
                        
                        this.Hide();
                        ProgramariPacienti programare = new ProgramariPacienti();
                        programare.transmitIdProg(pacient.IdUser);
                        programare.ShowDialog();
                    }
                    else
                    {
                        pacient.NamePacient = textBox_Nume.Text;
                        pacient.Gen = comboBox_Gen.Text;
                        pacient.Alergii = textBox_Alergii.Text;
                        pacient.BoliCronice = textBox_Boli.Text;
                        pacient.GrupaSanguina = comboBox_GrupaS.Text;

                        entities.ProfilMedical.Add(pacient);
                        entities.SaveChanges();
                        MessageBox.Show("Profilul a fost creat cu succes!");


                        this.Hide();
                        ProgramariPacienti programare = new ProgramariPacienti();
                        programare.transmitIdProg(pacient.IdUser);
                        programare.ShowDialog();
                    }

                }
            } 
            else
                    {
                        MessageBox.Show("Introduceti date in toate campurile");
                    }
        }

                private void button2_Click(object sender, EventArgs e)
                {

                }

        private void textBox_Nume_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Gen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Alergii_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Boli_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_GrupaS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


