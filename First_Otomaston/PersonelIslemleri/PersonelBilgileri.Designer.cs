namespace First_Otomaston
{
    partial class PersonelBilgileri
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
            this.DataGridPersoneller = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chcboxAdanZye = new System.Windows.Forms.CheckBox();
            this.chcboxZdanAya = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridPersoneller
            // 
            this.DataGridPersoneller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPersoneller.Location = new System.Drawing.Point(12, 89);
            this.DataGridPersoneller.Name = "DataGridPersoneller";
            this.DataGridPersoneller.RowHeadersVisible = false;
            this.DataGridPersoneller.Size = new System.Drawing.Size(1048, 427);
            this.DataGridPersoneller.TabIndex = 0;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 48);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(196, 20);
            this.txtAra.TabIndex = 1;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam Personel Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // chcboxAdanZye
            // 
            this.chcboxAdanZye.AutoSize = true;
            this.chcboxAdanZye.Location = new System.Drawing.Point(420, 55);
            this.chcboxAdanZye.Name = "chcboxAdanZye";
            this.chcboxAdanZye.Size = new System.Drawing.Size(76, 17);
            this.chcboxAdanZye.TabIndex = 4;
            this.chcboxAdanZye.Text = "A\'dan Z\'ye";
            this.chcboxAdanZye.UseVisualStyleBackColor = true;
            this.chcboxAdanZye.CheckedChanged += new System.EventHandler(this.chcboxAdanZye_CheckedChanged);
            // 
            // chcboxZdanAya
            // 
            this.chcboxZdanAya.AutoSize = true;
            this.chcboxZdanAya.Location = new System.Drawing.Point(512, 55);
            this.chcboxZdanAya.Name = "chcboxZdanAya";
            this.chcboxZdanAya.Size = new System.Drawing.Size(76, 17);
            this.chcboxZdanAya.TabIndex = 5;
            this.chcboxZdanAya.Text = "Z\'den A\'ya";
            this.chcboxZdanAya.UseVisualStyleBackColor = true;
            this.chcboxZdanAya.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PersonelBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 503);
            this.Controls.Add(this.chcboxZdanAya);
            this.Controls.Add(this.chcboxAdanZye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.DataGridPersoneller);
            this.Name = "PersonelBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelBilgileri";
            this.Load += new System.EventHandler(this.PersonelBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPersoneller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridPersoneller;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chcboxAdanZye;
        private System.Windows.Forms.CheckBox chcboxZdanAya;
    }
}