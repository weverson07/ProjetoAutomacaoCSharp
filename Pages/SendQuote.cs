using OpenQA.Selenium;

namespace ProjetoAutomacaoCSharp
{
    public static class Sendquote
    {
        private static By email = By.Id("email");
        private static By phone = By.Id("phone");
        private static By username = By.Id("username");
        private static By password = By.Id("password");
        private static By confirmpassword = By.Id("confirmpassword");
        private static By Comments = By.Id("Comments");
        private static IWebDriver? driver;
        public static void SetDriver(IWebDriver webDriver)
        {
            driver = webDriver;
        }
        public static void InseriEmail(String email_)
        {
            driver?.FindElement(email).SendKeys(email_);
        }

        public static void InseriPhone(String phone_)
        {
            driver?.FindElement(phone).SendKeys(phone_);
        }

        public static void Inseriusername(String username_)
        {
            driver?.FindElement(username).SendKeys(username_);
        }
        public static void Inseripassword(String password_)
        {
            driver?.FindElement(password).SendKeys(password_);
        }

        public static void Insericonfirmpassword(String confirmpassword_)
        {
            driver?.FindElement(confirmpassword).SendKeys(confirmpassword_);
        }
        public static void InseriComments(String Comments_)
        {
            driver?.FindElement(Comments).SendKeys(Comments_);
        }
    }
}