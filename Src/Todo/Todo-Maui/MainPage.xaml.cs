using Todo_Maui.ViewModels;
using Todo_Maui.Views;

namespace Todo_Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new TodoViewModel();
        }

        private async void NewItem(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Upsert(),true);
        }
    }
}