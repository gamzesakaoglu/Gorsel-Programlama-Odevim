using Microsoft.Maui.Controls;

namespace Odev1
{
    public partial class VucutKitleIndeksiPage : ContentPage
    {
        public VucutKitleIndeksiPage()
        {
            InitializeComponent();
        }

        private void Button_Hesapla_Clicked(object sender, EventArgs e)
        {
            double boy = double.Parse(BoyEntry.Text);
            double kilo = double.Parse(KiloEntry.Text);

            double boyMetre = boy / 100; // cm cinsinden boyu metre cinsine çevirir
            double vki = kilo / (boyMetre * boyMetre);

            string vkiAciklama = "";
            if (vki < 15)
            {
                vkiAciklama = "Çok ciddi düzeyde zayýf";
            }
            else if (vki >= 15 && vki < 16)
            {
                vkiAciklama = "Ciddi düzeyde zayýf";
            }
            else if (vki >= 16 && vki < 18.5)
            {
                vkiAciklama = "Hafif düzeyde zayýf";
            }
            else if (vki >= 18.5 && vki < 25)
            {
                vkiAciklama = "Normal kilolu";
            }
            else if (vki >= 25 && vki < 30)
            {
                vkiAciklama = "Fazla kilolu";
            }
            else if (vki >= 30 && vki < 35)
            {
                vkiAciklama = "1. derece obez";
            }
            else if (vki >= 35 && vki < 40)
            {
                vkiAciklama = "2. derece obez";
            }
            else
            {
                vkiAciklama = "3. derece obez";
            }

            VKILabel.Text = $"Vücut Kitle Ýndeksi: {vki:F2} ({vkiAciklama})";
        }
    }
}
