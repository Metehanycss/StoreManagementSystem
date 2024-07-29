namespace MarketYönetimSistemi.Views
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            dataGridView = new DataGridView();
            addButton = new Button();
            updateButton = new Button();
            clearButton = new Button();
            deleteButton = new Button();
            groupBox1 = new GroupBox();
            price = new TextBox();
            label3 = new Label();
            department = new TextBox();
            label2 = new Label();
            name = new TextBox();
            label1 = new Label();
            backButton = new Button();
            searchBox2 = new GroupBox();
            searchButton = new Button();
            searchVal = new TextBox();
            label5 = new Label();
            description = new RichTextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            searchBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(234, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(697, 401);
            dataGridView.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Navy;
            addButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            addButton.ForeColor = SystemColors.ControlLightLight;
            addButton.Location = new Point(12, 179);
            addButton.Name = "addButton";
            addButton.Size = new Size(201, 107);
            addButton.TabIndex = 3;
            addButton.Text = "Ekle";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.Navy;
            updateButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            updateButton.ForeColor = SystemColors.ControlLightLight;
            updateButton.Location = new Point(12, 306);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(201, 107);
            updateButton.TabIndex = 4;
            updateButton.Text = "Güncelle";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Navy;
            clearButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            clearButton.ForeColor = SystemColors.ControlLightLight;
            clearButton.Location = new Point(954, 306);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(201, 107);
            clearButton.TabIndex = 5;
            clearButton.Text = "Temizle";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Navy;
            deleteButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            deleteButton.ForeColor = SystemColors.ControlLightLight;
            deleteButton.Location = new Point(954, 179);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(201, 107);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Sil";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(description);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(price);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(department);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(794, 419);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 270);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // price
            // 
            price.Location = new Point(131, 99);
            price.Name = "price";
            price.Size = new Size(204, 27);
            price.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(15, 98);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 4;
            label3.Text = "Fiyat:";
            // 
            // department
            // 
            department.Location = new Point(131, 65);
            department.Name = "department";
            department.Size = new Size(204, 27);
            department.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(15, 65);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 2;
            label2.Text = "Departman:";
            // 
            // name
            // 
            name.Location = new Point(131, 30);
            name.Name = "name";
            name.Size = new Size(204, 27);
            name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(15, 32);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "İsim:";
            // 
            // backButton
            // 
            backButton.BackColor = Color.Olive;
            backButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            backButton.ForeColor = SystemColors.ControlLightLight;
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(201, 107);
            backButton.TabIndex = 8;
            backButton.Text = "Geri";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // searchBox2
            // 
            searchBox2.Controls.Add(searchButton);
            searchBox2.Controls.Add(searchVal);
            searchBox2.Controls.Add(label5);
            searchBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            searchBox2.Location = new Point(49, 572);
            searchBox2.Name = "searchBox2";
            searchBox2.Size = new Size(614, 117);
            searchBox2.TabIndex = 9;
            searchBox2.TabStop = false;
            searchBox2.Text = "Ara";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(0, 64, 0);
            searchButton.ForeColor = Color.Transparent;
            searchButton.Location = new Point(394, 36);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(191, 73);
            searchButton.TabIndex = 4;
            searchButton.Text = "Arama";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchVal
            // 
            searchVal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            searchVal.Location = new Point(101, 50);
            searchVal.Name = "searchVal";
            searchVal.Size = new Size(287, 43);
            searchVal.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(16, 50);
            label5.Name = "label5";
            label5.Size = new Size(79, 41);
            label5.TabIndex = 2;
            label5.Text = "İsim:";
            // 
            // description
            // 
            description.BackColor = SystemColors.Window;
            description.Location = new Point(129, 131);
            description.Name = "description";
            description.Size = new Size(206, 120);
            description.TabIndex = 7;
            description.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(15, 131);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 6;
            label4.Text = "Açıklama:";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1167, 693);
            Controls.Add(searchBox2);
            Controls.Add(backButton);
            Controls.Add(groupBox1);
            Controls.Add(deleteButton);
            Controls.Add(clearButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(dataGridView);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            searchBox2.ResumeLayout(false);
            searchBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button addButton;
        private Button updateButton;
        private Button clearButton;
        private Button deleteButton;
        private GroupBox groupBox1;
        private TextBox price;
        private Label label3;
        private TextBox department;
        private Label label2;
        private TextBox name;
        private Label label1;
        private Button backButton;
        private GroupBox searchBox2;
        private Button searchButton;
        private TextBox searchVal;
        private Label label5;
        private RichTextBox description;
        private Label label4;
    }
}