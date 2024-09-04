# api-conta-corrente

Este é o projeto de uma API simples de gerenciamento de conta corrente. Nele é possível realizar operações de débito, crédito e consulta de saldo das contas.

## Índice
- [Instalação](#instalação)
- [Executando a Aplicação](#executando-a-aplicação)
- [Executando os Testes](#executando-os-testes)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)

## Instalação
1. Clone o repositório:
   ```bash
   git clone https://github.com/Gust4vo-Santana/api-conta-corrente
   cd api-conta-corrente
   ```

2. Instale as dependências:
   ```bash
   dotnet restore
   ```

## Executando a Aplicação
Para iniciar o container da aplicação, execute:
```bash
docker-compose up --build
```

## Executando os Testes
O projeto utiliza xUnit para testes unitários. Para rodar os testes, use o seguinte comando:
```bash
dotnet test
```

## Tecnologias utilizadas
- **.NET 8.0**
- **Entity Framework**
- **PostgreSQL**
- **xUnit e Moq**
- **Docker**
- **RabbitMQ**
