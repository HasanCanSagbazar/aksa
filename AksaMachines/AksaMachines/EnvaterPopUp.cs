using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AksaMachines
{
    public partial class EnvaterPopUp : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-4U3BLLI;Initial Catalog=aksaMakEnvInfo;Integrated Security=True;";
        private Dictionary<string, int> mapEnvanter;
        private string envanterAdi = "";
        private string tableName = "";
        private Dictionary<string, Dictionary<string, int>> machineEnvanter;

        private Aksa_Makine_Bilgisi aksa_makine_bilgisi;

        public Dictionary<string, Dictionary<string, int>> MachineEnvanter
        {
            get { return this.machineEnvanter; }
        }
        public EnvaterPopUp(string tableName, Aksa_Makine_Bilgisi aksa_Makine_Bilgisi)
        {
            InitializeComponent();
            mapEnvanter = new Dictionary<string, int>();
            machineEnvanter = new Dictionary<string, Dictionary<string, int>>();
            this.aksa_makine_bilgisi = aksa_Makine_Bilgisi;
            this.tableName = tableName;
            
        }

        private void envanterTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void envanterPopUp_Load(object sender, EventArgs e)
        {
            GetInventoryDetails();
            editPieChart();

        }
        private void GetInventoryDetails()
        {

            int totalEnvanter = 0;
            string envanterTürü = "";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM " + tableName;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            envanterAdi = reader["EnvanterAdi"].ToString();



                            int stokadedi = Convert.ToInt32(reader["Stok"]);
                            // Şimdi burada alınan verilerle yapmak istediğiniz işlemleri gerçekleştirebilirsiniz.
                            // Örneğin, MessageBox ile gösterelim:

                            switch (tableName)
                            {
                                case "Spineret":
                                    envanterTürü = reader["EnvanterType"].ToString();
                                    mapEnvanter.Add(envanterTürü, stokadedi);
                                    envanterType.Items.Add(Convert.ToString(envanterTürü));
                                    break;

                                case "Kol":

                                    break;

                                case "Kandil":
                                    envanterTürü = reader["EnvanterType"].ToString();
                                    mapEnvanter.Add(envanterTürü, stokadedi);
                                    envanterType.Items.Add(Convert.ToString(envanterTürü));
                                    break;

                                case "PotFiltre":
                                    envanterTürü = reader["EnvanterType"].ToString();
                                    mapEnvanter.Add(envanterTürü, stokadedi);
                                    envanterType.Items.Add(Convert.ToString(envanterTürü));
                                    break;

                                default:
                                    MessageBox.Show("Invalid table name.");

                                    break;
                            }




                            totalEnvanter += stokadedi;

                        }
                        envaterAdıLabel.Text = envanterAdi;
                        envaterSayisiUp.Text = Convert.ToString(totalEnvanter);

                    }
                }
            }
        }


        private void envanterTürü_SelectedChangedValue(object sender, EventArgs e)
        {


            string selectedItem = envanterType.SelectedItem.ToString();

            tekTipEnvanterSayısı.Value = mapEnvanter[selectedItem];
            tekTipEnvanterSayısı.Maximum = mapEnvanter[selectedItem];


        }

        private void editPieChart()
        {
            var listKey = mapEnvanter.Keys.ToList();
            //envanterGösterim.Series.Add("envanterTürü");


            envanterGösterim.Series["envanterTürü"].ChartType = SeriesChartType.Pie;

            Title chartTitle = new Title(envanterAdi + " Envanter Gösterimi");
            chartTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            envanterGösterim.Titles.Add(chartTitle);

            foreach (var key in listKey)
            {
                envanterGösterim.Series["envanterTürü"].Points.AddXY(key, mapEnvanter[key]);
            }
            envanterGösterim.Series["envanterTürü"].IsValueShownAsLabel = true;
        }

        private void ayırButton_Clicked(object sender, EventArgs e)
        {
            string envanterAdi = this.envanterAdi;
            string envanterTürü = envanterType.SelectedItem.ToString();
            int ayrilanSayi = Convert.ToInt32( tekTipEnvanterSayısı.Value);

            

            if (machineEnvanter.Keys.Contains(envanterAdi))
            {
                
                if (machineEnvanter[envanterAdi].Keys.Contains(envanterTürü))
                {
                    machineEnvanter[envanterAdi][envanterTürü] = ayrilanSayi ;
                }
                else
                {
                    machineEnvanter[envanterAdi].Add(envanterTürü, ayrilanSayi) ;
                }
            }
            else
            {
                Dictionary<string, int> tempDict = new Dictionary<string, int>();
                tempDict.Add(envanterTürü, ayrilanSayi);
                machineEnvanter.Add(envanterAdi, tempDict);
            }
            

            string info = ayrilanSayi + " adet " + envanterTürü + " " + envanterAdi;

            aksa_makine_bilgisi.setEnvanterListesi(info);
        }
    }
}
