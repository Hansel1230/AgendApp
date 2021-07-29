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
    public partial class FomFormulario : Form
    {
        public int? oldIndex { get; set; } = null;

        #region Instancia de clase
        public static FomFormulario Instancia { get; } = new FomFormulario();

        //Objeto de ContactService
        private ContactService contactService;
        #endregion

        public bool isvalid = true;

        //Carga del formulario
        public FomFormulario()
        {
            InitializeComponent();
            contactService = new ContactService();
        }

        private void FomFormulario_Load(object sender, EventArgs e)
        {
            fullTxt();
            FomPantallaPrincipal.Instancia.LoadData();
        }

        #region Events/Mantenimiento Txt
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
        private void TxtAddress_Click(object sender, EventArgs e)
        {
            if (TxtAddress.Text == "Enter Address")
            {
                TxtAddress.Text = "";
            }
        }
        private void TxtAddress_Leave(object sender, EventArgs e)
        {
            if (TxtAddress.Text == "")
            {
                TxtAddress.Text = "Enter Address";
            }
        }
        private void TxtPersonalPhone_Click(object sender, EventArgs e)
        {
            if (TxtPersonalPhone.Text == "Enter Personal Phone")
            {
                TxtPersonalPhone.Text = "";
            }
        }    
        private void TxtPersonalPhone_Leave(object sender, EventArgs e)
        {
            if (TxtPersonalPhone.Text == "")
            {
                TxtPersonalPhone.Text = "Enter Personal Phone";
            }
        }
        private void TxtWorkPhone_Click(object sender, EventArgs e)
        {
            if (TxtWorkPhone.Text == "Enter Work Phone")
            {
                TxtWorkPhone.Text = "";
            }
        }
        private void TxtWorkPhone_Leave(object sender, EventArgs e)
        {
            if (TxtWorkPhone.Text == "")
            {
                TxtWorkPhone.Text = "Enter Work Phone" ;
            }
        }
        private void LblPersonalphone_Click(object sender, EventArgs e)
        {

        } 
        #endregion
        #region Validacion BtnAdd
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            isvalid = true;
            if (string.IsNullOrEmpty(TxtName.Text) || (TxtName.Text == "Enter Name"))
            {
                MessageBox.Show("Enter Name please!! ", "Warning");
                isvalid = false;
            }
            else if (string.IsNullOrEmpty(TxtLastName.Text) || (TxtLastName.Text == "Enter LastName"))
            {
                MessageBox.Show("Enter LastName please!! ", "Advertence");
                isvalid = false;
            }
            else if (string.IsNullOrEmpty(TxtAddress.Text) || (TxtAddress.Text == "Enter Address"))
            {
                MessageBox.Show("Enter Address please!! ", "Warning");
                isvalid = false;
            }
            else if (string.IsNullOrEmpty(TxtPersonalPhone.Text) || (TxtPersonalPhone.Text == "Enter Personal Phone"))
            {
                MessageBox.Show("Enter Personal Phone please!! ", "Warning");
                isvalid = false;
            }
            else if (string.IsNullOrEmpty(TxtWorkPhone.Text) || (TxtWorkPhone.Text == "Enter Work Phone"))
            {
                MessageBox.Show("Enter WorkPhone please!! ", "Warning");
                isvalid = false;
            }
            
            
            if (isvalid)
            {
                AddContact();
                Instancia.Hide();
                FomPantallaPrincipal.Instancia.Show();
                fullTxt();
            }
            #endregion
        }

        #region Methods
        public void fullTxt()
        {
            TxtName.Text = "Enter Name";
            TxtLastName.Text = "Enter LastName";
            TxtAddress.Text = "Enter Address";
            TxtWorkPhone.Text = "Enter Work Phone";
            TxtPersonalPhone.Text = "Enter Personal Phone";
        }
        public void ClearTxt()
        {
            TxtName.Clear();
            TxtLastName.Clear();
            TxtPersonalPhone.Clear();
            TxtWorkPhone.Clear();
            TxtAddress.Clear();
        }
        public void AddContact()
        {
            Contact contact;

            if (oldIndex != null)
            {
                contact = contactService.Getitem((int)oldIndex);
                contact.Name = TxtName.Text;
                contact.LastName = TxtLastName.Text;
                contact.Address = TxtAddress.Text;
                contact.PersonalPhone = TxtPersonalPhone.Text;
                contact.WorkPhone = TxtWorkPhone.Text;
                contactService.Edit((int)oldIndex, contact);
                oldIndex = null;
            }
            else
            {
                contact = new Contact();
                contact.Name = TxtName.Text;
                contact.LastName = TxtLastName.Text;
                contact.Address = TxtAddress.Text;
                contact.PersonalPhone = TxtPersonalPhone.Text;
                contact.WorkPhone = TxtWorkPhone.Text;
                contactService.add(contact);
            }              
           
            MessageBox.Show("Success", "Notification");
            FomPantallaPrincipal.Instancia.LoadData();
        }
        public void EditContact(int index)
        {
            Contact contact = contactService.Getitem(index);
            TxtName.Text = contact.Name;
            TxtLastName.Text = contact.LastName;
            TxtAddress.Text = contact.Address;
            TxtPersonalPhone.Text = contact.PersonalPhone;
            TxtWorkPhone.Text = contact.WorkPhone;
            oldIndex = index;
        }
        public void FullProp(int? index)
        {
            Contact contact = new Contact();
            contact = ContactService.Instancia.Getitem(index.Value);
            TxtName.Text = contact.Name;
            TxtLastName.Text = contact.LastName;
            TxtAddress.Text = contact.Address;
            TxtPersonalPhone.Text = contact.PersonalPhone;
            TxtWorkPhone.Text = contact.WorkPhone;            
        }
        #endregion

        private void FomFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
