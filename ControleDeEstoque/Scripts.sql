set IDENTITY_INSERT dbo.tipoUsuario on;

insert into dbo.TipoUsuario (id, Descricao) values (1, 'Administrador');

insert into dbo.TipoUsuario (id, Descricao) values (2, 'Visualizador');

insert into dbo.TipoUsuario (id, Descricao) values (3, 'Operacional');

set IDENTITY_INSERT dbo.tipoUsuario off;

set IDENTITY_INSERT dbo.TipoDeRegistro on;

insert into dbo.TipoDeRegistro (id, Descricao) values (1, 'Entrada');

insert into dbo.TipoDeRegistro (id, Descricao) values (2, 'Saida');

set IDENTITY_INSERT dbo.TipoDeRegistro off;

set IDENTITY_INSERT dbo.Endereco on;

insert into dbo.Endereco (id, Descricao, numero, cep) values (1, 'Empresa Fulano', 111, '11111-111');

insert into dbo.Endereco (id, Descricao, numero, cep) values (2, 'Empresa Ciclano', 222, '22222-222');

insert into dbo.Endereco (id, Descricao, numero, cep) values (3, 'Empresa Beltrano', 333, '33333-333');

insert into dbo.Endereco (id, Descricao, numero, cep) values (4, 'Empresa QueroPassarEmC#', 444, '44444-444');

insert into dbo.Endereco (id, Descricao, numero, cep) values (5, 'Empresa JaPasseiEmBanco', 555, '55555-555');

set IDENTITY_INSERT dbo.Endereco off;

set IDENTITY_INSERT dbo.Usuario on;

insert into dbo.Usuario(id, [Login], Senha, DataDeCadastro, [Status], TipoUsuario_Id) values (1, 'Amanda', 123, '26-10-1994', 'Ativo', 1);

set IDENTITY_INSERT dbo.Usuario off;