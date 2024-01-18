using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AksaMachines
{
    public partial class Personel : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-4U3BLLI;Initial Catalog=aksaMakEnvInfo;Integrated Security=True;";
        private UserData user;
        public Personel(UserData user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void envanterAdd_Click(object sender, EventArgs e)
        {

        }

        private void addEmployee_Clicked(object sender, EventArgs e)
        {
            string personelId = idTextBox.Text;
            string username = userNameTextBox.Text;
            string name = nameTextBox.Text;
            string job = jobTextBox.Text;
            string rol = roleTextBox.Text;
            string şifre = passwordTextBox.Text;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Personel (PersonelId, KullaniciAdi, AdSoyad, Meslek, Rol, Password) " +
                                     "VALUES (@PersonelId, @Username, @Name, @Job, @Role, @Password)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@PersonelId", personelId);
                    insertCommand.Parameters.AddWithValue("@Username", username);
                    insertCommand.Parameters.AddWithValue("@Name", name);
                    insertCommand.Parameters.AddWithValue("@Job", job);
                    insertCommand.Parameters.AddWithValue("@Role", rol);
                    insertCommand.Parameters.AddWithValue("@Password", şifre);

                    insertCommand.ExecuteNonQuery();
                }
                gridViewShow(connection);
            }
        }

        private void personel_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                gridViewShow(connection);
            }

            employeeNameLabel.Text = user.FullName;
            employeeIdLabel.Text = user.UserId;
            employeeRoleLabel.Text = user.Job;

        }

        private void gridViewShow(SqlConnection connection)
        {


            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Personel", connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.AutoResizeColumns();
            }

        }

        private void homePanel_Clicked(object sender, EventArgs e)
        {
            Aksa_Makine_Bilgisi aksa_Makine_Bilgisi = new Aksa_Makine_Bilgisi(user);
            aksa_Makine_Bilgisi.Show();
            this.Hide();
        }

        private void makinePanel_Clicked(object sender, EventArgs e)
        {
            Makine makine = new Makine(user); 
            makine.Show();
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
