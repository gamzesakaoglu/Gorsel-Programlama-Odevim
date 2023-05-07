using Microsoft.Maui.Controls;


namespace Odev1
{
    public partial class RenkSeciciPage : ContentPage
    {
        public RenkSeciciPage()
        {
            InitializeComponent();

            // Sliderlar de�i�ti�inde ColorBox'u g�ncelle
            RedSlider.ValueChanged += Slider_ValueChanged;
            GreenSlider.ValueChanged += Slider_ValueChanged;
            BlueSlider.ValueChanged += Slider_ValueChanged;

            // Ba�lang�� rengi olarak siyah� ayarla
            SetColorBoxColor(0, 0, 0);
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double red = RedSlider.Value;
            double green = GreenSlider.Value;
            double blue = BlueSlider.Value;

            SetColorBoxColor(red, green, blue);

            // RGB kodunu g�ncelle
            RGBKodLabel.Text = $"#{((int)red):X2}{((int)green):X2}{((int)blue):X2}";
        }

        private void SetColorBoxColor(double red, double green, double blue)
        {
            ColorBox.Color = Color.FromRgb((int)red, (int)green, (int)blue);
        }

        private async void Button_Kopyala_Clicked(object sender, EventArgs e)
        {
            // RGB kodunu panoya kopyala
            await Clipboard.SetTextAsync(RGBKodLabel.Text);

            // Kullan�c�ya geri bildirim ver
            await DisplayAlert("Ba�ar�l�", "RGB kodu panoya kopyaland�", "Tamam");
        }
    }
}
