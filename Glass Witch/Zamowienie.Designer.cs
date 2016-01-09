namespace Glass_Witch
{
    partial class Zamowienie
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
            this.lab_ulica = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lab_nazwa = new System.Windows.Forms.Label();
            this.lab_KrajKod = new System.Windows.Forms.Label();
            this.lab_vat = new System.Windows.Forms.Label();
            this.lab_data = new System.Windows.Forms.Label();
            this.lab_mail = new System.Windows.Forms.Label();
            this.lab_osobaKontaktowa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_ulica
            // 
            this.lab_ulica.AutoSize = true;
            this.lab_ulica.Location = new System.Drawing.Point(28, 51);
            this.lab_ulica.Name = "lab_ulica";
            this.lab_ulica.Size = new System.Drawing.Size(31, 13);
            this.lab_ulica.TabIndex = 0;
            this.lab_ulica.Text = "Ulica";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // lab_nazwa
            // 
            this.lab_nazwa.AutoSize = true;
            this.lab_nazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_nazwa.Location = new System.Drawing.Point(28, 26);
            this.lab_nazwa.Name = "lab_nazwa";
            this.lab_nazwa.Size = new System.Drawing.Size(45, 13);
            this.lab_nazwa.TabIndex = 2;
            this.lab_nazwa.Text = "Nazwa";
            // 
            // lab_KrajKod
            // 
            this.lab_KrajKod.AutoSize = true;
            this.lab_KrajKod.Location = new System.Drawing.Point(28, 77);
            this.lab_KrajKod.Name = "lab_KrajKod";
            this.lab_KrajKod.Size = new System.Drawing.Size(97, 13);
            this.lab_KrajKod.TabIndex = 3;
            this.lab_KrajKod.Text = "Kod pocztowy, kraj";
            // 
            // lab_vat
            // 
            this.lab_vat.AutoSize = true;
            this.lab_vat.Location = new System.Drawing.Point(28, 104);
            this.lab_vat.Name = "lab_vat";
            this.lab_vat.Size = new System.Drawing.Size(57, 13);
            this.lab_vat.TabIndex = 4;
            this.lab_vat.Text = "Numer Vat";
            // 
            // lab_data
            // 
            this.lab_data.AutoSize = true;
            this.lab_data.Location = new System.Drawing.Point(572, 104);
            this.lab_data.Name = "lab_data";
            this.lab_data.Size = new System.Drawing.Size(30, 13);
            this.lab_data.TabIndex = 5;
            this.lab_data.Text = "Data";
            // 
            // lab_mail
            // 
            this.lab_mail.AutoSize = true;
            this.lab_mail.Location = new System.Drawing.Point(197, 51);
            this.lab_mail.Name = "lab_mail";
            this.lab_mail.Size = new System.Drawing.Size(35, 13);
            this.lab_mail.TabIndex = 6;
            this.lab_mail.Text = "E-mail";
            // 
            // lab_osobaKontaktowa
            // 
            this.lab_osobaKontaktowa.AutoSize = true;
            this.lab_osobaKontaktowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_osobaKontaktowa.Location = new System.Drawing.Point(197, 26);
            this.lab_osobaKontaktowa.Name = "lab_osobaKontaktowa";
            this.lab_osobaKontaktowa.Size = new System.Drawing.Size(114, 13);
            this.lab_osobaKontaktowa.TabIndex = 7;
            this.lab_osobaKontaktowa.Text = "Osoba Kontaktowa";
            // 
            // Zamowienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 484);
            this.Controls.Add(this.lab_osobaKontaktowa);
            this.Controls.Add(this.lab_mail);
            this.Controls.Add(this.lab_data);
            this.Controls.Add(this.lab_vat);
            this.Controls.Add(this.lab_KrajKod);
            this.Controls.Add(this.lab_nazwa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lab_ulica);
            this.Name = "Zamowienie";
            this.Text = "Zamowienie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Zamowienie_FormClosing);
            this.Load += new System.EventHandler(this.Zamowienie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_ulica;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lab_nazwa;
        private System.Windows.Forms.Label lab_KrajKod;
        private System.Windows.Forms.Label lab_vat;
        private System.Windows.Forms.Label lab_data;
        private System.Windows.Forms.Label lab_mail;
        private System.Windows.Forms.Label lab_osobaKontaktowa;
    }
}