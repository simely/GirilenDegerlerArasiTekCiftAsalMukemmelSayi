namespace _210601029_Simel_Yüksel_Ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string baslik = "Programa Hoş Geldiniz!";
            string yazi = "Nesne Yönelimli Programlama Ödev 1";

            notifyIcon.ShowBalloonTip(3000, baslik, yazi, ToolTipIcon.Info);
        }

        private Boolean AsalSayiKontrol(int sayi)
        {
            int sayac = 0;

            for (int j = 1; j <= sayi; j++)
            {
                if (sayi % j == 0)
                    sayac++;
            }

            if (sayac == 2)
                return true;

            else
                return false;
        }

        private Boolean MukemmelSayiKontrol(int sayi)
        {
            int toplam = 0;

            for (int j = 1; j < sayi; j++)
            {
                if (sayi % j == 0)
                    toplam += j;
            }

            if (toplam == sayi)
                return true;

            else
                return false;
        }

        private void btnCalis_Click(object sender, EventArgs e)
        {
            int baslangic, bitis, i, tekToplam = 0, ciftToplam = 0, tekCarpim = 1, ciftCarpim = 1;
            int asalToplam = 0, mukemmelToplam = 0, asalCarpim = 1, mukemmelCarpim = 1;
            string sayi = "Sayilar:";
            string toplam = "Toplam:";
            string carpim = "Carpim:";

            baslangic = Convert.ToInt32(maskedTxtBaslangic.Text);
            bitis = Convert.ToInt32(maskedTxtBitis.Text);

            listViewTek.Items.Add(sayi);
            listViewCift.Items.Add(sayi);
            listViewAsal.Items.Add(sayi);
            listViewMukemmel.Items.Add(sayi);

            for (i = baslangic; i < bitis; i++)
            {
                if (i % 2 == 0)
                {
                    ciftToplam += i;
                    ciftCarpim *= i;
                    listViewCift.Items.Add(i.ToString());
                }

                else
                {
                    tekToplam += i;
                    tekCarpim *= i;
                    listViewTek.Items.Add(i.ToString());
                }

                if (AsalSayiKontrol(i))
                {
                    listViewAsal.Items.Add(i.ToString());
                    asalToplam += i;
                    asalCarpim *= i;
                }

                if (MukemmelSayiKontrol(i))
                {
                    listViewMukemmel.Items.Add(i.ToString());
                    mukemmelToplam += i;
                    mukemmelCarpim *= i;
                }
            }

            listViewCift.Items.Add(toplam);
            listViewCift.Items.Add(ciftToplam.ToString());
            listViewCift.Items.Add(carpim);
            listViewCift.Items.Add(ciftCarpim.ToString());
            listViewTek.Items.Add(toplam);
            listViewTek.Items.Add(tekToplam.ToString());
            listViewTek.Items.Add(carpim);
            listViewTek.Items.Add(tekCarpim.ToString());
            listViewAsal.Items.Add(toplam);
            listViewAsal.Items.Add(asalToplam.ToString());
            listViewAsal.Items.Add(carpim);
            listViewAsal.Items.Add(asalCarpim.ToString());
            listViewMukemmel.Items.Add(toplam);
            listViewMukemmel.Items.Add(mukemmelToplam.ToString());
            listViewMukemmel.Items.Add(carpim);
            listViewMukemmel.Items.Add(mukemmelCarpim.ToString());
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            maskedTxtBaslangic.Text = "";
            maskedTxtBitis.Text = "";
            listViewTek.Clear();
            listViewCift.Clear();
            listViewAsal.Clear();
            listViewMukemmel.Clear();
        }
    }
}