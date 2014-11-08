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
using BunnyCarrot.UI;

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

			//  var tv = new TextView(this);
			// tv.Text = "Привет, мир!";

            var application = new CCApplication();

            // GameAppDelegate is your class that inherits from CCApplicationDelegate
            application.ApplicationDelegate = new AppDelegate();
            SetContentView(application.AndroidContentView);
			// application.StartGame();
        }
    }
}


