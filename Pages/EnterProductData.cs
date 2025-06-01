using OpenQA.Selenium;
namespace ProjetoAutomacaoCSharp.Pages
{
    public static class Enterproductdata
    {
        private static IWebDriver? driver;
        private static By startDate = By.Id("startdate");
        private static By Insurance_ = By.Id("insurancesum");
        private static By DamageInsurance = By.Id("damageinsurance");
        private static By EuroProtection = By.Id("EuroProtection");
        private static By courtesycar = By.Id("courtesycar");
        private static By meritrating = By.Id("meritrating");

        public static void SetDriver(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public static void StartDate(String startdate)
        {
            driver?.FindElement(startDate).SendKeys(startdate);
        }

        public static void SelecionarInsurance(String valorinsurancesum)
        {
            driver?.FindElement(Insurance_).SendKeys(valorinsurancesum);
        }

        public static void SelecionaDamageInsurance(String valordamageinsurance)
        {
            driver?.FindElement(DamageInsurance).SendKeys(valordamageinsurance);
        }

        public static void SelecionaEuroProtection()
        {
            IWebElement produtosOpcional = driver!.FindElement(EuroProtection);
            Utils.SelecionaCaixaDemarcacao(driver, produtosOpcional);
        }

        public static void SelecionaCourtesyCar(String valoryes)
        {
            driver?.FindElement(courtesycar).SendKeys(valoryes);
        }
        public static void SelecionaMeritRating(String valormalus)
        {
            driver?.FindElement(meritrating).SendKeys(valormalus);
        }

    }
}

