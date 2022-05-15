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
    public partial class girisEkran : Form
    {
       
        public class bilgiler
        {
            public static string gidenAd = "";
            public static string gidenSoyAd = "";
            public static string sure = "";
            public static string talepEdilenUrun = "";
            public static string urunMiktari = "";
        }    
        
        public girisEkran()
        {
            InitializeComponent();
        }

        private void girisEkran_Enter(object sender, EventArgs e)
        {
            oyunForm oyunForm = new oyunForm();
            oyunForm.ShowDialog();

        }

        private void baslatButton_Click(object sender, EventArgs e)
        {

            oyunForm oyunForm = new oyunForm();
            oyunForm.kalanUrunLabel.Text = urunMiktariGirisText.Text;
            
            bilgiler.gidenAd = musteriAdGirisText.Text;
            bilgiler.gidenSoyAd = musteriSoyadGirisText.Text;
            bilgiler.talepEdilenUrun = talepEdilenUrunGirisText.Text;
            bilgiler.urunMiktari = urunMiktariGirisText.Text;
                        
            oyunForm.Show();
            Hide();

        }


        private void bilgiLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyuncuyu sağa oynatmak için A, sola oynatmak için D tuşlarını kullanınız." +
                            "Oyunu durdurmak ve devam ettirmek için 'P' tuşunu kullanınız.");
        }

        private void musteriAdGirisText_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
