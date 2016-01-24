namespace Glass_Witch
{
    partial class Ilosc
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
            this.txt_ilosc = new System.Windows.Forms.TextBox();
            this.lab_ilosc = new System.Windows.Forms.Label();
            this.but_zatwierdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ilosc
            // 
            this.txt_ilosc.Location = new System.Drawing.Point(40, 24);
            this.txt_ilosc.Name = "txt_ilosc";
            this.txt_ilosc.Size = new System.Drawing.Size(79, 20);
            this.txt_ilosc.TabIndex = 0;
            this.txt_ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lab_ilosc
            // 
            this.lab_ilosc.AutoSize = true;
            this.lab_ilosc.Location = new System.Drawing.Point(37, 8);
            this.lab_ilosc.Name = "lab_ilosc";
            this.lab_ilosc.Size = new System.Drawing.Size(82, 13);
            this.lab_ilosc.TabIndex = 1;
            this.lab_ilosc.Text = "Wprowadź ilość";
            // 
            // but_zatwierdz
            // 
            this.but_zatwierdz.Location = new System.Drawing.Point(40, 50);
            this.but_zatwierdz.Name = "but_zatwierdz";
            this.but_zatwierdz.Size = new System.Drawing.Size(79, 23);
            this.but_zatwierdz.TabIndex = 2;
            this.but_zatwierdz.Text = "Ok";
            this.but_zatwierdz.UseVisualStyleBackColor = true;
            this.but_zatwierdz.Click += new System.EventHandler(this.but_zatwierdz_Click);
            // 
            // Ilosc
            // 
            this.AcceptButton = this.but_zatwierdz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 79);
            this.Controls.Add(this.but_zatwierdz);
            this.Controls.Add(this.lab_ilosc);
            this.Controls.Add(this.txt_ilosc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ilosc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ilosc;
        private System.Windows.Forms.Label lab_ilosc;
        private System.Windows.Forms.Button but_zatwierdz;
    }
}