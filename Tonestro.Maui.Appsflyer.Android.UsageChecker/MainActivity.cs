using Object = Java.Lang.Object;

namespace Tonestro.Maui.Appsflyer.Android.UsageChecker;

using Com.Appsflyer;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        AppsFlyerLib appsFlyerLib = AppsFlyerLib.Instance;

        appsFlyerLib.SetDebugLog(true);
        const string fakeKey = "fakeKey";
        appsFlyerLib.Init(fakeKey, null, this);
        appsFlyerLib.Start(this, fakeKey);

        appsFlyerLib.LogEvent(this, "something", new Dictionary<string, Object>());

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
    }
}