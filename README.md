# E-commerce Blue Modas
Projeto de avaliação para Jet E-Commerce

**Tecnologias utilizadas**
 - .NET Core 3.1
 - MVC 5
 - Entity Framework Core 3.1.6
 
**Como executar este projeto**
 1. Utilize o VS Code ou Visual Studio 2019+ para abrir o projeto;
 2. No arquivo *appsetting.json* modifique o caminho da connection string para o banco de dados desejado;
 3. Abra o Package Manager Console; 
 4. Selecione o projeto `Ecommerce.Data`
 5. Execute o comando `PM> Update-Database`
 6. Em Solution Explorer defina o projeto `Ecommerce.UI.Web` como Startup Project;
 7. Execute a aplicação.
