﻿using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp2
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();
            string confirmar = txtConfirmarContrasenia.Text.Trim();

            usuarioNegocio negocio = new usuarioNegocio();

            if (negocio.CrearUsuario(nombreUsuario, contrasenia, confirmar, out string mensaje))
            {
                MessageBox.Show("✅ Usuario creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Para refrescar dgv al volver
                this.Close();
            }
            else
            {
                MessageBox.Show("❌ " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
