using Microsoft.Maui.Controls;

namespace Odev_1
{
    public partial class AppShell : Shell
    {
        public Command KrediHesaplamaCommand { get; }
        public Command VucutKitleIndeksiCommand { get; }
        public Command RenkSeciciCommand { get; }
        public Command YapilacaklarCommand { get; }

        public AppShell()
        {
            InitializeComponent();

            KrediHesaplamaCommand = new Command(async () => await GoToAsync("//KrediHesaplamaPage"));
            VucutKitleIndeksiCommand = new Command(async () => await GoToAsync("//VucutKitleIndeksiPage"));
            RenkSeciciCommand = new Command(async () => await GoToAsync("//RenkSeciciPage"));
            YapilacaklarCommand = new Command(async () => await GoToAsync("//YapilacaklarPage"));

            BindingContext = this;
        }
    }
}
