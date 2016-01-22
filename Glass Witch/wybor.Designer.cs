namespace Glass_Witch
{
    partial class wybor
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
            this.but_nowy_klient = new System.Windows.Forms.Button();
            this.but_staly_klient = new System.Windows.Forms.Button();
            this.but_powrot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_nowy_klient
            // 
            this.but_nowy_klient.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.but_nowy_klient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_nowy_klient.Location = new System.Drawing.Point(12, 12);
            this.but_nowy_klient.Name = "but_nowy_klient";
            this.but_nowy_klient.Size = new System.Drawing.Size(665, 97);
            this.but_nowy_klient.TabIndex = 0;
            this.but_nowy_klient.Text = "Dla Nowego Klienta";
            this.but_nowy_klient.UseVisualStyleBackColor = true;
            this.but_nowy_klient.Click += new System.EventHandler(this.but_nowy_klient_Click);
            // 
            // but_staly_klient
            // 
            this.but_staly_klient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_staly_klient.Location = new System.Drawing.Point(12, 115);
            this.but_staly_klient.Name = "but_staly_klient";
            this.but_staly_klient.Size = new System.Drawing.Size(665, 97);
            this.but_staly_klient.TabIndex = 1;
            this.but_staly_klient.Text = "Dla Stałego Klienta";
            this.but_staly_klient.UseVisualStyleBackColor = true;
            this.but_staly_klient.Click += new System.EventHandler(this.but_staly_klient_Click);
            // 
            // but_powrot
            // 
            this.but_powrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_powrot.Location = new System.Drawing.Point(243, 218);
            this.but_powrot.Name = "but_powrot";
            this.but_powrot.Size = new System.Drawing.Size(189, 97);
            this.but_powrot.TabIndex = 2;
            this.but_powrot.Text = "Powrót";
            this.but_powrot.UseVisualStyleBackColor = true;
            this.but_powrot.Click += new System.EventHandler(this.but_powrot_Click);
            // 
            // wybor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(690, 328);
            this.Controls.Add(this.but_powrot);
            this.Controls.Add(this.but_staly_klient);
            this.Controls.Add(this.but_nowy_klient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(706, 367);
            this.MinimumSize = new System.Drawing.Size(706, 367);
            this.Name = "wybor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wybór rodzaju zamówienia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wybor_FormClosing);
            this.Load += new System.EventHandler(this.wybor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_nowy_klient;
        private System.Windows.Forms.Button but_staly_klient;
        private System.Windows.Forms.Button but_powrot;
    }
}