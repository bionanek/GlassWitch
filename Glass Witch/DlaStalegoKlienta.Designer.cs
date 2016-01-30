namespace Glass_Witch
{
    partial class DlaStalegoKlienta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_szukajKlienta = new System.Windows.Forms.TextBox();
            this.lab_staliKlienci = new System.Windows.Forms.Label();
            this.dgv1_zamStaliKlienci = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.but_DoZamowienia = new System.Windows.Forms.Button();
            this.but_do_wprowadzania = new System.Windows.Forms.Button();
            this.txt_termin = new System.Windows.Forms.TextBox();
            this.lab_termin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_zamStaliKlienci)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_szukajKlienta
            // 
            this.txt_szukajKlienta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_szukajKlienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_szukajKlienta.Location = new System.Drawing.Point(88, 37);
            this.txt_szukajKlienta.Name = "txt_szukajKlienta";
            this.txt_szukajKlienta.Size = new System.Drawing.Size(152, 22);
            this.txt_szukajKlienta.TabIndex = 0;
            this.txt_szukajKlienta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_szukajKlienta.TextChanged += new System.EventHandler(this.txt_szukajKlienta_TextChanged_1);
            // 
            // lab_staliKlienci
            // 
            this.lab_staliKlienci.AutoSize = true;
            this.lab_staliKlienci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_staliKlienci.Location = new System.Drawing.Point(67, 9);
            this.lab_staliKlienci.Name = "lab_staliKlienci";
            this.lab_staliKlienci.Size = new System.Drawing.Size(200, 25);
            this.lab_staliKlienci.TabIndex = 1;
            this.lab_staliKlienci.Text = "SZUKAJ KLIENTA";
            // 
            // dgv1_zamStaliKlienci
            // 
            this.dgv1_zamStaliKlienci.AllowUserToAddRows = false;
            this.dgv1_zamStaliKlienci.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.NullValue = "brak";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgv1_zamStaliKlienci.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv1_zamStaliKlienci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1_zamStaliKlienci.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv1_zamStaliKlienci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv1_zamStaliKlienci.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1_zamStaliKlienci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv1_zamStaliKlienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1_zamStaliKlienci.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv1_zamStaliKlienci.Location = new System.Drawing.Point(41, 65);
            this.dgv1_zamStaliKlienci.Name = "dgv1_zamStaliKlienci";
            this.dgv1_zamStaliKlienci.ReadOnly = true;
            this.dgv1_zamStaliKlienci.RowHeadersVisible = false;
            this.dgv1_zamStaliKlienci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1_zamStaliKlienci.Size = new System.Drawing.Size(260, 241);
            this.dgv1_zamStaliKlienci.TabIndex = 3;
            this.dgv1_zamStaliKlienci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_zamStaliKlienci_CellClick);
            this.dgv1_zamStaliKlienci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_zamStaliKlienci_CellContentClick);
            this.dgv1_zamStaliKlienci.SelectionChanged += new System.EventHandler(this.dgv1_zamStaliKlienci_SelectionChanged);
            // 
            // but_DoZamowienia
            // 
            this.but_DoZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_DoZamowienia.Location = new System.Drawing.Point(149, 362);
            this.but_DoZamowienia.Name = "but_DoZamowienia";
            this.but_DoZamowienia.Size = new System.Drawing.Size(180, 45);
            this.but_DoZamowienia.TabIndex = 4;
            this.but_DoZamowienia.Text = "Przejdź do zamówenia";
            this.but_DoZamowienia.UseVisualStyleBackColor = true;
            this.but_DoZamowienia.Visible = false;
            this.but_DoZamowienia.Click += new System.EventHandler(this.but_DoZamowienia_Click);
            // 
            // but_do_wprowadzania
            // 
            this.but_do_wprowadzania.Location = new System.Drawing.Point(12, 362);
            this.but_do_wprowadzania.Name = "but_do_wprowadzania";
            this.but_do_wprowadzania.Size = new System.Drawing.Size(94, 45);
            this.but_do_wprowadzania.TabIndex = 5;
            this.but_do_wprowadzania.Text = "Wprowadź Nowego Klienta";
            this.but_do_wprowadzania.UseVisualStyleBackColor = true;
            this.but_do_wprowadzania.Click += new System.EventHandler(this.but_do_wprowadzania_Click);
            // 
            // txt_termin
            // 
            this.txt_termin.Location = new System.Drawing.Point(149, 336);
            this.txt_termin.Name = "txt_termin";
            this.txt_termin.Size = new System.Drawing.Size(136, 20);
            this.txt_termin.TabIndex = 6;
            // 
            // lab_termin
            // 
            this.lab_termin.AutoSize = true;
            this.lab_termin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_termin.Location = new System.Drawing.Point(190, 315);
            this.lab_termin.Name = "lab_termin";
            this.lab_termin.Size = new System.Drawing.Size(60, 18);
            this.lab_termin.TabIndex = 7;
            this.lab_termin.Text = "Termin";
            // 
            // DlaStalegoKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(342, 410);
            this.Controls.Add(this.lab_termin);
            this.Controls.Add(this.txt_termin);
            this.Controls.Add(this.but_do_wprowadzania);
            this.Controls.Add(this.but_DoZamowienia);
            this.Controls.Add(this.dgv1_zamStaliKlienci);
            this.Controls.Add(this.lab_staliKlienci);
            this.Controls.Add(this.txt_szukajKlienta);
            this.Name = "DlaStalegoKlienta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stali Klienci";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DlaStalegoKlienta_FormClosing);
            this.Load += new System.EventHandler(this.DlaStalegoKlienta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_zamStaliKlienci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_szukajKlienta;
        private System.Windows.Forms.Label lab_staliKlienci;
        private System.Windows.Forms.DataGridView dgv1_zamStaliKlienci;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button but_DoZamowienia;
        private System.Windows.Forms.Button but_do_wprowadzania;
        private System.Windows.Forms.TextBox txt_termin;
        private System.Windows.Forms.Label lab_termin;
    }
}