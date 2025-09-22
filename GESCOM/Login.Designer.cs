namespace WinFormsApp2
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            bindingSource1 = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            txtContrasenia = new TextBox();
            txtNombreUsuario = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Center;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.32041F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.67959F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 551F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.3866425F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.61336F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 185F));
            tableLayoutPanel1.Size = new Size(1806, 1050);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtContrasenia);
            panel2.Controls.Add(txtNombreUsuario);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(597, 181);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(647, 678);
            panel2.TabIndex = 3;
            // 
            // txtContrasenia
            // 
            txtContrasenia.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenia.Font = new Font("Segoe UI", 12F);
            txtContrasenia.Location = new Point(100, 205);
            txtContrasenia.Margin = new Padding(4, 5, 4, 5);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PlaceholderText = "  Contraseña";
            txtContrasenia.Size = new Size(461, 39);
            txtContrasenia.TabIndex = 2;
            txtContrasenia.UseSystemPasswordChar = true;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.Font = new Font("Segoe UI", 12F);
            txtNombreUsuario.Location = new Point(100, 156);
            txtNombreUsuario.Margin = new Padding(9, 5, 4, 5);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "  Nombre de Usuario";
            txtNombreUsuario.Size = new Size(461, 39);
            txtNombreUsuario.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(100, 279);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(461, 52);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Acceder";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, -181);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(461, 312);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 232, 221);
            ClientSize = new Size(1806, 1050);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            Text = "Inicio Sesion";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bindingSource1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtContrasenia;
        private TextBox txtNombreUsuario;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}
