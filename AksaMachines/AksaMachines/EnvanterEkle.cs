using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AksaMachines
{
    public partial class EnvanterEkle : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-4U3BLLI;Initial Catalog=aksaMakEnvInfo;Integrated Security=True;";
        private string envanterAdi = "";
        UserData user;
        public EnvanterEkle(UserData user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void EnvanterEkle_Load(object sender, EventArgs e)
        {
            envanterSize.Visible = false;
            envanterSizeComboBox.Visible = false;

            employeeNameLabel.Text = user.FullName;
            employeeIdLabel.Text = user.UserId;
            employeeRoleLabel.Text = user.Job;

            GetInventoryDetails();


        }


        private void addNewItem_Click(object sender, EventArgs e)
        {
            string tableName = EnvanterAdiComboBox.SelectedItem.ToString();
            string envanterType = EnvanterTürüComboBox.SelectedItem.ToString();
            int eklenecekMiktar = Convert.ToInt32(envanterEkleUpDown.Value);

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string insertQuery = $"INSERT INTO {tableName}(EnvanterAdi, EnvanterType, Stok, KullanilanStokAdedi, KullanilmayanStokAdedi) VALUES (@InventoryName, @InventoryType, @Stock, {0}, @Stock)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@InventoryName", tableName);
                    insertCommand.Parameters.AddWithValue("@InventoryType", envanterType);
                    insertCommand.Parameters.AddWithValue("@Stock", eklenecekMiktar);

                    insertCommand.ExecuteNonQuery();
                }
                /*string selectQuery = $"SELECT COUNT(*) FROM {tableName} WHERE EnvanterAdi = @InventoryName AND EnvanterType = @InventoryType";
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@InventoryName", tableName);
                    selectCommand.Parameters.AddWithValue("@InventoryType", envanterType);

                    int existingRecordCount = Convert.ToInt32(selectCommand.ExecuteScalar());

                    if (existingRecordCount > 0)
                    {
                        // Record exists, update it
                        string updateQuery = $"UPDATE {tableName} SET Stok = @Stock WHERE EnvanterAdi = @InventoryName AND EnvanterType = @InventoryType";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@InventoryName", tableName);
                            updateCommand.Parameters.AddWithValue("@InventoryType", envanterType);
                            updateCommand.Parameters.AddWithValue("@Stock", eklenecekMiktar);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Record doesn't exist, insert it
                        string insertQuery = $"INSERT INTO {tableName} (EnvanterAdi, EnvanterType, Stok) VALUES (@InventoryName, @InventoryType, @Stock)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@InventoryName", tableName);
                            insertCommand.Parameters.AddWithValue("@InventoryType", envanterType);
                            insertCommand.Parameters.AddWithValue("@Stock", eklenecekMiktar);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }*/
                showGridView(connection);
            }

        }

        private void envanterAdi_Chosen(object sender, EventArgs e)
        {
            EnvanterTürüComboBox.Items.Clear();
            string selectedTable = EnvanterAdiComboBox.SelectedItem.ToString();
            if (selectedTable == "Kol")
            {
                envanterSize.Visible = true;
                envanterSizeComboBox.Visible = true;
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                showGridView(connection);

                string query = "SELECT EnvanterType FROM EnvanterTypes WHERE EnvanterAdi = @InventoryName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InventoryName", selectedTable);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string envanterTypes = reader["EnvanterType"].ToString();
                            EnvanterTürüComboBox.Items.Add(envanterTypes);
                        }
                    }
                }
            }
        }

        private void showGridView(SqlConnection connection)
        {
            string selectedTable = EnvanterAdiComboBox.SelectedItem.ToString();


            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + selectedTable, connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.AutoResizeColumns();
            }

        }

        private void GetInventoryDetails()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT DISTINCT EnvanterAdi FROM EnvanterTypes";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string envanterAdi = reader["EnvanterAdi"].ToString();
                            EnvanterAdiComboBox.Items.Add(envanterAdi);
                        }
                    }
                }
            }
        }

        private void makinePanel_Clicked(object sender, EventArgs e)
        {
            Makine machine = new Makine(user);
            machine.Show();
            this.Hide();
        }

        private void employePanel_Clicked(object sender, EventArgs e)
        {
            Personel personel = new Personel(user);
            personel.Show();
            this.Hide();
        }

        private void homePanel_Clicked(object sender, EventArgs e)
        {
            Aksa_Makine_Bilgisi aksa_Makine_Bilgisi = new Aksa_Makine_Bilgisi(user);
            aksa_Makine_Bilgisi.Show();
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
