
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            slider.Value = 0.2;
            /*          Check IOS and perform something for that ios
                        if (Device.RuntimePlatform == Device.iOS)
                        {
                            Padding = new Thickness(0, 20, 0, 0);
                        }
            


            Device.OnPlatform(
                iOS: new Thickness(0,20,0,0),
                Android: new Thickness(10,20,0,0),
                WinPhone: new Thickness(30,20,0,0)
            );*/




            /*Create ui using code
             * Content = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Hi There"
            }*/
        }

    }
}
