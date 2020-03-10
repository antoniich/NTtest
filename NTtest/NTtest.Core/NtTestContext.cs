using NTtest.Core.Configuration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.IO;
using NLog;
using NLog.Extensions.Logging;

namespace NTtest.Core
{
    public class NtTestContext : IDisposable
    {
        public IWebDriver Driver { get; }

        public Logger Log { get; } = LogManager.GetCurrentClassLogger();

        public string FullTestName { get; }

        public NtTestContext(string fullTestName = "")
        {
            FullTestName = fullTestName;
            LogManager.Configuration = new NLogLoggingConfiguration(TestConfig.Get.GetSection("NLog"));
            Driver = InitializeDriver();
            WindowMaximize();
        }

        public string TestDirectory { get; } = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        private IWebDriver InitializeDriver()
        {
            Log.Info("Driver initialization...");
            IWebDriver webDriver = null;
            switch (Browser.Type)
            {
                case BrowserType.Chrome:
                    webDriver = new ChromeDriver(TestDirectory);
                    break;

                case BrowserType.Safari:
                    break;

                case BrowserType.Firefox:
                    break;

                case BrowserType.Opera:
                    break;

                case BrowserType.Edge:
                    break;

                case BrowserType.IE:
                    break;

                case BrowserType.None:
                    break;

                default:
                    throw new NotSupportedException($"The '{Browser.Type}' browser not supported");
            }

            return webDriver;
        }

        public void Dispose()
        {
            Driver.Quit();
        }

        public void WindowMaximize()
        {
            Driver.Manage().Window.Maximize();
        }

        public void DeleteAllCookies()
        {
            Driver.Manage().Cookies.DeleteAllCookies();
        }

        public Screenshot TakeScreenshot()
        {
            try
            {
                var screenshotProovider = (ITakesScreenshot)Driver;
                var screenshot = screenshotProovider.GetScreenshot();
                return screenshot;
            }
            catch (Exception)
            {
                //TODO error message to log
            }
            return null;
        }
    }
}