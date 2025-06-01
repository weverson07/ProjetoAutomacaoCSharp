using OpenQA.Selenium;

namespace ProjetoAutomacaoCSharp
{
    public static class Enterinsurantdata
    {
        private static IWebDriver? driver;
        private static By firstname = By.Id("firstname");
        private static By lastname = By.Id("lastname");
        private static By birthdate = By.Id("birthdate");
        private static By gendermale = By.Id("gendermale");
        private static By streetaddress = By.Id("streetaddress");
        private static By country = By.Id("country");
        private static By zipcode = By.Id("zipcode");
        private static By city = By.Id("city");
        private static By occupation = By.Id("occupation");
        private static By speeding = By.Id("speeding");
        private static By WebSite = By.Id("website");
        public static By enterproductdata = By.Id("enterproductdata");
        public static By selectpriceoption = By.Id("selectpriceoption");

        public static void SetDriver(IWebDriver webDriver)
        {
            driver = webDriver;
        }
        public static void SelecionaFirstName(String firstname_)
        {
            driver?.FindElement(firstname).SendKeys(firstname_);
        }
        public static void SelecionaLastName(String lastname_)
        {
            driver?.FindElement(lastname).SendKeys(lastname_);
        }
        public static void SelecionaBirthDate(String birthdate_)
        {
            driver?.FindElement(birthdate).SendKeys(birthdate_);
        }
        public static void SelecionaGenderMale()
        {
            IWebElement SelecSexo = driver!.FindElement(gendermale);
            Utils.SelecionaCaixaDemarcacao(driver, SelecSexo);
        }
        public static void SelecionaStreetAddress(String streetaddress_)
        {
            driver?.FindElement(streetaddress).SendKeys(streetaddress_);
        }
        public static void SelecionaCountry(String country_)
        {
            driver?.FindElement(country).SendKeys(country_);
        }
        public static void SelecionaZipcode(String zipcode_)
        {
            driver?.FindElement(zipcode).SendKeys(zipcode_);
        }
        public static void SelecionaCity(String city_)
        {
            driver?.FindElement(city).SendKeys(city_);
        }

        public static void SelecionaOccupation(String occupation_)
        {
            driver?.FindElement(occupation).SendKeys(occupation_); 
        }
        public static void SelecionaSpeeding()
        {
            IWebElement Hoobies = driver!.FindElement(speeding);
            Utils.SelecionaCaixaDemarcacao(driver, Hoobies);
        }
        public static void InseriWebSite(String webSite)
        {
            driver?.FindElement(WebSite).SendKeys(webSite);
        }
        public static void SelecionaEnterProductData()
        {
            driver?.FindElement(enterproductdata).Click();
        }

        public static void SelecionaSelectPriceOption()
        {
            driver?.FindElement(selectpriceoption).Click();
        }
    }
}