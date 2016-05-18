using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Common
{
    public static class Browser
    {
        #region Members
        private static IWebDriver _driver;

        #endregion

        #region Properties

        /// <summary>
        /// The Driver
        /// </summary>
        internal static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    // Add in some configuration to allow for multiple types of browsers to be interacted with
                    _driver = new FirefoxDriver();
                }

                return _driver;
            }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Disposes of the Browser
        /// </summary>
        public static void Dispose()
        {
            // TODO: Adding exception handling
            for (var i = Driver.WindowHandles.Count; i > 0; i--)
            {
                Driver.Close();
            }

            Driver.Quit();

            Driver.Dispose();
        }

        /// <summary>
        /// Closes current tab
        /// </summary>
        public static void CloseCurrentTab()
        {
            // TODO: Add exception handling and logging
            Driver.Close();
        }

        #endregion
    }
}
