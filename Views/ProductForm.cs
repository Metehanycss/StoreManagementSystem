using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MarketYönetimSistemi.Views;

namespace MarketYönetimSistemi.Views
{
    public partial class ProductForm : Form
    {
        private int selectedProductId = -1;

        public ProductForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=MY;Initial Catalog=MarketDb;Integrated Security=True;TrustServerCertificate=True");

        public void productList()
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Products ORDER BY ProductId", conn);
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

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Uygulamanın tüm formlarını kapat
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                if (selectedProductId == null)
                    return;

                if (row.Cells["ProductId"].Value == DBNull.Value)
                    return;

                selectedProductId = Convert.ToInt32(row.Cells["ProductId"].Value);

                // Seçilen satırdaki değerleri TextBox kontrollerine yükleyin
                name.Text = row.Cells["Name"].Value.ToString();
                price.Text = row.Cells["Price"].Value.ToString();
                department.Text = row.Cells["Department"].Value.ToString();
                description.Text = row.Cells["Description"].Value.ToString();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Show();
            this.Hide();
        }

        private void ProductForm_Load_1(object sender, EventArgs e)
        {
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Products(Name, Price, Department, Description) VALUES(@Name, @Price, @Department, @Description)", conn);
                sqlCommand.Parameters.AddWithValue("@Name", name.Text);
                sqlCommand.Parameters.AddWithValue("@Price", price.Text);
                sqlCommand.Parameters.AddWithValue("@Department", department.Text);
                sqlCommand.Parameters.AddWithValue("@Description", description.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Ürün Başarıyla Eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                productList();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            price.Text = string.Empty;
            department.Text = string.Empty;
            description.Text = string.Empty;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (selectedProductId == -1)
            {
                MessageBox.Show("Lütfen Silmek İçin Bir Ürün Seçin.");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Products WHERE ProductId = @ProductId", conn);
                sqlCommand.Parameters.AddWithValue("@ProductId", selectedProductId);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Ürün Başarıyla Silindi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                productList();
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

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Name"].Value != null && row.Cells["Name"].Value.ToString().ToLower().Equals(searchValue))
                {
                    row.Selected = true;
                    dataGridView.FirstDisplayedScrollingRowIndex = row.Index;

                    name.Text = row.Cells["Name"].Value.ToString();
                    price.Text = row.Cells["Price"].Value.ToString();
                    department.Text = row.Cells["Department"].Value.ToString();
                    description.Text = row.Cells["Description"].Value.ToString();
                    return;
                }
            }

            MessageBox.Show("Ürün Bulunamadı.");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (selectedProductId == -1)
            {
                MessageBox.Show("Lütfen Güncellemek İçin Bir Ürün Seçin.");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Products SET Name = @Name, Price = @Price, Department = @Department, Description = @Description WHERE ProductId = @ProductId", conn);
                sqlCommand.Parameters.AddWithValue("@ProductId", selectedProductId);
                sqlCommand.Parameters.AddWithValue("@Name", name.Text);
                sqlCommand.Parameters.AddWithValue("@Price", price.Text);
                sqlCommand.Parameters.AddWithValue("@Department", department.Text);
                sqlCommand.Parameters.AddWithValue("@Description", description.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Ürün Başarıyla Güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                productList();
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            productList();
            dataGridView.CellClick += dataGridView_CellClick;
        }
    }
}
