using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MarketYönetimSistemi.Views;

namespace MarketYönetimSistemi.Views
{
    public partial class PersonnelForm : Form
    {
        private int selectedPersonnelId = -1;

        public PersonnelForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=MY;Initial Catalog=MarketDb;Integrated Security=True;TrustServerCertificate=True");

        public void personnelList()
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Personnels ORDER BY PersonnelId", conn);
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

        private void PersonnelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Uygulamanın tüm formlarını kapat
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                selectedPersonnelId = Convert.ToInt32(row.Cells["PersonnelId"].Value);

                // Seçilen satırdaki değerleri TextBox kontrollerine yükleyin
                nameVal.Text = row.Cells["Name"].Value.ToString();
                genderVal.Text = row.Cells["Gender"].Value.ToString();
                departmentVal.Text = row.Cells["Department"].Value.ToString();
                phoneVal.Text = row.Cells["Phone"].Value.ToString();
                addressVal.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Personnels(Name, Gender, Department, Phone, Address) VALUES(@Name, @Gender, @Department, @Phone, @Address)", conn);
                sqlCommand.Parameters.AddWithValue("@Name", nameVal.Text);
                sqlCommand.Parameters.AddWithValue("@Gender", genderVal.Text);
                sqlCommand.Parameters.AddWithValue("@Department", departmentVal.Text);
                sqlCommand.Parameters.AddWithValue("@Phone", phoneVal.Text);
                sqlCommand.Parameters.AddWithValue("@Address", addressVal.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Personnel added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                personnelList();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameVal.Text = string.Empty;
            genderVal.Text = string.Empty;
            departmentVal.Text = string.Empty;
            phoneVal.Text = string.Empty;
            addressVal.Text = string.Empty;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (selectedPersonnelId == -1)
            {
                MessageBox.Show("Please select a personnel to delete.");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Personnels WHERE PersonnelId = @PersonnelId", conn);
                sqlCommand.Parameters.AddWithValue("@PersonnelId", selectedPersonnelId);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Personnel deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                personnelList();
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
                if (row.Cells["Name"].Value != null && row.Cells["Name"].Value.ToString().ToLower().Equals(searchValue))
                {
                    row.Selected = true;
                    dataGridView.FirstDisplayedScrollingRowIndex = row.Index;

                    // Seçilen satırdaki değerleri TextBox kontrollerine yükleyin
                    nameVal.Text = row.Cells["Name"].Value.ToString();
                    genderVal.Text = row.Cells["Gender"].Value.ToString();
                    departmentVal.Text = row.Cells["Department"].Value.ToString();
                    phoneVal.Text = row.Cells["Phone"].Value.ToString();
                    addressVal.Text = row.Cells["Address"].Value.ToString();
                    return;
                }
            }

            MessageBox.Show("Personnel not found.");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (selectedPersonnelId == -1)
            {
                MessageBox.Show("Please select a personnel to update.");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Personnels SET Name = @Name, Gender = @Gender, Department = @Department, Phone = @Phone , Address = @Address WHERE PersonnelId = @PersonnelId", conn);
                sqlCommand.Parameters.AddWithValue("@PersonnelId", selectedPersonnelId);
                sqlCommand.Parameters.AddWithValue("@Name", nameVal.Text);
                sqlCommand.Parameters.AddWithValue("@Gender", genderVal.Text);
                sqlCommand.Parameters.AddWithValue("@Department", departmentVal.Text);
                sqlCommand.Parameters.AddWithValue("@Phone", phoneVal.Text);
                sqlCommand.Parameters.AddWithValue("@Address", addressVal.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Personnel updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                personnelList();
            }
        }

        private void PersonnelForm_Load(object sender, EventArgs e)
        {
            personnelList();
            dataGridView.CellClick += dataGridView_CellClick; // CellClick olayını bağlayın
        }
    }
}
