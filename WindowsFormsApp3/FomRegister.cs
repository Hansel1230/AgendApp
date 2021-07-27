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
    public partial class FomRegister : Form
    {
        public static FomRegister Instancia { get; } = new FomRegister();
        public bool isvalid = true;

        public FomRegister()
        {
            InitializeComponent();
        }
        private void FomRegister_Load(object sender, EventArgs e)
        {
            fullTxt();
            
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

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            isvalid = true;
            if (string.IsNullOrEmpty(TxtName.Text) || (TxtName.Text == "Enter Name"))
            {
                MessageBox.Show("Enter Name please!! ", "Advertence");
                isvalid = false;
            }
            else if (string.IsNullOrEmpty(TxtLastName.Text) || (TxtLastName.Text == "Enter LastName"))
            {
                MessageBox.Show("Enter LastName please!! ", "Advertence");
                isvalid = false;
            }
            else if (string.IsNullOrEmpty(TxtUserName.Text) || (TxtUserName.Text == "Enter UserName"))
            {
                MessageBox.Show("Enter UserName please!! ", "Advertence");
                isvalid = false;
            }
            else if (string.IsNullOrEmpty(TxtPassword.Text) || (TxtPassword.Text == "Enter Password"))
            {
                MessageBox.Show("Enter Password please!! ", "Advertence");
                isvalid = false;
            }
            if (isvalid)
            {
                MessageBox.Show("Success", "Notification");
                Instancia.Hide();
                FomPantallaPrincipal.Instancia.Show();
                ClearTxt();
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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

    }
}
