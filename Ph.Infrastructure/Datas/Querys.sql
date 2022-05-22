/*
drop table itemprodutocompra;
--drop table itemprodutovenda;
drop table compra;
drop table Fornecedor;
drop table estoque;
drop table produto; 
--drop table venda;
drop table venda; 
drop table cliente;
*/

CREATE TABLE cliente(
    id bigint identity NOT NULL,
    nome varchar(100) NOT NULL ,
    cnpjcpf varchar(14) NOT NULL,
    tipopessoa smallint NOT NULL,
    email varchar(250) NOT NULL,
    logradouro  VARCHAR (250) NOT NULL,
    numero VARCHAR (100) NOT NULL,
    bairro VARCHAR (150) NOT NULL,
    cidade VARCHAR (100) NOT NULL,
    uf  VARCHAR (2)   NOT NULL,
    cep VARCHAR (8)   NOT NULL
    
)
 alter table cliente add CONSTRAINT [PK_CLIENTE] PRIMARY KEY (id);
 alter table cliente add CONSTRAINT [UK_CLIENTE_CNPJCPF] UNIQUE (cnpjcpf);

    Create table fornecedor(
	id bigint identity NOT NULL,
	razaosocial varchar (150) NOT NULL,
	cnpjcpf varchar(14) NOT NULL,
	tipopessoa smallint NOT NULL,	
	email varchar(250) NOT NULL,
	logradouro varchar(250) NOT NULL,
	numero varchar(100) NOT NULL,
	bairro varchar(150) NOT NULL,
	cidade varchar(100) NOT NULL,
	uf varchar(2) NOT NULL,
	cep varchar(8) NOT NULL

)

alter table fornecedor add constraint PK_FORNECEDOR primary key (id)
alter table fornecedor add constraint UK_FORNECEDOR_CNPJCPF UNIQUE (cnpjcpf)
alter table fornecedor add constraint UK_FORNECEDOR_RAZAOSOCIAL UNIQUE (razaosocial)
insert into fornecedor values ('ph auto peças','22222548122222',2,'felipegomesrodrigues19@gmail.com','rua jandira','617','sb','niteroi','rj','24141400')
select * from fornecedor


create table produto (
    id bigint identity NOT NULL,
    descricao varchar(150) NOT NULL,
    codigointerno varchar(20) NOT NULL,
    codigoexterno varchar(20) NOT NULL,
    valorunitario numeric (18,2) NOT NULL

 )
 
 alter table produto add constraint PK_PRODUTO PRIMARY KEY (ID);

create table compra (
    id bigint identity NOT NULL,
    numeronotafiscal bigint NOT NULL,
    ordemcompra bigint NOT NULL,
    dataentrada date NOT NULL,
    fornecedorid bigint NOT NULL
)

alter table compra add constraint PK_COMPRA PRIMARY KEY (ID);
alter table compra add constraint FK_COMPRA_FORNECEDOR FOREIGN KEY (FORNECEDORID) REFERENCES FORNECEDOR(ID)

create table estoque (
    id bigint identity NOT NULL,
    quantidade int NOT NULL,
    localizacao varchar(15),
    produtoid bigint NOT NULL
)

alter table estoque add constraint PK_ESTOQUE PRIMARY KEY (ID);
alter table estoque add constraint FK_ESTOQUE_PRODUTO FOREIGN KEY (PRODUTOID) REFERENCES PRODUTO (ID); 


create table itemprodutocompra (
        id bigint identity NOT NULL,
        valorunitario numeric(18,2) NOT NULL,
        quantidade int NOT NULL,
        produtoid bigint NOT NULL,
        compraid bigint NOT NULL
        
)

alter table itemprodutocompra add constraint PK_ITEMPRODUTOCOMPRA PRIMARY KEY (ID);
alter table itemprodutocompra add constraint FK_ITEMPRODUTOCOMPRA_PRODUTO FOREIGN KEY (PRODUTOID) REFERENCES PRODUTO(ID);
alter table itemprodutocompra add constraint FK_ITEMPRODUTOCOMPRA_COMPRA FOREIGN KEY (COMPRAID) REFERENCES COMPRA (ID);
 
 create table venda (
    id bigint identity NOT NULL,
    descontopercentual numeric(18,2) NULL,
    descontovalor numeric(18,2) NULL,
    tipoformapagamento smallint NOT NULL,
    clienteid bigint NOT NULL
 ) 

 alter table venda add constraint PK_VENDA PRIMARY KEY (ID);
 alter table venda add constraint FK_VENDA_CLIENTE FOREIGN KEY(CLIENTEID) REFERENCES CLIENTE (ID);          
 

 create table itemprodutovenda (
        id bigint identity NOT NULL,
        valorunitario numeric(18,2) NOT NULL,
        quantidade int NOT NULL,
        produtoid bigint NOT NULL,
        vendaid bigint NOT NULL
        
)

alter table itemprodutovenda add constraint PK_ITEMPRODUTOVENDA PRIMARY KEY (ID);
alter table itemprodutovenda add constraint FK_ITEMPRODUTOVENDA_PRODUTO FOREIGN KEY (PRODUTOID) REFERENCES PRODUTO(ID);
alter table itemprodutovenda add constraint FK_ITEMPRODUTOVENDA_VENDA FOREIGN KEY (VENDAID) REFERENCES VENDA (ID);
 