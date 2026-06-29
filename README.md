# ProAuto

Sistema web desenvolvido em **ASP.NET Core MVC** para atualização cadastral de associados.

## Funcionalidades

* Login com CPF e placa do veículo
* Visualização dos dados do associado
* Atualização de endereço
* Persistência de dados com Entity Framework Core
* Validação de formulários com jQuery
* Mensagens de sucesso e erro

## Tecnologias

* ASP.NET Core MVC
* C#
* Entity Framework Core
* SQL Server
* Bootstrap 5
* jQuery

## Banco de Dados

O banco é criado automaticamente pelas migrations.

Execute:

```bash
dotnet ef database update
```

## Usuários de Teste

| Nome        | CPF         | Placa   |
| ----------- | ----------- | ------- |
| João Silva  | 11111111111 | ABC1234 |
| Maria Souza | 22222222222 | XYZ9999 |

## Como executar

1. Clone o repositório:

   git clone https://github.com/Leonardu76/ProAuto.git

2. Abra a solução no Visual Studio.

3. Configure a string de conexão no `appsettings.json`.

4. Execute as migrations:

   dotnet ef database update

5. Inicie a aplicação:

   * `F5` no Visual Studio, ou
   * `dotnet run`

## Como usar

1. Acesse `/Login/Index`.
2. Faça login com CPF e placa.
3. Atualize os dados de endereço.
4. Faça logout em `/Login/Logout`.

## Estrutura do projeto

```
Controllers/
Services/
Data/
Models/
ViewModels/
Views/
```

Arquitetura em camadas:

```
Controllers → Services → DbContext → Database
```
