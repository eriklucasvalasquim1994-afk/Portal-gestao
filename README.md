#  Portal de Gestão Corporativa - Integração SQL Server

Este projeto é um sistema de gerenciamento dinâmico que atua como uma interface inteligente entre o usuário final e uma base de dados **SQL Server**. O portal foi desenvolvido para permitir a visualização, análise e edição de registros em tempo real, garantindo a integridade dos dados e agilidade na tomada de decisão.

##  Objetivo do Projeto
Facilitar a administração de grandes volumes de dados através de um dashboard intuitivo, onde é possível realizar consultas complexas e atualizações diretas no banco de dados de forma segura.

##  Stack Tecnológica
* **Backend:** .NET (ASP.NET Core / C#)
* **Banco de Dados:** SQL Server (T-SQL)
* **Acesso a Dados:** Entity Framework Core ou Dapper
* **Frontend:** (Em desenvolvimento / Razor Pages / Blazor)

##  Funcionalidades Principais
- [x] **Leitura de Dados (Read):** Integração direta com SQL para listagem de informações.
- [x] **Edição Dinâmica (Update):** Interface para alteração de registros existentes.
- [x] **Persistência de Dados:** Garantia de que cada alteração seja refletida imediatamente no banco.
- [x] **Filtros Personalizados:** Busca otimizada dentro da base SQL.

##  Arquitetura de Dados
O sistema utiliza uma camada de persistência robusta para se comunicar com o SQL Server, focando em:
1. **Segurança:** Proteção contra SQL Injection.
2. **Performance:** Queries otimizadas para leitura rápida.
3. **Escalabilidade:** Estrutura pronta para suportar novas tabelas e relacionamentos.

##  Como Executar
1. Configure a `ConnectionString` no seu `appsettings.json`.
2. Execute as Migrations ou rode o script SQL fornecido na pasta `/Database`.
3. Inicie a aplicação e acesse via navegador.
