using Todo_Maui.ViewModels;

namespace Todo_Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new TodoViewModel();
        }
    }
}