using System.Text.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject1.NovaPasta
{
    public static class DriverFactory
    {
        private static IWebDriver? driver;
        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                try
                {
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    var options = new ChromeOptions();
                    options.AddArgument("enable-automation");
                    options.AddAdditionalOption("useAutomationExtension", false);
                    driver = new ChromeDriver(options);

                    string basePath = AppDomain.CurrentDomain.BaseDirectory;
                    string jsonPath = Path.Combine(basePath, "appsettings.json");
                    string jsonRecebe = File.ReadAllText(jsonPath);
                    var jsonDoc = JsonDocument.Parse(jsonRecebe);
                    string? url = jsonDoc.RootElement
                                         .GetProperty("Selenium")
                                         .GetProperty("url")
                                         .GetString();

                    if (string.IsNullOrWhiteSpace(url))
                    {
                        throw new Exception("URL está nula ou vazia no arquivo appsettings.json!");
                    }

                    driver.Navigate().GoToUrl(url);
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                }
                catch (WebDriverException ex)
                {
                    throw new Exception("Erro ao iniciar o FirefoxDriver. Verifique compatibilidade. Mensagem: " + ex.Message, ex);
                }
            }

            return driver;
        }
        public static void TearDown()
        {
            driver?.Quit();
            driver = null;
        }
    }
}
