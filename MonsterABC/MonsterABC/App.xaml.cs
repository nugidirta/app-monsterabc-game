using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MonsterABC.Views;
using MonsterABC.Ads;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MonsterABC
{
    public partial class App : Application
    {
        /**
         * Monster ABC App
         *
         * @package  Xamarin Monster ABC
         * @author   Ketut Ugi Diranta <nugi.dirta@gmail.com>
         */

        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            // DependencyService.Get<IInterstitialAds>().ShowAds();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            // DependencyService.Get<IInterstitialAds>().ShowAds();
        }


    }
}
