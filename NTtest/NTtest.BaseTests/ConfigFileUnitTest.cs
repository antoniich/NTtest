using NTtest.Core.Configuration;
using System;
using Xunit;
using FluentAssertions;
using FluentAssertions.Execution;

namespace NTtest.BaseTests
{
    public class ConfigFileUnitTest
    {
        [Fact]
        public void GetTimeoutsFromConfigFile()
        {
            using (new AssertionScope())
            {
                Timeout.Quick.TotalMilliseconds.Should().Be(100);
                Timeout.Short.TotalMilliseconds.Should().Be(1000);
                Timeout.Medium.TotalMilliseconds.Should().Be(3000);
                Timeout.Long.TotalMilliseconds.Should().Be(10000);
                Timeout.Implicit.TotalMilliseconds.Should().Be(20000);
            }
        }

        [Fact]
        public void GetBrowserDataFromConfigFile()
        {
            using (new AssertionScope())
            {
                Browser.Type.Should().Be(BrowserType.Chrome);
                Browser.Version.ToString().Should().Be("79.0");
                Browser.IsRemote.Should().BeFalse();
            }
        }
    }
}