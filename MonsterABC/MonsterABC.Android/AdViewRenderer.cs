using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Ads;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using MonsterABC.Ads;
using MonsterABC.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AdControlView), typeof(AdViewRenderer))]
namespace MonsterABC.Droid
{
    public class AdViewRenderer : ViewRenderer<AdControlView, AdView>
    {
        public AdViewRenderer(Context context)
            : base(context)
        {
        }

        public AdViewRenderer()
            : base(null)
        {
            // Default constructor needed for Xamarin Forms bug?
            throw new Exception("This constructor should not actually ever be used");
        }

        string adUnitId = "ca-app-pub-9052306741159536/7828231470"; //Replace your ADS Unit ID here
        //Note you may want to adjust this, see further down.

        AdSize adSize = AdSize.Banner;
        AdView adView;
        AdView CreateNativeAdControl()
        {
            if (adView != null)
                return adView;

            // This is a string in the Resources/values/strings.xml that I added or you can modify it here. This comes from admob and contains a / in it
            //adUnitId = Forms.Context.Resources.GetString(Resource.String.banner_ad_unit_id);
            adView = new AdView(Context);
            adView.AdSize = adSize;
            adView.AdUnitId = adUnitId;

            var adParams = new LinearLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);

            adView.LayoutParameters = adParams;

            adView.LoadAd(new AdRequest
                    .Builder()
                    .Build());
            return adView;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<AdControlView> e)
        {
            base.OnElementChanged(e);
            try
            {
                if (e.OldElement == null && this.Element != null)
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