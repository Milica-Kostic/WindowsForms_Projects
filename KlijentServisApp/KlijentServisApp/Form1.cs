using ADO.NETEntityCodeFirst.DBModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NETEntityCodeFirst
{
    public partial class Form1 : Form
    {
        Models db = new Models();
        public Form1()
        {
            InitializeComponent();
        }
        public void ClearKlijent()
        {
            txtKlijentID.Text = string.Empty;
            txtNazivKlijenta.Text= string.Empty;
            txtRegistarskiBroj.Text = string.Empty;
            txtKontakt.Text = string.Empty;
            txtKomentar.Text = string.Empty;
        }
        public void ClearServis()
        {
            txtServisID.Text = string.Empty;
            cbKlijentFk.Text = string.Empty;
            dpServisa.Text = string.Empty;
            txtTipUsluge.Text = string.Empty;
        }
        private void btnGetKlijente_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                GridKlijenti.DataSource = db.klijenti.ToList<Klijent>();
                GridKlijenti.Columns[5].Visible = false;
                Cursor = Cursors.Default;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGetServise_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                GridServisi.DataSource = db.servisi.ToList<Servis>();
                GridServisi.Columns[4].Visible = false;
                Cursor = Cursors.Default;
                cbKlijentFk.DataSource = db.klijenti.ToList<Klijent>();
                cbKlijentFk.ValueMember = "Id";
                cbKlijentFk.DisplayMember = "NazivKlijenta";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
}

        private void btnCreateKlijent_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNazivKlijenta.Text.Trim() != "" && txtRegistarskiBroj.Text.Trim() != "" && txtKontakt.Text.Trim() != "" && txtKomentar.Text.Trim() != "")
                {
                    Klijent klijent = new Klijent
                    {
                        NazivKlijenta = txtNazivKlijenta.Text,
                        RegistarskiBroj = txtRegistarskiBroj.Text,
                        Kontakt = txtKontakt.Text,
                        DodatniKomentar = txtKomentar.Text
                    };
                    db.klijenti.Add(klijent);

                    int ret = db.SaveChanges();
                    MessageBox.Show("Uspesno ste dodali klijenta!","Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGetKlijente_Click(null, null);
                    ClearKlijent();
                }
                else
                {
                    MessageBox.Show("Molimo Vas, unesite sva polja!","Obavestenje",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (DbEntityValidationException EFex)
            {
                foreach (DbEntityValidationResult s in EFex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }
                }
                db.Dispose();
                db = new Models();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCreateServis_Click(object sender, EventArgs e)
        {
            try
            {

                if(cbKlijentFk.Text != "" && dpServisa.Text != "" && txtTipUsluge.Text != "")
                {
                    var KlijentId = Convert.ToInt32(cbKlijentFk.SelectedValue);
                    var result = db.klijenti.FirstOrDefault(s => s.Id == KlijentId);

                    if (result != null)
                    {
                        Servis servis = new Servis
                        {
                            KlijentId = Convert.ToInt32(cbKlijentFk.SelectedValue),
                            DatumServisa = Convert.ToDateTime(dpServisa.Text),
                            OpisUsluge = txtTipUsluge.Text
                        };

                        db.servisi.Add(servis);
                        var datum = Convert.ToDateTime(dpServisa.Text);
                        if (datum < DateTime.Now.Date)
                        {
                            MessageBox.Show("Datum ne moze biti stariji od danasnjeg!","Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        int ret = db.SaveChanges();
                        MessageBox.Show("Uspesno ste dodali servis!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnGetServise_Click(null, null);
                        ClearServis();
                        }
                        else
                        {
                            MessageBox.Show("Izabrali ste nepostojeceg klijenta!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
            {
                MessageBox.Show("Molimo Vas, unesite sva polja!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
            catch (DbEntityValidationException EFex)
            {
                foreach (DbEntityValidationResult s in EFex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }
                }
                db.Dispose();
                db = new Models();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdateKlijent_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridKlijenti.Columns.Count == 0)
                {
                    MessageBox.Show("Izaberite klijenta!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if (GridKlijenti.SelectedRows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Izaberite klijenta kog zelite da obrisete!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if (txtNazivKlijenta.Text.Trim() != "" && txtRegistarskiBroj.Text.Trim() != "" && txtKontakt.Text.Trim() != "" && txtKomentar.Text.Trim() != "")
                {
                    int KlijentId = Convert.ToInt32(txtKlijentID.Text);
                    var result = db.klijenti.FirstOrDefault(k => k.Id == KlijentId);

                    if (result != null)
                    {
                        Klijent klijent = new Klijent
                        {
                            Id = Convert.ToInt32(txtKlijentID.Text),
                            NazivKlijenta = txtNazivKlijenta.Text,
                            RegistarskiBroj = txtRegistarskiBroj.Text,
                            Kontakt = txtKontakt.Text,
                            DodatniKomentar = txtKomentar.Text
                        };
                        db.klijenti.AddOrUpdate(klijent);
                        db.SaveChanges();
                        MessageBox.Show("Uspesno ste dodali klijenta!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Izabrali ste nepostojeceg klijenta!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    btnGetKlijente_Click(null, null);
                    ClearKlijent();
                }
                else
                {
                    MessageBox.Show("Molimo Vas, unesite sva polja!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DbEntityValidationException EFex)
            {
                foreach (DbEntityValidationResult s in EFex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }
                }
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnUpdateServis_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbKlijentFk.Text != "" && dpServisa.Text != "" && txtTipUsluge.Text != "")
                {
                    if (GridServisi.Columns.Count == 0)
                    {
                        MessageBox.Show("Izaberite servis!","Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }
                    if (GridServisi.SelectedRows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("Izaberite servis koji zelite da izmenite!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }

                    int ServisId = Convert.ToInt32(txtServisID.Text);
                    var result = db.servisi.SingleOrDefault(s => s.Id == ServisId);

                    int KlijentId = Convert.ToInt32(cbKlijentFk.SelectedValue);
                    var rcs = db.klijenti.FirstOrDefault(s => s.Id == KlijentId);
                    if (result != null)
                    {
                        if(rcs != null)
                        {
                            var datum = Convert.ToDateTime(dpServisa.Text);
                            if (datum < DateTime.Now.Date)
                            {
                                MessageBox.Show("Unesite validan datum!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                Servis servis = new Servis
                                {
                                    Id = Convert.ToInt32(txtServisID.Text),
                                    KlijentId = Convert.ToInt32(cbKlijentFk.SelectedValue),
                                    DatumServisa = Convert.ToDateTime(dpServisa.Text),
                                    OpisUsluge = txtTipUsluge.Text

                                };
                                db.servisi.AddOrUpdate(servis);
                                int ret = db.SaveChanges();
                                MessageBox.Show("Uspesno ste dodali servis!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Izabrali ste nepostojeceg klijenta!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Servis ne postoji", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    btnGetServise_Click(null, null);
                    ClearServis();
                }
                else
                {
                    MessageBox.Show("Molimo Vas, unesite sva polja!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (DbEntityValidationException EFex)
            {
                foreach (DbEntityValidationResult s in EFex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }
                }
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnDeleteKlijenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Da li zelite da obrisete klijenta", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (GridKlijenti.Columns.Count == 0)
                    {
                        MessageBox.Show("Izaberite klijenta koga brisete!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (GridKlijenti.SelectedRows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("Izaberite klijenta kog zelite da obrisete!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        using (var db = new Models())
                        {
                            int KlijentId = Convert.ToInt32(txtKlijentID.Text);

                            var klijent = db.klijenti.Where(k => k.Id == KlijentId).FirstOrDefault();
                            if (klijent != null)
                            {
                                db.klijenti.Remove(klijent);
                                db.SaveChanges();
                            }
                        }
                        btnGetKlijente_Click(null, null);
                        ClearKlijent();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDeleteservis_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Da li zelite da obrisete klijenta", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (GridServisi.Columns.Count == 0)
                    {
                        MessageBox.Show("Izaberite klijenta koga brisete!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (GridServisi.SelectedRows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("Izaberite klijenta kog zelite da obrisete!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        using (var db = new Models())
                        {
                            int ServisId = Convert.ToInt32(txtServisID.Text);

                            var servis = db.servisi.Where(s => s.Id == ServisId).FirstOrDefault();
                            if (servis != null)
                            {
                                db.servisi.Remove(servis);
                                db.SaveChanges();
                            }
                        }
                        
                    }                   
                }
                btnGetServise_Click(null, null);
                ClearServis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void GridKlijenti_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = GridKlijenti.Rows[indexRow];
            txtKlijentID.Text = row.Cells[0].Value.ToString();
            txtNazivKlijenta.Text = row.Cells[1].Value.ToString();
            txtRegistarskiBroj.Text = row.Cells[2].Value.ToString();
            txtKontakt.Text = row.Cells[3].Value.ToString();
            txtKomentar.Text = row.Cells[4].Value.ToString();

        }

        private void GridServisi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = GridServisi.Rows[indexRow];
            txtServisID.Text = row.Cells[0].Value.ToString();
            cbKlijentFk.Text = row.Cells[1].Value.ToString();
            dpServisa.Text = row.Cells[2].Value.ToString();
            txtTipUsluge.Text = row.Cells[3].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
    

