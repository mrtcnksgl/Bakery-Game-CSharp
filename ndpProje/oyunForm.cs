/*  Geliştirici   : Mertcan Köseoğlu
	Öğrenci No    : B201200032
	Ödev Açıklama : NDP Proje Ödevi
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndpProje
{
    public partial class oyunForm : Form
    {

        public int sure = 120;

        public Random rnd = new Random();

        girisEkran giris = new girisEkran();


        public int kekSayi = 0;
        public int kremaSayi = 0;
        public int kahveSayi = 0;
        public int kronometre;

        private int kalan;
        private int yapılan;

        public oyunForm()
        {
            InitializeComponent();
        }

        private void musteriİsimLabel_Click(object sender, EventArgs e)
        {

        }

        private void oyunForm_Load(object sender, EventArgs e)
        {
            musteriİsimLabel.Text = girisEkran.bilgiler.gidenAd.ToString() + " "
                                  + girisEkran.bilgiler.gidenSoyAd.ToString();
            sureLabel.Text = girisEkran.bilgiler.sure.ToString();
            urunAdiLabel.Text = girisEkran.bilgiler.talepEdilenUrun.ToString();

            oyunKekPictureBox.Top = -50;
            oyunKremaPictureBox.Top = -100;
            oyunKahvePictureBox.Top = -150;
            oyunSurprizKutuPictureBox.Top = -500;

        }

        private void oyunSureTimer_Tick(object sender, EventArgs e)
        {

            sure -= 1;
            sureLabel.Text = sure.ToString();


        }

        private void oyunForm_KeyDown(object sender, KeyEventArgs e)
        {
            int yatay = chefPictureBox.Location.X;

            if (e.KeyCode == Keys.A && chefPictureBox.Left > 0)
            {
                yatay -= 10;
            }
            if (e.KeyCode == Keys.D && (chefPictureBox.Width + chefPictureBox.Left) < 712)
            {
                yatay += 10;

            }

            chefPictureBox.Location = new Point(yatay, 0);

            if (malzemeTimer.Enabled == true && oyunSureTimer.Enabled == true)
            {
                if (e.KeyCode == Keys.P)
                {
                    oyunSureTimer.Stop();
                    malzemeTimer.Stop();
                }

            }
            else if (malzemeTimer.Enabled == false && oyunSureTimer.Enabled == false)
            {
                if (e.KeyCode == Keys.P)
                {
                    malzemeTimer.Start();
                    oyunSureTimer.Start();

                }

            }
        }

        private void oyunKekPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void malzemeTimer_Tick(object sender, EventArgs e)
        {
            oyunKekPictureBox.Top += 5;
            oyunKekPictureBox2.Top += 5;
            oyunKremaPictureBox.Top += 5;
            oyunKremaPictureBox2.Top += 5;
            oyunKahvePictureBox.Top += 5;
            oyunKahvePictureBox2.Top += 5;



            //if (kronometre > 500)
            //{
            //    oyunKekPictureBox.Top += 5;
            //    oyunKekPictureBox2.Top += 5;
            //    oyunKremaPictureBox.Top += 5;
            //    oyunKremaPictureBox2.Top += 5;
            //    oyunKahvePictureBox.Top += 5;
            //    oyunKahvePictureBox2.Top += 5;
            //}
            //else
            //{
            //    oyunKekPictureBox.Top += 2;
            //    oyunKekPictureBox2.Top += 2;
            //    oyunKremaPictureBox.Top += 2;
            //    oyunKremaPictureBox2.Top += 2;
            //    oyunKahvePictureBox.Top += 2;
            //    oyunKahvePictureBox2.Top += 2;
            //}


            if (oyunKekPictureBox.Top > 769 + oyunKekPictureBox.Height)
            {
                oyunKekPictureBox.Left = rnd.Next(oyunAlanıPanel.Width - 50);
                oyunKekPictureBox.Top = -25;
            }
            if (oyunKekPictureBox.Top == 480 && !(oyunKekPictureBox.Left + oyunKekPictureBox.Width < chefPictureBox.Left) && !(chefPictureBox.Left + chefPictureBox.Width < oyunKekPictureBox.Left))
            {
                kekSayi++;
                oyunKekPictureBox.Top = -15;
                oyunKekPictureBox.Left = rnd.Next(oyunAlanıPanel.Width - 50);
                kekSayısıLabel.Text = kekSayi.ToString();
            }
            if (oyunKekPictureBox2.Top > 769 + oyunKekPictureBox2.Height)
            {
                oyunKekPictureBox2.Left = rnd.Next(oyunAlanıPanel.Width - 50);
                oyunKekPictureBox2.Top = -25;
            }
            if (oyunKekPictureBox2.Top == 480 && !(oyunKekPictureBox2.Left + oyunKekPictureBox2.Width < chefPictureBox.Left) && !(chefPictureBox.Left + chefPictureBox.Width < oyunKekPictureBox2.Left))
            {
                kekSayi++;
                oyunKekPictureBox2.Top = -15;
                oyunKekPictureBox2.Left = rnd.Next(oyunAlanıPanel.Width - 50);
                kekSayısıLabel.Text = kekSayi.ToString();
            }


            if (oyunKremaPictureBox.Top > 769 + oyunKremaPictureBox.Height)
            {
                oyunKremaPictureBox.Left = rnd.Next(oyunAlanıPanel.Width - 50);
                oyunKremaPictureBox.Top = -25;
            }
            if (oyunKremaPictureBox.Top == 480 && !(oyunKremaPictureBox.Left + oyunKremaPictureBox.Width < chefPictureBox.Left) && !(chefPictureBox.Left + chefPictureBox.Width < oyunKremaPictureBox.Left))
            {
                kremaSayi++;
                oyunKremaPictureBox.Top = -15;
                oyunKremaPictureBox.Left = rnd.Next(oyunAlanıPanel.Width - 50);
                kremaSayısıLabel.Text = kremaSayi.ToString();

            }
            if (oyunKremaPictureBox2.Top > 769 + oyunKremaPictureBox2.Height)
            {
                oyunKremaPictureBox2.Left = rnd.Next(oyunAlanıPanel.Width - 50);
                oyunKremaPictureBox2.Top = -25;
            }
            if (oyunKremaPictureBox2.Top == 480 && !(oyunKremaPictureBox2.Left + oyunKremaPictureBox2.Width < chefPictureBox.Left) && !(chefPictureBox.Left + chefPictureBox.Width < oyunKremaPictureBox2.Left))
            {
                kremaSayi++;
                oyunKremaPictureBox2.Top = -15;
                oyunKremaPictureBox2.Left = rnd.Next(oyunAlanıPanel.Width - 50);
                kremaSayısıLabel.Text = kremaSayi.ToString();

            }


            if (oyunKahvePictureBox.Top > 769 + oyunKahvePictureBox.Height)
            {
                oyunKahvePictureBox.Left = rnd.Next(oyunAlanıPanel.Width - 50);
                oyunKahvePictureBox.Top = -25;
            }
            if (oyunKahvePictureBox.Top == 480 && !(oyunKahvePictureBox.Left + oyunKahvePictureBox.Width < chefPictureBox.Left) && !(chefPictureBox.Left + chefPictureBox.Width < oyunKahvePictureBox.Left))
            {
                kahveSayi++;
                oyunKahvePictureBox.Top = -15;
                oyunKahvePictureBox.Left = rnd.Next(oyunAlanıPanel.Width - 50);
                kahveSayısıLabel.Text = kahveSayi.ToString();
            }
            if (oyunKahvePictureBox2.Top > 769 + oyunKahvePictureBox2.Height)
            {
                oyunKahvePictureBox2.Left = rnd.Next(oyunAlanıPanel.Width - 50);
                oyunKahvePictureBox2.Top = -25;
            }
            if (oyunKahvePictureBox2.Top == 480 && !(oyunKahvePictureBox2.Left + oyunKahvePictureBox2.Width < chefPictureBox.Left) && !(chefPictureBox.Left + chefPictureBox.Width < oyunKahvePictureBox2.Left))
            {
                kahveSayi++;
                oyunKahvePictureBox2.Top = -15;
                oyunKahvePictureBox2.Left = rnd.Next(oyunAlanıPanel.Width - 50);
                kahveSayısıLabel.Text = kahveSayi.ToString();
            }

            oyunSurprizKutuPictureBox.Top += 5;

            if (oyunSurprizKutuPictureBox.Top > 769 + oyunSurprizKutuPictureBox.Height)
            {
                oyunSurprizKutuPictureBox.Left = rnd.Next(oyunAlanıPanel.Width - 50);
                oyunSurprizKutuPictureBox.Top = -25;
            }
            if (oyunSurprizKutuPictureBox.Top == 480 && !(oyunSurprizKutuPictureBox.Left + oyunSurprizKutuPictureBox.Width < chefPictureBox.Left) && !(chefPictureBox.Left + chefPictureBox.Width < oyunSurprizKutuPictureBox.Left))
            {

                int random = rnd.Next(2);

                oyunSurprizKutuPictureBox.Top = -2000;
                oyunSurprizKutuPictureBox.Left = rnd.Next(oyunAlanıPanel.Width - 50);


                if (random == 0)
                {
                    kalan = Convert.ToInt32(kalanUrunLabel.Text);
                    if (yapılan > 0)
                    {
                        yapılan -= 1;
                        kalan += 1;
                        kalanUrunLabel.Text = kalan.ToString();
                        yapılanUrunLAbel.Text = yapılan.ToString();

                    }
                    else
                    {
                        yapılan = 0;
                        kalan += 1;
                        kalanUrunLabel.Text = kalan.ToString();
                        yapılanUrunLAbel.Text = yapılan.ToString();
                    }

                }
                if (random == 1)
                {
                    kalan = Convert.ToInt32(kalanUrunLabel.Text);
                    if (kalan > 0)
                    {
                        kalan -= 1;
                        yapılan += 1;
                        kalanUrunLabel.Text = kalan.ToString();
                        yapılanUrunLAbel.Text = yapılan.ToString();

                    }
                    else
                    {
                        kalan = 0;
                        yapılan += 1;
                        kalanUrunLabel.Text = kalan.ToString();
                        yapılanUrunLAbel.Text = yapılan.ToString();

                    }

                }

            }

        }

        private void oyunBilgisiHesaplamaTimer_Tick(object sender, EventArgs e)
        {

            if (Convert.ToInt32(kalanUrunLabel.Text) > 0)
            {
                if (kekSayi >= 1 && kremaSayi >= 2 && kahveSayi >= 3)
                {
                    if ((kekSayi % 1) == 0 && (kremaSayi % 2 == 0 || kremaSayi % 2 == 1) && (kahveSayi % 3 == 0 || kahveSayi % 3 == 1 || kahveSayi % 3 == 2))
                    {
                        kalan = Convert.ToInt32(kalanUrunLabel.Text);
                        kalan -= 1;
                        kalanUrunLabel.Text = kalan.ToString();

                        yapılan += 1;
                        yapılanUrunLAbel.Text = yapılan.ToString();

                        kekSayi -= 1;
                        kahveSayi = (kahveSayi % 3);
                        kremaSayi = (kremaSayi % 2);

                        kekSayısıLabel.Text = kekSayi.ToString();
                        kremaSayısıLabel.Text = kremaSayi.ToString();
                        kahveSayısıLabel.Text = kahveSayi.ToString();
                    }
                }

            }

            if (Convert.ToInt32(kalanUrunLabel.Text) == 0)
            {
                oyunBilgisiHesaplamaTimer.Stop();
                oyunSureTimer.Stop();
                malzemeTimer.Stop();

                MessageBox.Show(120 - Convert.ToInt32(sureLabel.Text) + " SANİYE İÇİNDE GÖREVİ BAŞARIYLA TAMAMLADINIZ!");
                Close();
                Application.Exit();

            }
        }
    }
}
