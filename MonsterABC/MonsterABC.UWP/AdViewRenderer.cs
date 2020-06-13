using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

using Microsoft.Advertising.Ads;
using Microsoft.Advertising.WinRT.UI;
using Windows.System.Profile;

[assembly: ExportRenderer(typeof(MonsterABC.Ads.AdControlView), typeof(MonsterABC.UWP.AdViewRenderer))]
namespace MonsterABC.UWP
{
    public class AdViewRenderer : ViewRenderer<Ads.AdControlView, AdControl>
    {
        //TEST ADS
        string bannerId = "test";
        string applicationID = "3f83fe91-d6be-434d-a0ae-7351c5a997f1";

        //LIVE ADS
        //string bannerId = "1100035148";
        //string applicationID = "9nklff29d7fj";

        AdControl adView;
        
        void CreateNativeAdControl()
        {
            if (adView != null)
                return;

            var width = 300;
            var height = 50;
            if (AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Desktop")
            {
                width = 728;
                height = 90;
            }
            // Setup your BannerView, review AdSizeCons class for more Ad sizes. 
            adView = new AdControl
            {
                ApplicationId = applicationID,
                AdUnitId = bannerId,
                HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
                VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Bottom,
                Height = height,
                Width = width
            };

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Ads.AdControlView> e)
        {
            base.OnElementChanged(e);
            try
            {
                if (Control == null)
                {
                    CreateNativeAdControl();
                    SetNativeControl(adView);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}