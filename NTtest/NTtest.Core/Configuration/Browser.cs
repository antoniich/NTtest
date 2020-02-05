using NTtest.Core.Extentions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTtest.Core.Configuration
{
    public static class Browser
    {
        public static BrowserType Type => TestConfig.Get.GetSection("Browser")["Type"].ToEnum(BrowserType.None);

        public static Version Version => TestConfig.Get.GetSection("Browser")["Version"].ToVersion();

        public static bool IsRemote => TestConfig.Get.GetSection("Browser")["IsRemote"].ToBool();
    }
}