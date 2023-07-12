using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matematik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            /* Kullanıcının girmiş olduğu 2 degerler arasında rastgele yine 
            * kullanıcının girmiş oldugu deger kadar tekrarlamayan tek sayılardan oluşan 
            * bir dizi oluşturun ve elemanlarını gösteriniz */

            if (txt_o24_1.Text != "" && txt_o24_2.Text != "" && txt_o24_3.Text != "")
            {
                int veri_1 = Convert.ToInt32(txt_o24_1.Text);
                int veri_2 = Convert.ToInt32(txt_o24_2.Text);
                int eleman_sayisi = Convert.ToInt32(txt_o24_3.Text);

                int[] dizi = new int[eleman_sayisi];
                Random rastgele = new Random();
                int sayi_kucuk = 0;
                int sayi_buyuk = 0;

                if (veri_1 < veri_2)
                {
                    sayi_kucuk = veri_1;
                    sayi_buyuk = veri_2;
                }
                else
                {
                    sayi_kucuk = veri_2;
                    sayi_buyuk = veri_1;
                }

                int kontrol = 0;

                for (int i = 0; i < eleman_sayisi; i = i + 1)//dizi elemanları arasında gezinti yapmamızı saglayacak
                {
                    int uretilen_sayi = rastgele.Next(sayi_kucuk, sayi_buyuk);

                    if (uretilen_sayi % 2 == 1)//tek kontrolü
                    {
                        for (int j = 0; j < i; j = j + 1)
                        {
                            if (dizi[j] == uretilen_sayi)// üretilen sayı diziye daha önce eklenmiş
                            {
                                kontrol = 1;
                            }
                        }

                        if (kontrol == 1)//
                        {
                            i = i - 1;
                            kontrol = 0;
                        }
                        else
                        {
                            dizi[i] = uretilen_sayi;
                            lb_o24.Items.Add(dizi[i]);
                        }

                    }
                    else
                    {
                        i = i - 1;
                    }

                }
                

               

                int en_kucuk_deger = dizi[0];

                for (int k = 0; k < dizi.Length; k++)
                {
                    if (dizi[k] < en_kucuk_deger)
                    {
                        en_kucuk_deger = dizi[k];
                    }
                }
                txt_sonuc.Text = Convert.ToString(en_kucuk_deger);
            }
            else
            {
                MessageBox.Show("Eksik bilgi girildi");
                txt_o24_1.Focus();
            }
        }
    }
}
