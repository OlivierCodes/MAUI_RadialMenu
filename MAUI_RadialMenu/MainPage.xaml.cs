using Syncfusion.Maui.RadialMenu;

namespace MAUI_RadialMenu
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void SfRadialMenuItem_ItemTapped(object sender, Syncfusion.Maui.RadialMenu.ItemTappedEventArgs e)
        {
            if(sender != null && sender is SfRadialMenuItem item)
            {
                var text = "Le bouton " + item.Text  + " a été appuyé";
                await DisplayAlert("Alerte !", text, "OK");
            }
        }
    }

}
