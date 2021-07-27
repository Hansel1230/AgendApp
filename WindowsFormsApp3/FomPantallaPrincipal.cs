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
        private void FomPantallaPrincipal_Load(object sender, EventArgs e)
        {
            Instancia.Hide();
        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            Instancia.Hide();
            FomLogin.Instancia.Fulltxt();
            FomLogin.Instancia.Show();
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FomFormulario.Instancia.Show();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
           // Instancia.Hide();
            //FomFormulario.Instancia.Show();
        }

        private void DgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*public void LoadData()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = FomFormulario.Instancia.contact.GetAll();
            btn
        }
        */
    }
}
