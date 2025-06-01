using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

public static class Utils
{
    public static void SelecionaCaixaDemarcacao(IWebDriver driver, IWebElement selecCaixa)
    {
        if (driver == null)
        {
            throw new ArgumentNullException(nameof(driver));
        }
        if (selecCaixa == null)
        {
            throw new ArgumentNullException(nameof(selecCaixa));
        }
        if (!selecCaixa.Selected)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(selecCaixa).Click().Perform();
        }
    }
}