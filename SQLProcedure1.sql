use trilha
go

/*11)*/
create procedure SPAddTarefa(@id_projeto as int,  @titulo as VARCHAR(100), @descricao as VARCHAR(200), @status as VARCHAR(30))
as
begin
	if exists (select * from Projetos where Id = @id_projeto)
		begin
			insert into Tarefas (ProjetoId, Titulo, Descricao, Status) values 
				(1, 'Pesquisa', 'Pesquisa para concepção inicial do projeto', 'Concluído');
		end
	else
	begin
		print '@id_projeto não existe';
	end
end

exec SPAddTarefa @id_projeto = 2, 
                 @titulo = 'Criar API',
                 @descricao = 'Construção de uma API em .NET Core 8',
                 @status = 'Em andamento';
