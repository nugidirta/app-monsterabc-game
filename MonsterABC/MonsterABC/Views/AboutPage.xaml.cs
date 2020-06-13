using MonsterABC.Ads;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MonsterABC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void ButtonCallAds_OnClicked(object sender, EventArgs e)
        {
            DependencyService.Get<IInterstitialAds>().ShowAds();
        }
    }
}