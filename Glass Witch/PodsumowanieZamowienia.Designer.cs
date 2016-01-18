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
            this.but_doPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_doPDF
            // 
            this.but_doPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_doPDF.Location = new System.Drawing.Point(194, 226);
            this.but_doPDF.Name = "but_doPDF";
            this.but_doPDF.Size = new System.Drawing.Size(172, 47);
            this.but_doPDF.TabIndex = 0;
            this.but_doPDF.Text = "Generuj do PDF";
            this.but_doPDF.UseVisualStyleBackColor = true;
            this.but_doPDF.Click += new System.EventHandler(this.but_doPDF_Click);
            // 
            // PodsumowanieZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 285);
            this.Controls.Add(this.but_doPDF);
            this.Name = "PodsumowanieZamowienia";
            this.Text = "PodsumowanieZamowienia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_doPDF;
    }
}