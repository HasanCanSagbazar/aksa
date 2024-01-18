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

namespace AksaMachines
{
    public partial class Makine : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-4U3BLLI;Initial Catalog=aksaMakEnvInfo;Integrated Security=True;";
        private UserData user;
        public Makine(UserData user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void addMachine_Clicked(object sender, EventArgs e)
        {
            string machineId = machineNumtextBox.Text;
            string machineName = machineNametextBox.Text;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO Makine(MakineId, MakineAdi) VALUES (@MachineId, @MachineName)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MachineId", machineId);
                    command.Parameters.AddWithValue("@MachineName", machineName);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void machine_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Makine", connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.AutoResizeColumns();
                }
            }

            employeeNameLabel.Text = user.FullName;
            employeeIdLabel.Text = user.UserId;
            employeeRoleLabel.Text = user.Job;
        }

        private void homePanel_Clicked(object sender, EventArgs e)
        {
            Aksa_Makine_Bilgisi aksa_Makine_Bilgisi = new Aksa_Makine_Bilgisi(user);
            aksa_Makine_Bilgisi.Show();
            this.Hide();
        }

        private void employeePanel_Clicked(object sender, EventArgs e)
        {
            Personel personel = new Personel(user);
            personel.Show();
            this.Hide();
        }

        private void envanterPanel_Clicked(object sender, EventArgs e)
        {
            EnvanterEkle envanter = new EnvanterEkle(user);
            envanter.Show();
            this.Hide();
        }

        private void signOutPanel_Clicked(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
