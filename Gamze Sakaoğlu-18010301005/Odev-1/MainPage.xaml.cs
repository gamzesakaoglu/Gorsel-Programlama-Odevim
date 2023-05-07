using Microsoft.Maui.Controls;
using Odev1;
using System;

namespace Odev_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_KrediHesaplama_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KrediHesaplamaPage());
        }

        private async void Button_VKI_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VucutKitleIndeksiPage());
        }

        private async void Button_Renk_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RenkSeciciPage());
        }

        private async void Button_Yapilacaklar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new YapilacaklarPage());
        }
    }
}
