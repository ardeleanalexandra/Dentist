using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Admin : Form
    {
        DentistEntities entities;
        public Admin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UQRV9PC\WINCC;Initial Catalog=Dentist;Integrated Security=True"))
            {
                try
                {
                    SqlDataAdapter sqlDa1 = new SqlDataAdapter("Select * from Clinici", conn);
                    SqlDataAdapter sqlDa2 = new SqlDataAdapter("Select * from Medici", conn);
                    DataTable dataTable1 = new DataTable();
                    DataTable dataTable2 = new DataTable();
                    sqlDa1.Fill(dataTable1);
                    sqlDa2.Fill(dataTable2);

                    dataGridView1.DataSource = dataTable1;
                    dataGridView2.DataSource = dataTable2;
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (entities = new DentistEntities())
            {
                Medici medic = new Medici();

                medic.IdClinici = Convert.ToInt32(textBox_IdClinica.Text);
                medic.NameMedic = textBox_NameM.Text;

                entities.Medici.Add(medic);
                entities.SaveChanges();
                MessageBox.Show("Ati adaugat cu succes");
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (entities = new DentistEntities())
            {
                foreach (DataGridViewCell item in this.dataGridView2.SelectedCells)
                {
                    if (item.Selected)
                    {
                        var itemToRemove = entities.Medici.SingleOrDefault(p => p.Id == (int)item.Value);
                        if (itemToRemove != null)
                        {
                            entities.Medici.Remove(itemToRemove);
                            entities.SaveChanges();
                            MessageBox.Show("Camp sters cu succes!");
                        }
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_NameM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
