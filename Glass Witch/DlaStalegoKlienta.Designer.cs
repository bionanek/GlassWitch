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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_szukajKlienta = new System.Windows.Forms.TextBox();
            this.lab_staliKlienci = new System.Windows.Forms.Label();
            this.but_szukajKlienta = new System.Windows.Forms.Button();
            this.dgv1_zamStaliKlienci = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.but_DoZamowienia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_zamStaliKlienci)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_szukajKlienta
            // 
            this.txt_szukajKlienta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_szukajKlienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_szukajKlienta.Location = new System.Drawing.Point(93, 37);
            this.txt_szukajKlienta.Name = "txt_szukajKlienta";
            this.txt_szukajKlienta.Size = new System.Drawing.Size(152, 22);
            this.txt_szukajKlienta.TabIndex = 0;
            this.txt_szukajKlienta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lab_staliKlienci
            // 
            this.lab_staliKlienci.AutoSize = true;
            this.lab_staliKlienci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_staliKlienci.Location = new System.Drawing.Point(72, 9);
            this.lab_staliKlienci.Name = "lab_staliKlienci";
            this.lab_staliKlienci.Size = new System.Drawing.Size(200, 25);
            this.lab_staliKlienci.TabIndex = 1;
            this.lab_staliKlienci.Text = "SZUKAJ KLIENTA";
            // 
            // but_szukajKlienta
            // 
            this.but_szukajKlienta.Location = new System.Drawing.Point(119, 65);
            this.but_szukajKlienta.Name = "but_szukajKlienta";
            this.but_szukajKlienta.Size = new System.Drawing.Size(96, 35);
            this.but_szukajKlienta.TabIndex = 2;
            this.but_szukajKlienta.Text = "SZUKAJ";
            this.but_szukajKlienta.UseVisualStyleBackColor = true;
            this.but_szukajKlienta.Click += new System.EventHandler(this.but_szukajKlienta_Click);
            // 
            // dgv1_zamStaliKlienci
            // 
            this.dgv1_zamStaliKlienci.AllowUserToAddRows = false;
            this.dgv1_zamStaliKlienci.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = "brak";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv1_zamStaliKlienci.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1_zamStaliKlienci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1_zamStaliKlienci.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv1_zamStaliKlienci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv1_zamStaliKlienci.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1_zamStaliKlienci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1_zamStaliKlienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1_zamStaliKlienci.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1_zamStaliKlienci.Location = new System.Drawing.Point(41, 106);
            this.dgv1_zamStaliKlienci.Name = "dgv1_zamStaliKlienci";
            this.dgv1_zamStaliKlienci.ReadOnly = true;
            this.dgv1_zamStaliKlienci.RowHeadersVisible = false;
            this.dgv1_zamStaliKlienci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1_zamStaliKlienci.Size = new System.Drawing.Size(260, 241);
            this.dgv1_zamStaliKlienci.TabIndex = 3;
            this.dgv1_zamStaliKlienci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_zamStaliKlienci_CellClick);
            this.dgv1_zamStaliKlienci.SelectionChanged += new System.EventHandler(this.dgv1_zamStaliKlienci_SelectionChanged);
            // 
            // but_DoZamowienia
            // 
            this.but_DoZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_DoZamowienia.Location = new System.Drawing.Point(93, 353);
            this.but_DoZamowienia.Name = "but_DoZamowienia";
            this.but_DoZamowienia.Size = new System.Drawing.Size(152, 45);
            this.but_DoZamowienia.TabIndex = 4;
            this.but_DoZamowienia.Text = "Przejdź do zamówenia";
            this.but_DoZamowienia.UseVisualStyleBackColor = true;
            this.but_DoZamowienia.Visible = false;
            this.but_DoZamowienia.Click += new System.EventHandler(this.but_DoZamowienia_Click);
            // 
            // DlaStalegoKlienta
            // 
            this.AcceptButton = this.but_szukajKlienta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(342, 410);
            this.Controls.Add(this.but_DoZamowienia);
            this.Controls.Add(this.dgv1_zamStaliKlienci);
            this.Controls.Add(this.but_szukajKlienta);
            this.Controls.Add(this.lab_staliKlienci);
            this.Controls.Add(this.txt_szukajKlienta);
            this.Name = "DlaStalegoKlienta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DlaStalegoKlienta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DlaStalegoKlienta_FormClosing);
            this.Load += new System.EventHandler(this.DlaStalegoKlienta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_zamStaliKlienci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_szukajKlienta;
        private System.Windows.Forms.Label lab_staliKlienci;
        private System.Windows.Forms.Button but_szukajKlienta;
        private System.Windows.Forms.DataGridView dgv1_zamStaliKlienci;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button but_DoZamowienia;
    }
}