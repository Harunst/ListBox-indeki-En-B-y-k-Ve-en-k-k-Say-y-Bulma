using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_İçindeki_En_Büyük_Ve_en_küçük__Sayıyı_Bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayi;
            for (int i = 1; i <= 20; i++)
            {
                sayi = random.Next(1, 100);
                lstSayi.Items.Add(sayi);
            }
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            int kucuk, buyuk;
            int buyukIndeks = 0;
            kucuk = Convert.ToInt32(lstSayi.Items[0]);
            buyuk = Convert.ToInt32(lstSayi.Items[0]);
            int sayi;
            for (int i = 0; i < lstSayi.Items.Count; i++)
            {
                sayi = Convert.ToInt32(lstSayi.Items[i]);

                if (buyuk < sayi)
                {
                    buyuk = sayi;
                    buyukIndeks = i;
                }

                if (kucuk > sayi)
                {
                    kucuk = sayi;
                }

            }
            lblBuyuk.Text = "En Büyük Sayı : " + buyuk;
            lblKucuk.Text = "En Küçük Sayı : " + kucuk;
            lstSayi.SelectedIndex = buyukIndeks;
        }
    }
}
