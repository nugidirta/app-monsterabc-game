using Microsoft.Advertising.WinRT.UI;
using MonsterABC.Ads;
using MonsterABC.UWP;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(InterstitialAds))]
namespace MonsterABC.UWP
{
    public class InterstitialAds : IInterstitialAds
    {
        //TEST ADS
        string interstitialId = "test";
        string applicationID = "d25517cb-12d4-4699-8bdc-52040c712cab";

        //LIVE ADS
        //string interstitialId = "1100035169";
        //string applicationID = "9nklff29d7fj";

        private InterstitialAd interstitialAd;
        public void ShowAds()
        {
            // Instantiate the interstitial video ad

            interstitialAd = new InterstitialAd();

            // Attach event handlers

            interstitialAd.ErrorOccurred += OnAdError;

            interstitialAd.AdReady += OnAdReady;

            interstitialAd.Cancelled += OnAdCancelled;

            interstitialAd.Completed += OnAdCompleted;

            interstitialAd.RequestAd(AdType.Display, applicationID, interstitialId); //Replace your Ads ID
        }
        private void OnAdCompleted(object sender, object e)
        {
            //For easy Debug Ads
        }

        private void OnAdCancelled(object sender, object e)
        {
            //For easy Debug Ads
        }

        private void OnAdReady(object sender, object e)
        {
            interstitialAd.Show();
        }

        private void OnAdError(object sender, AdErrorEventArgs e)
        {
            Debug.WriteLine("Microsoft InterstitialAd Ads Error: " + e.ErrorMessage);
            //interstitialAd.RequestAd(AdType.Display, "9ngb2hgx2bqp", "352373");
            //VungleAds ads = new VungleAds();
            //ads.ShowAds();

        }
    }
}
