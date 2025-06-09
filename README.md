# 🚨 SafeZone

A **SafeZone** é uma aplicação RESTful desenvolvida em .NET com foco em **respostas a situações de emergência**, como desastres naturais. Seu objetivo é **registrar alertas críticos**, indicar **áreas seguras acessíveis** e **gerenciar a localização das ocorrências**.

---

## 🎯 Objetivo

Auxiliar pessoas e instituições a gerenciar riscos em momentos de extrema urgência, como enchentes, deslizamentos ou situações climáticas perigosas, com:
- Cadastro e controle de **alertas**
- Gerenciamento de **áreas seguras**
- Consulta e registro de **localizações afetadas**
- Interface com documentação automática via Swagger

---

## 🧱 Arquitetura e Organização do Projeto

O projeto está organizado seguindo o padrão **Clean Architecture**:

SafeZone
├── API                  # Camada de Controllers e Swagger
├── Application          # DTOs, Interfaces e Mapeamentos
├── Domain               # Entidades de Negócio
├── Infrastructure       # DbContext, Repositórios e Conexão com BD
└── Migrations           # Controle de versão do EF Core

---

## 🔗 Diagrama de Relacionamento


Imagem no Arquivo.zip

---

## 💻 Tecnologias e Dependências

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- AutoMapper
- Swagger / Swashbuckle
- Fluent Validation com DataAnnotations

---

## 🛠️ Como executar localmente

1. **Clone o projeto**  
git clone https://github.com/seu-usuario/SafeZone.git  
cd SafeZone

2. **Configure o banco PostgreSQL no `appsettings.json`**
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=SafeZoneDB;Username=postgres;Password=dudu0602"
}

3. **Execute as migrations**
dotnet ef database update --project SafeZone.Infrastructure --startup-project SafeZone.API

4. **Rode a API**
dotnet run --project SafeZone.API

5. **Acesse a documentação**
http://localhost:5005/swagger

---

## 🧪 Testes – Exemplos de JSON

### 🔔 `AlertaDTO`
```json
{
  "descricao": "Enchente iminente no bairro central",
  "condicaoClimatica": "Chuvas intensas",
  "temperatura": 23.7,
  "usuarioId": 1,
  "localizacaoId": 1
}
```

### 👤 `UsuarioDTO`
```json
{
  "nome": "Maria Oliveira",
  "email": "maria.oliveira@email.com",
  "telefone": "11988887777",
  "cidade": "Campinas",
  "estado": "SP"
}
```

### 📍 `LocalizacaoDTO`
```json
{
  "cidade": "Campinas",
  "estado": "SP",
  "bairro": "Centro",
  "rua": "Av. Brasil",
  "cep": "13000-000"
}
```

### 🛟 `AreaSeguraDTO`
```json
{
  "nome": "Escola Municipal Refúgio",
  "descricao": "Abrigo com capacidade para 150 pessoas",
  "cidade": "Campinas",
  "estado": "SP",
  "bairro": "Jardim do Lago",
  "rua": "Rua da Paz",
  "cep": "13045-000",
  "acessivel": true,
  "capacidade": 150
}
```

---

## 📽️ Vídeos

| Tipo           | Link                |
|----------------|---------------------|
| 🎬 Demonstração da Solução | _(Inserir link do YouTube)_ |
| 🗣️ Pitch (até 3 minutos)     | _(Inserir link do YouTube)_ |

---

## 👥 Equipe

- Eduardo Miguel Forato Monteiro – RM 555871
- Cícero Gabriel Oliveira Serafim – RM 556996
- Alice Teixeira Caldeira - RM 556293
