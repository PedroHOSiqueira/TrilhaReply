CREATE DATABASE trilha;

use trilha;

/*1) criacao das tabelas */

create table Projetos(
Id INT IDENTITY NOT NULL,
Nome VARCHAR(50) NOT NULL,
Descricao VARCHAR(200) NOT NULL,
DataInicio DATE NOT NULL,
DataFim DATE
CONSTRAINT pk_id_projetos PRIMARY KEY(Id)
);

create table Tarefas(
Id INT IDENTITY NOT NULL,
ProjetoId INT NOT NULL,
Titulo VARCHAR(100) NOT NULL,
Descricao VARCHAR(200) NOT NULL,
Status VARCHAR(30) NOT NULL,
CONSTRAINT pk_id_tarefas PRIMARY KEY(Id),
CONSTRAINT fk_id_projetos FOREIGN KEY(ProjetoId)
	REFERENCES Projetos(Id)
);

create table Usuarios(
Id INT IDENTITY NOT NULL,
Nome VARCHAR(100) NOT NULL,
Email VARCHAR(100) NOT NULL,
Telefone char(14) NOT NULL,
Cargo VARCHAR(30) NOT NULL,
CONSTRAINT pk_id_usuarios PRIMARY KEY(Id),
);


create table Equipes(
Id INT IDENTITY NOT NULL,
Nome VARCHAR(100) NOT NULL,
Setor VARCHAR(30) NOT NULL,
Responsavel VARCHAR(100) NOT NULL,
Descricao VARCHAR(200) NOT NULL,
CONSTRAINT pk_id_equipes PRIMARY KEY(Id),
);

create table Usuarios_Equipes(
IdUsuario INT NOT NULL,
IdEquipe INT NOT NULL,
DataEntrada DATE NOT NULL,
Funcao VARCHAR(50) NOT NULL,
Ativo VARCHAR(50) NOT NULL,
CONSTRAINT fk_id_usuario FOREIGN KEY(IdUsuario)
	REFERENCES Usuarios(Id),
CONSTRAINT fk_id_equipe FOREIGN KEY(IdEquipe)
	REFERENCES Equipes(Id)
);

