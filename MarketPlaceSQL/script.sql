-- Cria��o da tabela Cliente
CREATE TABLE Cliente (
    ID INT PRIMARY KEY,
    NOME VARCHAR(256),
    CPF BIGINT,
    EMAIL VARCHAR(70),
    SENHA VARCHAR(25),
    ENDERECO_ID INT
);

-- Cria��o da tabela Vendedor
CREATE TABLE Vendedor (
    ID INT PRIMARY KEY,
    RAZAO_SOCIAL VARCHAR(100),
    NOME_FANTASIA VARCHAR(70),
    EMAIL VARCHAR(70),
    SENHA VARCHAR(25),
    CNPJ VARCHAR(18),
    COMISSAO INT,
    ENDERECO_ID INT
);

-- Cria��o da tabela Produto
CREATE TABLE Produto (
    ID INT PRIMARY KEY,
    DESCRICAO VARCHAR(45),
    PRECO FLOAT(5,2),
    IMAGEM VARCHAR(200),
    STATUS BOOL,
    VENDEDOR_ID INT,
    CATEGORIA_ID INT,
    FOREIGN KEY (VENDEDOR_ID) REFERENCES Vendedor(ID)
);

-- Cria��o da tabela Carrinho
CREATE TABLE Carrinho (
    ID INT PRIMARY KEY,
    DATA_PEDIDO DATE,
    VALOR_TOTAL FLOAT(7,2),
    STATUS_PEDIDO_ID INT,
    CLIENTE_ID INT,
    FOREIGN KEY (CLIENTE_ID) REFERENCES Cliente(ID)
);

-- Cria��o da tabela Item_Carrinho
CREATE TABLE Item_Carrinho (
    QUANTIDADE VARCHAR(45),
    TOTAL FLOAT(7,2),
    CARRINHO_ID INT,
    PRODUTO_ID INT,
    PRIMARY KEY (CARRINHO_ID, PRODUTO_ID),
    FOREIGN KEY (CARRINHO_ID) REFERENCES Carrinho(ID),
    FOREIGN KEY (PRODUTO_ID) REFERENCES Produto(ID)
);