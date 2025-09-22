using capaEntidad;
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
    public partial class GestionMenu : Form
    {
        private Usuario usuarioActual;
        public GestionMenu(Usuario user)
        {
            InitializeComponent();
            usuarioActual = user;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            GestionInformes main = new GestionInformes(usuarioActual);
            main.WindowState = FormWindowState.Maximized;
            main.Show();


        }

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            this.Close();
            GestionInformes main = new GestionInformes(usuarioActual);
            main.WindowState = FormWindowState.Maximized;
            main.Show();
        }
    }
}
