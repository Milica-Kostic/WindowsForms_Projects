namespace DomaciDC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKupac = new System.Windows.Forms.DataGridView();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.dgvFakture = new System.Windows.Forms.DataGridView();
            this.dgvStavkeFakture = new System.Windows.Forms.DataGridView();
            this.tbNazivKupca = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.btnDodajKupca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNazivStavke = new System.Windows.Forms.TextBox();
            this.tbCenaStavke = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDodajFakturu = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.btnSacuvajXML = new System.Windows.Forms.Button();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.cbKupacID = new System.Windows.Forms.ComboBox();
            this.cbFakturaID = new System.Windows.Forms.ComboBox();
            this.btnXMLsema = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFakture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeFakture)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKupac
            // 
            this.dgvKupac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKupac.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKupac.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dgvKupac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKupac.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKupac.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKupac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvKupac.ColumnHeadersHeight = 29;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKupac.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvKupac.EnableHeadersVisualStyles = false;
            this.dgvKupac.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvKupac.Location = new System.Drawing.Point(16, 145);
            this.dgvKupac.Margin = new System.Windows.Forms.Padding(0);
            this.dgvKupac.Name = "dgvKupac";
            this.dgvKupac.ReadOnly = true;
            this.dgvKupac.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKupac.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvKupac.RowHeadersVisible = false;
            this.dgvKupac.RowHeadersWidth = 51;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.dgvKupac.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvKupac.RowTemplate.Height = 24;
            this.dgvKupac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKupac.Size = new System.Drawing.Size(266, 267);
            this.dgvKupac.TabIndex = 0;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.Color.ForestGreen;
            this.btnKreiraj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKreiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.Location = new System.Drawing.Point(430, 45);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(279, 78);
            this.btnKreiraj.TabIndex = 1;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // dgvFakture
            // 
            this.dgvFakture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFakture.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFakture.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dgvFakture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFakture.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFakture.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFakture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvFakture.ColumnHeadersHeight = 29;
            this.dgvFakture.EnableHeadersVisualStyles = false;
            this.dgvFakture.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvFakture.Location = new System.Drawing.Point(430, 145);
            this.dgvFakture.Margin = new System.Windows.Forms.Padding(0);
            this.dgvFakture.Name = "dgvFakture";
            this.dgvFakture.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFakture.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvFakture.RowHeadersVisible = false;
            this.dgvFakture.RowHeadersWidth = 51;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFakture.RowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvFakture.RowTemplate.Height = 24;
            this.dgvFakture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFakture.Size = new System.Drawing.Size(279, 267);
            this.dgvFakture.TabIndex = 2;
            // 
            // dgvStavkeFakture
            // 
            this.dgvStavkeFakture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStavkeFakture.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStavkeFakture.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dgvStavkeFakture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStavkeFakture.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStavkeFakture.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStavkeFakture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvStavkeFakture.ColumnHeadersHeight = 29;
            this.dgvStavkeFakture.EnableHeadersVisualStyles = false;
            this.dgvStavkeFakture.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvStavkeFakture.Location = new System.Drawing.Point(836, 145);
            this.dgvStavkeFakture.Margin = new System.Windows.Forms.Padding(0);
            this.dgvStavkeFakture.Name = "dgvStavkeFakture";
            this.dgvStavkeFakture.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStavkeFakture.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvStavkeFakture.RowHeadersVisible = false;
            this.dgvStavkeFakture.RowHeadersWidth = 51;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStavkeFakture.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvStavkeFakture.RowTemplate.Height = 24;
            this.dgvStavkeFakture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeFakture.Size = new System.Drawing.Size(262, 267);
            this.dgvStavkeFakture.TabIndex = 3;
            // 
            // tbNazivKupca
            // 
            this.tbNazivKupca.Location = new System.Drawing.Point(140, 500);
            this.tbNazivKupca.Name = "tbNazivKupca";
            this.tbNazivKupca.Size = new System.Drawing.Size(153, 24);
            this.tbNazivKupca.TabIndex = 4;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(150, 556);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(143, 24);
            this.tbAdresa.TabIndex = 5;
            // 
            // btnDodajKupca
            // 
            this.btnDodajKupca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDodajKupca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajKupca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKupca.Location = new System.Drawing.Point(42, 641);
            this.btnDodajKupca.Name = "btnDodajKupca";
            this.btnDodajKupca.Size = new System.Drawing.Size(240, 66);
            this.btnDodajKupca.TabIndex = 7;
            this.btnDodajKupca.Text = "Dodaj kupca";
            this.btnDodajKupca.UseVisualStyleBackColor = false;
            this.btnDodajKupca.Click += new System.EventHandler(this.btnDodajKupca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Naziv kupca: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adresa kupca: ";
            // 
            // tbNazivStavke
            // 
            this.tbNazivStavke.Location = new System.Drawing.Point(994, 543);
            this.tbNazivStavke.Name = "tbNazivStavke";
            this.tbNazivStavke.Size = new System.Drawing.Size(142, 24);
            this.tbNazivStavke.TabIndex = 14;
            // 
            // tbCenaStavke
            // 
            this.tbCenaStavke.Location = new System.Drawing.Point(994, 590);
            this.tbCenaStavke.Name = "tbCenaStavke";
            this.tbCenaStavke.Size = new System.Drawing.Size(142, 24);
            this.tbCenaStavke.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(418, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Izaberite kupca: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(412, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Izaberite datum: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(812, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Izaberite fakturu: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(812, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Unesite Naziv stavke: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(815, 590);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Unesite cenu stavke: ";
            // 
            // btnDodajFakturu
            // 
            this.btnDodajFakturu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDodajFakturu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajFakturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajFakturu.Location = new System.Drawing.Point(451, 641);
            this.btnDodajFakturu.Name = "btnDodajFakturu";
            this.btnDodajFakturu.Size = new System.Drawing.Size(241, 66);
            this.btnDodajFakturu.TabIndex = 22;
            this.btnDodajFakturu.Text = "Dodaj fakturu";
            this.btnDodajFakturu.UseVisualStyleBackColor = false;
            this.btnDodajFakturu.Click += new System.EventHandler(this.btnDodajFakturu_Click_1);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDodajStavku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStavku.Location = new System.Drawing.Point(840, 641);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(281, 66);
            this.btnDodajStavku.TabIndex = 23;
            this.btnDodajStavku.Text = "Dodaj stavku fakture";
            this.btnDodajStavku.UseVisualStyleBackColor = false;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click_1);
            // 
            // btnSacuvajXML
            // 
            this.btnSacuvajXML.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSacuvajXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSacuvajXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajXML.Location = new System.Drawing.Point(16, 45);
            this.btnSacuvajXML.Name = "btnSacuvajXML";
            this.btnSacuvajXML.Size = new System.Drawing.Size(266, 78);
            this.btnSacuvajXML.TabIndex = 24;
            this.btnSacuvajXML.Text = "Sacuvaj XML ";
            this.btnSacuvajXML.UseVisualStyleBackColor = false;
            this.btnSacuvajXML.Click += new System.EventHandler(this.btnSacuvajXML_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(556, 555);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(162, 24);
            this.dtPicker.TabIndex = 26;
            // 
            // cbKupacID
            // 
            this.cbKupacID.FormattingEnabled = true;
            this.cbKupacID.Location = new System.Drawing.Point(556, 499);
            this.cbKupacID.Name = "cbKupacID";
            this.cbKupacID.Size = new System.Drawing.Size(153, 26);
            this.cbKupacID.TabIndex = 27;
            // 
            // cbFakturaID
            // 
            this.cbFakturaID.FormattingEnabled = true;
            this.cbFakturaID.Location = new System.Drawing.Point(959, 500);
            this.cbFakturaID.Name = "cbFakturaID";
            this.cbFakturaID.Size = new System.Drawing.Size(177, 26);
            this.cbFakturaID.TabIndex = 28;
            // 
            // btnXMLsema
            // 
            this.btnXMLsema.BackColor = System.Drawing.Color.ForestGreen;
            this.btnXMLsema.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXMLsema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLsema.Location = new System.Drawing.Point(836, 44);
            this.btnXMLsema.Name = "btnXMLsema";
            this.btnXMLsema.Size = new System.Drawing.Size(262, 78);
            this.btnXMLsema.TabIndex = 30;
            this.btnXMLsema.Text = "Sacuvaj XML semu";
            this.btnXMLsema.UseVisualStyleBackColor = false;
            this.btnXMLsema.Click += new System.EventHandler(this.btnXMLsema_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(500, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "Dodaj fakturu";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(78, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "Dodaj kupca";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(866, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 24);
            this.label10.TabIndex = 33;
            this.label10.Text = "Dodajte stavku fakture";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1190, 725);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnXMLsema);
            this.Controls.Add(this.cbFakturaID);
            this.Controls.Add(this.cbKupacID);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.btnSacuvajXML);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.btnDodajFakturu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCenaStavke);
            this.Controls.Add(this.tbNazivStavke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajKupca);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbNazivKupca);
            this.Controls.Add(this.dgvStavkeFakture);
            this.Controls.Add(this.dgvFakture);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.dgvKupac);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Fakture";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFakture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeFakture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKupac;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.DataGridView dgvFakture;
        private System.Windows.Forms.DataGridView dgvStavkeFakture;
        private System.Windows.Forms.TextBox tbNazivKupca;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Button btnDodajKupca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNazivStavke;
        private System.Windows.Forms.TextBox tbCenaStavke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDodajFakturu;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnSacuvajXML;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.ComboBox cbKupacID;
        private System.Windows.Forms.ComboBox cbFakturaID;
        private System.Windows.Forms.Button btnXMLsema;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

