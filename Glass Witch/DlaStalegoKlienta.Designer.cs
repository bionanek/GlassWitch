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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_szukajKlienta = new System.Windows.Forms.TextBox();
            this.lab_staliKlienci = new System.Windows.Forms.Label();
            this.but_szukajKlienta = new System.Windows.Forms.Button();
            this.dgv1_zamStaliKlienci = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
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
            this.but_szukajKlienta.Location = new System.Drawing.Point(115, 65);
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
            dataGridViewCellStyle3.NullValue = "brak";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv1_zamStaliKlienci.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1_zamStaliKlienci.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv1_zamStaliKlienci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv1_zamStaliKlienci.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv1_zamStaliKlienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1_zamStaliKlienci.Location = new System.Drawing.Point(32, 161);
            this.dgv1_zamStaliKlienci.Name = "dgv1_zamStaliKlienci";
            this.dgv1_zamStaliKlienci.ReadOnly = true;
            this.dgv1_zamStaliKlienci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1_zamStaliKlienci.Size = new System.Drawing.Size(260, 150);
            this.dgv1_zamStaliKlienci.TabIndex = 3;
            this.dgv1_zamStaliKlienci.SelectionChanged += new System.EventHandler(this.dgv1_zamStaliKlienci_SelectionChanged);
            // 
            // DlaStalegoKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(353, 359);
            this.Controls.Add(this.dgv1_zamStaliKlienci);
            this.Controls.Add(this.but_szukajKlienta);
            this.Controls.Add(this.lab_staliKlienci);
            this.Controls.Add(this.txt_szukajKlienta);
            this.Name = "DlaStalegoKlienta";
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
    }
}