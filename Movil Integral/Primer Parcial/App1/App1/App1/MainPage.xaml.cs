using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        int _count;
        string _message;
        Button button1;
        public MainPage()
        {
            InitializeComponent();
            _count = 0;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (button1 == null)
                button1 = ((Button)sender);

            _count++;
            _message = "You clicked me {0} times";
            button1.Text = string.Format(_message, _count);
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            _message = "Click me";
            if (button1 != null)
            {
                _count = 0;
                button1.Text = _message;
            }
        }
    }
}