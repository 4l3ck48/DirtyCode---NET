# DirtyCode

Bem-vindo ao repositório do projeto *DirtyCode*! Este repositório contém o código-fonte da nossa API, desenvolvida para atender aos requisitos do nosso projeto acadêmico.


## Arquitetura

Para o desenvolvimento da API, optamos por uma *arquitetura monolítica*. Neste modelo, a aplicação é construída como uma unidade coesa, com todos os componentes — como lógica de negócios, acesso a dados e autenticação — integrados em um único projeto e operando como um único processo.

### Justificativa da Arquitetura

- *Fase Inicial de Desenvolvimento e Validação:* A arquitetura monolítica permite um desenvolvimento ágil e menos complexo, ideal para validar o modelo de negócio e as funcionalidades principais de forma rápida e eficiente.
- *Menor Complexidade e Facilidade de Manutenção:* É mais fácil de desenvolver, implantar e manter no curto prazo, reduzindo a sobrecarga de gerenciar múltiplos serviços e simplificando a integração e testes da API.
- *Custo-Efetividade:* Requer menos infraestrutura inicial, o que é crucial para a gestão eficiente de recursos na fase atual do projeto.
- *Facilidade de Escalabilidade Gradual:* Permite uma transição gradual para uma arquitetura mais modular conforme o projeto cresce, facilitando a migração para microservices quando necessário.
- *Simplicidade de Debug e Testes:* Proporciona um ambiente de desenvolvimento mais integrado, facilitando a configuração e execução de testes.

## Design Patterns Utilizados

Durante o desenvolvimento da API, adotamos os seguintes *design patterns* para garantir uma estrutura robusta e escalável:

- *Repository Pattern:* Para encapsular o acesso a dados e separar a lógica de persistência da lógica de negócios.

- *Service Pattern:* Para organizar a lógica de negócios em serviços distintos, promovendo a reutilização e manutenção do código.

- *Dependency Injection:* Para facilitar a gestão das dependências e promover um código mais testável e desacoplado.

## Instruções para Rodar a API

Para rodar a API localmente, siga os passos abaixo:

1. *Clone o Repositório:*

    bash
    git clone https://github.com/seuusuario/DirtyCode.git
    cd DirtyCode
    

2. *Configure o Ambiente:*
   
   Certifique-se de ter o [.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0) instalado.

3. *Restaurar Pacotes NuGet:*

    bash
    dotnet restore
    

4. *Compilar a Aplicação:*

    bash
    dotnet build
    

5. *Executar a API:*

    bash
    dotnet run
    

   A API estará disponível em http://localhost:5000 por padrão.



## Integrantes do Grupo

- *Matheus Chagas de Moraes Sampaio* – RM550489 (2TDSPH)
- *Paulo Henrique Moreira Angueira* – RM99704 (2TDSPH)
- *Victor Hugo Astorino Barra Mansa* – RM550573 (2TDSPH)
- *Aleck Ramos Cappucci* – RM551340 (2TDSPM)
- *Murilo Ribeiro Valério da Silva* – RM550858 (2TDSPF)
---

Obrigado por conferir o *DirtyCode*! Se você tiver alguma dúvida ou precisar de assistência, entre em contato com um dos integrantes do grupo.
