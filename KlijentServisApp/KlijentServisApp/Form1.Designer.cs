namespace ADO.NETEntityCodeFirst
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridKlijenti = new System.Windows.Forms.DataGridView();
            this.GridServisi = new System.Windows.Forms.DataGridView();
            this.txtKlijentID = new System.Windows.Forms.TextBox();
            this.txtNazivKlijenta = new System.Windows.Forms.TextBox();
            this.txtRegistarskiBroj = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.btnUpdateKlijent = new System.Windows.Forms.Button();
            this.btnDeleteKlijenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTipUsluge = new System.Windows.Forms.TextBox();
            this.txtServisID = new System.Windows.Forms.TextBox();
            this.dpServisa = new System.Windows.Forms.DateTimePicker();
            this.btnGetServise = new System.Windows.Forms.Button();
            this.btnDeleteservis = new System.Windows.Forms.Button();
            this.btnUpdateServis = new System.Windows.Forms.Button();
            this.btnCreateServis = new System.Windows.Forms.Button();
            this.btnGetKlijente = new System.Windows.Forms.Button();
            this.btnCreateKlijent = new System.Windows.Forms.Button();
            this.cbKlijentFk = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridKlijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridServisi)).BeginInit();
            this.SuspendLayout();
            // 
            // GridKlijenti
            // 
            this.GridKlijenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridKlijenti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridKlijenti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.GridKlijenti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridKlijenti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridKlijenti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.GridKlijenti.ColumnHeadersHeight = 30;
            this.GridKlijenti.EnableHeadersVisualStyles = false;
            this.GridKlijenti.GridColor = System.Drawing.Color.SteelBlue;
            this.GridKlijenti.Location = new System.Drawing.Point(25, 12);
            this.GridKlijenti.Name = "GridKlijenti";
            this.GridKlijenti.ReadOnly = true;
            this.GridKlijenti.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridKlijenti.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.GridKlijenti.RowHeadersVisible = false;
            this.GridKlijenti.RowHeadersWidth = 51;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.GridKlijenti.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.GridKlijenti.RowTemplate.Height = 24;
            this.GridKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridKlijenti.Size = new System.Drawing.Size(564, 224);
            this.GridKlijenti.TabIndex = 0;
            this.GridKlijenti.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridKlijenti_CellMouseClick);
            // 
            // GridServisi
            // 
            this.GridServisi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridServisi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridServisi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.GridServisi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridServisi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridServisi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.GridServisi.ColumnHeadersHeight = 30;
            this.GridServisi.EnableHeadersVisualStyles = false;
            this.GridServisi.GridColor = System.Drawing.Color.SteelBlue;
            this.GridServisi.Location = new System.Drawing.Point(645, 12);
            this.GridServisi.Name = "GridServisi";
            this.GridServisi.ReadOnly = true;
            this.GridServisi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridServisi.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.GridServisi.RowHeadersVisible = false;
            this.GridServisi.RowHeadersWidth = 51;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.GridServisi.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.GridServisi.RowTemplate.Height = 24;
            this.GridServisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridServisi.Size = new System.Drawing.Size(559, 224);
            this.GridServisi.TabIndex = 1;
            this.GridServisi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridServisi_CellMouseClick);
            // 
            // txtKlijentID
            // 
            this.txtKlijentID.Location = new System.Drawing.Point(343, 263);
            this.txtKlijentID.Name = "txtKlijentID";
            this.txtKlijentID.Size = new System.Drawing.Size(29, 23);
            this.txtKlijentID.TabIndex = 3;
            this.txtKlijentID.Visible = false;
            // 
            // txtNazivKlijenta
            // 
            this.txtNazivKlijenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivKlijenta.Location = new System.Drawing.Point(326, 308);
            this.txtNazivKlijenta.Name = "txtNazivKlijenta";
            this.txtNazivKlijenta.Size = new System.Drawing.Size(206, 26);
            this.txtNazivKlijenta.TabIndex = 4;
            // 
            // txtRegistarskiBroj
            // 
            this.txtRegistarskiBroj.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistarskiBroj.Location = new System.Drawing.Point(326, 354);
            this.txtRegistarskiBroj.Name = "txtRegistarskiBroj";
            this.txtRegistarskiBroj.Size = new System.Drawing.Size(206, 26);
            this.txtRegistarskiBroj.TabIndex = 5;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKontakt.Location = new System.Drawing.Point(326, 398);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(206, 26);
            this.txtKontakt.TabIndex = 6;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKomentar.Location = new System.Drawing.Point(326, 443);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(206, 26);
            this.txtKomentar.TabIndex = 7;
            // 
            // btnUpdateKlijent
            // 
            this.btnUpdateKlijent.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateKlijent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateKlijent.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateKlijent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateKlijent.Location = new System.Drawing.Point(283, 491);
            this.btnUpdateKlijent.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateKlijent.Name = "btnUpdateKlijent";
            this.btnUpdateKlijent.Size = new System.Drawing.Size(154, 66);
            this.btnUpdateKlijent.TabIndex = 8;
            this.btnUpdateKlijent.Text = "UPDATE";
            this.btnUpdateKlijent.UseVisualStyleBackColor = false;
            this.btnUpdateKlijent.Click += new System.EventHandler(this.btnUpdateKlijent_Click);
            // 
            // btnDeleteKlijenta
            // 
            this.btnDeleteKlijenta.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteKlijenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteKlijenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteKlijenta.ForeColor = System.Drawing.Color.White;
            this.btnDeleteKlijenta.Location = new System.Drawing.Point(449, 491);
            this.btnDeleteKlijenta.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteKlijenta.Name = "btnDeleteKlijenta";
            this.btnDeleteKlijenta.Size = new System.Drawing.Size(152, 66);
            this.btnDeleteKlijenta.TabIndex = 9;
            this.btnDeleteKlijenta.Text = "DELETE";
            this.btnDeleteKlijenta.UseVisualStyleBackColor = false;
            this.btnDeleteKlijenta.Click += new System.EventHandler(this.btnDeleteKlijenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Naziv klijenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(186, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Registarski broj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(241, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kontakt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(156, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dodatni komentar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(240, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Klijenti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MintCream;
            this.label6.Location = new System.Drawing.Point(841, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 28);
            this.label6.TabIndex = 27;
            this.label6.Text = "Servis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(712, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Opis usluge:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(693, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Datum servisa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(699, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Naziv klijenta:";
            // 
            // txtTipUsluge
            // 
            this.txtTipUsluge.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipUsluge.Location = new System.Drawing.Point(842, 419);
            this.txtTipUsluge.Name = "txtTipUsluge";
            this.txtTipUsluge.Size = new System.Drawing.Size(206, 26);
            this.txtTipUsluge.TabIndex = 19;
            // 
            // txtServisID
            // 
            this.txtServisID.Location = new System.Drawing.Point(944, 257);
            this.txtServisID.Name = "txtServisID";
            this.txtServisID.Size = new System.Drawing.Size(32, 23);
            this.txtServisID.TabIndex = 16;
            this.txtServisID.Visible = false;
            // 
            // dpServisa
            // 
            this.dpServisa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpServisa.Location = new System.Drawing.Point(842, 368);
            this.dpServisa.Name = "dpServisa";
            this.dpServisa.Size = new System.Drawing.Size(206, 26);
            this.dpServisa.TabIndex = 28;
            // 
            // btnGetServise
            // 
            this.btnGetServise.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGetServise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetServise.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetServise.ForeColor = System.Drawing.Color.White;
            this.btnGetServise.Location = new System.Drawing.Point(1087, 243);
            this.btnGetServise.Name = "btnGetServise";
            this.btnGetServise.Size = new System.Drawing.Size(117, 42);
            this.btnGetServise.TabIndex = 30;
            this.btnGetServise.Text = "Servisi";
            this.btnGetServise.UseVisualStyleBackColor = false;
            this.btnGetServise.Click += new System.EventHandler(this.btnGetServise_Click);
            // 
            // btnDeleteservis
            // 
            this.btnDeleteservis.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteservis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteservis.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteservis.ForeColor = System.Drawing.Color.White;
            this.btnDeleteservis.Location = new System.Drawing.Point(997, 492);
            this.btnDeleteservis.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteservis.Name = "btnDeleteservis";
            this.btnDeleteservis.Size = new System.Drawing.Size(152, 66);
            this.btnDeleteservis.TabIndex = 34;
            this.btnDeleteservis.Text = "DELETE";
            this.btnDeleteservis.UseVisualStyleBackColor = false;
            this.btnDeleteservis.Click += new System.EventHandler(this.btnDeleteservis_Click);
            // 
            // btnUpdateServis
            // 
            this.btnUpdateServis.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateServis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateServis.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateServis.ForeColor = System.Drawing.Color.White;
            this.btnUpdateServis.Location = new System.Drawing.Point(831, 492);
            this.btnUpdateServis.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateServis.Name = "btnUpdateServis";
            this.btnUpdateServis.Size = new System.Drawing.Size(154, 66);
            this.btnUpdateServis.TabIndex = 33;
            this.btnUpdateServis.Text = "UPDATE";
            this.btnUpdateServis.UseVisualStyleBackColor = false;
            this.btnUpdateServis.Click += new System.EventHandler(this.btnUpdateServis_Click);
            // 
            // btnCreateServis
            // 
            this.btnCreateServis.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCreateServis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateServis.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateServis.ForeColor = System.Drawing.Color.White;
            this.btnCreateServis.Location = new System.Drawing.Point(666, 492);
            this.btnCreateServis.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreateServis.Name = "btnCreateServis";
            this.btnCreateServis.Size = new System.Drawing.Size(152, 66);
            this.btnCreateServis.TabIndex = 32;
            this.btnCreateServis.Text = "CREATE";
            this.btnCreateServis.UseVisualStyleBackColor = false;
            this.btnCreateServis.Click += new System.EventHandler(this.btnCreateServis_Click);
            // 
            // btnGetKlijente
            // 
            this.btnGetKlijente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGetKlijente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetKlijente.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetKlijente.ForeColor = System.Drawing.Color.White;
            this.btnGetKlijente.Location = new System.Drawing.Point(25, 242);
            this.btnGetKlijente.Name = "btnGetKlijente";
            this.btnGetKlijente.Size = new System.Drawing.Size(116, 43);
            this.btnGetKlijente.TabIndex = 35;
            this.btnGetKlijente.Text = "Klijenti";
            this.btnGetKlijente.UseVisualStyleBackColor = false;
            this.btnGetKlijente.Click += new System.EventHandler(this.btnGetKlijente_Click);
            // 
            // btnCreateKlijent
            // 
            this.btnCreateKlijent.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCreateKlijent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateKlijent.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateKlijent.ForeColor = System.Drawing.Color.White;
            this.btnCreateKlijent.Location = new System.Drawing.Point(111, 491);
            this.btnCreateKlijent.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreateKlijent.Name = "btnCreateKlijent";
            this.btnCreateKlijent.Size = new System.Drawing.Size(152, 66);
            this.btnCreateKlijent.TabIndex = 36;
            this.btnCreateKlijent.Text = "CREATE";
            this.btnCreateKlijent.UseVisualStyleBackColor = false;
            this.btnCreateKlijent.Click += new System.EventHandler(this.btnCreateKlijent_Click);
            // 
            // cbKlijentFk
            // 
            this.cbKlijentFk.FormattingEnabled = true;
            this.cbKlijentFk.Location = new System.Drawing.Point(842, 320);
            this.cbKlijentFk.Name = "cbKlijentFk";
            this.cbKlijentFk.Size = new System.Drawing.Size(206, 25);
            this.cbKlijentFk.TabIndex = 39;
            this.cbKlijentFk.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1222, 594);
            this.Controls.Add(this.cbKlijentFk);
            this.Controls.Add(this.btnCreateKlijent);
            this.Controls.Add(this.btnGetKlijente);
            this.Controls.Add(this.btnDeleteservis);
            this.Controls.Add(this.btnUpdateServis);
            this.Controls.Add(this.btnCreateServis);
            this.Controls.Add(this.btnGetServise);
            this.Controls.Add(this.dpServisa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTipUsluge);
            this.Controls.Add(this.txtServisID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteKlijenta);
            this.Controls.Add(this.btnUpdateKlijent);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtRegistarskiBroj);
            this.Controls.Add(this.txtNazivKlijenta);
            this.Controls.Add(this.txtKlijentID);
            this.Controls.Add(this.GridServisi);
            this.Controls.Add(this.GridKlijenti);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridKlijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridServisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridKlijenti;
        private System.Windows.Forms.DataGridView GridServisi;
        private System.Windows.Forms.TextBox txtKlijentID;
        private System.Windows.Forms.TextBox txtNazivKlijenta;
        private System.Windows.Forms.TextBox txtRegistarskiBroj;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.Button btnUpdateKlijent;
        private System.Windows.Forms.Button btnDeleteKlijenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTipUsluge;
        private System.Windows.Forms.TextBox txtServisID;
        private System.Windows.Forms.DateTimePicker dpServisa;
        private System.Windows.Forms.Button btnGetServise;
        private System.Windows.Forms.Button btnDeleteservis;
        private System.Windows.Forms.Button btnUpdateServis;
        private System.Windows.Forms.Button btnCreateServis;
        private System.Windows.Forms.Button btnGetKlijente;
        private System.Windows.Forms.Button btnCreateKlijent;
        private System.Windows.Forms.ComboBox cbKlijentFk;
    }
}

