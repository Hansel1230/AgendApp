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
    public partial class FomLogin : Form
    {
        public static FomLogin Instancia { get; } = new FomLogin();

        public FomLogin()
        {
            InitializeComponent();
        }

        private void FomLogin_Load(object sender, EventArgs e)
        {

        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FomPantallaPrincipal.Instancia.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FomRegister.Instancia.Show();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {

        }        
    }
}
