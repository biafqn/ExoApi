# 🚀 EXOAPI - Gerenciamento de Projetos e Usuários

## 📘 Sobre o Projeto

Este projeto consiste na criação da **ExoApi**, uma **API RESTful** desenvolvida para gerenciar projetos e usuários da empresa.  
A API permite o armazenamento, controle e visibilidade dos projetos em andamento, além de gerenciar permissões de acesso para os usuários.  

Foi desenvolvida para ser consumida por uma equipe de mobile, garantindo **performance**, **segurança** e **escalabilidade**.

---

## ✨ Funcionalidades Principais

A API oferece os seguintes recursos para gerenciamento de dados:

### 📁 Projetos
- **Listar:** Retorna uma lista com todos os projetos, incluindo `id`, `nome do projeto`, `área` e `status`.
- **Buscar:** Permite buscar os detalhes de um único projeto através de seu ID.
- **Deletar:** Exclui um projeto específico (disponível apenas para usuários com permissão).
- **Atualizar:** Permite a atualização total ou parcial das informações de um projeto (disponível apenas para usuários com permissão).

### 👤 Usuários
- **Listar:** Retorna uma lista com todos os usuários, incluindo `id`, `e-mail` e `senha`.
- **Buscar:** Permite buscar os detalhes de um único usuário através de seu ID.
- **Deletar:** Exclui um usuário específico (disponível apenas para usuários com permissão).
- **Atualizar:** Permite a atualização total ou parcial das informações de um usuário (disponível apenas para usuários com permissão).

---

## 🧰 Tecnologias Utilizadas

A API foi desenvolvida utilizando as melhores práticas do mercado, com foco em segurança e desempenho.  
As principais tecnologias e frameworks utilizados são:

- **ASP.NET Core:** Framework robusto e escalável para a criação da API.
- **Entity Framework Core:** ORM (Object-Relational Mapper) para facilitar a interação com o banco de dados.
- **JSON Web Tokens (JWT):** Utilizado para autenticação e autorização dos usuários, garantindo que apenas usuários com permissão possam acessar rotas sensíveis.
- **Swagger/OpenAPI:** Para a documentação interativa da API, facilitando a consulta e o consumo dos endpoints.

---

## 🧩 Desafios Resolvidos

Durante o desenvolvimento da **ExoApi**, os seguintes desafios foram superados:

- ✅ **Implementação de CRUD Completo:** Foram criadas operações de Create, Read, Update e Delete para as entidades Projetos e Usuários.
- ✅ **Documentação da API:** A documentação foi implementada utilizando Swagger, fornecendo uma interface interativa para explorar e testar todos os endpoints.
- ✅ **Retorno de Dados e Status:** Todos os endpoints retornam dados em formato JSON e utilizam os status HTTP corretos (`200 OK`, `201 Created`, `404 Not Found`, `401 Unauthorized`) conforme as melhores práticas.
- ✅ **Sistema de Permissões:** Foi implementado um sistema de autenticação e autorização com JWT, garantindo que as operações de deletar e atualizar sejam restritas apenas a usuários com permissão.

---

## 🛠️ Como Rodar o Projeto

Para executar a **ExoApi** em seu ambiente local, siga os passos abaixo:

### ✅ Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) instalado.

### 📥 Clone o repositório

```bash
git clone [URL_DO_SEU_REPOSITORIO]
cd [NOME_DA_PASTA]
⚙️ Configuração do Banco de Dados
Atualize a string de conexão no arquivo appsettings.json.

Rode as migrações do Entity Framework para criar o banco de dados:

bash
dotnet ef database update
▶️ Execução
Inicie o projeto com o comando:

bash
dotnet run
A API estará disponível em:

arduino
https://localhost:7000
A documentação do Swagger pode ser acessada em:

bash
https://localhost:7000/swagger

📂 Estrutura do Projeto

/Controllers      → Controladores que definem os endpoints da API  
/Models           → Classes de modelo (entidades) do banco de dados  
/Repositories     → Lógica de acesso e manipulação dos dados  
/Contexts         → Contexto do Entity Framework  
appsettings.json  → Arquivo de configuração (string de conexão etc.)


📫 Suporte
Se tiver alguma dúvida, sugestão ou problema, sinta-se à vontade para abrir uma issue no repositório!
