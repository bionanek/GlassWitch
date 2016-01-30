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
            this.dgv1_wybraneProdukty = new System.Windows.Forms.DataGridView();
            this.lab_nazwa = new System.Windows.Forms.Label();
            this.lab_kodPocztowy = new System.Windows.Forms.Label();
            this.lab_vat = new System.Windows.Forms.Label();
            this.lab_data = new System.Windows.Forms.Label();
            this.lab_mail = new System.Windows.Forms.Label();
            this.lab_osobaKontaktowa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.but_zatwierdź = new System.Windows.Forms.Button();
            this.lab_termin = new System.Windows.Forms.Label();
            this.lab_deadline = new System.Windows.Forms.Label();
            this.lab_miasto = new System.Windows.Forms.Label();
            this.lab_kraj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_wybraneProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_ulica
            // 
            this.lab_ulica.AutoSize = true;
            this.lab_ulica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_ulica.Location = new System.Drawing.Point(27, 152);
            this.lab_ulica.Name = "lab_ulica";
            this.lab_ulica.Size = new System.Drawing.Size(44, 20);
            this.lab_ulica.TabIndex = 0;
            this.lab_ulica.Text = "Ulica";
            // 
            // dgv1_wybraneProdukty
            // 
            this.dgv1_wybraneProdukty.AllowUserToAddRows = false;
            this.dgv1_wybraneProdukty.AllowUserToDeleteRows = false;
            this.dgv1_wybraneProdukty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1_wybraneProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1_wybraneProdukty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv1_wybraneProdukty.Location = new System.Drawing.Point(0, 324);
            this.dgv1_wybraneProdukty.Name = "dgv1_wybraneProdukty";
            this.dgv1_wybraneProdukty.RowHeadersVisible = false;
            this.dgv1_wybraneProdukty.Size = new System.Drawing.Size(1048, 229);
            this.dgv1_wybraneProdukty.TabIndex = 1;
            // 
            // lab_nazwa
            // 
            this.lab_nazwa.AutoSize = true;
            this.lab_nazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_nazwa.Location = new System.Drawing.Point(27, 60);
            this.lab_nazwa.Name = "lab_nazwa";
            this.lab_nazwa.Size = new System.Drawing.Size(62, 20);
            this.lab_nazwa.TabIndex = 2;
            this.lab_nazwa.Text = "Nazwa";
            // 
            // lab_kodPocztowy
            // 
            this.lab_kodPocztowy.AutoSize = true;
            this.lab_kodPocztowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_kodPocztowy.Location = new System.Drawing.Point(26, 187);
            this.lab_kodPocztowy.Name = "lab_kodPocztowy";
            this.lab_kodPocztowy.Size = new System.Drawing.Size(107, 20);
            this.lab_kodPocztowy.TabIndex = 3;
            this.lab_kodPocztowy.Text = "Kod pocztowy";
            // 
            // lab_vat
            // 
            this.lab_vat.AutoSize = true;
            this.lab_vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_vat.Location = new System.Drawing.Point(27, 251);
            this.lab_vat.Name = "lab_vat";
            this.lab_vat.Size = new System.Drawing.Size(85, 20);
            this.lab_vat.TabIndex = 4;
            this.lab_vat.Text = "Numer Vat";
            // 
            // lab_data
            // 
            this.lab_data.AutoSize = true;
            this.lab_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_data.Location = new System.Drawing.Point(819, 251);
            this.lab_data.Name = "lab_data";
            this.lab_data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_data.Size = new System.Drawing.Size(44, 20);
            this.lab_data.TabIndex = 5;
            this.lab_data.Text = "Data";
            this.lab_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_mail
            // 
            this.lab_mail.AutoSize = true;
            this.lab_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_mail.Location = new System.Drawing.Point(26, 121);
            this.lab_mail.Name = "lab_mail";
            this.lab_mail.Size = new System.Drawing.Size(53, 20);
            this.lab_mail.TabIndex = 6;
            this.lab_mail.Text = "E-mail";
            // 
            // lab_osobaKontaktowa
            // 
            this.lab_osobaKontaktowa.AutoSize = true;
            this.lab_osobaKontaktowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_osobaKontaktowa.Location = new System.Drawing.Point(27, 92);
            this.lab_osobaKontaktowa.Name = "lab_osobaKontaktowa";
            this.lab_osobaKontaktowa.Size = new System.Drawing.Size(160, 20);
            this.lab_osobaKontaktowa.TabIndex = 7;
            this.lab_osobaKontaktowa.Text = "Osoba Kontaktowa";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Edytuj Klienta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // but_zatwierdź
            // 
            this.but_zatwierdź.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_zatwierdź.Location = new System.Drawing.Point(752, 10);
            this.but_zatwierdź.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.but_zatwierdź.Name = "but_zatwierdź";
            this.but_zatwierdź.Size = new System.Drawing.Size(216, 81);
            this.but_zatwierdź.TabIndex = 9;
            this.but_zatwierdź.Text = "Zatwierdź";
            this.but_zatwierdź.UseVisualStyleBackColor = true;
            this.but_zatwierdź.Click += new System.EventHandler(this.but_zatwierdź_Click);
            // 
            // lab_termin
            // 
            this.lab_termin.AutoSize = true;
            this.lab_termin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_termin.Location = new System.Drawing.Point(110, 281);
            this.lab_termin.Name = "lab_termin";
            this.lab_termin.Size = new System.Drawing.Size(57, 20);
            this.lab_termin.TabIndex = 10;
            this.lab_termin.Text = "Termin";
            // 
            // lab_deadline
            // 
            this.lab_deadline.AutoSize = true;
            this.lab_deadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_deadline.Location = new System.Drawing.Point(27, 281);
            this.lab_deadline.Name = "lab_deadline";
            this.lab_deadline.Size = new System.Drawing.Size(76, 20);
            this.lab_deadline.TabIndex = 11;
            this.lab_deadline.Text = "Deadline:";
            // 
            // lab_miasto
            // 
            this.lab_miasto.AutoSize = true;
            this.lab_miasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_miasto.Location = new System.Drawing.Point(139, 187);
            this.lab_miasto.Name = "lab_miasto";
            this.lab_miasto.Size = new System.Drawing.Size(56, 20);
            this.lab_miasto.TabIndex = 12;
            this.lab_miasto.Text = "Miasto";
            // 
            // lab_kraj
            // 
            this.lab_kraj.AutoSize = true;
            this.lab_kraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_kraj.Location = new System.Drawing.Point(27, 219);
            this.lab_kraj.Name = "lab_kraj";
            this.lab_kraj.Size = new System.Drawing.Size(36, 20);
            this.lab_kraj.TabIndex = 13;
            this.lab_kraj.Text = "Kraj";
            // 
            // Zamowienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1048, 553);
            this.Controls.Add(this.lab_kraj);
            this.Controls.Add(this.lab_miasto);
            this.Controls.Add(this.lab_deadline);
            this.Controls.Add(this.lab_termin);
            this.Controls.Add(this.but_zatwierdź);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_osobaKontaktowa);
            this.Controls.Add(this.lab_mail);
            this.Controls.Add(this.lab_data);
            this.Controls.Add(this.lab_vat);
            this.Controls.Add(this.lab_kodPocztowy);
            this.Controls.Add(this.lab_nazwa);
            this.Controls.Add(this.dgv1_wybraneProdukty);
            this.Controls.Add(this.lab_ulica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Zamowienie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamówienie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Zamowienie_FormClosing);
            this.Load += new System.EventHandler(this.Zamowienie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_wybraneProdukty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_ulica;
        private System.Windows.Forms.Label lab_nazwa;
        private System.Windows.Forms.Label lab_kodPocztowy;
        private System.Windows.Forms.Label lab_vat;
        private System.Windows.Forms.Label lab_data;
        private System.Windows.Forms.Label lab_mail;
        private System.Windows.Forms.Label lab_osobaKontaktowa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button but_zatwierdź;
        public System.Windows.Forms.DataGridView dgv1_wybraneProdukty;
        private System.Windows.Forms.Label lab_termin;
        private System.Windows.Forms.Label lab_deadline;
        private System.Windows.Forms.Label lab_miasto;
        private System.Windows.Forms.Label lab_kraj;
    }
}