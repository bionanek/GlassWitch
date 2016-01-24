namespace Glass_Witch
{
    partial class WyborProduktow
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
            this.dgv1_produkty = new System.Windows.Forms.DataGridView();
            this.txt_szukaj = new System.Windows.Forms.TextBox();
            this.cmb_waluta = new System.Windows.Forms.ComboBox();
            this.lab_waluta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv1_wybraneProdukty = new System.Windows.Forms.DataGridView();
            this.but_dodaj = new System.Windows.Forms.Button();
            this.but_doKlienta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_produkty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_wybraneProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1_produkty
            // 
            this.dgv1_produkty.AllowUserToAddRows = false;
            this.dgv1_produkty.AllowUserToDeleteRows = false;
            this.dgv1_produkty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv1_produkty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1_produkty.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv1_produkty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1_produkty.Location = new System.Drawing.Point(12, 197);
            this.dgv1_produkty.Name = "dgv1_produkty";
            this.dgv1_produkty.RowHeadersVisible = false;
            this.dgv1_produkty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1_produkty.Size = new System.Drawing.Size(551, 313);
            this.dgv1_produkty.TabIndex = 0;
            this.dgv1_produkty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_produkty_CellClick);
            // 
            // txt_szukaj
            // 
            this.txt_szukaj.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_szukaj.Location = new System.Drawing.Point(179, 157);
            this.txt_szukaj.Name = "txt_szukaj";
            this.txt_szukaj.Size = new System.Drawing.Size(160, 20);
            this.txt_szukaj.TabIndex = 1;
            this.txt_szukaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_szukaj.TextChanged += new System.EventHandler(this.txt_szukaj_TextChanged);
            // 
            // cmb_waluta
            // 
            this.cmb_waluta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_waluta.Items.AddRange(new object[] {
            "Euro €",
            "Dollar $",
            "Złoty -,"});
            this.cmb_waluta.Location = new System.Drawing.Point(480, 55);
            this.cmb_waluta.Name = "cmb_waluta";
            this.cmb_waluta.Size = new System.Drawing.Size(141, 21);
            this.cmb_waluta.TabIndex = 2;
            this.cmb_waluta.SelectedIndexChanged += new System.EventHandler(this.cmb_waluta_SelectedIndexChanged);
            // 
            // lab_waluta
            // 
            this.lab_waluta.AutoSize = true;
            this.lab_waluta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_waluta.Location = new System.Drawing.Point(492, 22);
            this.lab_waluta.Name = "lab_waluta";
            this.lab_waluta.Size = new System.Drawing.Size(112, 16);
            this.lab_waluta.TabIndex = 3;
            this.lab_waluta.Text = "Wybierz walutę";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(194, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Szukaj produktów";
            // 
            // dgv1_wybraneProdukty
            // 
            this.dgv1_wybraneProdukty.AllowUserToAddRows = false;
            this.dgv1_wybraneProdukty.AllowUserToDeleteRows = false;
            this.dgv1_wybraneProdukty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1_wybraneProdukty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1_wybraneProdukty.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv1_wybraneProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1_wybraneProdukty.Location = new System.Drawing.Point(583, 197);
            this.dgv1_wybraneProdukty.Name = "dgv1_wybraneProdukty";
            this.dgv1_wybraneProdukty.RowHeadersVisible = false;
            this.dgv1_wybraneProdukty.Size = new System.Drawing.Size(551, 313);
            this.dgv1_wybraneProdukty.TabIndex = 5;
            // 
            // but_dodaj
            // 
            this.but_dodaj.Enabled = false;
            this.but_dodaj.Location = new System.Drawing.Point(401, 154);
            this.but_dodaj.Name = "but_dodaj";
            this.but_dodaj.Size = new System.Drawing.Size(100, 23);
            this.but_dodaj.TabIndex = 6;
            this.but_dodaj.Text = "Dodaj ";
            this.but_dodaj.UseVisualStyleBackColor = true;
            this.but_dodaj.Click += new System.EventHandler(this.but_dodaj_Click);
            // 
            // but_doKlienta
            // 
            this.but_doKlienta.Location = new System.Drawing.Point(973, 22);
            this.but_doKlienta.Name = "but_doKlienta";
            this.but_doKlienta.Size = new System.Drawing.Size(161, 54);
            this.but_doKlienta.TabIndex = 7;
            this.but_doKlienta.Text = "Dalej";
            this.but_doKlienta.UseVisualStyleBackColor = true;
            this.but_doKlienta.Click += new System.EventHandler(this.but_doKlienta_Click);
            // 
            // WyborProduktow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1146, 522);
            this.Controls.Add(this.but_doKlienta);
            this.Controls.Add(this.but_dodaj);
            this.Controls.Add(this.dgv1_wybraneProdukty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_waluta);
            this.Controls.Add(this.cmb_waluta);
            this.Controls.Add(this.txt_szukaj);
            this.Controls.Add(this.dgv1_produkty);
            this.Name = "WyborProduktow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WyborProduktow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WyborProduktow_FormClosing);
            this.Load += new System.EventHandler(this.WyborProduktow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_produkty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_wybraneProdukty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1_produkty;
        private System.Windows.Forms.TextBox txt_szukaj;
        private System.Windows.Forms.ComboBox cmb_waluta;
        private System.Windows.Forms.Label lab_waluta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv1_wybraneProdukty;
        private System.Windows.Forms.Button but_dodaj;
        private System.Windows.Forms.Button but_doKlienta;
    }
}