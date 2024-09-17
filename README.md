# DirtyCode

Bem-vindo ao repositório do **DirtyCode**! Este projeto é uma API desenvolvida com ASP.NET Core para gerenciar dados relacionados a usuários, produtos, arquivos e previsões.

## Integrantes do Grupo

- **Matheus Chagas de Moraes Sampaio** – RM550489 (2TDSPH)
- **Paulo Henrique Moreira Angueira** – RM99704 (2TDSPH)
- **Victor Hugo Astorino Barra Mansa** – RM550573 (2TDSPH)
- **Aleck Ramos Cappucci** – RM551340 (2TDSPM)
- **Murilo Ribeiro Valério da Silva** – RM550858 (2TDSPF)

## Arquitetura do Projeto

O projeto **DirtyCode** segue uma arquitetura baseada em princípios de Clean Architecture e Design Patterns, utilizando o padrão **Repository** para a separação da lógica de acesso a dados e a lógica de negócios. A API foi construída com ASP.NET Core e .NET 8, e está estruturada da seguinte forma:

### **Estrutura de Diretórios**

- **Controllers**: Contém os controladores da API, responsáveis por lidar com as requisições HTTP e retornar respostas.
- **Models**: Define os modelos de dados usados na API.
- **Repository**: Implementa o padrão Repository para abstração do acesso a dados.
- **DataBase**: Contém o contexto do banco de dados e configurações relacionadas.

### **Design Patterns Utilizados**

1. **Repository Pattern**: Utilizado para separar a lógica de acesso a dados da lógica de negócios. Permite uma fácil substituição da implementação de dados sem impactar o restante da aplicação.
2. **Unit of Work Pattern**: Gerencia as transações e mudanças no banco de dados de forma coesa.
3. **Dependency Injection**: Facilita a injeção de dependências, promovendo o desacoplamento entre as classes.

## Instruções para Rodar a API

### **Pré-requisitos**

- [.NET SDK 8](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) ou outro banco de dados compatível

### **Passos para Execução**

1. **Clone o Repositório**

   ```bash
   git clone https://github.com/SeuUsuario/DirtyCode.git
   cd DirtyCode
   ```

2. **Configure a String de Conexão**

   Edite o arquivo `appsettings.json` para configurar a string de conexão com o banco de dados:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Data Source=localhost;Initial Catalog=DirtyCodeDB;Integrated Security=True"
   }
   ```

3. **Restaure as Dependências**

   ```bash
   dotnet restore
   ```

4. **Atualize o Banco de Dados**

   Aplique as migrations para criar o banco de dados e as tabelas necessárias:

   ```bash
   dotnet ef database update
   ```

5. **Execute a Aplicação**

   ```bash
   dotnet run
   ```

6. **Acesse a API**

   A API estará disponível em `https://localhost:5001` (ou a porta configurada). Você pode usar o Swagger UI para explorar e testar os endpoints em `https://localhost:5001/swagger`.

## Documentação da API

A API fornece os seguintes endpoints:

- **Usuários**
  - `GET /api/usuario` – Buscar todos os usuários
  - `GET /api/usuario/{id}` – Buscar usuário por ID
  - `POST /api/usuario` – Cadastrar um novo usuário
  - `PUT /api/usuario/{id}` – Atualizar um usuário existente
  - `DELETE /api/usuario/{id}` – Apagar um usuário

- **Produtos**
  - `GET /api/produto` – Buscar todos os produtos
  - `GET /api/produto/{id}` – Buscar produto por ID
  - `POST /api/produto` – Cadastrar um novo produto
  - `PUT /api/produto/{id}` – Atualizar um produto existente
  - `DELETE /api/produto/{id}` – Apagar um produto

- **Arquivos**
  - `GET /api/arquivo` – Buscar todos os arquivos
  - `GET /api/arquivo/{id}` – Buscar arquivo por ID
  - `POST /api/arquivo` – Cadastrar um novo arquivo
  - `PUT /api/arquivo/{id}` – Atualizar um arquivo existente
  - `DELETE /api/arquivo/{id}` – Apagar um arquivo

- **Previsões**
  - `GET /api/previsao` – Buscar todas as previsões
  - `GET /api/previsao/{id}` – Buscar previsão por ID
  - `POST /api/previsao` – Cadastrar uma nova previsão
  - `PUT /api/previsao/{id}` – Atualizar uma previsão existente
  - `DELETE /api/previsao/{id}` – Apagar uma previsão

## Contribuições

Sinta-se à vontade para contribuir para o projeto. Se você encontrar um problema ou tiver uma sugestão de melhoria, abra um *issue* ou envie um *pull request*. 

---
