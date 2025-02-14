use trilha;
go

/*2) inserção nas tabelas */

insert into Projetos (Nome, Descricao, DataInicio, DataFim) values 
('Projeto Cluster', 'Criação de um sistema protótipo para Stellantis', '2024-01-10', '2024-06-30'),
('Projeto Hermes', 'Implementação de um novo sistema para Stellantis na área de engenharia', '2024-02-15', '2024-07-20'),
('Projeto Air', 'Pesquisa para possível futura implementação, sobre novas tecnologias IA', '2024-03-05', '2024-08-15');

update Projetos SET DataFim = '2025-03-30' WHERE Id = 1;
update Projetos SET DataFim = '2025-03-01' WHERE Id = 3;


insert into Tarefas (ProjetoId, Titulo, Descricao, Status) values 
(1, 'Definir requisitos', 'Coletar e documentar requisitos funcionais e não funcionais', 'Em andamento'),
(1, 'Desenvolver um protótipo', 'Criar um protótipo funcional', 'A fazer'),
(2, 'Teste com cliente', 'Testar o fluxo da aplicação junto ao business/cliente', 'Concluído');

insert into Tarefas (ProjetoId, Titulo, Descricao, Status) values 
(1, 'Pesquisa', 'Pesquisa para concepção inicial do projeto', 'Concluído');


insert into Usuarios (Nome, Email, Telefone, Cargo) values 
('Pedro Siqueira', 'p.siqueira@email.com', '(31)98769-1601', 'Desenvolvedor'),
('Augusto Assis', 'a.assis@email.com', '(31)91234-5678', 'Analista de Sistemas'),
('Thais Palhares', 't.palhares@email.com', '(31)99432-1234', 'Gerente de Projetos');

insert into Equipes (Nome, Setor, Responsavel, Descricao) values
('Equipe de Desenvolvimento', 'TI', 'Wemerson Souza', 'Equipe responsável pela etapa de desenvolvimento de software'),
('Equipe de Infraestrutura', 'TI', 'Davi Lucas', 'Equipe responsável pela etapa de manutenção da infraestrutura'),
('Equipe de Pesquisa', 'Pesquisa e Inovação', 'Ana Luiza', 'Equipe responsável pela pesquisa e desenvolvimento');

insert into Usuarios_Equipes (IdUsuario, IdEquipe, DataEntrada, Funcao, Ativo) values
/*
(1, 1, '2024-01-15', 'Desenvolvedor', 1),
(2, 2, '2024-01-20', 'Pesquisador', 1),
(3, 3, '2024-03-10', 'Gerente', 1);
*/

(3, 1, '2024-01-15', 'Desenvolvedor', 1),
(4, 2, '2024-01-20', 'Pesquisador', 1),
(5, 3, '2024-03-10', 'Gerente', 1);


select * from Projetos
select * from Tarefas
select * from Equipes
select * from Usuarios
select * from Usuarios_Equipes