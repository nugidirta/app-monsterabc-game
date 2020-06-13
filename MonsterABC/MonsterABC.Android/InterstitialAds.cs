using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Ads;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MonsterABC.Ads;
using MonsterABC.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(InterstitialAds))]
namespace MonsterABC.Droid
{
    public class InterstitialAds : IInterstitialAds
    {
        private InterstitialAd ads;
        public void ShowAds()
        {
            try
            {
                var context = Android.App.Application.Context;
                ads = new InterstitialAd(context);

                ads.AdUnitId = "ca-app-pub-9052306741159536/8103278234"; //Replace Video Ads

                var intlistener = new InterstitialAdListener(ads);
                intlistener.OnAdLoaded();
                ads.AdListener = intlistener;

                var requestBuilder = new AdRequest.Builder();
                ads.LoadAd(requestBuilder.Build());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Android Interstitial: " + ex.Message);
            }

        }
    }
}