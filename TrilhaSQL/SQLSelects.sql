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
from Projetos p, Tarefas t
where p.Id = ProjetoId group by p.Id, p.Nome;

/*6)*/
select p.Id as id_projeto, p.Nome, count(t.Id) as quantidade_de_tarefas 
from Projetos p 
left join Tarefas t on p.Id = ProjetoId group by p.Id, p.Nome having count(t.id) > 5;

/*
7) 
inner join/join -> na junção das tabelas mantém apenas aqueles que são iguais/dão match. 
Em uma comparação com os ID's, vão se manter apenas aqueles items com correspondências nos ID's nas duas ou mais tabelas.

left join -> na junção das tabelas mantém tanto aqueles que são iguais/dão match, quanto aqueles que não possuem 
correspondências na tabela da esquerda ou "original". 
Considerando duas tabelas, manterá os items com macthces nas duas tabelas e também o dados que não tem match da tabela original.

right join -> considerando o left join, é basicamente a mesma coisa, porém mantém aqueles dão match 
e os da tabela da direita na qual esta sendo feito o join em vez na da esquerda/original

outer join -> na junção das tabelas mantém tudo, aqueles que deram match e os que não deram também, tanto da tabela da esquerda
quanto da direita, como se fosse uma junção de todos os joins acima.
*/

/*8)*/
select t.Titulo, p.Nome 
from Projetos p 
inner join Tarefas t on p.Id = ProjetoId group by t.Titulo, p.Nome;

/*9)*/
select p.Id as id_projeto, p.Nome as nome_projeto, e.Id as id_equipe, e.Nome AS nome_equipe, Setor
from Projetos p
inner join Tarefas t on p.Id = t.ProjetoId
inner join Equipes e on e.Id = p.Id
group by p.Id, p.Nome, e.Id, e.Nome, e.Setor


/*10)*/
select p.Id as id_projeto, p.Nome as nome_projeto, e.Nome as nome_equipe, e.setor, e.Responsavel
from Projetos p 
left join Equipes e on p.Id = e.Id;

