using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        String[] quote = { "The greatest glory in living lies not in never falling, but in rising every time we fall",
                "The way to get started is to quit talking and begin doing.",
                "Your time is limited, so don't waste it living someone else's life. Don't be trapped by dogma – which is living with the results of other people's thinking.",
                "If life were predictable it would cease to be life, and be without flavor.",
                "If you look at what you have in life, you'll always have more. If you look at what you don't have in life, you'll never have enough."
            };
        int counter = 0;
        public QuotesPage()
        {
            InitializeComponent();
            

        }

        private void btnNextQuote_Clicked(object sender, EventArgs e)
        {
            counter = counter >= quote.Length? 0 : counter;
            lblQuote.Text = this.quote[counter++];
        }
    }
}