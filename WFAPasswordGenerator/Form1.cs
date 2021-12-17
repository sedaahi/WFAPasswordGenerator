using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPasswordGenerator
{
    public partial class Form1 : Form
    {
        bool kucukHarfVarMi, buyukHarfVarMi, rakamVarMi, ozelKArakterVarMi;
        int sifreUzunlugu, sifreSayisi;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSifreUret_Click(object sender, EventArgs e)
        {
            richTxtSifreler.Text = "";
            kucukHarfVarMi = chkKucukHarf.Checked;
            buyukHarfVarMi = chkBuyukHarf.Checked;
            rakamVarMi = chkRakam.Checked;
            ozelKArakterVarMi = chkOzelKarakter.Checked;

            sifreUzunlugu = (int)nudSifreUzunlugu.Value;
            sifreSayisi = (int)nudSifreSayisi.Value;

            if (!(kucukHarfVarMi || buyukHarfVarMi || rakamVarMi || ozelKArakterVarMi))
            {
                MessageBox.Show("Lütfen bir parametre seçiniz!");
                return; //Boş check boxlaradan hiç birine tik atılmadığında ekrana "Lütfen bir parametre seçiniz" yazar
            }

            string selectedChars = "";
            KucukHarfEkle(ref selectedChars);
            BuyukHarfEkle(ref selectedChars);
            RakamEkle(ref selectedChars);
            OzelKarakterEkle(ref selectedChars);
            SifreUret(selectedChars);
            //Yukarıdaki4 metotun geri değer döndürmemesine ancak selectedChars değişkenini değiştirmesini istiyorum nasıl? CEVAP: private stringlerin stringi voide cevir içerideki reurnleri sil.  Yukarıdaki kucuk harf eklede string sil =>selectedChars=KucukHarfEkle(ref ekle....)
        }


        private void KucukHarfEkle(ref string selectedChars)
        {
            if (kucukHarfVarMi)
            {
                for (int i = 97; i < 123; i++)    //ASCII table dan değerler alınıyor
                {
                    selectedChars += Convert.ToChar(i);
                }
            }

        }
        private void BuyukHarfEkle(ref string selectedChars)
        {
            if (buyukHarfVarMi)
            {
                for (int i = 65; i < 91; i++)
                {
                    selectedChars += Convert.ToChar(i);
                }
            }

        }
        private void RakamEkle(ref string selectedChars)
        {
            if (rakamVarMi)
            {
                for (int i = 48; i < 58; i++)
                {
                    selectedChars += Convert.ToChar(i);
                }
            }

        }
        private void OzelKarakterEkle(ref string selectedChars)
        {
            if (ozelKArakterVarMi)
            {
                for (int i = 33; i < 48; i++)
                {
                    selectedChars += Convert.ToChar(i);
                }
            }

        }

        private void SifreUret(string selectedChars)
        {
            for (int i = 0; i < sifreSayisi; i++)
            {
                string sifre = "";
                for (int j = 0; j < sifreUzunlugu; j++)
                {
                    sifre += selectedChars[rnd.Next(selectedChars.Length)];
                }
                richTxtSifreler.Text += sifre;
                richTxtSifreler.Text += "\r\n\r\n";

            }
        }



    }
}
