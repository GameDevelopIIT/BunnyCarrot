using CocosDenshion;
using CocosSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyCarrot.UI
{
    public class AppDelegate : CCApplicationDelegate
    {
        public override void ApplicationDidFinishLaunching(CCApplication application, CCWindow mainWindow)
        {
            application.PreferMultiSampling = false;
            application.ContentRootDirectory = "Content";
            //mainWindow.SupportedDisplayOrientations = CCDisplayOrientation.Default;

            // Установим общее разрешение, котораое будет использоваться для всех сцен
            Resolution.DesignResolution = mainWindow.DesignResolutionSize;

            // todo:  Add our GameScene initialization here
        }

        public override void ApplicationDidEnterBackground(CCApplication application)
        {
            // Stop all of the animation actions that are running.
            application.Paused = true;

            // If SimpleAudioEngine is used, the music must be paused.
            CCSimpleAudioEngine.SharedEngine.PauseBackgroundMusic();
        }

        public override void ApplicationWillEnterForeground(CCApplication application)
        {
            application.Paused = false;
            CCSimpleAudioEngine.SharedEngine.ResumeBackgroundMusic();
        }
    }

}
