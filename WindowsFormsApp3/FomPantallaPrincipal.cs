using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FomPantallaPrincipal : Form
    {
        public static FomPantallaPrincipal Instancia { get; } = new FomPantallaPrincipal();

        public FomPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hola","Saludo");
            Instancia.Hide();
            FomLogin.Instancia.Show();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FomFormulario.Instancia.Show();
        }
    }
}
