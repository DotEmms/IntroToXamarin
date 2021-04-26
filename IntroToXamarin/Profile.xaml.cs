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
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void OnProfileButtonClicked(object sender, EventArgs e)
        {
            lblProfile.IsVisible = true;
            lblProfile.Text = $"Hello {txtName.Text}! You are {txtAge.Text} years old and these are your hobby's: {txtHobbies.Text}.";
            
        }
    }
}