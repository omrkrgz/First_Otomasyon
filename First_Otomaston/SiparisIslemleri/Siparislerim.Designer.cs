﻿namespace First_Otomaston
{
    partial class Siparislerim
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
            this.dataGridSiparisler = new System.Windows.Forms.DataGridView();
            this.dateTimeilkTarih = new System.Windows.Forms.DateTimePicker();
            this.dateTimeSonTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSiparisler
            // 
            this.dataGridSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSiparisler.Location = new System.Drawing.Point(7, 187);
            this.dataGridSiparisler.Name = "dataGridSiparisler";
            this.dataGridSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSiparisler.Size = new System.Drawing.Size(1352, 407);
            this.dataGridSiparisler.TabIndex = 0;
            // 
            // dateTimeilkTarih
            // 
            this.dateTimeilkTarih.Location = new System.Drawing.Point(66, 4);
            this.dateTimeilkTarih.Name = "dateTimeilkTarih";
            this.dateTimeilkTarih.Size = new System.Drawing.Size(200, 20);
            this.dateTimeilkTarih.TabIndex = 1;
            // 
            // dateTimeSonTarih
            // 
            this.dateTimeSonTarih.Location = new System.Drawing.Point(66, 32);
            this.dateTimeSonTarih.Name = "dateTimeSonTarih";
            this.dateTimeSonTarih.Size = new System.Drawing.Size(200, 20);
            this.dateTimeSonTarih.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "İlk Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Son Tarih:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tarihe Göre Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Siparislerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeSonTarih);
            this.Controls.Add(this.dateTimeilkTarih);
            this.Controls.Add(this.dataGridSiparisler);
            this.Name = "Siparislerim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparislerim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Siparislerim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSiparisler;
        private System.Windows.Forms.DateTimePicker dateTimeilkTarih;
        private System.Windows.Forms.DateTimePicker dateTimeSonTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}