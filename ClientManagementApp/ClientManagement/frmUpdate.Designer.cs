namespace DomaciCRUD
{
    partial class frmUpdate
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNazivUpdate = new System.Windows.Forms.TextBox();
            this.tbKontaktUpdate = new System.Windows.Forms.TextBox();
            this.tbGradUpdate = new System.Windows.Forms.TextBox();
            this.tbZemljaUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(286, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Update client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(200, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(181, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(204, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(189, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Country";
            // 
            // tbNazivUpdate
            // 
            this.tbNazivUpdate.Location = new System.Drawing.Point(291, 130);
            this.tbNazivUpdate.Name = "tbNazivUpdate";
            this.tbNazivUpdate.Size = new System.Drawing.Size(212, 22);
            this.tbNazivUpdate.TabIndex = 14;
            // 
            // tbKontaktUpdate
            // 
            this.tbKontaktUpdate.Location = new System.Drawing.Point(291, 173);
            this.tbKontaktUpdate.Name = "tbKontaktUpdate";
            this.tbKontaktUpdate.Size = new System.Drawing.Size(212, 22);
            this.tbKontaktUpdate.TabIndex = 15;
            // 
            // tbGradUpdate
            // 
            this.tbGradUpdate.Location = new System.Drawing.Point(291, 218);
            this.tbGradUpdate.Name = "tbGradUpdate";
            this.tbGradUpdate.Size = new System.Drawing.Size(212, 22);
            this.tbGradUpdate.TabIndex = 16;
            // 
            // tbZemljaUpdate
            // 
            this.tbZemljaUpdate.Location = new System.Drawing.Point(291, 265);
            this.tbZemljaUpdate.Name = "tbZemljaUpdate";
            this.tbZemljaUpdate.Size = new System.Drawing.Size(212, 22);
            this.tbZemljaUpdate.TabIndex = 17;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Peru;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(291, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(212, 65);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.SystemColors.Control;
            this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbId.Location = new System.Drawing.Point(433, 95);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(70, 15);
            this.tbId.TabIndex = 20;
            this.tbId.Visible = false;
            this.tbId.ReadOnlyChanged += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbZemljaUpdate);
            this.Controls.Add(this.tbGradUpdate);
            this.Controls.Add(this.tbKontaktUpdate);
            this.Controls.Add(this.tbNazivUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmUpdate";
            this.Text = "Update client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox tbNazivUpdate;
        public System.Windows.Forms.TextBox tbKontaktUpdate;
        public System.Windows.Forms.TextBox tbGradUpdate;
        public System.Windows.Forms.TextBox tbZemljaUpdate;
        public System.Windows.Forms.TextBox tbId;
    }
}