using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace WindowsIconMaker
{
    public class IconDataSource
    {

        private ObservableCollection<IconInfo> _icons;

        public ObservableCollection<IconInfo> Icons
        {
            get
            {
                return _icons = _icons ?? new ObservableCollection<IconInfo>
                {
                    new IconInfo {Width = 930, Height = 450, FileName = "SplashScreen.scale-150.png"},
                    new IconInfo {Width = 1488, Height = 720, FileName = "SplashScreen.scale-240.png"},
                    new IconInfo {Width = 2480, Height = 1200, FileName = "SplashScreen.scale-400.png"},
                    new IconInfo {Width = 1240, Height = 600, FileName = "SplashScreen.scale-200.png"},
                    new IconInfo {Width = 310, Height = 150, FileName = "Wide310x150Logo.scale-100.png"},
                    new IconInfo {Width = 620, Height = 300, FileName = "Wide310x150Logo.scale-200.png"},
                    new IconInfo {Width = 1240, Height = 600, FileName = "Wide310x150Logo.scale-400.png"},
                    new IconInfo {Width = 744, Height = 360, FileName = "WideLogo.scale-240.png"},


                    new IconInfo {Width = 24, Height = 24, FileName = "BadgeLogo.scale-100.png"},
                    new IconInfo {Width = 30, Height = 30, FileName = "BadgeLogo.scale-125.png"},
                    new IconInfo {Width = 36, Height = 36, FileName = "BadgeLogo.scale-150.png"},
                    new IconInfo {Width = 48, Height = 48, FileName = "BadgeLogo.scale-200.png"},
                    new IconInfo {Width = 58, Height = 58, FileName = "BadgeLogo.scale-240.png"},
                    new IconInfo {Width = 96, Height = 96, FileName = "BadgeLogo.scale-400.png"},
                    new IconInfo {Width = 48, Height = 48, FileName = "LockScreenLogo.scale-200.png"},
                    new IconInfo {Width = 360, Height = 360, FileName = "Logo.scale-240.png"},
                    new IconInfo {Width = 336, Height = 336, FileName = "OriginLogo.scale-240.png"},
                    new IconInfo {Width = 106, Height = 106, FileName = "SmallLogo.scale-240.png"},
                    new IconInfo {Width = 150, Height = 150, FileName = "Square150x150Logo.scale-100.png"},
                    new IconInfo {Width = 300, Height = 300, FileName = "Square150x150Logo.scale-200.png"},
                    new IconInfo {Width = 600, Height = 600, FileName = "Square150x150Logo.scale-400.png"},
                    new IconInfo {Width = 310, Height = 310, FileName = "Square310x310Logo.scale-100.png"},
                    new IconInfo {Width = 620, Height = 620, FileName = "Square310x310Logo.scale-200.png"},
                    new IconInfo {Width = 1240, Height = 1240, FileName = "Square310x310Logo.scale-400.png"},
                    new IconInfo {Width = 44, Height = 44, FileName = "Square44x44Logo.scale-100.png"},
                    new IconInfo {Width = 88, Height = 88, FileName = "Square44x44Logo.scale-200.png"},
                    new IconInfo {Width = 176, Height = 176, FileName = "Square44x44Logo.scale-400.png"},
                    new IconInfo
                    {
                        Width = 24,
                        Height = 24,
                        FileName = "Square44x44Logo.targetsize-24_altform-unplated.png"
                    },
                    new IconInfo
                    {
                        Width = 256,
                        Height = 256,
                        FileName = "Square44x44Logo.targetsize-256_altform-unplated.png"
                    },
                    new IconInfo
                    {
                        Width = 48,
                        Height = 48,
                        FileName = "Square44x44Logo.targetsize-48_altform-unplated.png"
                    },
                    new IconInfo {Width = 71, Height = 71, FileName = "Square71x71Logo.scale-100.png"},
                    new IconInfo {Width = 142, Height = 142, FileName = "Square71x71Logo.scale-200.png"},
                    new IconInfo {Width = 170, Height = 170, FileName = "Square71x71Logo.scale-240.png"},
                    new IconInfo {Width = 284, Height = 284, FileName = "Square71x71Logo.scale-400.png"},
                    new IconInfo {Width = 50, Height = 50, FileName = "StoreLogo.scale-100.png"},
                    new IconInfo {Width = 63, Height = 63, FileName = "StoreLogo.scale-125.png"},
                    new IconInfo {Width = 75, Height = 75, FileName = "StoreLogo.scale-150.png"},
                    new IconInfo {Width = 100, Height = 100, FileName = "StoreLogo.scale-200.png"},
                    new IconInfo {Width = 200, Height = 200, FileName = "StoreLogo.scale-400.png"},
                };
            }
        }
    }
}