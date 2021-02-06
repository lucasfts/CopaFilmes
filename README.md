# Copa do mundo de filmes

## Configuração do Projeto

Abra um terminal ou prompt do windows e execute os comandos a seguir para clonar o repositório
```
    git clone https://github.com/lucasfts/CopaFilmes.git
```
Após clonar o repositório digite o comando abaixo para entrar na pasta raiz
```
    cd CopaFilmes
```

### Executando o projeto de Back-End
A partir do diretório raiz digite os comandos a seguir:
```
    cd Back-End\CopaFilmes\src\CopaFilmes.WebApi
    dotnet run
```
Após os comandos será possível consultar a documentação da api através da url https://localhost:5001/swagger

### Executando o projeto de Font-End
A partir do diretório raiz digite os comandos a seguir:
```
    cd Front-End\CopaFilmes
    npm install
    ng serve
```
Pronto a aplicação estará disponível através da url http://localhost:4200

### Executando os testes de unidade
A partir do diretório raiz digite os comandos a seguir:
```
    cd Back-End\CopaFilmes\tests\CopaFilmes.UnitTests
    dotnet test
```

### Executando os testes de integração
A partir do diretório raiz digite os comandos a seguir:
```
    cd Back-End\CopaFilmes\tests\CopaFilmes.IntegrationTests
    dotnet test
```
