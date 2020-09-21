using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DomaciCRUD
{
    public partial class frmPocetna : Form
    {
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.ReadOnly = true;
                ClCRUD.ClsDataAccess x = new ClCRUD.ClsDataAccess();
                dataGridView1.DataSource = x.KlijentiSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                frmInsertcs x = new frmInsertcs();
                x.ShowDialog();
                btnRefreshGrid_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string IzabraniKlijentID;
                string IzabraniNaziv;
                string IzabraniKontakt;
                string IzabraniGrad;
                string IzabranaZemlja;
                if (dataGridView1.Columns.Count == 0)
                {
                    MessageBox.Show("Choose a client!");
                    btnRefreshGrid_Click(null, null);
                    return;
                }
                if (dataGridView1.SelectedRows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("You didn't choose a client! ");
                    btnRefreshGrid.Focus();
                    return;
                }
                else
                {
                    IzabraniKlijentID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    IzabraniNaziv = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    IzabraniKontakt = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    IzabraniGrad = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    IzabranaZemlja = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                }
                frmUpdate x = new frmUpdate(IzabraniKlijentID, IzabraniNaziv, IzabraniKontakt, IzabraniGrad, IzabranaZemlja);
                x.ShowDialog();
                btnRefreshGrid_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string izabraniKlijentID;
                if (MessageBox.Show("Are you sure you want to delete a client?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dataGridView1.Columns.Count == 0)
                    {
                        MessageBox.Show("Choose a client!");
                        btnRefreshGrid.Focus();
                        return;
                    }
                    if (dataGridView1.SelectedRows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("You didn't choose a client!");
                        btnRefreshGrid.Focus();
                        return;
                    }
                    else
                    {
                        izabraniKlijentID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    }
                    ClCRUD.ClsDataAccess x = new ClCRUD.ClsDataAccess();
                    x.KlijentiDelete(Convert.ToInt32(izabraniKlijentID));
                    MessageBox.Show("Client is deleted!");
                    btnRefreshGrid_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }   
    
}
