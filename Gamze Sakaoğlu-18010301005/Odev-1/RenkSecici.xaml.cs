using Microsoft.Maui.Controls;


namespace Odev1
{
    public partial class RenkSeciciPage : ContentPage
    {
        public RenkSeciciPage()
        {
            InitializeComponent();

            // Sliderlar deðiþtiðinde ColorBox'u güncelle
            RedSlider.ValueChanged += Slider_ValueChanged;
            GreenSlider.ValueChanged += Slider_ValueChanged;
            BlueSlider.ValueChanged += Slider_ValueChanged;

            // Baþlangýç rengi olarak siyahý ayarla
            SetColorBoxColor(0, 0, 0);
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double red = RedSlider.Value;
            double green = GreenSlider.Value;
            double blue = BlueSlider.Value;

            SetColorBoxColor(red, green, blue);

            // RGB kodunu güncelle
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

            // Kullanýcýya geri bildirim ver
            await DisplayAlert("Baþarýlý", "RGB kodu panoya kopyalandý", "Tamam");
        }
    }
}
