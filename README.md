# Mercadinho Brasil

Sistema simples de mercado feito em **C# com Windows Forms** e banco de dados **PostgreSQL**.
Projeto Final da disciplina de Programação Orientada a Objetos I.

## Integrantes do grupo

| Nome | RA |
|------|----|
| Murilo Lopes | 225096 |
| João Pedro Osório | 125213 |
| Paulo Ricardo | 125118 |
| João Lucas Ribeiro | 125359 |
| Otávio Oliveira Santos | 125532 |
| Matheus Fernandes Sikva | 125404 |

## O que o sistema faz

| Tela | O que tem nela |
|------|----------------|
| **Início** | Tela principal sem borda, com menu lateral e 4 botões grandes |
| **Produtos** | Cadastrar, consultar, alterar e excluir produtos (CRUD completo) |
| **Vender** | Caixa: escolhe os produtos, monta o carrinho e finaliza a venda (baixa o estoque sozinho) |
| **Estoque** | Mostra a quantidade de cada produto, avisa estoque baixo e dá entrada de mercadoria |
| **Relatórios** | Lista as vendas com filtro por período e por forma de pagamento |

## Requisitos do trabalho

- [x] Interface gráfica em C#
- [x] CRUD (Create, Read, Update, Delete) → tela de Produtos
- [x] Menu com 4 itens, cada um abrindo uma tela diferente → Produtos, Vender, Estoque e Relatórios
- [x] Banco de dados com arquivo `.sql` → `banco/mercadinho_brasil.sql`
- [ ] Projeto em um repositório Git (falta enviar para o GitHub)

## O que precisa estar instalado

1. **Visual Studio 2026 Community** com a carga de trabalho **"Desenvolvimento para desktop com .NET"**
2. **.NET 10 SDK** (já vem junto com o Visual Studio)
3. **PostgreSQL** (versão 18 ou parecida) — o **pgAdmin** vem junto na instalação
4. **Git**

## Como rodar

### 1) Criar o banco de dados (só na primeira vez)

**Jeito fácil:** dê dois cliques em `banco/criar_banco.bat` e digite a senha do usuário `postgres` quando pedir.

**Pelo pgAdmin:**
1. Botão direito em *Databases* > *Create* > *Database...* e dê o nome `mercadinho_brasil`
2. Botão direito no banco criado > *Query Tool*
3. Abra o arquivo `banco/mercadinho_brasil.sql` e aperte **F5**

O script cria as tabelas, alguns produtos de exemplo e o usuário `mercadinho`
(senha `mercadinho123`), que é o usuário que o programa usa para entrar no banco.

### 2) Abrir o projeto

Abra o arquivo `MercadinhoBrasil.slnx` no Visual Studio e aperte **F5**.

> Se o seu banco usar outro usuário, senha ou porta, troque no arquivo `MercadinhoBrasil/Dados/Conexao.cs`.

## Como o projeto está organizado

```
MercadinhoBrasil/
├── banco/
│   ├── mercadinho_brasil.sql   -> script que cria as tabelas e os dados de exemplo
│   └── criar_banco.bat         -> atalho para criar o banco com dois cliques
└── MercadinhoBrasil/
    ├── Program.cs              -> onde o programa começa
    ├── Modelos/                -> as classes do sistema
    │   ├── Produto.cs
    │   ├── Venda.cs
    │   ├── ItemVenda.cs
    │   └── EstoqueInsuficienteException.cs
    ├── Dados/                  -> o "back-end": classes que conversam com o banco
    │   ├── Conexao.cs
    │   ├── ProdutoDados.cs
    │   └── VendaDados.cs
    └── Telas/                  -> as telas (Windows Forms)
        ├── FormPrincipal       -> menu e tela inicial
        ├── FormProdutos
        ├── FormVender
        ├── FormEstoque
        ├── FormRelatorios
        └── Estilo.cs           -> deixa todas as tabelas com a mesma aparência
```

Cada tela tem dois arquivos: o `.cs` (o código que nós escrevemos) e o `.Designer.cs`
(o desenho da tela, que o Visual Studio controla quando arrastamos os componentes).

## Tabelas do banco

- **produtos** — id, nome, categoria, preco, quantidade
- **vendas** — id, data_venda, forma_pagamento, valor_total
- **itens_venda** — id, venda_id, produto_id, quantidade, preco_unitario

Uma venda tem vários itens, e cada item aponta para um produto.
