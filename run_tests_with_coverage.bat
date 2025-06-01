@echo off
echo Executando testes com coleta de cobertura...
dotnet test --collect:"XPlat Code Coverage"

echo Localizando arquivo de cobertura...
for /R %%f in (*coverage.cobertura.xml) do (
    set "COVERAGE=%%f"
    goto :found
)
:found

if not defined COVERAGE (
    echo Arquivo de cobertura não encontrado.
    exit /b 1
)

echo Gerando relatório HTML...
dotnet tool install --global dotnet-reportgenerator-globaltool
reportgenerator -reports:"%COVERAGE%" -targetdir:"coverage-report" -reporttypes:Html

echo Abrindo o relatório...
start coverage-report\index.html