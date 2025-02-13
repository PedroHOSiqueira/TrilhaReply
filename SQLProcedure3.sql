use trilha
go

/*13)*/
create procedure SPUpdateTarefaStatus(@id_tarefa as int)
as
begin
	if exists (select * from Tarefas where Id = @id_tarefa)
		begin
			update Tarefas SET Status = 'Concluído' WHERE Id = @id_tarefa;
		end
	else
	begin
		print('@id_tarefa não existe');
	end
end

exec SPUpdateTarefaStatus @id_tarefa = 7;

select * from Tarefas;