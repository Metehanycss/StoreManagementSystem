using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MarketYönetimSistemi.Views
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MY;Initial Catalog=RestorantDb;Integrated Security=True;TrustServerCertificate=True");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailVal.Text; // emailVal, kullanıcının e-postasını girdiği TextBox kontrolünün adı olmalıdır.
            string password = passwordVal.Text; // passwordVal, kullanıcının parolasını girdiği TextBox kontrolünün adı olmalıdır.

            if (ValidateUser(email, password))
            {
                MessageBox.Show("Login successful!");
                HomePageForm homePageForm = new HomePageForm(); // MainPage, başarılı giriş sonrası açılacak formun adıdır.
                homePageForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        private bool ValidateUser(string email, string password)
        {
            try
            {
                conn.Open();
                string query = "SELECT PasswordHash FROM Users WHERE Email = @Email";  // Burada PasswordHash aslında doğrudan parolayı içerir.
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                string storedPassword = cmd.ExecuteScalar() as string;  // Veritabanından dönen parola değerini alıyoruz.

                conn.Close();

                if (storedPassword != null && storedPassword == password)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return false;
        }
    }
}
