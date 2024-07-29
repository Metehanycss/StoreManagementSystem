namespace MarketYönetimSistemi.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            emailVal = new TextBox();
            label4 = new Label();
            passwordVal = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(2, 94);
            label1.Name = "label1";
            label1.Size = new Size(1170, 118);
            label1.TabIndex = 0;
            label1.Text = "MARKET YÖNETİM SİSTEMİ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(286, 269);
            label2.Name = "label2";
            label2.Size = new Size(122, 38);
            label2.TabIndex = 1;
            label2.Text = "E -Posta:";
            // 
            // emailVal
            // 
            emailVal.Font = new Font("Segoe UI", 14F);
            emailVal.Location = new Point(451, 268);
            emailVal.Name = "emailVal";
            emailVal.Size = new Size(316, 39);
            emailVal.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(309, 346);
            label4.Name = "label4";
            label4.Size = new Size(99, 38);
            label4.TabIndex = 4;
            label4.Text = "Parola:";
            // 
            // passwordVal
            // 
            passwordVal.Font = new Font("Segoe UI", 14F);
            passwordVal.Location = new Point(451, 345);
            passwordVal.Name = "passwordVal";
            passwordVal.Size = new Size(316, 39);
            passwordVal.TabIndex = 5;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            loginButton.Location = new Point(560, 412);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(207, 75);
            loginButton.TabIndex = 6;
            loginButton.Text = "Giriş Yap";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1167, 693);
            Controls.Add(loginButton);
            Controls.Add(passwordVal);
            Controls.Add(label4);
            Controls.Add(emailVal);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox emailVal;
        private Label label4;
        private TextBox passwordVal;
        private Button loginButton;
    }
}