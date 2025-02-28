# API de Produtos e Pessoas

## 📌 Descrição
Esta API tem como objetivo fornecer informações sobre Produtos e Pessoas, conectando-se a um banco de dados **SQL Server Localhost**. Todas as entidades listadas abaixo estão refletidas em tabelas do banco de dados.

## 📦 Entidades e Propriedades

### **Produto**
- `Codigo` (int) - Código único do produto.
- `Descricao` (string) - Descrição do produto.
- `Marca` (objeto) - Informação sobre a marca do produto.
- `Estoque` (int) - Quantidade disponível no estoque.

### **Marca**
- `Codigo` (int) - Código único da marca.
- `Descricao` (string) - Nome da marca.

### **Pessoa**
- `Codigo` (int) - Código único da pessoa.
- `Nome` (string) - Nome da pessoa.
- `Idade` (int) - Idade da pessoa.
- `CPF` (string) - Cadastro de Pessoa Física.
- `Cidade` (objeto) - Informações sobre a cidade.
- `Logradouro` (string) - Nome da rua/avenida.
- `NumeroEstabelecimento` (int) - Número da residência/estabelecimento.
- `Bairro` (string) - Bairro onde a pessoa reside.
- `CEP` (string) - Código Postal.
- `Dependentes` (Lista de Pessoa) - Lista de dependentes vinculados a essa pessoa.

### **Cidade**
- `CodigoIBGE` (int) - Código do IBGE para a cidade.
- `Nome` (string) - Nome da cidade.
- `UF` (string) - Unidade Federativa (Estado).
- `CodigoPais` (int) - Código do país.

## 🚀 Endpoints da API

### **Produto**
- `GET /api/produtos` - Retorna todos os produtos.
- `GET /api/produtos/{codigo}` - Retorna um produto pelo código.
- `POST /api/produtos` - Cadastra um novo produto.
- `PUT /api/produtos/{codigo}` - Atualiza um produto existente.
- `DELETE /api/produtos/{codigo}` - Remove um produto.

### **Pessoa**
- `GET /api/pessoas` - Retorna todas as pessoas.
- `GET /api/pessoas/{codigo}` - Retorna uma pessoa pelo código.
- `POST /api/pessoas` - Cadastra uma nova pessoa.
- `PUT /api/pessoas/{codigo}` - Atualiza uma pessoa existente.
- `DELETE /api/pessoas/{codigo}` - Remove uma pessoa.

### **Cidade**
- `GET /api/cidades` - Retorna todas as cidades.
- `GET /api/cidades/{codigoIBGE}` - Retorna uma cidade pelo código IBGE.
- `POST /api/cidades` - Cadastra uma nova cidade.

## 📌 Tecnologias Utilizadas
- **C#** com **.NET Core** para a API.
- **Entity Framework Core** para acesso ao banco de dados.
- **SQL Server** para armazenamento dos dados.
- **Swagger** para documentação da API.
