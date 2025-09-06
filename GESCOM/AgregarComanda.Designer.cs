namespace WinFormsApp2
{
    partial class AgregarComanda
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            label5 = new Label();
            comboBox3 = new ComboBox();
            button3 = new Button();
            label4 = new Label();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            textBox3 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            button5 = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(236, 232, 221);
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.82997751F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.17002F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 304F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label6, 3, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.5686283F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.43137F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.Size = new Size(734, 461);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(236, 232, 221);
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 25F);
            label6.Location = new Point(412, 0);
            label6.Name = "label6";
            label6.Size = new Size(298, 95);
            label6.TabIndex = 4;
            label6.Text = "Listado del pedido";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(236, 232, 221);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(33, 0);
            label1.Name = "label1";
            label1.Size = new Size(354, 95);
            label1.TabIndex = 0;
            label1.Text = "Agregar Comanda";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 232, 221);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(33, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 341);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F);
            button4.ImageAlign = ContentAlignment.TopRight;
            button4.Location = new Point(246, 190);
            button4.Name = "button4";
            button4.Size = new Size(86, 32);
            button4.TabIndex = 22;
            button4.Text = "Agregar";
            button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(37, 165);
            label5.Name = "label5";
            label5.Size = new Size(60, 21);
            label5.TabIndex = 21;
            label5.Text = "Bebida:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Elegir Bebida" });
            comboBox3.Location = new Point(37, 197);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(203, 23);
            comboBox3.TabIndex = 20;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F);
            button3.ImageAlign = ContentAlignment.TopRight;
            button3.Location = new Point(246, 125);
            button3.Name = "button3";
            button3.Size = new Size(86, 32);
            button3.TabIndex = 19;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(37, 104);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 18;
            label4.Text = "Comida:";
            label4.Click += label4_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Elegir Comida" });
            comboBox2.Location = new Point(37, 132);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(203, 23);
            comboBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(227, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(62, 29);
            textBox1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBox1.Location = new Point(176, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(64, 23);
            comboBox1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(37, 60);
            label3.Name = "label3";
            label3.Size = new Size(184, 21);
            label3.TabIndex = 14;
            label3.Text = "Cantidad de Comensales:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(37, 26);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 13;
            label2.Text = "Numero de Mesa:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox3);
            panel2.Location = new Point(37, 226);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 59);
            panel2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(0, 0);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Comentario";
            textBox3.Size = new Size(293, 57);
            textBox3.TabIndex = 11;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(188, 291);
            button2.Name = "button2";
            button2.Size = new Size(144, 37);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(25, 291);
            button1.Name = "button1";
            button1.Size = new Size(145, 37);
            button1.TabIndex = 7;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button5);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(412, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(298, 341);
            panel3.TabIndex = 5;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F);
            button5.ImageAlign = ContentAlignment.TopRight;
            button5.Location = new Point(101, 294);
            button5.Name = "button5";
            button5.Size = new Size(86, 32);
            button5.TabIndex = 23;
            button5.Text = "Quitar";
            button5.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(16, 229);
            label14.Name = "label14";
            label14.Size = new Size(139, 21);
            label14.TabIndex = 21;
            label14.Text = "Ejemplo Bebida 11";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(16, 195);
            label13.Name = "label13";
            label13.Size = new Size(130, 21);
            label13.TabIndex = 20;
            label13.Text = "Ejemplo Bebida 9";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(16, 165);
            label12.Name = "label12";
            label12.Size = new Size(130, 21);
            label12.TabIndex = 19;
            label12.Text = "Ejemplo Bebida 6";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(16, 134);
            label11.Name = "label11";
            label11.Size = new Size(130, 21);
            label11.TabIndex = 18;
            label11.Text = "Ejemplo Bebida 2";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(16, 104);
            label10.Name = "label10";
            label10.Size = new Size(137, 21);
            label10.TabIndex = 17;
            label10.Text = "Ejemplo Comida 5";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(16, 76);
            label9.Name = "label9";
            label9.Size = new Size(137, 21);
            label9.TabIndex = 16;
            label9.Text = "Ejemplo Comida 6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(16, 45);
            label8.Name = "label8";
            label8.Size = new Size(137, 21);
            label8.TabIndex = 15;
            label8.Text = "Ejemplo Comida 8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(16, 13);
            label7.Name = "label7";
            label7.Size = new Size(137, 21);
            label7.TabIndex = 14;
            label7.Text = "Ejemplo Comida 1";
            // 
            // AgregarComanda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 461);
            Controls.Add(tableLayoutPanel1);
            Name = "AgregarComanda";
            Text = "AgregarComanda";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label4;
        private ComboBox comboBox2;
        private Button button3;
        private Button button4;
        private Label label5;
        private ComboBox comboBox3;
        private Panel panel3;
        private Label label7;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button button5;
        private Label label14;
        private Label label13;
    }
}