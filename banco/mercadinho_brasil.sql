-- =============================================================
--  MERCADINHO BRASIL - Script do banco de dados (PostgreSQL)
--  Projeto Final de POO I
--
--  COMO USAR:
--  1) Crie um banco de dados vazio chamado: mercadinho_brasil
--  2) Rode este script inteiro dentro desse banco
--     (no pgAdmin: botão direito no banco > Query Tool > abrir
--      este arquivo > apertar F5)
--
--  Pode rodar de novo quando quiser "zerar" o banco.
-- =============================================================


-- Avisa o banco que este arquivo está salvo em UTF-8 (para os acentos não quebrarem).
SET client_encoding = 'UTF8';


-- -------------------------------------------------------------
-- 1) Apaga as tabelas antigas (se existirem) para começar do zero
-- -------------------------------------------------------------
DROP TABLE IF EXISTS itens_venda;
DROP TABLE IF EXISTS vendas;
DROP TABLE IF EXISTS produtos;


-- -------------------------------------------------------------
-- 2) Tabela de produtos (é o nosso estoque)
-- -------------------------------------------------------------
CREATE TABLE produtos (
    id          SERIAL PRIMARY KEY,
    nome        VARCHAR(100)   NOT NULL,
    categoria   VARCHAR(50)    NOT NULL,
    preco       NUMERIC(10, 2) NOT NULL,
    quantidade  INTEGER        NOT NULL DEFAULT 0
);


-- -------------------------------------------------------------
-- 3) Tabela de vendas (uma linha para cada venda feita)
-- -------------------------------------------------------------
CREATE TABLE vendas (
    id               SERIAL PRIMARY KEY,
    data_venda       TIMESTAMP      NOT NULL,
    forma_pagamento  VARCHAR(30)    NOT NULL,
    valor_total      NUMERIC(10, 2) NOT NULL
);


-- -------------------------------------------------------------
-- 4) Tabela de itens da venda (os produtos de cada venda)
--    Uma venda tem vários itens. Cada item aponta para um produto.
-- -------------------------------------------------------------
CREATE TABLE itens_venda (
    id              SERIAL PRIMARY KEY,
    venda_id        INTEGER        NOT NULL REFERENCES vendas (id),
    produto_id      INTEGER        NOT NULL REFERENCES produtos (id),
    quantidade      INTEGER        NOT NULL,
    preco_unitario  NUMERIC(10, 2) NOT NULL
);


-- -------------------------------------------------------------
-- 5) Alguns produtos de exemplo para o sistema não começar vazio
-- -------------------------------------------------------------
INSERT INTO produtos (nome, categoria, preco, quantidade) VALUES
    ('Arroz Branco 5kg',        'Alimentos',  27.90, 40),
    ('Feijão Carioca 1kg',      'Alimentos',   8.49, 35),
    ('Açúcar Cristal 1kg',      'Alimentos',   4.99, 50),
    ('Café Torrado 500g',       'Alimentos',  18.90, 25),
    ('Macarrão Espaguete 500g', 'Alimentos',   4.29, 60),
    ('Óleo de Soja 900ml',      'Alimentos',   7.89, 30),
    ('Leite Integral 1L',       'Laticínios',  5.49, 48),
    ('Queijo Mussarela 500g',   'Laticínios', 24.90,  4),
    ('Manteiga 200g',           'Laticínios', 11.90, 12),
    ('Refrigerante Cola 2L',    'Bebidas',     9.99, 36),
    ('Suco de Laranja 1L',      'Bebidas',     7.50, 20),
    ('Água Mineral 500ml',      'Bebidas',     2.50, 80),
    ('Sabão em Pó 1kg',         'Limpeza',    13.90, 18),
    ('Detergente 500ml',        'Limpeza',     2.79,  3),
    ('Papel Higiênico 12un',    'Higiene',    19.90, 22),
    ('Sabonete 90g',            'Higiene',     2.99, 45),
    ('Banana Prata (kg)',       'Hortifruti',  6.99, 15),
    ('Tomate (kg)',             'Hortifruti',  8.99,  5);


-- -------------------------------------------------------------
-- 6) Usuário que o programa em C# usa para entrar no banco
--    (assim não precisamos colocar a senha do "postgres" no código)
--    Usuário: mercadinho    Senha: mercadinho123
-- -------------------------------------------------------------
DO $$
BEGIN
    IF NOT EXISTS (SELECT 1 FROM pg_roles WHERE rolname = 'mercadinho') THEN
        CREATE USER mercadinho WITH PASSWORD 'mercadinho123';
    END IF;
END
$$;

GRANT ALL ON ALL TABLES    IN SCHEMA public TO mercadinho;
GRANT ALL ON ALL SEQUENCES IN SCHEMA public TO mercadinho;
