using OpenQA.Selenium;

namespace ProjetoAutomacaoCSharp
{
    public static class Selectpriceoption
    {
        private static IWebDriver? driver;

        public static By selectultimate = By.Id("selectultimate");
        private static By sendquote = By.Id("sendquote");
        public static void SetDriver(IWebDriver webDriver)
        {
            driver = webDriver;
        }
        public static void SelecionaSelecUltimate()
        {
            IWebElement SelecUltimate = driver!.FindElement(selectultimate);
            Utils.SelecionaCaixaDemarcacao(driver, SelecUltimate);
        }
        public static void AvancaSendquote()
        {
            driver?.FindElement(sendquote).Click();
        }

    }
}