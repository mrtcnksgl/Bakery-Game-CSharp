﻿
namespace ndpProje
{
    partial class girisEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisEkran));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.bilgiLabel = new System.Windows.Forms.Label();
            this.baslatButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.urunMiktariGirisText = new System.Windows.Forms.TextBox();
            this.talepEdilenUrunGirisText = new System.Windows.Forms.TextBox();
            this.musteriSoyadGirisText = new System.Windows.Forms.TextBox();
            this.musteriAdGirisText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(341, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Köseoğlu Pastanesi - Hoşgeldiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.bilgiLabel);
            this.panel2.Controls.Add(this.baslatButton);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 646);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(215, 22);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(200, 200);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // bilgiLabel
            // 
            this.bilgiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiLabel.Location = new System.Drawing.Point(210, 348);
            this.bilgiLabel.Name = "bilgiLabel";
            this.bilgiLabel.Size = new System.Drawing.Size(312, 89);
            this.bilgiLabel.TabIndex = 4;
            this.bilgiLabel.Text = "Oyun tuş takım bilgisi için tıklayınız.";
            this.bilgiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bilgiLabel.Click += new System.EventHandler(this.bilgiLabel_Click);
            // 
            // baslatButton
            // 
            this.baslatButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.baslatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslatButton.ForeColor = System.Drawing.Color.Snow;
            this.baslatButton.Location = new System.Drawing.Point(837, 516);
            this.baslatButton.Name = "baslatButton";
            this.baslatButton.Size = new System.Drawing.Size(125, 50);
            this.baslatButton.TabIndex = 3;
            this.baslatButton.Text = "BAŞLAT";
            this.baslatButton.UseVisualStyleBackColor = false;
            this.baslatButton.Click += new System.EventHandler(this.baslatButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.urunMiktariGirisText);
            this.panel3.Controls.Add(this.talepEdilenUrunGirisText);
            this.panel3.Controls.Add(this.musteriSoyadGirisText);
            this.panel3.Controls.Add(this.musteriAdGirisText);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(696, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 257);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // urunMiktariGirisText
            // 
            this.urunMiktariGirisText.BackColor = System.Drawing.Color.AliceBlue;
            this.urunMiktariGirisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunMiktariGirisText.Location = new System.Drawing.Point(211, 210);
            this.urunMiktariGirisText.Name = "urunMiktariGirisText";
            this.urunMiktariGirisText.Size = new System.Drawing.Size(179, 30);
            this.urunMiktariGirisText.TabIndex = 4;
            // 
            // talepEdilenUrunGirisText
            // 
            this.talepEdilenUrunGirisText.BackColor = System.Drawing.Color.AliceBlue;
            this.talepEdilenUrunGirisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.talepEdilenUrunGirisText.Location = new System.Drawing.Point(211, 150);
            this.talepEdilenUrunGirisText.Name = "talepEdilenUrunGirisText";
            this.talepEdilenUrunGirisText.Size = new System.Drawing.Size(179, 30);
            this.talepEdilenUrunGirisText.TabIndex = 3;
            // 
            // musteriSoyadGirisText
            // 
            this.musteriSoyadGirisText.BackColor = System.Drawing.Color.AliceBlue;
            this.musteriSoyadGirisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriSoyadGirisText.Location = new System.Drawing.Point(211, 90);
            this.musteriSoyadGirisText.Name = "musteriSoyadGirisText";
            this.musteriSoyadGirisText.Size = new System.Drawing.Size(179, 30);
            this.musteriSoyadGirisText.TabIndex = 2;
            // 
            // musteriAdGirisText
            // 
            this.musteriAdGirisText.BackColor = System.Drawing.Color.AliceBlue;
            this.musteriAdGirisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriAdGirisText.Location = new System.Drawing.Point(211, 30);
            this.musteriAdGirisText.Name = "musteriAdGirisText";
            this.musteriAdGirisText.Size = new System.Drawing.Size(179, 30);
            this.musteriAdGirisText.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(19, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ürün Miktarı:";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(19, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Talep Edilen Ürün:";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(19, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Müşteri Soyadı:";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Müşteri Adı:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(210, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 89);
            this.label4.TabIndex = 0;
            this.label4.Text = "En iyi skorları görüntülemek için tıklayınız.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(210, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 89);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oyuna başlamak için bilgilerinizi girini ve BAŞLAT butonuna basınız.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(793, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 200);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(93, 454);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 89);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(93, 348);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // girisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 722);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "girisEkran";
            this.Text = "Köseoğlu Pastanesi";
            this.Enter += new System.EventHandler(this.girisEkran_Enter);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urunMiktariGirisText;
        private System.Windows.Forms.TextBox talepEdilenUrunGirisText;
        private System.Windows.Forms.Button baslatButton;
        private System.Windows.Forms.Label bilgiLabel;
        private System.Windows.Forms.TextBox musteriSoyadGirisText;
        private System.Windows.Forms.TextBox musteriAdGirisText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

