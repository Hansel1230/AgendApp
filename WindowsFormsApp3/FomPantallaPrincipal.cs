using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace WindowsFormsApp3
{
    public partial class FomPantallaPrincipal : Form
    {
        public int? index=null;
        
        #region Instancia
        public static FomPantallaPrincipal Instancia { get; } = new FomPantallaPrincipal();
        
        private ContactService contactService;
        #endregion

        public FomPantallaPrincipal()
        {
            InitializeComponent();
            contactService = new ContactService();
        }

        #region Events
        private void FomPantallaPrincipal_Load(object sender, EventArgs e)
        {           
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
            FomFormulario.Instancia.fullTxt();     
        }
        
        private void DgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
        }
        private void DgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                BtnEdit.Visible = true;
                BtnDelete.Visible = true;
                BtnDeselect.Visible = true;
                
                FomFormulario.Instancia.FullProp(index);
            }
            
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (index == null)
            {
                MessageBox.Show("Select Contact please", "Warning");
            }
            else
            {
                DialogResult response = MessageBox.Show("Are you sure to Edit the contact?", "Warning", MessageBoxButtons.OKCancel);
                if (response == DialogResult.OK)
                {
                    FomFormulario.Instancia.EditContact(index.Value);

                    FomFormulario.Instancia.Show();
                }
            }

        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }
        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }
        #endregion

        #region Methods
        public void LoadData()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ContactService.Instancia.GetAll();
            DgvContacts.DataSource = bindingSource;
            Deselect();
        }
        private void Deselect()
        {
            DgvContacts.ClearSelection();
            BtnDeselect.Visible = false;
            BtnEdit.Visible = false;
            BtnDelete.Visible = false;
        }
        private void DeleteContact()
        {
            if (index == null)
            {
                MessageBox.Show("Select Contact please", "Warning");
            }
            else
            {
                DialogResult response = MessageBox.Show("Are you sure to the delete contact?", "Warning",MessageBoxButtons.OKCancel);
                if (response == DialogResult.OK)
                {
                    ContactService.Instancia.Delelte(index.Value);
                    LoadData();
                    Deselect();
                }
            }
        }

        #endregion

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
