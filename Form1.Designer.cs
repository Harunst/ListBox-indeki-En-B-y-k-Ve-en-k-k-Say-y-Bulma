namespace ListBox_İçindeki_En_Büyük_Ve_en_küçük__Sayıyı_Bulma
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuyuk = new System.Windows.Forms.Label();
            this.lblKucuk = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSayi = new System.Windows.Forms.ListBox();
            this.btnbul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "En Büyük Sayı:";
            // 
            // lblBuyuk
            // 
            this.lblBuyuk.AutoSize = true;
            this.lblBuyuk.Location = new System.Drawing.Point(437, 104);
            this.lblBuyuk.Name = "lblBuyuk";
            this.lblBuyuk.Size = new System.Drawing.Size(47, 13);
            this.lblBuyuk.TabIndex = 1;
            this.lblBuyuk.Text = "lblBuyuk";
            // 
            // lblKucuk
            // 
            this.lblKucuk.AutoSize = true;
            this.lblKucuk.Location = new System.Drawing.Point(437, 129);
            this.lblKucuk.Name = "lblKucuk";
            this.lblKucuk.Size = new System.Drawing.Size(48, 13);
            this.lblKucuk.TabIndex = 3;
            this.lblKucuk.Text = "lblKucuk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "En Küçük  Sayı:";
            // 
            // lstSayi
            // 
            this.lstSayi.FormattingEnabled = true;
            this.lstSayi.Location = new System.Drawing.Point(137, 22);
            this.lstSayi.Name = "lstSayi";
            this.lstSayi.Size = new System.Drawing.Size(112, 212);
            this.lstSayi.TabIndex = 4;
            // 
            // btnbul
            // 
            this.btnbul.Location = new System.Drawing.Point(150, 240);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(75, 23);
            this.btnbul.TabIndex = 5;
            this.btnbul.Text = "Bul";
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbul);
            this.Controls.Add(this.lstSayi);
            this.Controls.Add(this.lblKucuk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBuyuk);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBuyuk;
        private System.Windows.Forms.Label lblKucuk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstSayi;
        private System.Windows.Forms.Button btnbul;
    }
}

