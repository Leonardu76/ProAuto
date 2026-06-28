🚗 ProAuto - Sistema de Atualização Cadastral

Sistema web desenvolvido em ASP.NET Core MVC com Entity Framework Core, responsável pela atualização de dados cadastrais de associados da ProAuto.

📌 Funcionalidades
🔐 Login com CPF + placa do veículo
👤 Visualização de dados do associado
🏠 Atualização de endereço (único campo editável)
💾 Persistência com Entity Framework Core (Migrations)
⚙️ Arquitetura em camadas (Controller → Service → DbContext)
📩 Mensagens de sucesso e erro (TempData)
🧪 Validação front-end com jQuery
🧱 Tecnologias utilizadas
ASP.NET Core MVC
C#
Entity Framework Core
SQL Server
Bootstrap 5
jQuery
🗄️ Banco de dados (Migrations)

O banco é criado automaticamente via migrations.

▶️ Como criar o banco

Execute no Package Manager Console:

Update-Database

ou via CLI:

dotnet ef database update
👤 Usuários de teste (Seed)

Após rodar as migrations, os seguintes usuários estarão disponíveis:

🧑 Associados
🔹 João Silva
CPF: 11111111111
Placa: ABC1234
🔹 Maria Souza
CPF: 22222222222
Placa: XYZ9999
🧭 Como rodar o projeto
1️⃣ Clonar o repositório
git clone [https://github.com/SEU-USUARIO/ProAuto.git](https://github.com/Leonardu76/ProAuto)
2️⃣ Abrir no Visual Studio
Abrir o arquivo .sln
3️⃣ Configurar banco de dados

No arquivo appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=ProAuto;Trusted_Connection=True;"
}
4️⃣ Rodar migrations
dotnet ef database update
5️⃣ Executar aplicação

Pressione:

F5

ou:

dotnet run
🔐 Como usar o sistema
1. Login

Acesse:

/Login/Index

Preencha:

CPF (somente números)
Placa do veículo

Exemplo:

CPF: 11111111111
Placa: ABC1234
2. Acesso ao sistema

Após login você será redirecionado para:

/Associate/Index
3. Atualização de endereço

Você poderá editar apenas:

Rua
Número
Cidade
Estado
CEP
4. Logout

Clique no botão de logout ou acesse:

/Login/Logout
🏗️ Arquitetura do projeto
Controllers → Services → DbContext → Database
Camadas:
Controllers: controle de fluxo
Services: regras de negócio
Data: acesso ao banco (EF Core)
ViewModels: transporte de dados para View
⚙️ Estrutura do projeto
/Controllers
/Services
/Services/Interfaces
/Services/Implementations
/Data
/Models
/ViewModels
/Views
