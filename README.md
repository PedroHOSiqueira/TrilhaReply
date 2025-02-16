# TrilhaReply

# 📌 Projeto ReplyAPI

Este repositório contém uma API REST utilizando .NET Core 8, Entity
Framework Core (EF Core) Code First e Migrations com SQL Server como banco de dados. Utiliza dos princípios da Injeção de Dependência utilizando interfaces e repositórios para manipular os dados.

## 📋 Requisitos

Softwares necessários para rodar o projeto:

- [.NET SDK 8](https://dotnet.microsoft.com/en-us/download)
- [SQL Server 2022](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [SQL Server Management Studio (SSMS)](https://aka.ms/ssmsfullsetup) (opcional, mas recomendado)
- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [Postman](https://www.postman.com/) ou [Swagger UI](https://swagger.io/tools/swagger-ui/) para testar a API

## Após clonar o projeto

### 1️⃣ Configure a Connection String

Abra o arquivo `appsettings.json` e configure a string de conexão com seu SQL Server:

<!-- ```json
"ConnectionStrings": {
    "DefaultConnection": "Server=SQLSERVER2022;Database=ReplyDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
``` -->

<!-- Se estiver usando `localhost`, altere para: -->

```json
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost\\SQLSERVER2022;Database=ReplyDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 2️⃣ Instalar todas as dependências

```sh
 dotnet restore
```

Foram utilizados os seguintes pacotes/dependências NuGet para realização do projeto que podem ser instalados também por linha de comando individualmente

- [Microsoft.EntityFrameworkCore]
- [Microsoft.EntityFrameworkCore.Design]
- [Microsoft.EntityFrameworkCore.Tools]
- [Microsoft.EntityFrameworkCore.SqlServer]

### 3️⃣ Comandos utilizados ao criar o projeto

```sh
dotnet add package Microsoft.EntityFrameworkCore.Design

Install-Package Microsoft.EntityFrameworkCore.Tools

Install-Package Microsoft.EntityFrameworkCore.SqlServer
```

### 4️⃣ Comandos para Executar as Migrations e Criar o Banco de Dados

instalar dotnet ef

```sh
 dotnet tool install --global dotnet-ef
```

Criar migrations

```sh
 dotnet ef migrations add InitialCreate --project ReplyAPI
```

criar banco de dados e schemas dos modelos

```sh
dotnet ef database update --project ReplyAPI
```

### 5️⃣ Rode a API

### 6️⃣ Teste no Swagger

```
 https://localhost:44305/swagger/index.html
```

## 🛠 Endpoints Disponíveis

📸 **API rodando no Swagger:**

![Equipe e EquipeUsuario](Prints_Evidências/EndpointsSwagger1.png)
![Projeto, Tarefa e Usuario](Prints_Evidências/EndpointsSwagger2.png)

---

## 🎯 Evidências dos endpoints funcionando

✅ **Endpoints testados no Postman e Swagger:**

Equipe - GetAll

![get](Prints_Evidências/Equipe/get.png)

Equipe - Post

![post](Prints_Evidências/Equipe/post.png)

Equipe - Put

![put](Prints_Evidências/Equipe/put.png)

Equipe - Delete

![delete1](Prints_Evidências/Equipe/delete1.png)
![delete2](Prints_Evidências/Equipe/delete2.png)

---

Projeto - GetAll

![get](Prints_Evidências/Projeto/get.png)

Projeto - Post

![post](Prints_Evidências/Projeto/post.png)

Projeto - Put

![put](Prints_Evidências/Projeto/put.png)

Projeto - Delete

![delete1](Prints_Evidências/Projeto/delete1.png)
![delete2](Prints_Evidências/Projeto/delete2.png)

---

Tarefa - GetAll

![get](Prints_Evidências/Tarefa/get.png)

Tarefa - Post

![post](Prints_Evidências/Tarefa/post.png)

Tarefa - Put
![put](Prints_Evidências/Tarefa/put.png)

Tarefa - Delete

![delete1](Prints_Evidências/Tarefa/delete1.png)
![delete2](Prints_Evidências/Tarefa/delete2.png)

---

Usuario - GetAll

![get](Prints_Evidências/Usuario/get.png)

Usuario - Post

![post](Prints_Evidências/Usuario/post.png)

Usuario - Put

![put](Prints_Evidências/Usuario/put.png)

Usuario - Delete

![delete1](Prints_Evidências/Usuario/delete1.png)
![delete2](Prints_Evidências/Usuario/delete2.png)

---

UsuarioEquipe - GetAll

![get](Prints_Evidências/UsuarioEquipe/get.png)

UsuarioEquipe - Post

![post](Prints_Evidências/UsuarioEquipe/post.png)

UsuarioEquipe - Put

![put](Prints_Evidências/UsuarioEquipe/put.png)

UsuarioEquipe - Delete

![delete1](Prints_Evidências/UsuarioEquipe/delete1.png)
![delete2](Prints_Evidências/UsuarioEquipe/delete2.png)




