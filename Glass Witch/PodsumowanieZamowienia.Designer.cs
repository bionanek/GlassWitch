namespace Glass_Witch
{
    partial class PodsumowanieZamowienia
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.but_generowanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(896, 386);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // but_generowanie
            // 
            this.but_generowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_generowanie.Location = new System.Drawing.Point(487, 12);
            this.but_generowanie.Name = "but_generowanie";
            this.but_generowanie.Size = new System.Drawing.Size(246, 23);
            this.but_generowanie.TabIndex = 1;
            this.but_generowanie.Text = "GENERUJ";
            this.but_generowanie.UseVisualStyleBackColor = true;
            this.but_generowanie.Click += new System.EventHandler(this.but_generowanie_Click);
            // 
            // PodsumowanieZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 386);
            this.Controls.Add(this.but_generowanie);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "PodsumowanieZamowienia";
            this.Text = "Podsumowanie Zamówienia";
            this.Load += new System.EventHandler(this.PodsumowanieZamowienia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button but_generowanie;
    }
}