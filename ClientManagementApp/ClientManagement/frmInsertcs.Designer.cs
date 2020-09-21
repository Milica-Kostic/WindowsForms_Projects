namespace DomaciCRUD
{
    partial class frmInsertcs
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNazivInsert = new System.Windows.Forms.TextBox();
            this.tbkontaktInsert = new System.Windows.Forms.TextBox();
            this.tbGradInsert = new System.Windows.Forms.TextBox();
            this.tbZemljaInsert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInsertK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(228, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tbNazivInsert
            // 
            this.tbNazivInsert.Location = new System.Drawing.Point(293, 129);
            this.tbNazivInsert.Name = "tbNazivInsert";
            this.tbNazivInsert.Size = new System.Drawing.Size(253, 22);
            this.tbNazivInsert.TabIndex = 1;
            // 
            // tbkontaktInsert
            // 
            this.tbkontaktInsert.Location = new System.Drawing.Point(293, 167);
            this.tbkontaktInsert.Name = "tbkontaktInsert";
            this.tbkontaktInsert.Size = new System.Drawing.Size(253, 22);
            this.tbkontaktInsert.TabIndex = 2;
            // 
            // tbGradInsert
            // 
            this.tbGradInsert.Location = new System.Drawing.Point(293, 208);
            this.tbGradInsert.Name = "tbGradInsert";
            this.tbGradInsert.Size = new System.Drawing.Size(253, 22);
            this.tbGradInsert.TabIndex = 3;
            // 
            // tbZemljaInsert
            // 
            this.tbZemljaInsert.Location = new System.Drawing.Point(293, 250);
            this.tbZemljaInsert.Name = "tbZemljaInsert";
            this.tbZemljaInsert.Size = new System.Drawing.Size(253, 22);
            this.tbZemljaInsert.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(213, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(232, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(219, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(311, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Add new client";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnInsertK
            // 
            this.btnInsertK.BackColor = System.Drawing.Color.Peru;
            this.btnInsertK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertK.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnInsertK.ForeColor = System.Drawing.Color.White;
            this.btnInsertK.Location = new System.Drawing.Point(293, 311);
            this.btnInsertK.Name = "btnInsertK";
            this.btnInsertK.Size = new System.Drawing.Size(253, 63);
            this.btnInsertK.TabIndex = 9;
            this.btnInsertK.Text = "INSERT";
            this.btnInsertK.UseVisualStyleBackColor = false;
            this.btnInsertK.Click += new System.EventHandler(this.btnInsertK_Click);
            // 
            // frmInsertcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(821, 414);
            this.Controls.Add(this.btnInsertK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbZemljaInsert);
            this.Controls.Add(this.tbGradInsert);
            this.Controls.Add(this.tbkontaktInsert);
            this.Controls.Add(this.tbNazivInsert);
            this.Controls.Add(this.label1);
            this.Name = "frmInsertcs";
            this.Text = " Add client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNazivInsert;
        private System.Windows.Forms.TextBox tbkontaktInsert;
        private System.Windows.Forms.TextBox tbGradInsert;
        private System.Windows.Forms.TextBox tbZemljaInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInsertK;
    }
}