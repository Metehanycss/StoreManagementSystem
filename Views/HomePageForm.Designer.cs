namespace MarketYönetimSistemi.Views
{
    partial class HomePageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            label1 = new Label();
            productButton = new Button();
            supplierButton = new Button();
            personnelButton = new Button();
            customerButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(-1, 95);
            label1.Name = "label1";
            label1.Size = new Size(1170, 118);
            label1.TabIndex = 1;
            label1.Text = "MARKET YÖNETİM SİSTEMİ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // productButton
            // 
            productButton.BackColor = Color.Navy;
            productButton.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            productButton.ForeColor = SystemColors.ControlLightLight;
            productButton.Location = new Point(119, 261);
            productButton.Name = "productButton";
            productButton.Size = new Size(315, 107);
            productButton.TabIndex = 2;
            productButton.Text = "Ürünler";
            productButton.UseVisualStyleBackColor = false;
            productButton.Click += productButton_Click;
            // 
            // supplierButton
            // 
            supplierButton.BackColor = Color.Navy;
            supplierButton.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            supplierButton.ForeColor = SystemColors.ControlLightLight;
            supplierButton.Location = new Point(692, 406);
            supplierButton.Name = "supplierButton";
            supplierButton.Size = new Size(315, 107);
            supplierButton.TabIndex = 3;
            supplierButton.Text = "Tedarikçiler";
            supplierButton.UseVisualStyleBackColor = false;
            supplierButton.Click += supplierButton_Click;
            // 
            // personnelButton
            // 
            personnelButton.BackColor = Color.Navy;
            personnelButton.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            personnelButton.ForeColor = SystemColors.ControlLightLight;
            personnelButton.Location = new Point(119, 406);
            personnelButton.Name = "personnelButton";
            personnelButton.Size = new Size(315, 107);
            personnelButton.TabIndex = 4;
            personnelButton.Text = "Personeller";
            personnelButton.UseVisualStyleBackColor = false;
            personnelButton.Click += personnelButton_Click;
            // 
            // customerButton
            // 
            customerButton.BackColor = Color.Navy;
            customerButton.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            customerButton.ForeColor = SystemColors.ControlLightLight;
            customerButton.Location = new Point(692, 261);
            customerButton.Name = "customerButton";
            customerButton.Size = new Size(315, 107);
            customerButton.TabIndex = 5;
            customerButton.Text = "Cariler";
            customerButton.UseVisualStyleBackColor = false;
            customerButton.Click += customerButton_Click;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1167, 693);
            Controls.Add(customerButton);
            Controls.Add(personnelButton);
            Controls.Add(supplierButton);
            Controls.Add(productButton);
            Controls.Add(label1);
            Name = "HomePageForm";
            Text = "HomePageForm";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button productButton;
        private Button supplierButton;
        private Button personnelButton;
        private Button customerButton;
    }
}