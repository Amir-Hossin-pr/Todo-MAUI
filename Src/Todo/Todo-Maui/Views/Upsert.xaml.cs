using Todo_Maui.ViewModels;

namespace Todo_Maui.Views;

public partial class Upsert : ContentPage
{
    public Upsert()
    {
        InitializeComponent();
        BindingContext = new TodoViewModel();
    }

  
}