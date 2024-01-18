using System.Data.OleDb;
using System.Data.SqlClient;


namespace AksaMachines
{
    public partial class Login : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-4U3BLLI;Initial Catalog=aksaMakEnvInfo;Integrated Security=True;";
        
        
        public Login()
        {
            InitializeComponent();
        }

        private void loginTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = KullanýcýAdý.Text;
            string password = PasswordBox.Text;


            UserData user = AuthenticateUser(username, password);
            if (user!= null)
            {
               
                
                Aksa_Makine_Bilgisi aksa = new Aksa_Makine_Bilgisi(user);

                aksa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }

        }

        private static UserData AuthenticateUser(string username, string password)
        {
            
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Personel WHERE KullaniciAdi = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string UserId = reader["PersonelId"].ToString();
                            string FullName = reader["AdSoyad"].ToString();
                            string Job = reader["Meslek"].ToString();

                            // Assuming UserData is a class to hold user details
                            UserData userData = new UserData(UserId, FullName, Job);

                            return userData;
                        }
                    }
                }
            }
            return null;
        }
    }
}
