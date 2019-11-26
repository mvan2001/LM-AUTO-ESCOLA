CREATE DATABASE db_autoescola;

USE db_autoescola;

GO

CREATE TABLE aluno
(
id INT not null PRIMARY KEY IDENTITY,
nome NVARCHAR (50) null,
cpf NVARCHAR (50) null,
rg NVARCHAR (50) null,
telefone NVARCHAR (50) null,
categoriacnh NVARCHAR (50) null,
horariodeaula NVARCHAR (50) null,
);

CREATE TABLE atendente
(
id INT not null PRIMARY KEY IDENTITY,
nome NVARCHAR (50) null,
cpf NVARCHAR (50) null,
rg NVARCHAR (50) null,
telefone NVARCHAR (50) null,
);

CREATE TABLE instrutor
(
id INT not null PRIMARY KEY IDENTITY,
nome NVARCHAR (50) null,
cpf NVARCHAR (50) null,
rg NVARCHAR (50) null,
telefone NVARCHAR (50) null,
);

CREATE TABLE veiculo
(
id INT not null PRIMARY KEY IDENTITY,
chassi NVARCHAR (50) null,
placa NVARCHAR (50) null,
modelo NVARCHAR (50) null,
cor NVARCHAR (50) null,
);

CREATE TABLE controledealuno
(
id INT not null PRIMARY KEY IDENTITY,
nome NVARCHAR (50) null,
frequencia NVARCHAR (50) null,
pagamento NVARCHAR (50) null,
);

CREATE TABLE cadastrosistema
(
id INT not null PRIMARY KEY IDENTITY,
usuario NVARCHAR (50) null,
senha NVARCHAR (50) null,
);