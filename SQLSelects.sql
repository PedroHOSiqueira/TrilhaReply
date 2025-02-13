use trilha;
go

/*3)*/
select Id as id_projeto, Nome, DataInicio as data_incio, DataFim as data_fim 
from Projetos 
where DataFim > format(getDate(), 'yyyy/MM/dd') order by Nome;

/*4)*/
select Id as id_tarefa, Titulo, Descricao, Status 
from Tarefas
where Status != 'Concluído' and ProjetoId = 1;

/*5)*/
select p.Id as id_projeto, p.Nome, count(t.Id) as quantidade_de_tarefas 
from Projetos p 
left join Tarefas t on p.Id = ProjetoId group by p.Id, p.Nome;

/*6)*/
select p.Id as id_projeto, p.Nome, count(t.Id) as quantidade_de_tarefas 
from Projetos p 
left join Tarefas t on p.Id = ProjetoId group by p.Id, p.Nome having count(t.id) > 5;


/*
7) 



*/

/*8)*/
select t.Titulo, p.Nome 
from Projetos p 
inner join Tarefas t on p.Id = ProjetoId group by t.Titulo, p.Nome;

/*9)*/
select u.Id as id_usuario, u.Nome as nome_usuario, e.Id as id_equipe, e.Nome AS nome_equipe
from Usuarios u
left join Usuarios_Equipes ue on u.Id = ue.IdUsuario
left join Equipes e on ue.IdEquipe = e.Id;

/*10)*/
select p.Id as id_projeto, p.Nome as nome_projeto, e.Nome as nome_equipe, e.setor, e.Responsavel
from Projetos p 
left join Equipes e on p.Id = e.Id;

