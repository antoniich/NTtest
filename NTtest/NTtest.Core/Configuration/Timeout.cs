using System;
using System.Collections.Generic;
using System.Text;

namespace NTtest.Core.Configuration
{
    public static class Timeout
    {
        public static TimeSpan Quick => TimeSpan.FromMilliseconds(Convert.ToDouble(TestConfig.Get.GetSection("Timeouts")["Quick"]));

        public static TimeSpan Short => TimeSpan.FromMilliseconds(Convert.ToDouble(TestConfig.Get.GetSection("Timeouts")["Short"]));

        public static TimeSpan Medium => TimeSpan.FromMilliseconds(Convert.ToDouble(TestConfig.Get.GetSection("Timeouts")["Medium"]));

        public static TimeSpan Long => TimeSpan.FromMilliseconds(Convert.ToDouble(TestConfig.Get.GetSection("Timeouts")["Long"]));

        public static TimeSpan Implicit => TimeSpan.FromMilliseconds(Convert.ToDouble(TestConfig.Get.GetSection("Timeouts")["Implicit"]));

    }
}
