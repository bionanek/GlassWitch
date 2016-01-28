namespace Glass_Witch
{
    partial class PodsumowanieZamówienia1
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
            this.GenerujPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerujPDF
            // 
            this.GenerujPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerujPDF.Location = new System.Drawing.Point(12, 12);
            this.GenerujPDF.Name = "GenerujPDF";
            this.GenerujPDF.Size = new System.Drawing.Size(377, 214);
            this.GenerujPDF.TabIndex = 0;
            this.GenerujPDF.Text = "GENERUJ PDF";
            this.GenerujPDF.UseVisualStyleBackColor = true;
            this.GenerujPDF.Click += new System.EventHandler(this.GenerujPDF_Click);
            // 
            // PodsumowanieZamówienia1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 238);
            this.Controls.Add(this.GenerujPDF);
            this.Name = "PodsumowanieZamówienia1";
            this.Text = "PDF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerujPDF;
    }
}