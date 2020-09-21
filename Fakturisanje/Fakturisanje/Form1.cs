using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomaciDC
{
    public partial class Form1 : Form
    {
        DataTable kupci, fakture, faktureStavke;
        DataSet Fakturisanje;

        private void btnDodajKupca_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNazivKupca.Text.Trim() != "" && tbAdresa.Text.Trim() != "")
                {
                    kupci.Rows.Add(null, tbNazivKupca.Text, tbAdresa.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btnDodajFakturu_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbKupacID.Text.Trim() != "" && dtPicker.Text.Trim() != "")
                {

                    fakture.Rows.Add(null, cbKupacID.SelectedValue, dtPicker.Text);

                }

                else
                {
                    MessageBox.Show("Unesite info o fakturi");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDodajStavku_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbFakturaID.Text.Trim() != "" && tbNazivStavke.Text.Trim() != "" && tbCenaStavke.Text.Trim() != "")
                {

                    faktureStavke.Rows.Add(cbFakturaID.SelectedValue, tbNazivStavke.Text, tbCenaStavke.Text);
                }
                else
                {
                    MessageBox.Show("Unesite informaciju o stavki");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSacuvajXML_Click(object sender, EventArgs e)
        {
            try
            {
                if (Fakturisanje != null)
                {
                    Fakturisanje.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//DokumentXML.xml", XmlWriteMode.WriteSchema);
                    MessageBox.Show("XML fajl je sacuvan!");
                }
                else
                {
                    MessageBox.Show("Nema podataka za kreiranje XML fajla!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXMLsema_Click(object sender, EventArgs e)
        {
            try
            {
               if(Fakturisanje != null)
                {
                    Fakturisanje.WriteXmlSchema(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//DokumentXMLSema.xsd");
                    MessageBox.Show("XML sema je sacuvana!");
                }
                else
                {
                    MessageBox.Show("Nema podataka za kreiranje XML seme!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            //KUPCI
            kupci = new DataTable("Kupci");
            DataColumn kupacID = new DataColumn("KupacID");
            kupacID.DataType = typeof(int);
            kupacID.AutoIncrement = true;
            kupacID.AutoIncrementSeed = 1;
            kupacID.AutoIncrementStep = 1;
            kupacID.AllowDBNull = false;
            kupci.Columns.Add(kupacID);

            DataColumn naziv = new DataColumn("NazivKupca");
            naziv.DataType = typeof(string);
            naziv.MaxLength = 50;
            naziv.AllowDBNull = false;
            naziv.Caption = "Naziv Kupca";
            kupci.Columns.Add(naziv);

            DataColumn adr = new DataColumn("Adresa");
            adr.DataType = typeof(string);
            adr.MaxLength = 200;
            adr.AllowDBNull = true;
            kupci.Columns.Add(adr);

            kupci.PrimaryKey = new DataColumn[]
            {
                kupacID
            };
            //tbNazivKupca.DataBindings.Clear();
            //tbAdresa.DataBindings.Clear();
            //tbNazivKupca.DataBindings.Add("Text",kupci,"NazivKupca");
            //tbAdresa.DataBindings.Add("Text", kupci, "Adresa");

            //FAKTURE
            fakture = new DataTable("Fakture");

            DataColumn fakturaID = new DataColumn("FakturaID");
            fakturaID.DataType = typeof(int);
            fakturaID.AutoIncrement = true;
            fakturaID.AutoIncrementSeed = 1;
            fakturaID.AutoIncrementStep = 1;
            fakturaID.AllowDBNull = false;
            fakture.Columns.Add(fakturaID);
            fakture.PrimaryKey = new DataColumn[]
            {
                fakturaID
            };

            DataColumn kupacFK = new DataColumn("KupacID");
            kupacFK.DataType = typeof(int);
            kupacFK.AllowDBNull = false;
            fakture.Columns.Add(kupacFK);

            DataColumn datum = new DataColumn("Datum");
            datum.DataType = typeof(DateTime);
            datum.AllowDBNull = false;
            fakture.Columns.Add(datum);

            //cbKupacID.DataBindings.Clear();
            //dtPicker.DataBindings.Clear();

            //cbKupacID.DataBindings.Add("Text",fakture,"KupacID");
            cbKupacID.DataSource = kupci;
            cbKupacID.ValueMember = "KupacID";
            cbKupacID.DisplayMember = "NazivKupca";
            
            //dtPicker.DataBindings.Add("Text",fakture,"Datum");

            //FAKTURE STAVKE
            faktureStavke = new DataTable("FaktureStavke");

            DataColumn fakturaFk = new DataColumn("FakturaID");
            fakturaFk.DataType = typeof(int);
            fakturaFk.AllowDBNull = false;
            faktureStavke.Columns.Add(fakturaFk);

            DataColumn nazivStavke = new DataColumn("NazivStavke");
            nazivStavke.AllowDBNull = false;
            nazivStavke.DataType = typeof(string);
            nazivStavke.MaxLength = 40;
            faktureStavke.Columns.Add(nazivStavke);
            faktureStavke.PrimaryKey = new DataColumn[]
            {
                fakturaFk, nazivStavke

            };

            DataColumn cena = new DataColumn("Cena");
            cena.DataType = typeof(decimal);
            cena.AllowDBNull = false;
            faktureStavke.Columns.Add(cena);

            //cbFakturaID.DataBindings.Clear();
            //tbNazivStavke.DataBindings.Clear();
            //tbCenaStavke.DataBindings.Clear();

            //cbFakturaID.DataBindings.Add("Text", faktureStavke, "FakturaID");
            cbFakturaID.DataSource = fakture;
            cbFakturaID.ValueMember = "FakturaID";
            cbFakturaID.DisplayMember = "FakturaID";
            //tbNazivStavke.DataBindings.Add("Text", faktureStavke, "NazivStavke");
            //tbCenaStavke.DataBindings.Add("Text",faktureStavke,"Cena");

            Fakturisanje = new DataSet("Fakturisanje");
            Fakturisanje.Tables.Add(kupci);
            Fakturisanje.Tables.Add(fakture);
            Fakturisanje.Tables.Add(faktureStavke);

            DataRelation dataRelation = new DataRelation("RelacijaKupciFakture", kupci.Columns["KupacID"], fakture.Columns["KupacID"],true);

            Fakturisanje.Relations.Add(dataRelation);
            ForeignKeyConstraint fk = (ForeignKeyConstraint)fakture.Constraints["RelacijaKupciFakture"];
            fk.DeleteRule = Rule.None;
            fk.UpdateRule = Rule.None;

            DataRelation dataRelation1 = new DataRelation("RelacijaFakturaStavkeFakture", fakture.Columns["FakturaID"], faktureStavke.Columns["FakturaID"],true);

            Fakturisanje.Relations.Add(dataRelation1);

            ForeignKeyConstraint foreignKey = (ForeignKeyConstraint)faktureStavke.Constraints["RelacijaFakturaStavkeFakture"];
            foreignKey.DeleteRule = Rule.None;
            foreignKey.UpdateRule = Rule.None;

            


            //dodajemo slogove
            kupci.Rows.Add(1, "Kupac 1", "Adresa 1");
            kupci.Rows.Add(2, "Kupac 2", "Adresa 2");
            kupci.Rows.Add(3, "Kupac 3", "Adresa 3");
            kupci.Rows.Add(4, "Kupac 4", "Adresa 4");
            kupci.Rows.Add(5, "Kupac 5", "Adresa 5");

            fakture.Rows.Add(1, 2, DateTime.Now);
            fakture.Rows.Add(2, 5, DateTime.Now);
            fakture.Rows.Add(3, 1, DateTime.Now);
            fakture.Rows.Add(4, 2, DateTime.Now);
            fakture.Rows.Add(5, 3, DateTime.Now);

            faktureStavke.Rows.Add(1, "Naziv 1", 253);
            faktureStavke.Rows.Add(2, "Naziv 2", 555);
            faktureStavke.Rows.Add(3, "Naziv 3", 123);
            faktureStavke.Rows.Add(4, "Naziv 4", 569);
            faktureStavke.Rows.Add(5, "Naziv 5", 234);

            dgvKupac.DataSource = kupci;
            dgvFakture.DataSource = fakture;
            dgvStavkeFakture.DataSource = faktureStavke;


        }

    }
}
