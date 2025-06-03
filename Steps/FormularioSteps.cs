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
            EnterVehicleData.MarcaEModelo("Audi", "Scooter");
            EnterVehicleData.PreencheCamposDoFormulario("1000", "1700", "10/10/2020", "1");
            EnterVehicleData.SelecionaHardDriver();
            EnterVehicleData.PreencheCamposRestantesDoFormulario("1", "Diesel", "20", "30000", "5000", "hdg389333L", "80000");
        }

        [Then(@"o sistema deve aceitar o envio com sucesso")]
        public void EntaoOSistemaDeveAceitarOEnvioComSucesso()
        {

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

            Enterproductdata.StartDate("10/10/2025");
            Enterproductdata.SelecionarInsurance("35.000.000,00");
            Enterproductdata.SelecionaMeritRating("Malus 12");
            Enterproductdata.SelecionaDamageInsurance("Full Coverage");
            Enterproductdata.SelecionaEuroProtection();
            Enterproductdata.SelecionaCourtesyCar("Yes");
            Enterinsurantdata.SelecionaSelectPriceOption();

            Selectpriceoption.SelecionaSelecUltimate();
            Selectpriceoption.AvancaSendquote();

            Sendquote.InseriEmail("testeCar@gmail.com");
            Sendquote.InseriPhone("11977665566");
            Sendquote.Inseriusername("teste");
            Sendquote.Inseripassword("TesteCar12@&");
            Sendquote.Insericonfirmpassword("TesteCar12@&");
            Sendquote.InseriComments("Congratulations on the excellent work! Your dedication and attention to detail are remarkable.");
        }
    }
}
