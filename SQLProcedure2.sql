use trilha
go

/*12)*/
create procedure SPGetTarefaEquipe(@id_usuario as int, @id_equipe as int)		
as
begin
	if exists (select * from Usuarios where Id = @id_usuario)
		if exists (select * from Equipes where Id = @id_equipe)
			begin
				select t.Id as id_tarefa, t.Titulo from Tarefas t
				inner join Projetos p on t.ProjetoId = p.Id
				inner join Equipes e on p.Id = e.Id
				inner join Usuarios_Equipes ue on ue.IdEquipe = e.Id
				where ue.IdEquipe = @id_equipe and ue.IdUsuario = @id_usuario;
			end
		else 
		begin
			print '@id_equipe não existe'
		end
	else 
	begin
		print '@id_usuario não existe'
	end
end

exec SPGetTarefaEquipe @id_usuario = 4, 
					   @id_equipe = 2;
