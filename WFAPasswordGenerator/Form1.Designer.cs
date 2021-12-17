
namespace WFAPasswordGenerator
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
            this.richTxtSifreler = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkKucukHarf = new System.Windows.Forms.CheckBox();
            this.chkBuyukHarf = new System.Windows.Forms.CheckBox();
            this.chkRakam = new System.Windows.Forms.CheckBox();
            this.chkOzelKarakter = new System.Windows.Forms.CheckBox();
            this.nudSifreSayisi = new System.Windows.Forms.NumericUpDown();
            this.nudSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.lblSifreSayisi = new System.Windows.Forms.Label();
            this.lblSifreUzunlugu = new System.Windows.Forms.Label();
            this.btnSifreUret = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).BeginInit();
            this.SuspendLayout();
            // 
            // richTxtSifreler
            // 
            this.richTxtSifreler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtSifreler.Enabled = false;
            this.richTxtSifreler.Location = new System.Drawing.Point(245, 12);
            this.richTxtSifreler.Name = "richTxtSifreler";
            this.richTxtSifreler.ReadOnly = true;
            this.richTxtSifreler.Size = new System.Drawing.Size(230, 278);
            this.richTxtSifreler.TabIndex = 8;
            this.richTxtSifreler.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSifreUret);
            this.groupBox1.Controls.Add(this.lblSifreUzunlugu);
            this.groupBox1.Controls.Add(this.lblSifreSayisi);
            this.groupBox1.Controls.Add(this.nudSifreUzunlugu);
            this.groupBox1.Controls.Add(this.nudSifreSayisi);
            this.groupBox1.Controls.Add(this.chkOzelKarakter);
            this.groupBox1.Controls.Add(this.chkRakam);
            this.groupBox1.Controls.Add(this.chkBuyukHarf);
            this.groupBox1.Controls.Add(this.chkKucukHarf);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 278);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametreler";
            // 
            // chkKucukHarf
            // 
            this.chkKucukHarf.AutoSize = true;
            this.chkKucukHarf.Location = new System.Drawing.Point(61, 33);
            this.chkKucukHarf.Name = "chkKucukHarf";
            this.chkKucukHarf.Size = new System.Drawing.Size(80, 17);
            this.chkKucukHarf.TabIndex = 0;
            this.chkKucukHarf.Text = "Küçük Harf";
            this.chkKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chkBuyukHarf
            // 
            this.chkBuyukHarf.AutoSize = true;
            this.chkBuyukHarf.Location = new System.Drawing.Point(61, 56);
            this.chkBuyukHarf.Name = "chkBuyukHarf";
            this.chkBuyukHarf.Size = new System.Drawing.Size(79, 17);
            this.chkBuyukHarf.TabIndex = 1;
            this.chkBuyukHarf.Text = "Büyük Harf";
            this.chkBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chkRakam
            // 
            this.chkRakam.AutoSize = true;
            this.chkRakam.Location = new System.Drawing.Point(61, 79);
            this.chkRakam.Name = "chkRakam";
            this.chkRakam.Size = new System.Drawing.Size(60, 17);
            this.chkRakam.TabIndex = 2;
            this.chkRakam.Text = "Rakam";
            this.chkRakam.UseVisualStyleBackColor = true;
            // 
            // chkOzelKarakter
            // 
            this.chkOzelKarakter.AutoSize = true;
            this.chkOzelKarakter.Location = new System.Drawing.Point(61, 102);
            this.chkOzelKarakter.Name = "chkOzelKarakter";
            this.chkOzelKarakter.Size = new System.Drawing.Size(101, 17);
            this.chkOzelKarakter.TabIndex = 3;
            this.chkOzelKarakter.Text = "Özel Karakterler";
            this.chkOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // nudSifreSayisi
            // 
            this.nudSifreSayisi.Location = new System.Drawing.Point(112, 172);
            this.nudSifreSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSifreSayisi.Name = "nudSifreSayisi";
            this.nudSifreSayisi.Size = new System.Drawing.Size(75, 20);
            this.nudSifreSayisi.TabIndex = 4;
            this.nudSifreSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSifreUzunlugu
            // 
            this.nudSifreUzunlugu.Location = new System.Drawing.Point(112, 198);
            this.nudSifreUzunlugu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSifreUzunlugu.Name = "nudSifreUzunlugu";
            this.nudSifreUzunlugu.Size = new System.Drawing.Size(75, 20);
            this.nudSifreUzunlugu.TabIndex = 5;
            this.nudSifreUzunlugu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSifreSayisi
            // 
            this.lblSifreSayisi.AutoSize = true;
            this.lblSifreSayisi.Location = new System.Drawing.Point(23, 174);
            this.lblSifreSayisi.Name = "lblSifreSayisi";
            this.lblSifreSayisi.Size = new System.Drawing.Size(58, 13);
            this.lblSifreSayisi.TabIndex = 6;
            this.lblSifreSayisi.Text = "Şifre Sayısı";
            // 
            // lblSifreUzunlugu
            // 
            this.lblSifreUzunlugu.AutoSize = true;
            this.lblSifreUzunlugu.Location = new System.Drawing.Point(23, 200);
            this.lblSifreUzunlugu.Name = "lblSifreUzunlugu";
            this.lblSifreUzunlugu.Size = new System.Drawing.Size(76, 13);
            this.lblSifreUzunlugu.TabIndex = 7;
            this.lblSifreUzunlugu.Text = "Şifre Uzunluğu";
            // 
            // btnSifreUret
            // 
            this.btnSifreUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreUret.Location = new System.Drawing.Point(112, 224);
            this.btnSifreUret.Name = "btnSifreUret";
            this.btnSifreUret.Size = new System.Drawing.Size(75, 29);
            this.btnSifreUret.TabIndex = 8;
            this.btnSifreUret.Text = "Üret";
            this.btnSifreUret.UseVisualStyleBackColor = true;
            this.btnSifreUret.Click += new System.EventHandler(this.btnSifreUret_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 303);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTxtSifreler);
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtSifreler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSifreUret;
        private System.Windows.Forms.Label lblSifreUzunlugu;
        private System.Windows.Forms.Label lblSifreSayisi;
        private System.Windows.Forms.NumericUpDown nudSifreUzunlugu;
        private System.Windows.Forms.NumericUpDown nudSifreSayisi;
        private System.Windows.Forms.CheckBox chkOzelKarakter;
        private System.Windows.Forms.CheckBox chkRakam;
        private System.Windows.Forms.CheckBox chkBuyukHarf;
        private System.Windows.Forms.CheckBox chkKucukHarf;
    }
}

