use trilha
go

/*11)*/
create procedure SPAddTarefa(@id_projeto as int,  @titulo as VARCHAR(100), @descricao as VARCHAR(200), @status as VARCHAR(30))
as
begin
	if exists (select * from Projetos where Id = @id_projeto)
		begin
			insert into Tarefas (ProjetoId, Titulo, Descricao, Status) values 
				(@id_projeto, @titulo, @descricao, @status);
		end
	else
	begin
		print '@id_projeto não existe';
	end
end


exec SPAddTarefa @id_projeto = 3, 
                 @titulo = 'Criar API',
                 @descricao = 'Construção de uma API em .NET Core 8',
                 @status = 'Em andamento';

select * from Tarefas;
