using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace ProjetoAutomacaoCSharp.Pages
{
    public static class EnterVehicleData
    {
        private static IWebDriver? driver;

        private static readonly By make = By.Id("make");
        private static readonly By model = By.Id("model");
        private static readonly By cylindercapacity = By.Id("cylindercapacity");
        private static readonly By engineperformance = By.Id("engineperformance");
        private static readonly By dateofmanufacture = By.Id("dateofmanufacture");
        private static readonly By numberofseats = By.Id("numberofseats");
        private static readonly By Yes = By.XPath("//label[@class='ideal-radiocheck-label' and contains(., 'Yes')]");
        private static readonly By numberofseatsmotorcycle = By.Id("numberofseatsmotorcycle");
        private static readonly By fuel = By.Id("fuel");
        private static readonly By payload = By.Id("payload");
        private static readonly By totalweight = By.Id("totalweight");
        private static readonly By listprice = By.Id("listprice");
        private static readonly By licenseplatenumber = By.Id("licenseplatenumber");
        private static readonly By annualmileage = By.Id("annualmileage");
        private static readonly By enterinsurantdata = By.Id("enterinsurantdata");
        public static void SetDriver(IWebDriver webDriver)
        {
            driver = webDriver ?? throw new ArgumentNullException(nameof(webDriver));
        }
        public static void MarcaEModelo(String audi_, String scooter_)
        {
            verificar();
        
            var carro = new SelectElement(driver!.FindElement(make));
            carro.SelectByText(audi_);

            var model_ = new SelectElement(driver.FindElement(model));
            model_.SelectByText(scooter_);
        }

        public static void PreencheCamposDoFormulario(String cylindercapacity_, String engineperformance_,
                    String dateofmanufacture_, String numberofseats_)
        {
            verificar();
            driver?.FindElement(cylindercapacity).SendKeys(cylindercapacity_);
            driver?.FindElement(engineperformance).SendKeys(engineperformance_);
            driver?.FindElement(dateofmanufacture).SendKeys(dateofmanufacture_);
            driver?.FindElement(numberofseats).SendKeys(numberofseats_);
        }

        public static void SelecionaHardDriver()
        {
            verificar();
            IWebElement radioLabelYes = driver!.FindElement(Yes);
            Utils.SelecionaCaixaDemarcacao(driver, radioLabelYes);
        }

        public static void PreencheCamposRestantesDoFormulario(String numberofseatsmotorcycle_, String fuel_,
                    String payload_, String totalweight_, String listprice_, String licenseplatenumber_,
                    String annualmileage_)
        {
            verificar();
            driver?.FindElement(numberofseatsmotorcycle).SendKeys(numberofseatsmotorcycle_);
            driver?.FindElement(fuel).SendKeys(fuel_);
            driver?.FindElement(payload).SendKeys(payload_);
            driver?.FindElement(totalweight).SendKeys(totalweight_);
            driver?.FindElement(listprice).SendKeys(listprice_);
            driver?.FindElement(licenseplatenumber).SendKeys(licenseplatenumber_);
            driver?.FindElement(annualmileage).SendKeys(annualmileage_);
            driver?.FindElement(enterinsurantdata).Click();
        }

        public static void verificar()
        {
            if (driver == null)
            {
                throw new NullReferenceException("WebDriver não foi configurado. Use SetDriver(driver) antes de chamar os métodos.");
            }
        }

    }
}