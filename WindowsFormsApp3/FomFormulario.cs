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
    public partial class FomFormulario : Form
    {
        public static FomFormulario Instancia { get; } = new FomFormulario();

        public FomFormulario()
        {
            InitializeComponent();
        }

        private void FomFormulario_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FomPantallaPrincipal.Instancia.Show();
        }
    }
}
