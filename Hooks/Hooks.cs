using TechTalk.SpecFlow;
using ProjetoAutomacaoCSharp;
using TestProject1.NovaPasta;

namespace ProjetoAutomacaoCSharp.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            DriverFactory.GetDriver(); // Abre navegador
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverFactory.TearDown(); // Fecha navegador
        }
    }
}
