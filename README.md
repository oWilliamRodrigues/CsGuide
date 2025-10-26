# 🎯 CS Guide

Aplicação web desenvolvida em **ASP.NET Core MVC** com foco em apresentar informações detalhadas sobre **armas e mapas competitivos** de Counter-Strike 2 (CS2).

O objetivo é criar um **guia organizado e interativo**, permitindo aos usuários visualizar estatísticas e descrições de armas, mapas e demais conteúdos de forma simples, visual e bem estruturada.

---

🧩 Funcionalidades

Listagem de armas com imagem, dano, precisão e descrição

Listagem de mapas competitivos com lado favorito e detalhes visuais

Interface responsiva com Bootstrap 5

Páginas MVC organizadas em seções (Home / Armas / Mapas)

Navegação intuitiva e design limpo inspirado em sites de CS2 como HLTV (hltv.org)

---

## 🧱 Arquitetura e Organização

O projeto segue o **padrão de camadas** (Domain, Infra, Application e UI), garantindo separação de responsabilidades e fácil manutenção:

📦 CSGuide

 ┣ 📁 Domain
 
 ┃ ┣ 📄 Models → Entidades principais (Arma, Mapa)
 
 ┃ ┗ 📄 DTOs → Objetos de transferência de dados
 
 ┣ 📁 Infra
 
 ┃ ┣ 📄 Repositories → Acesso ao banco de dados (CRUD e consultas)
 
 ┃ ┗ 📄 Data → Contexto de persistência (CSGuideContext)
 
 ┣ 📁 Application

 ┃ ┗ 📄 Services → Regras de negócio e validações
 
 ┣ 📁 UI (Web)
 
 ┃ ┣ 📄 Controllers → Lógica das páginas e endpoints MVC
 
 ┃ ┣ 📄 Views → Páginas Razor (Home, Armas, Mapas)
 
 ┃ ┗ 📄 wwwroot → Arquivos estáticos (CSS, JS, imagens)

---

## ⚙️ Tecnologias Utilizadas

- **ASP.NET Core MVC 8.0**
- **Entity Framework Core**
- **Bootstrap 5**
- **C# 12**
- **PostgreSQL**

---

## 🗃️ Banco de Dados

O projeto utiliza **PostgreSQL**.  
As tabelas e sequências são criadas automaticamente a partir dos scripts SQL:

### 🔹 Tabelas Principais
- `TBL_ARMAS` — Armas do jogo, com tipo, dano, precisão, cadência, preço, descrição e imagem.  
- `TBL_MAPAS` — Mapas competitivos, com localização, lado favorito, descrição e imagem.

### 🔹 Exemplo de Criação

```sql
CREATE TABLE TBL_ARMAS (
  ID_ARMA BIGINT PRIMARY KEY DEFAULT NEXTVAL('SEQ_ARMAS'),
  NOME_ARMA VARCHAR(20) NOT NULL,
  TIPO VARCHAR(20) NOT NULL,
  DANO INT NOT NULL,
  PRECISAO INT NOT NULL,
  CADENCIA INT NOT NULL,
  PRECO INT NOT NULL,
  DESCRICAO VARCHAR(100) NOT NULL,
  IMAGEM_ARMA VARCHAR(200) NOT NULL
);
```

Os inserts incluem armas e mapas oficiais do modo competitivo (Dust II, Mirage, Inferno, etc.), além de rifles, pistolas e snipers populares do jogo.

---

💻 Como Executar o Projeto

1 Clonar o repositório
git clone https://github.com/oWilliamRodrigues/CsGuide.git
cd csguide

2 Configurar o banco

Atualize a connection string no appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Database=csgo_guide;Username=postgres;Password=suasenha"
}

3 Executar a aplicação
dotnet run

Acesse:
➡️ http://localhost:5000
