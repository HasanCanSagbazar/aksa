using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace AksaMachines
{
    public partial class Aksa_Makine_Bilgisi : Form
    {
        UserData user;
        List<Object> machineEnvanter;
        MachineControl machineControls;
        private const string ConnectionString = "Data Source=DESKTOP-4U3BLLI;Initial Catalog=aksaMakEnvInfo;Integrated Security=True;";
        private MachineControl previouslyClickedControl;
        MachineControl clickedControl;
        EnvaterPopUp envaterPopUp;
        bool machineClicked = false;

        public Aksa_Makine_Bilgisi(UserData user)
        {
            InitializeComponent();
            this.user = user;
            machineEnvanter = new List<Object>();
            sendButton.Text = char.ConvertFromUtf32(0x2192);
        }

        /*private void employeeLabel_Click(object sender, EventArgs e)
        {

        }*/

        private void Aksa_Makine_Bilgisi_Load(object sender, EventArgs e)
        {
            populateItems();
            employeeNameLabel.Text = user.FullName;
            employeeIdLabel.Text = user.UserId;
            employeeRoleLabel.Text = user.Job;
        }

        private void populateItems()
        {
            List<MachineControl> machineControlsList = new List<MachineControl>();
            int index_Machine = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) AS RecordCount, MakineID, MakineAdi FROM Makine GROUP BY MakineID, MakineAdi";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {


                            machineControls = new MachineControl();

                            machineControls.MachineId = reader["MakineID"].ToString();
                            machineControls.MachineName = reader["MakineAdi"].ToString();

                            machineControls.Click += MachineControl_Clicked;
                            allMachineDisplay.Controls.Add(machineControls);
                            index_Machine++;
                        }
                    }
                }
                connection.Close();
            }

        }

        private void MachineControl_Clicked(object sender, EventArgs e)
        {
            // Handle the click event of the MachineControl
            clickedControl = sender as MachineControl;

            // Deselect the previously clicked control (if any)
            DeselectPreviousControls();

            // Update the visual state or perform any other actions
            clickedControl.BackColor = Color.Yellow; // Example: Change the background color

            // Store the reference to the clicked control
            previouslyClickedControl = clickedControl;
        }

        private void DeselectPreviousControls()
        {
            if (previouslyClickedControl != null)
            {
                previouslyClickedControl.BackColor = Color.SteelBlue; // Reset the background color or update as needed
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void spineretPanel_Clicked(object sender, EventArgs e)
        {
            string tableName = spineretLabel.Text;
            envaterPopUp = new EnvaterPopUp(tableName, this);
            envaterPopUp.ShowDialog(this);

            machineEnvanter.Add(envaterPopUp.MachineEnvanter);

        }

        private void kolPanel_Click(object sender, EventArgs e)
        {
            string tableName = kolLabel.Text;
            envaterPopUp = new EnvaterPopUp(tableName, this);
            envaterPopUp.ShowDialog(this);

            machineEnvanter.Add(envaterPopUp.MachineEnvanter);
        }

        private void kandilPanel_Click(object sender, EventArgs e)
        {
            string tableName = kandilLabel.Text;
            envaterPopUp = new EnvaterPopUp(tableName, this);
            envaterPopUp.ShowDialog(this);

            machineEnvanter.Add(envaterPopUp.MachineEnvanter);
        }

        private void potFiltrePanel_Click(object sender, EventArgs e)
        {
            string tableName = potFiltreLabel.Text;
            envaterPopUp = new EnvaterPopUp(tableName, this);
            envaterPopUp.ShowDialog(this);

            machineEnvanter.Add(envaterPopUp.MachineEnvanter);
        }

        public void setEnvanterListesi(string envanterInfo)
        {

            for (int i = 0; i < EnvanterListesi.Items.Count - 1; i++)
            {

                //lastIndex = item.Split(" ").Length - 1;
                string listboxType = EnvanterListesi.Items[i].ToString().Split(" ")[2];
                string infoType = envanterInfo.Split(" ")[2];
                if (listboxType == infoType)
                {
                    EnvanterListesi.Items.RemoveAt(i);
                    //EnvanterListesi.Items.Add(envanterInfo);
                    break;
                }

            }

            if (EnvanterListesi != null)
            {
                EnvanterListesi.Items.Add(envanterInfo);
            }

        }

        private void sendButton_Clicked(object sender, EventArgs e)
        {

            string makineId = clickedControl.MachineId;
            string envanterAdi;
            string envanterType;
            int stok;
            foreach (Dictionary<string, Dictionary<string, int>> mapEnv in machineEnvanter)
            {

                foreach (var item in mapEnv)
                {
                    envanterAdi = item.Key;
                    Dictionary<string, int> innerMap = item.Value;
                    foreach (var innerItem in innerMap)
                    {
                        envanterType = innerItem.Key;
                        stok = innerItem.Value;

                        UpdateOrInsertInventory(envanterAdi, makineId, envanterType, stok);
                    }
                }
            }

            machineEnvanter.Clear();
            EnvanterListesi.Items.Clear();
            envaterPopUp.MachineEnvanter.Clear();

        }

        private void UpdateOrInsertInventory(string inventoryName, string machineId, string inventoryType, int stock)
        {
            //MessageBox.Show($"{inventoryName}{inventoryType}");
            int resultUsedStock = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Check if the record already exists
                string selectQuery = "SELECT Count(*) FROM MakEnv WHERE EnvanterAdi = @InventoryName AND MakId = @MachineId AND EnvanterType = @InventoryType";
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@InventoryName", inventoryName);
                    selectCommand.Parameters.AddWithValue("@MachineId", machineId);
                    selectCommand.Parameters.AddWithValue("@InventoryType", inventoryType);

                    int existingRecordCount = Convert.ToInt32(selectCommand.ExecuteScalar());

                    if (existingRecordCount > 0)
                    {
                        // Record exists, update it
                        string updateQuery = "UPDATE MakEnv SET Stok = @Stock WHERE EnvanterAdi = @InventoryName AND MakId = @MachineId AND EnvanterType = @InventoryType";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@Stock", stock);
                            updateCommand.Parameters.AddWithValue("@InventoryName", inventoryName);
                            updateCommand.Parameters.AddWithValue("@MachineId", machineId);
                            updateCommand.Parameters.AddWithValue("@InventoryType", inventoryType);

                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Record doesn't exist, insert it
                        string insertQuery = "INSERT INTO MakEnv (EnvanterAdi, MakId, EnvanterType, Stok) VALUES (@InventoryName, @MachineId, @InventoryType, @Stock)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@InventoryName", inventoryName);
                            insertCommand.Parameters.AddWithValue("@MachineId", machineId);
                            insertCommand.Parameters.AddWithValue("@InventoryType", inventoryType);
                            insertCommand.Parameters.AddWithValue("@Stock", stock);

                            insertCommand.ExecuteNonQuery();
                        }
                    }



                }
                string selectQuery2 = $"SELECT KullanilanStokAdedi FROM {inventoryName} WHERE EnvanterType = @InventoryType";
              

                using (SqlCommand selectQuery2Command = new SqlCommand(selectQuery2, connection))
                {
                    selectQuery2Command.Parameters.AddWithValue("@InventoryType", inventoryType);

                    using (SqlDataReader reader = selectQuery2Command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            resultUsedStock = Convert.ToInt32(reader["KullanilanStokAdedi"]);
                        }
                        else
                        {
                            MessageBox.Show("Record not found");
                        }
                    }
                }

                string updateQuery2 = $"UPDATE {inventoryName} SET KullanilanStokAdedi = @NewValue AND KullanilmayanStokAdedi = @newValue2 WHERE EnvanterType = @InventoryType;";
                using (SqlCommand updateQuery2Command = new SqlCommand(updateQuery2, connection))
                {
                    int newValueUsedStock = resultUsedStock + stock;
                    
                    updateQuery2Command.Parameters.AddWithValue("@InventoryType", inventoryType);
                    updateQuery2Command.Parameters.AddWithValue("@NewValue", newValueUsedStock);
                    updateQuery2Command.ExecuteNonQuery();

                }
                    
                //connection.Close();
            }
        }

        private void envanter_Clicked(object sender, EventArgs e)
        {
            EnvanterEkle env = new EnvanterEkle(user);
            env.Show();
            this.Hide();
        }

        private void machinePanel_Clicked(object sender, EventArgs e)
        {
            Makine makine = new Makine(user);
            makine.Show();
            this.Hide();
        }

        private void personelPanel_Clicked(object sender, EventArgs e)
        {
            Personel personel = new Personel(user);
            personel.Show();
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
