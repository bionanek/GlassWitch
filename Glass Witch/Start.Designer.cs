﻿namespace Glass_Witch
{
    partial class Start
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
            this.but_nowe = new System.Windows.Forms.Button();
            this.but_wykonane = new System.Windows.Forms.Button();
            this.but_wszystkie = new System.Windows.Forms.Button();
            this.but_klienci = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_nowe
            // 
            this.but_nowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.but_nowe.Location = new System.Drawing.Point(12, 78);
            this.but_nowe.Name = "but_nowe";
            this.but_nowe.Size = new System.Drawing.Size(225, 75);
            this.but_nowe.TabIndex = 0;
            this.but_nowe.Text = "Nowe Zamówienie";
            this.but_nowe.UseVisualStyleBackColor = true;
            this.but_nowe.Click += new System.EventHandler(this.but_nowe_Click);
            // 
            // but_wykonane
            // 
            this.but_wykonane.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_wykonane.Location = new System.Drawing.Point(12, 331);
            this.but_wykonane.Name = "but_wykonane";
            this.but_wykonane.Size = new System.Drawing.Size(225, 75);
            this.but_wykonane.TabIndex = 2;
            this.but_wykonane.Text = "Zamówienia wykonane";
            this.but_wykonane.UseVisualStyleBackColor = true;
            // 
            // but_wszystkie
            // 
            this.but_wszystkie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_wszystkie.Location = new System.Drawing.Point(12, 202);
            this.but_wszystkie.Name = "but_wszystkie";
            this.but_wszystkie.Size = new System.Drawing.Size(225, 75);
            this.but_wszystkie.TabIndex = 1;
            this.but_wszystkie.Text = "Wszystkie Zamówienia";
            this.but_wszystkie.UseVisualStyleBackColor = true;
            // 
            // but_klienci
            // 
            this.but_klienci.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_klienci.Location = new System.Drawing.Point(12, 457);
            this.but_klienci.Name = "but_klienci";
            this.but_klienci.Size = new System.Drawing.Size(225, 71);
            this.but_klienci.TabIndex = 3;
            this.but_klienci.Text = "Stali Klienci";
            this.but_klienci.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1130, 638);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_klienci);
            this.Controls.Add(this.but_wszystkie);
            this.Controls.Add(this.but_wykonane);
            this.Controls.Add(this.but_nowe);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programoinator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_nowe;
        private System.Windows.Forms.Button but_wykonane;
        private System.Windows.Forms.Button but_wszystkie;
        private System.Windows.Forms.Button but_klienci;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
