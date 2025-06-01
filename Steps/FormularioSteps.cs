using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProject1.NovaPasta;
using ProjetoAutomacaoCSharp.Pages;

namespace ProjetoAutomacaoCSharp.StepDefinitions
{

    [Binding]
    public class FormularioSteps
    {
        private IWebDriver? driver;
        // private By startDate = By.Id("startdate");
        // public void StartDate(String startdate)
        // {
        //     driver?.FindElement(startDate).SendKeys(startdate);
        // }
        // private By WebSite = By.Id("website");
        // public void InseriWebSite(String webSite)
        // {
        //     driver?.FindElement(WebSite).SendKeys(webSite);
        // }

        [Given(@"que o usuário acessa o formulário")]
        public void DadoQueOUsuarioAcessaOFormulario()
        {
            driver = DriverFactory.GetDriver();

            EnterVehicleData.SetDriver(driver);
            Enterproductdata.SetDriver(driver);
            Enterinsurantdata.SetDriver(driver);
            Selectpriceoption.SetDriver(driver);
            Sendquote.SetDriver(driver);
        }


        [When(@"ele preenche todos os campos obrigatórios")]

        public void QuandoElePreencheTodosOsCamposObrigatorios()
        {
            // driver?.FindElement(By.Id("make")).SendKeys("Audi");
            // // continue preenchendo...
            // driver?.FindElement(By.Id("model")).SendKeys("Scooter");

            // driver?.FindElement(By.Id("cylindercapacity")).SendKeys("1000");

            // driver?.FindElement(By.Id("engineperformance")).SendKeys("1700");

            // driver?.FindElement(By.Id("dateofmanufacture")).SendKeys("10/10/2020");

            // driver?.FindElement(By.Id("numberofseats")).SendKeys("1");

            // IWebElement radioLabelYes = driver!.FindElement(By.XPath("//label[@class='ideal-radiocheck-label' and contains(., 'Yes')]"));
            // Utils.SelecionaCaixaDemarcacao(driver, radioLabelYes);

            // driver?.FindElement(By.Id("numberofseatsmotorcycle")).SendKeys("1");

            // driver?.FindElement(By.Id("fuel")).SendKeys("Diesel");

            // driver?.FindElement(By.Id("payload")).SendKeys("20");

            // driver?.FindElement(By.Id("totalweight")).SendKeys("30000");

            // driver?.FindElement(By.Id("listprice")).SendKeys("5000");

            // driver?.FindElement(By.Id("licenseplatenumber")).SendKeys("hdg389333L");

            // driver?.FindElement(By.Id("annualmileage")).SendKeys("80000");
            EnterVehicleData.MarcaEModelo("Audi", "Scooter");
            EnterVehicleData.PreencheCamposDoFormulario("1000", "1700", "10/10/2020", "1");
            EnterVehicleData.SelecionaHardDriver();
            EnterVehicleData.PreencheCamposRestantesDoFormulario("1", "Diesel", "20", "30000", "5000", "hdg389333L", "80000");
        }

        [Then(@"o sistema deve aceitar o envio com sucesso")]
        public void EntaoOSistemaDeveAceitarOEnvioComSucesso()
        {
            // driver?.FindElement(By.Id("enterinsurantdata")).Click();

            // IWebElement label = driver!.FindElement(By.XPath("//label[text()='First Name']"));
            // string validatexto = label.Text;
            // Console.WriteLine(validatexto);

            // driver.FindElement(By.Id("firstname")).SendKeys("teste");

            // driver.FindElement(By.Id("lastname")).SendKeys("Demais");

            // driver.FindElement(By.Id("birthdate")).SendKeys("10/10/1980");

            // IWebElement SelecSexo = driver.FindElement(By.Id("gendermale"));
            // Utils.SelecionaCaixaDemarcacao(driver, SelecSexo);

            // driver.FindElement(By.Id("streetaddress")).SendKeys("facil@gmail.com");

            // driver.FindElement(By.Id("country")).SendKeys("Brazil");

            // driver.FindElement(By.Id("zipcode")).SendKeys("03388190");

            // driver.FindElement(By.Id("city")).SendKeys("São Paulo");

            // driver.FindElement(By.Id("occupation")).SendKeys("Public Official");

            // IWebElement Hoobies = driver.FindElement(By.Id("speeding"));
            // Utils.SelecionaCaixaDemarcacao(driver, Hoobies);

            // InseriWebSite("www.teste.com.br");

            // driver.FindElement(By.Id("enterproductdata")).Click();

            Enterinsurantdata.SelecionaFirstName("teste");
            Enterinsurantdata.SelecionaLastName("Demais");
            Enterinsurantdata.SelecionaBirthDate("10/10/1980");
            Enterinsurantdata.SelecionaGenderMale();
            Enterinsurantdata.SelecionaStreetAddress("facil@gmail.com");
            Enterinsurantdata.SelecionaCountry("Brazil");
            Enterinsurantdata.SelecionaZipcode("03388190");
            Enterinsurantdata.SelecionaCity("São Paulo");
            Enterinsurantdata.SelecionaOccupation("Public Official");
            Enterinsurantdata.SelecionaSpeeding();
            Enterinsurantdata.InseriWebSite("www.teste.com.br");
            Enterinsurantdata.SelecionaEnterProductData();


            // StartDate("10/10/2025");

            // driver.FindElement(By.Id("insurancesum")).SendKeys("35.000.000,00");

            // driver.FindElement(By.Id("meritrating")).SendKeys("Malus 12");

            // driver.FindElement(By.Id("damageinsurance")).SendKeys("Full Coverage");

            // IWebElement produtosOpcional = driver.FindElement(By.Id("EuroProtection"));
            // Utils.SelecionaCaixaDemarcacao(driver, produtosOpcional);

            // driver.FindElement(By.Id("courtesycar")).SendKeys("Yes");

            Enterproductdata.StartDate("10/10/2025");
            Enterproductdata.SelecionarInsurance("35.000.000,00");
            Enterproductdata.SelecionaMeritRating("Malus 12");
            Enterproductdata.SelecionaDamageInsurance("Full Coverage");
            Enterproductdata.SelecionaEuroProtection();
            Enterproductdata.SelecionaCourtesyCar("Yes");
            Enterinsurantdata.SelecionaSelectPriceOption();


            // driver.FindElement(By.Id("selectpriceoption")).Click();

            // IWebElement SelecUltimate = driver.FindElement(By.Id("selectultimate"));
            // Utils.SelecionaCaixaDemarcacao(driver, SelecUltimate);

            Selectpriceoption.SelecionaSelecUltimate();
            Selectpriceoption.AvancaSendquote();


            // driver?.FindElement(By.Id("sendquote")).Click();
            // driver?.FindElement(By.Id("email")).SendKeys("testeCar@gmail.com");
            // driver?.FindElement(By.Id("phone")).SendKeys("11977665566");
            // driver?.FindElement(By.Id("username")).SendKeys("teste");
            // driver?.FindElement(By.Id("password")).SendKeys("TesteCar12@&");
            // driver?.FindElement(By.Id("confirmpassword")).SendKeys("TesteCar12@&");
            // driver?.FindElement(By.Id("Comments"))
            //         .SendKeys("Congratulations on the excellent work! Your dedication and attention to detail are remarkable.");

            Sendquote.InseriEmail("testeCar@gmail.com");
            Sendquote.InseriPhone("11977665566");
            Sendquote.Inseriusername("teste");
            Sendquote.Inseripassword("TesteCar12@&");
            Sendquote.Insericonfirmpassword("TesteCar12@&");
            Sendquote.InseriComments("Congratulations on the excellent work! Your dedication and attention to detail are remarkable.");
        }
    }
}
