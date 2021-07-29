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

namespace WindowsFormsApp3
{
    public partial class FomRegister : Form
    {
        #region Instancia
        public static FomRegister Instancia { get; } = new FomRegister();
        #endregion

        public bool isvalid = true;

        public FomRegister()
        {
            InitializeComponent();
        }

        #region Events/Mantenimiento Txt
        private void FomRegister_Load(object sender, EventArgs e)
        {
            fullTxt();
            TxtName.Focus();
            
        }
        private void TxtName_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "Enter Name")
            {
                TxtName.Text = "";
            }
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            if (TxtName.Text == "")
            {
                TxtName.Text = "Enter Name";
            }
        }
        private void TxtLastName_Click(object sender, EventArgs e)
        {
            if (TxtLastName.Text == "Enter LastName")
            {
                TxtLastName.Text = "";
            }
        }
        private void TxtLastName_Leave(object sender, EventArgs e)
        {
            if (TxtLastName.Text == "")
            {
                TxtLastName.Text = "Enter LastName";
            }
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
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        #region Validacion BtnRegister
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            isvalid = true;
            if (string.IsNullOrEmpty(TxtName.Text) || (TxtName.Text == "Enter Name"))
            {
                MessageBox.Show("Enter Name please!! ", "Warning");
                isvalid = false;
            }
            else if (string.IsNullOrEmpty(TxtLastName.Text) || (TxtLastName.Text == "Enter LastName"))
            {
                MessageBox.Show("Enter LastName please!! ", "Warning");
                isvalid = false;
            }
            else if (string.IsNullOrEmpty(TxtUserName.Text) || (TxtUserName.Text == "Enter UserName"))
            {
                MessageBox.Show("Enter UserName please!! ", "Warning");
                isvalid = false;
            }
            else if (string.IsNullOrEmpty(TxtPassword.Text) || (TxtPassword.Text == "Enter Password"))
            {
                MessageBox.Show("Enter Password please!! ", "Warning");
                isvalid = false;
            }
            if (isvalid)
            {
                /*string direccion = TxtUserName.Text;
                string fullDireccion = direccion + "/" + "pass.txt";
                // Register here
                if (!Directory.Exists(direccion))
                {
                    Directory.CreateDirectory(direccion);
                    File.Create(fullDireccion);
                    StreamWriter sw = new StreamWriter(fullDireccion);
                    sw.WriteLine(TxtPassword.Text);
                    sw.Close();
                    File.SetAttributes(fullDireccion, FileAttributes.Hidden);
                }*/

                MessageBox.Show("Success", "Notification");
                Instancia.Hide();
                FomPantallaPrincipal.Instancia.Show();
                ClearTxt();
            }
            #endregion
        }
     
        #region Methods

        public void fullTxt()
        {
            TxtName.Text = "Enter Name";
            TxtLastName.Text = "Enter LastName";
            TxtUserName.Text = "Enter UserName";
            TxtPassword.Text = "Enter Password";
        }
        public void ClearTxt()
        {
            TxtName.Clear();
            TxtLastName.Clear();
            TxtUserName.Clear();
            TxtPassword.Clear();
        }
        #endregion

        private void FomRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
