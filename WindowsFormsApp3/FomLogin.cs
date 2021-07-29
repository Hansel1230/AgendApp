using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
 

namespace WindowsFormsApp3
{
    public sealed partial class FomLogin : Form
    {
        #region Instancia
        public static FomLogin Instancia { get; } = new FomLogin();
        #endregion

        public bool isvalid = true;

        private FomLogin()
        {
            InitializeComponent();
        }

        #region Events/Mantenimiento Txt

        private void FomLogin_Load(object sender, EventArgs e)
        {
            Fulltxt();
        }
        private void TxtUserName_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "Enter UserName")
            {
                TxtUserName.Text = "";
            }
        }
        private void TxtUserName_Leave(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "")
            {
                TxtUserName.Text = "Enter UserName";
            }
        }
        private void TxtPassword_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "Enter Password")
            {
                TxtPassword.Text = "";
            }
        }    
        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = "Enter Password";
            }
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {            
            Instancia.Hide();
            FomRegister.Instancia.Show();
            FomRegister.Instancia.fullTxt();
            Fulltxt();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        #region Validacion BtnLogin
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            isvalid = true;
            if (string.IsNullOrEmpty(TxtUserName.Text) || (TxtUserName.Text == "Enter UserName"))
            {
                MessageBox.Show("Enter UserName please!! ", "Advertence");
                isvalid = false;
            }
            else if (string.IsNullOrEmpty(TxtPassword.Text) || (TxtPassword.Text == "Enter Password"))
            {
                MessageBox.Show("Enter Password please!! ", "Warning");
                isvalid = false;
            }
            if (isvalid)
            {
                FomPantallaPrincipal.Instancia.Show();
                Instancia.Hide();
                Fulltxt(); 
            }
        }
        #endregion

        #region Methods
        public void Fulltxt()
        {
            TxtUserName.Text = "Enter UserName";
            TxtPassword.Text = "Enter Password";
        }
        #endregion
    }
}
