﻿namespace WinFormsApp2
{
    partial class GestionMenu
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
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnVolver = new Button();
            btnEliminarComida = new Button();
            btnAgregarComida = new Button();
            btnEditarComida = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            dataGridView4 = new DataGridView();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            btnVolver2 = new Button();
            btnEliminarBebida = new Button();
            btnAgregarBebida = new Button();
            btnEditarBebida = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(36, 5);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 125);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(176, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 81);
            label1.TabIndex = 1;
            label1.Text = "Comidas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 232, 230);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnEliminarComida);
            panel1.Controls.Add(btnAgregarComida);
            panel1.Controls.Add(btnEditarComida);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(36, 919);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 92);
            panel1.TabIndex = 5;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(485, 27);
            btnVolver.Margin = new Padding(4, 5, 6, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(89, 38);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminarComida
            // 
            btnEliminarComida.Location = new Point(327, 27);
            btnEliminarComida.Margin = new Padding(4, 5, 4, 5);
            btnEliminarComida.Name = "btnEliminarComida";
            btnEliminarComida.Size = new Size(89, 38);
            btnEliminarComida.TabIndex = 5;
            btnEliminarComida.Text = "Eliminar";
            btnEliminarComida.UseVisualStyleBackColor = true;
            // 
            // btnAgregarComida
            // 
            btnAgregarComida.Location = new Point(17, 27);
            btnAgregarComida.Margin = new Padding(6, 5, 4, 5);
            btnAgregarComida.Name = "btnAgregarComida";
            btnAgregarComida.Size = new Size(89, 38);
            btnAgregarComida.TabIndex = 3;
            btnAgregarComida.Text = "Agregar";
            btnAgregarComida.UseVisualStyleBackColor = true;
            // 
            // btnEditarComida
            // 
            btnEditarComida.Location = new Point(176, 27);
            btnEditarComida.Margin = new Padding(4, 5, 4, 5);
            btnEditarComida.Name = "btnEditarComida";
            btnEditarComida.Size = new Size(79, 38);
            btnEditarComida.TabIndex = 4;
            btnEditarComida.Text = "Editar";
            btnEditarComida.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Nombre, Descripcion, Precio });
            dataGridView1.Location = new Point(36, 140);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(682, 769);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 8;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 150;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 8;
            Precio.Name = "Precio";
            Precio.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(4, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(24, 135);
            label2.TabIndex = 7;
            label2.Text = "Gestion De Menú";
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(1091, 5);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(680, 125);
            panel4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 30F);
            label4.Location = new Point(236, 25);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(241, 81);
            label4.TabIndex = 1;
            label4.Text = "Bebidas";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.Location = new Point(1091, 140);
            dataGridView4.Margin = new Padding(4, 5, 4, 5);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.Size = new Size(680, 769);
            dataGridView4.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "id";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Nombre";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Descripcion";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Precio";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.Width = 150;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(236, 232, 221);
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.4404974F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.5595F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 365F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 688F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Controls.Add(panel3, 3, 2);
            tableLayoutPanel1.Controls.Add(dataGridView4, 3, 1);
            tableLayoutPanel1.Controls.Add(panel4, 3, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8531952F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.1468048F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new Size(1806, 1050);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(236, 232, 230);
            panel3.Controls.Add(btnVolver2);
            panel3.Controls.Add(btnEliminarBebida);
            panel3.Controls.Add(btnAgregarBebida);
            panel3.Controls.Add(btnEditarBebida);
            panel3.Location = new Point(1091, 919);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(680, 92);
            panel3.TabIndex = 7;
            // 
            // btnVolver2
            // 
            btnVolver2.Location = new Point(485, 27);
            btnVolver2.Margin = new Padding(4, 5, 6, 5);
            btnVolver2.Name = "btnVolver2";
            btnVolver2.Size = new Size(89, 38);
            btnVolver2.TabIndex = 6;
            btnVolver2.Text = "Volver";
            btnVolver2.UseVisualStyleBackColor = true;
            // 
            // btnEliminarBebida
            // 
            btnEliminarBebida.Location = new Point(327, 27);
            btnEliminarBebida.Margin = new Padding(4, 5, 4, 5);
            btnEliminarBebida.Name = "btnEliminarBebida";
            btnEliminarBebida.Size = new Size(89, 38);
            btnEliminarBebida.TabIndex = 5;
            btnEliminarBebida.Text = "Eliminar";
            btnEliminarBebida.UseVisualStyleBackColor = true;
            // 
            // btnAgregarBebida
            // 
            btnAgregarBebida.Location = new Point(17, 27);
            btnAgregarBebida.Margin = new Padding(6, 5, 4, 5);
            btnAgregarBebida.Name = "btnAgregarBebida";
            btnAgregarBebida.Size = new Size(89, 38);
            btnAgregarBebida.TabIndex = 3;
            btnAgregarBebida.Text = "Agregar";
            btnAgregarBebida.UseVisualStyleBackColor = true;
            // 
            // btnEditarBebida
            // 
            btnEditarBebida.Location = new Point(176, 27);
            btnEditarBebida.Margin = new Padding(4, 5, 4, 5);
            btnEditarBebida.Name = "btnEditarBebida";
            btnEditarBebida.Size = new Size(79, 38);
            btnEditarBebida.TabIndex = 4;
            btnEditarBebida.Text = "Editar";
            btnEditarBebida.UseVisualStyleBackColor = true;
            // 
            // GestionMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1806, 1050);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionMenu";
            Text = "GestionMenu";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button btnVolver;
        private Button btnEliminarComida;
        private Button btnAgregarComida;
        private Button btnEditarComida;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private Label label2;
        private Panel panel4;
        private Label label4;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnEliminarBebida;
        private Button btnAgregarBebida;
        private Button btnEditarBebida;
        private Button btnVolver2;
    }
}