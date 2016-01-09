namespace Glass_Witch
{
    partial class WszystkieZamowienia
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
            this.dgv1_zamowienia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_zamowienia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1_zamowienia
            // 
            this.dgv1_zamowienia.AllowUserToAddRows = false;
            this.dgv1_zamowienia.AllowUserToDeleteRows = false;
            this.dgv1_zamowienia.AllowUserToOrderColumns = true;
            this.dgv1_zamowienia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1_zamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1_zamowienia.Location = new System.Drawing.Point(12, 30);
            this.dgv1_zamowienia.Name = "dgv1_zamowienia";
            this.dgv1_zamowienia.RowHeadersVisible = false;
            this.dgv1_zamowienia.Size = new System.Drawing.Size(1106, 596);
            this.dgv1_zamowienia.TabIndex = 0;
            // 
            // WszystkieZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1130, 638);
            this.Controls.Add(this.dgv1_zamowienia);
            this.Name = "WszystkieZamowienia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wszystkie Zamówienia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WszystkieZamowienia_FormClosing);
            this.Load += new System.EventHandler(this.WszystkieZamowienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1_zamowienia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1_zamowienia;
    }
}