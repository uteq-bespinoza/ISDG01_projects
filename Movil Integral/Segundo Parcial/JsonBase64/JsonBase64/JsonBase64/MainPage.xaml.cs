using Xamarin.Forms;

namespace JsonBase64
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel.RegisterViewModel();
        }
    }
}
