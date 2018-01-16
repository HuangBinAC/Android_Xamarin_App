using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Distribute;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Android_Xamarin_App
{
    [Activity(Label = "Android_Xamarin_App", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);

            AppCenter.Start("be2e85a9-e851-45d7-ac0f-aeffe54edcd0",
                   typeof(Analytics), typeof(Crashes));
        }
    }
}

