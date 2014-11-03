using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using Microsoft.Xna.Framework;
using CocosSharp;

namespace BunnyCarrot.Android
{
    [Activity(
        Label = "Bunny Carrot",
        AlwaysRetainTaskState = true,
        Icon = "@drawable/icon",
        Theme = "@android:style/Theme.NoTitleBar",
        LaunchMode = LaunchMode.SingleInstance,
        ScreenOrientation = ScreenOrientation.Landscape,
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.Keyboard |
        ConfigChanges.KeyboardHidden)
    ]
    public class MainActivity : AndroidGameActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var application = new CCApplication();

            // GameAppDelegate is your class that inherits from CCApplicationDelegate
            application.ApplicationDelegate = new BunnyCarrot.UI.AppDelegate();
            SetContentView(application.AndroidContentView);
            application.StartGame();
        }
    }
}


