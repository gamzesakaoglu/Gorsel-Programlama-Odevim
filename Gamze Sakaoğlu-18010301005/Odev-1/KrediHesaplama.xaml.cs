using Microsoft.Maui.Controls;

namespace Odev1
{
    public partial class KrediHesaplamaPage : ContentPage
    {
        public KrediHesaplamaPage()
        {
            InitializeComponent();
        }
        private void Button_Hesapla_Clicked(object sender, EventArgs e)
        {
            double krediTutari = double.Parse(KrediTutariEntry.Text);
            double faizOrani = double.Parse(FaizOraniEntry.Text);
            double vadeSuresi = double.Parse(VadeSuresiEntry.Text);

            double aylikFaizOrani = faizOrani / 1200; // % cinsinden faiz oran�n� ayl�k faiz oran�na �evirir
            double aylikOdeme = 0;
            double toplamOdeme = 0;

            switch (KrediTuruPicker.SelectedItem.ToString())
            {
                case "�htiya� Kredisi":
                    double ihtiyacKrediKKDF = 0.15; // �rnek KKDF de�eri
                    double ihtiyacKrediBSMV = 0.10; // �rnek BSMV de�eri
                    aylikOdeme = (krediTutari * aylikFaizOrani) / (1 - Math.Pow(1 + aylikFaizOrani, -vadeSuresi));
                    aylikOdeme += aylikOdeme * ihtiyacKrediKKDF + aylikOdeme * ihtiyacKrediBSMV; // KKDF ve BSMV ekleniyor
                    toplamOdeme = aylikOdeme * vadeSuresi;
                    break;
                case "Konut Kredisi":
                   
                    aylikOdeme = (krediTutari * aylikFaizOrani) / (1 - Math.Pow(1 + aylikFaizOrani, -vadeSuresi));
                    toplamOdeme = aylikOdeme * vadeSuresi;
                    break;
                case "Ta��t Kredisi":
                    double konutKrediKKDF = 0.15; // �rnek KKDF de�eri
                    double konutKrediBSMV = 0.5; // �rnek BSMV de�eri
                    aylikOdeme = (krediTutari * aylikFaizOrani) / (1 - Math.Pow(1 + aylikFaizOrani, -vadeSuresi));
                    aylikOdeme += aylikOdeme * konutKrediKKDF + aylikOdeme * konutKrediBSMV; // KKDF ve BSMV ekleniyor
                    toplamOdeme = aylikOdeme * vadeSuresi;
                    break;
                case "Ticari Kredi":
                    double ticariKrediKKDF = 0.0; // �rnek KKDF de�eri
                    double ticariKrediBSMV = 0.5; // �rnek BSMV de�eri
                    aylikOdeme = (krediTutari * aylikFaizOrani) / (1 - Math.Pow(1 + aylikFaizOrani, -vadeSuresi));
                    aylikOdeme += aylikOdeme * ticariKrediKKDF + aylikOdeme * ticariKrediBSMV; // KKDF ve BSMV ekleniyor
                    toplamOdeme = aylikOdeme * vadeSuresi;
                    break;
            }

            AylikOdemeLabel.Text = aylikOdeme.ToString("C2");
            ToplamOdemeLabel.Text = toplamOdeme.ToString("C2");
        }
    }
}