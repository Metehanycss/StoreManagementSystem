using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MarketYönetimSistemi.Views;

namespace MarketYönetimSistemi.Views
{
    public partial class CustomerForm : Form
    {
        private int selectedCustomerId = -1;

        public CustomerForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=MY;Initial Catalog=RestorantDb;Integrated Security=True;TrustServerCertificate=True");

        public void dataList()
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customers ORDER BY CustomerId", conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Uygulamanın tüm formlarını kapat
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                selectedCustomerId = Convert.ToInt32(row.Cells["CustomerId"].Value);

                // Seçilen satırdaki değerleri TextBox kontrollerine yükleyin
                nameVal.Text = row.Cells["FirstName"].Value.ToString();
                surnameVal.Text = row.Cells["LastName"].Value.ToString();
                phoneVal.Text = row.Cells["Phone"].Value.ToString();
                emailVal.Text = row.Cells["Email"].Value.ToString();
                addressVal.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HomePageForm mainPage = new HomePageForm();
            mainPage.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Customers(FirstName, LastName, Phone, Email, Address) VALUES(@FirstName, @LastName, @Phone, @Email, @Address)", conn);
                sqlCommand.Parameters.AddWithValue("@FirstName", nameVal.Text);
                sqlCommand.Parameters.AddWithValue("@LastName", surnameVal.Text);
                sqlCommand.Parameters.AddWithValue("@Phone", phoneVal.Text);
                sqlCommand.Parameters.AddWithValue("@Email", emailVal.Text);
                sqlCommand.Parameters.AddWithValue("@Address", addressVal.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                dataList();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameVal.Text = string.Empty;
            surnameVal.Text = string.Empty;
            phoneVal.Text = string.Empty;
            emailVal.Text = string.Empty;
            addressVal.Text = string.Empty;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (selectedCustomerId == -1)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Customers WHERE CustomerId = @CustomerId", conn);
                sqlCommand.Parameters.AddWithValue("@CustomerId", selectedCustomerId);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Customer deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                dataList();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            string searchValue = searchVal.Text.ToLower();

            // Önce tüm seçimleri temizle
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Selected = false;
            }

            // Sonra arama yap ve eşleşen satırı seç
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["FirstName"].Value != null && row.Cells["FirstName"].Value.ToString().ToLower().Equals(searchValue))
                {
                    row.Selected = true;
                    dataGridView.FirstDisplayedScrollingRowIndex = row.Index;

                    // Seçilen satırdaki değerleri TextBox kontrollerine yükleyin
                    nameVal.Text = row.Cells["FirstName"].Value.ToString();
                    surnameVal.Text = row.Cells["LastName"].Value.ToString();
                    phoneVal.Text = row.Cells["Phone"].Value.ToString();
                    emailVal.Text = row.Cells["Email"].Value.ToString();
                    addressVal.Text = row.Cells["Address"].Value.ToString();
                    return;
                }
            }

            MessageBox.Show("Customer not found.");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (selectedCustomerId == -1)
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Email = @Email , Address = @Address WHERE CustomerId = @CustomerId", conn);
                sqlCommand.Parameters.AddWithValue("@CustomerId", selectedCustomerId);
                sqlCommand.Parameters.AddWithValue("@FirstName", nameVal.Text);
                sqlCommand.Parameters.AddWithValue("@LastName", surnameVal.Text);
                sqlCommand.Parameters.AddWithValue("@Phone", phoneVal.Text);
                sqlCommand.Parameters.AddWithValue("@Email", emailVal.Text);
                sqlCommand.Parameters.AddWithValue("@Address", addressVal.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Customer updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                dataList();
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dataList();
            dataGridView.CellClick += dataGridView_CellClick; // CellClick olayını bağlayın
        }

        private void CustomerForm_Load_1(object sender, EventArgs e)
        {
            dataList();
            dataGridView.CellClick += dataGridView_CellClick; // CellClick olayını bağlayın
        }
    }
}
