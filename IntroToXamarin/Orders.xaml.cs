using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroToXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Orders : ContentPage
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void OnOrderButtonClicked(object sender, EventArgs e)
        {

        }
    }
}