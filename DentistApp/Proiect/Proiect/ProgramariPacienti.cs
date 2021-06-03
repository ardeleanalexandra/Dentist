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
    public partial class ProgramariPacienti : Form
    {

        DentistEntities entities;
        public int idUser;

        private string connectionString =
            @"Data Source=DESKTOP-UQRV9PC\WINCC;Initial Catalog=Dentist;Integrated Security=True";
        public List<Programari> ProgramariLista()
        {
            int startIndex = 0;
            int maxRows = 20;
            using (entities = new DentistEntities())
            {
                List<Programari> listProgramari = new List<Programari>();
                listProgramari = (from prog in entities.Programari select prog)
                .OrderBy(prog => prog.Id)
                .Skip(startIndex)
                .Take(maxRows).ToList();
                return listProgramari;
            }

        }


        public ProgramariPacienti()
        {
            InitializeComponent();
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UQRV9PC\WINCC;Initial Catalog=Dentist;Integrated Security=True"))
            {
                try
                {
                    string query = "select NameClinica, Id from Clinici";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Clinici");
                    comboBox.DisplayMember = "NameClinica";
                    comboBox.ValueMember = "Id";
                    comboBox.DataSource = ds.Tables["Clinici"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }
            }
            
        }
        public void transmitIdProg(int idUser)
        {
            this.idUser = idUser;
        }
        private void ProgramariPacienti_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            using (entities = new DentistEntities())
            {
                 if(entities.Programari.Any(p=> p.IdUser == idUser))
                 {
                     MessageBox.Show("Userul are deja o programare!");
                 }
                 else {
                Programari programare = new Programari();

                programare.IdUser = idUser;
                programare.Data = dateTimePicker1.Value;
                programare.IdClinica = Convert.ToInt32(comboBox.SelectedValue.ToString());
                entities.Programari.Add(programare);
                entities.SaveChanges();
                MessageBox.Show("Ati adaugat cu succes");
                 }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UQRV9PC\WINCC;Initial Catalog=Dentist;Integrated Security=True"))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Programari", conn);
                    DataTable dataTable = new DataTable();
                    sqlDa.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }
            }
        

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            using (entities = new DentistEntities())
            {
                foreach (DataGridViewCell item in this.dataGridView.SelectedCells)
                {
                    if (item.Selected)
                    {
                       // dataGridView.Rows[item.RowIndex]
                        var itemToRemove = entities.Programari.SingleOrDefault(p => p.Id ==(int) item.Value);
                        if (itemToRemove != null)
                        {
                            entities.Programari.Remove(itemToRemove);
                            entities.SaveChanges();
                            MessageBox.Show("Programare stearsa cu succes");
                            
                        }
                    }
                }
   
            }
        }
    }
}
