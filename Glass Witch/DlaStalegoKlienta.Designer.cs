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
            this.txt_szukajKlienta = new System.Windows.Forms.TextBox();
            this.lab_szukajKlienta = new System.Windows.Forms.Label();
            this.but_szukajKlienta = new System.Windows.Forms.Button();
            this.dgv1_staliKlienci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_staliKlienci)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_szukajKlienta
            // 
            this.txt_szukajKlienta.Location = new System.Drawing.Point(173, 38);
            this.txt_szukajKlienta.Multiline = true;
            this.txt_szukajKlienta.Name = "txt_szukajKlienta";
            this.txt_szukajKlienta.Size = new System.Drawing.Size(177, 31);
            this.txt_szukajKlienta.TabIndex = 0;
            this.txt_szukajKlienta.TextChanged += new System.EventHandler(this.txt_szukajKlienta_TextChanged);
            // 
            // lab_szukajKlienta
            // 
            this.lab_szukajKlienta.AutoSize = true;
            this.lab_szukajKlienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_szukajKlienta.Location = new System.Drawing.Point(172, 9);
            this.lab_szukajKlienta.Name = "lab_szukajKlienta";
            this.lab_szukajKlienta.Size = new System.Drawing.Size(178, 24);
            this.lab_szukajKlienta.TabIndex = 1;
            this.lab_szukajKlienta.Text = "SZUKAJ KLIENTA";
            // 
            // but_szukajKlienta
            // 
            this.but_szukajKlienta.Location = new System.Drawing.Point(208, 75);
            this.but_szukajKlienta.Name = "but_szukajKlienta";
            this.but_szukajKlienta.Size = new System.Drawing.Size(106, 36);
            this.but_szukajKlienta.TabIndex = 2;
            this.but_szukajKlienta.Text = "SZUKAJ";
            this.but_szukajKlienta.UseVisualStyleBackColor = true;
            this.but_szukajKlienta.Click += new System.EventHandler(this.but_szukajKlienta_Click);
            // 
            // dgv1_staliKlienci
            // 
            this.dgv1_staliKlienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1_staliKlienci.Location = new System.Drawing.Point(12, 117);
            this.dgv1_staliKlienci.Name = "dgv1_staliKlienci";
            this.dgv1_staliKlienci.Size = new System.Drawing.Size(522, 243);
            this.dgv1_staliKlienci.TabIndex = 3;
            // 
            // DlaStalegoKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 372);
            this.Controls.Add(this.dgv1_staliKlienci);
            this.Controls.Add(this.but_szukajKlienta);
            this.Controls.Add(this.lab_szukajKlienta);
            this.Controls.Add(this.txt_szukajKlienta);
            this.Name = "DlaStalegoKlienta";
            this.Text = "DlaStalegoKlienta";
            this.Load += new System.EventHandler(this.DlaStalegoKlienta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_staliKlienci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_szukajKlienta;
        private System.Windows.Forms.Label lab_szukajKlienta;
        private System.Windows.Forms.Button but_szukajKlienta;
        private System.Windows.Forms.DataGridView dgv1_staliKlienci;
    }
}