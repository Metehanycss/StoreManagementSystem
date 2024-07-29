using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MarketYönetimSistemi.Views;

namespace MarketYönetimSistemi.Views
{
    public partial class SupplierForm : Form
    {
        private int selectedId = -1;

        public SupplierForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=MY;Initial Catalog=MarketDb;Integrated Security=True;TrustServerCertificate=True");

        public void dataList()
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Suppliers ORDER BY SupplierId", conn);
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

        private void SupplierForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Uygulamanın tüm formlarını kapat
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["SupplierId"].Value);

                // Seçilen satırdaki değerleri TextBox kontrollerine yükleyin
                nameVal.Text = row.Cells["CompanyName"].Value.ToString();
                emailVal.Text = row.Cells["Email"].Value.ToString();
                phoneVal.Text = row.Cells["Phone"].Value.ToString();
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
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Suppliers(CompanyName, Email, Phone, Address) VALUES(@CompanyName, @Email, @Phone, @Address)", conn);
                sqlCommand.Parameters.AddWithValue("@CompanyName", nameVal.Text);
                sqlCommand.Parameters.AddWithValue("@Email", nameVal.Text);
                sqlCommand.Parameters.AddWithValue("@Phone", phoneVal.Text);
                sqlCommand.Parameters.AddWithValue("@Address", addressVal.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Supplier added successfully!");
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
            emailVal.Text = string.Empty;
            phoneVal.Text = string.Empty;
            addressVal.Text = string.Empty;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (selectedId == -1)
            {
                MessageBox.Show("Please select a supplier to delete.");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Suppliers WHERE SupplierId = @SupplierId", conn);
                sqlCommand.Parameters.AddWithValue("@SupplierId", selectedId);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Supplier deleted successfully!");
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
                if (row.Cells["CompanyName"].Value != null && row.Cells["CompanyName"].Value.ToString().ToLower().Equals(searchValue))
                {
                    row.Selected = true;
                    dataGridView.FirstDisplayedScrollingRowIndex = row.Index;

                    // Seçilen satırdaki değerleri TextBox kontrollerine yükleyin
                    nameVal.Text = row.Cells["CompanyName"].Value.ToString();
                    emailVal.Text = row.Cells["Email"].Value.ToString();
                    phoneVal.Text = row.Cells["Phone"].Value.ToString();
                    addressVal.Text = row.Cells["Address"].Value.ToString();
                    return;
                }
            }

            MessageBox.Show("Supplier not found.");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (selectedId == -1)
            {
                MessageBox.Show("Please select a supplier to update.");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Suppliers SET CompanyName = @CompanyName, Email = @Email, Phone = @Phone, Address = @Address WHERE SupplierId = @SupplierId", conn);
                sqlCommand.Parameters.AddWithValue("@SupplierId", selectedId);
                sqlCommand.Parameters.AddWithValue("@CompanyName", nameVal.Text);
                sqlCommand.Parameters.AddWithValue("@Phone", nameVal.Text);
                sqlCommand.Parameters.AddWithValue("@Address", addressVal.Text);
                sqlCommand.Parameters.AddWithValue("@Email", emailVal.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Supplier updated successfully!");
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

        private void SupplierForm_Load_1(object sender, EventArgs e)
        {

        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            dataList();
            dataGridView.CellClick += dataGridView_CellClick;
        }
    }
}
