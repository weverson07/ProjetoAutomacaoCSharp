using OpenQA.Selenium;
namespace ProjetoAutomacaoCSharp.Pages
{
    public static class EnterVehicleData
    {
        private static IWebDriver? driver;
        public static void SetDriver(IWebDriver webDriver)
        {
            driver = webDriver;
        }
        public static void MarcaEModelo()
        {
            driver?.FindElement(By.Id("make")).SendKeys("Audi");
            driver?.FindElement(By.Id("model")).SendKeys("Scooter");
        }

        public static void PreencheCamposDoFormulario()
        {
            driver?.FindElement(By.Id("cylindercapacity")).SendKeys("1000");
            driver?.FindElement(By.Id("engineperformance")).SendKeys("1700");
            driver?.FindElement(By.Id("dateofmanufacture")).SendKeys("10/10/2020");
            driver?.FindElement(By.Id("numberofseats")).SendKeys("1");
        }

        public static void SeleconaHardDriver()
        {
            if (driver == null)
            {
                throw new NullReferenceException("O WebDriver não foi configurado. Chame EnterVehicleData.SetDriver(driver) antes de usar os métodos.");
            }
            IWebElement radioLabelYes = driver!.FindElement(By.XPath("//label[@class='ideal-radiocheck-label' and contains(., 'Yes')]"));
            Utils.SelecionaCaixaDemarcacao(driver, radioLabelYes);
        }

        public static void PreencheCamposRestatntesDoFormulario()
        {
            driver?.FindElement(By.Id("numberofseatsmotorcycle")).SendKeys("1");
            driver?.FindElement(By.Id("fuel")).SendKeys("Diesel");
            driver?.FindElement(By.Id("payload")).SendKeys("20");
            driver?.FindElement(By.Id("totalweight")).SendKeys("30000");
            driver?.FindElement(By.Id("listprice")).SendKeys("5000");
            driver?.FindElement(By.Id("licenseplatenumber")).SendKeys("hdg389333L");
            driver?.FindElement(By.Id("annualmileage")).SendKeys("80000");
            driver?.FindElement(By.Id("enterinsurantdata")).Click();
        }

    }
}