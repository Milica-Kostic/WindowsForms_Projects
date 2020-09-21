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
    public partial class frmInsertcs : Form
    {
        public frmInsertcs()
        {
            InitializeComponent();
        }

        private void btnCancelInsert_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertK_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (tbNazivInsert.Text.Trim() != "" && tbkontaktInsert.Text.Trim() != "" && tbGradInsert.Text.Trim() != "" && tbZemljaInsert.Text.Trim() != "")
                { 
                ClCRUD.ClsDataAccess x = new ClCRUD.ClsDataAccess();
                x.KlijentiInsert(tbNazivInsert.Text,tbkontaktInsert.Text,tbGradInsert.Text,tbZemljaInsert.Text);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
