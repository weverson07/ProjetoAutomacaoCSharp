# Projeto de Automação de Testes com C# + Selenium + SpecFlow

Este projeto realiza testes automatizados em um formulário web utilizando:

- C#
- Selenium WebDriver
- SpecFlow (Cucumber para .NET)
- NUnit (estrutura de testes)
- Page Object Model (POM) para organização do código

---

## 📁 Estrutura do Projeto

```
ProjetoAutomacaoCSharp/
│
├── Pages/                  # Page Objects (mapeamento e ações por página)
├── StepDefinitions/        # Etapas definidas em Gherkin
├── Features/               # Arquivos .feature (cenários de teste)
├── Utils/                  # Métodos auxiliares (seleções, helpers, etc.)
├── DriverFactory.cs        # Gerenciador de WebDriver
├── ProjetoAutomacaoCSharp.csproj
└── README.md               # Este arquivo
```

---

## ✅ Pré-requisitos

Antes de iniciar, certifique-se de ter:

- [.NET SDK 6.0+](https://dotnet.microsoft.com/download)
- [Visual Studio 2022 ou superior](https://visualstudio.microsoft.com/)
  - Workload: `.NET desktop development`
- [ChromeDriver](https://chromedriver.chromium.org/downloads) (ou outro driver de navegador)
- Navegador Google Chrome instalado

---

## 🛠️ Instalação das Dependências

Abra o terminal na raiz do projeto e execute:

```bash
dotnet restore
```

### 🧩 Pacotes NuGet utilizados

Você pode instalar os pacotes manualmente via terminal:

```bash
dotnet add package Selenium.WebDriver
dotnet add package Selenium.WebDriver.ChromeDriver
dotnet add package Selenium.Support
dotnet add package SpecFlow
dotnet add package SpecFlow.NUnit
dotnet add package NUnit
dotnet add package NUnit3TestAdapter
dotnet add package Microsoft.NET.Test.Sdk
dotnet add package SpecFlow.Tools.MsBuild.Generation
dotnet add package Microsoft.Extensions.Configuration.Json
dotnet add package Microsoft.Extensions.Configuration
```

Ou use o **Gerenciador de Pacotes NuGet** no Visual Studio (clicando com o botão direito no projeto → `Gerenciar Pacotes NuGet`).

Install-Package NUnit

---

## 🚀 Executando os Testes

1. Compile o projeto:

```bash
dotnet build
```

2. Execute os testes com o comando:

```bash
dotnet test
```

Ou diretamente pelo Visual Studio, usando o menu **Test > Run All Tests** (ou `Ctrl + R, A`).

---

## 🧪 Como escrever novos testes

1. Crie um novo arquivo `.feature` na pasta `Features/`
2. Defina o cenário de teste com Gherkin.
3. Execute o comando para gerar os `StepDefinitions`:

```bash
specflow stepdefinition skeleton ProjetoAutomacaoCSharp.csproj
```

4. Implemente os métodos dentro da pasta `StepDefinitions/`
5. Utilize os `PageObjects` dentro da pasta `Pages/` para acessar elementos e realizar ações.

---

## 🧼 Boas Práticas

- Separe o mapeamento de elementos das ações (seguindo o padrão Page Object Model)
- Mantenha os steps organizados por funcionalidade
- Use helpers utilitários para ações repetitivas (ex: clicar em checkboxes)
- Utilize arquivos `.feature` para manter testes legíveis por não desenvolvedores

---

## 👨‍💻 Autor

Desenvolvido por: **Weverson**  
LinkedIn: [seulinkedin](https://www.linkedin.com/in/wefferson07)  
GitHub: (https://github.com/weverson07)

---

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
