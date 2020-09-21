using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomaciCRUD
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
            
        }
        public frmUpdate(string KupacID, string Naziv, string Kontakt, string Grad, string Zemlja)
        {
            InitializeComponent();
            tbId.Text = KupacID;
            tbNazivUpdate.Text= Naziv;
            tbKontaktUpdate.Text = Kontakt;
            tbGradUpdate.Text = Grad;
            tbZemljaUpdate.Text = Zemlja;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                ClCRUD.ClsDataAccess x = new ClCRUD.ClsDataAccess();
                if (tbId.Text != "" && tbNazivUpdate.Text !="" && tbKontaktUpdate.Text != "" && tbGradUpdate.Text != "" && tbZemljaUpdate.Text != "")
                { 
                x.KlijentiUpdate(Convert.ToInt32(tbId.Text), tbNazivUpdate.Text, tbKontaktUpdate.Text, tbGradUpdate.Text, tbZemljaUpdate.Text);
                MessageBox.Show("You added a client!");
                this.Close();
                }
                else
                {
                    MessageBox.Show("Fill all fields!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Something gone wrong... You didn't add a client.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
