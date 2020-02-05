using System;
using System.Collections.Generic;
using System.Text;
using NTtest.Core.Extentions;

namespace NTtest.Core.Configuration
{
    public static class Timeout
    {
        public static TimeSpan Quick { get; } = TestConfig.Get.GetSection("Timeouts")["Quick"].ToTimeSpanFromMiliseconds();

        public static TimeSpan Short { get; } = TestConfig.Get.GetSection("Timeouts")["Short"].ToTimeSpanFromMiliseconds();

        public static TimeSpan Medium { get; } = TestConfig.Get.GetSection("Timeouts")["Medium"].ToTimeSpanFromMiliseconds();

        public static TimeSpan Long { get; } = TestConfig.Get.GetSection("Timeouts")["Long"].ToTimeSpanFromMiliseconds();

        public static TimeSpan Implicit { get; } = TestConfig.Get.GetSection("Timeouts")["Implicit"].ToTimeSpanFromMiliseconds();
    }
}