-- CTR + SHIFT + R = ATUALIZA O SCRIP CASO ESTEJA ACUSANDO ERROS
-- CTR + R = ATALHO PARA FECHAR RESULTADO
USE MASTER
GO

IF EXISTS(SELECT 1 FROM SYS.DATABASES WHERE NAME = 'ORDEMSERVICO')
BEGIN
	ALTER DATABASE ORDEMSERVICO SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	DROP DATABASE ORDEMSERVICO
END
GO

CREATE DATABASE ORDEMSERVICO
GO

USE ORDEMSERVICO
GO
--TABELA "PERMISSÕES DO USUARIO"
CREATE TABLE Permissao
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Descricao VARCHAR(250)
)
GO
--INSERT DA TABELA "PERMISSÃO"
INSERT INTO Permissao(Descricao)
	VALUES('Abrir O.S'),
	('Abrir O.S, Fechar O.S'),
	('Abrir O.S, Fechar O.S, Encaminhar O.S')
GO
--TABELA "PLANO"
CREATE TABLE Plano
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Descricao VARCHAR(150),
	Valor VARCHAR(50)
)
GO

INSERT INTO Plano(Descricao, Valor)
	VALUES('300 MEGAS', 99.90),
	('350 MEGAS + 1 ROTEADOR EM COMODATO', 119.90),
	('400 MEGAS + 1 ROTEADOR EM COMODATO', 129.90),
	('500 MEGAS + 2 ROTEADORES EM COMODATO', 139.90)
GO
CREATE PROCEDURE SP_InserirPlano
	@Id INT OUTPUT,
	@Descricao VARCHAR(150),
	@Valor VARCHAR(50)
AS
	INSERT INTO Plano(Descricao, Valor)
		VALUES(@Descricao,	@Valor)
	SET @Id = (SELECT @@IDENTITY)
GO

--EXEC SP_InserirPlano 5, '1 GIGA + 3 PONTOS DE WI-FI', 500.00
CREATE PROC SP_BuscarPlano
	@Filtro VARCHAR(50)
	as
IF EXISTS(SELECT 1 FROM Plano WHERE CONVERT(VARCHAR(50), Id) = @Filtro)
	SELECT Id, Descricao, Valor FROM Plano WHERE CONVERT(VARCHAR(50), Id) = @Filtro
ELSE
	SELECT Id, Descricao, Valor FROM Plano WHERE Descricao LIKE '%' + @filtro + '%'
GO

-- OR Id LIKE '%'+ @filtro +'%'
CREATE PROC SP_ExcluirPlano
	@Id INT
AS
	DELETE FROM Plano WHERE Id = @Id
GO
CREATE PROC SP_AlterarPlano
	@Id INT,
	@Descricao VARCHAR(150),
	@Valor VARCHAR(50)
AS
	UPDATE Plano SET
	Descricao = @Descricao,
	Valor = @Valor
	WHERE Id = @Id
GO
-- EXEC SP_AlterarPlano 9, '600', '100'
-- SELECT*FROM Plano

--TABELA "PESSOA"
CREATE TABLE Pessoa
(
	-- DADOS PESSOAIS
	Id INT PRIMARY KEY IDENTITY(1,1),-----AUTOMATICO
	Ativo BIT,----------------------------FEITO
	NomeUsuario VARCHAR(150),-------------FEITO
	Senha VARCHAR(150),-------------------FEITO
	NomeCompleto VARCHAR(150),------------FEITO
	Cpf VARCHAR(14),----------------------FEITO
	Rg VARCHAR(13),-----------------------FEITO
	OrgaoExpeditor VARCHAR(6),------------FEITO
	DataNascimento DATETIME,--------------FEITO
	Cep VARCHAR(10),
	Rua VARCHAR(150),---------------------FEITO
	NumCasa VARCHAR(10),------------------FEITO
	Bairro VARCHAR(150),------------------ADICIONADO RECENTE
	EstadoCivil VARCHAR(10),--------------FEITO
	Nacionalidade VARCHAR(10),------------FEITO
	Email VARCHAR(30),--------------------FEITO
	Telefone VARCHAR(15),-----------------FEITO
	CelularUm VARCHAR(16),----------------FEITO
	CelularDois VARCHAR(16),--------------FEITO
	Cidade VARCHAR(10),-------------------FEITO
	Uf VARCHAR(2),------------------------FEITO
	Foto VARCHAR(150),
	-- DADOS DO FUNCIONARIO
	Funcionario BIT,----------------------FEITO
	Id_Permissao INT,---------------------FEITO
	Salario varchar(15),
	Cargo VARCHAR(50),--------------------FEITO
	DataAdmissao DATETIME NULL,-----------FEITO
	DataDemissao DATETIME NULL,-----------FEITO
	Banco VARCHAR(40),--------------------FEITO
	NumeroAgenciaBanco VARCHAR(10),-------FEITO
	NumeroContaBanco VARCHAR(15),---------FEITO
	-- DADOS DO CLIENTE
	Cliente BIT,--------------------------FEITO
	Id_Plano INT,
	--InicioDoContrato DATETIME NULL,	--COMENTADO PARA REALIZAR TESTES
	InicioDoContrato DATETIME NULL,
	FimDoContrato DATETIME NULL,
	-- OBSERVAÇOES GERAIS
	Observacao VARCHAR(250)---------------FEITO
)
GO

CREATE PROCEDURE SP_InserirUsuario
	@Id INT OUTPUT,
	@Ativo BIT,
	@NomeUsuario VARCHAR(150),
	@Senha VARCHAR(150),
	@NomeCompleto VARCHAR(150),
	@Cpf VARCHAR(14),
	@Rg VARCHAR(13),
	@OrgaoExpeditor VARCHAR(6),
	@DataNascimento DATETIME,
	@Cep VARCHAR(10),
	@Rua VARCHAR(150),
	@NumCasa VARCHAR(10),
	@Bairro VARCHAR(150),
	@EstadoCivil VARCHAR(10),
	@Nacionalidade VARCHAR(10),
	@Email VARCHAR(30),
	@Telefone VARCHAR(15),
	@CelularUm VARCHAR(16),
	@CelularDois VARCHAR(16),
	@Cidade VARCHAR(10),
	@Uf VARCHAR(2),
	@Foto VARCHAR(150),
	@Funcionario BIT,
	@Id_Permissao INT,
	@Salario VARCHAR(15),
	@Cargo VARCHAR(50),
	@DataAdmissao DATETIME = NULL,
	@DataDemissao DATETIME = NULL,
	@Banco VARCHAR(40),
	@NumeroAgenciaBanco VARCHAR(10),
	@NumeroContaBanco VARCHAR(15),
	@Cliente BIT,
	@InicioDoContrato DATETIME = NULL,
	@FimDoContrato DATETIME = NULL,
	@Observacao VARCHAR(250),
	@Id_Plano INT
AS
	INSERT INTO Pessoa(
	Ativo,
	NomeUsuario,
	Senha,
	NomeCompleto,
	Cpf,
	Rg,
	OrgaoExpeditor,
	DataNascimento,
	Cep,
	Rua,
	NumCasa,
	Bairro,
	EstadoCivil,
	Nacionalidade,
	Email,
	Telefone,
	CelularUm,
	CelularDois,
	Cidade,
	Uf,
	Foto,
	Funcionario,
	Id_Permissao,
	Salario,
	Cargo,
	DataAdmissao,
	DataDemissao,
	Banco,
	NumeroAgenciaBanco,
	NumeroContaBanco,
	Cliente,
	InicioDoContrato,
	FimDoContrato,
	Observacao,
	Id_Plano)
	VALUES(@Ativo,
	@NomeUsuario,
	@Senha,
	@NomeCompleto,
	@Cpf,
	@Rg,
	@OrgaoExpeditor,
	@DataNascimento,
	@Cep,
	@Rua,
	@NumCasa,
	@Bairro,
	@EstadoCivil,
	@Nacionalidade,
	@Email,
	@Telefone,
	@CelularUm,
	@CelularDois,
	@Cidade,
	@Uf,
	@Foto,
	@Funcionario,
	@Id_Permissao,
	@Salario,
	@Cargo,
	@DataAdmissao,
	@DataDemissao,
	@Banco,
	@NumeroAgenciaBanco,
	@NumeroContaBanco,
	@Cliente,
	@InicioDoContrato,
	@FimDoContrato,
	@Observacao,
	@Id_Plano)
	SET @Id = (SELECT @@IDENTITY)
GO

EXEC SP_InserirUsuario 0, 0, 'Usuario123', 'Senha123', 'MATHEUS MORTO-VIVO', '111.111.111-11', '11.111.111', 'SSP',
'05-01-2000', '77827-150', 'CEMITÉRIO JARDIM DAS PAINEIRAS', '543', 'CENTRO', 'SOLTEIRO', 'BRASILEIRO', 'ze_preguica@gmail.com', '633411-2300', '63991035240', null,
'ARAGUAINA', 'TO', 'C:\Users\ADM\source\repos\3V4ND3R5ON\Base\Base\UIPrincipal\bin\Debug\Imgs\Matheus.jpeg', 1, 3, '2.500', 'SUPORTE1', '01-01-2014', '01-01-2018', 'Banco 0260 Nu Pagamentos S.A', '0001', '5658481-4', 1,
'02-02-2020', '02-02-2022', 'ESSE FUNCIONARIO MATA LEFOA O DIA TODO NO ALMOXARIFADO', 3
GO

--TABELA TipoChamado
CREATE TABLE TipoChamado
	(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Descricao VARCHAR(30) 
)
GO
--SP_InserirTipoChamado
CREATE PROCEDURE SP_InserirTipoChamado
	@Id INT OUTPUT,
	@Descricao VARCHAR(150)
AS
	INSERT INTO TipoChamado(Descricao)
		VALUES(@Descricao)
	SET @Id = (SELECT @@IDENTITY)
GO
--EXEC SP_InserirTipoChamado 0, 'TESTE TIPO DE CHAMADO'
--SP_ExcluirTipoChamado
CREATE PROC SP_ExcluirTipoChamado
	@Id INT
AS
	DELETE FROM TipoChamado WHERE Id = @Id
GO
--EXEC SP_ExcluirTipoChamado 3
--SP_AlterarTipoChamado
CREATE PROC SP_AlterarTipoChamado
	@Id INT,
	@Descricao VARCHAR(150)
AS
	UPDATE TipoChamado SET
	Descricao = @Descricao
	WHERE Id = @Id
GO
--EXEC SP_AlterarTipoChamado 2, 'TESTE DE ALTERAÇÃO'
CREATE PROC SP_BuscarTipoChamado
	@Filtro VARCHAR(50)
	as
IF EXISTS(SELECT 1 FROM TipoChamado WHERE CONVERT(VARCHAR(50), Id) = @Filtro)
	SELECT Id, Descricao FROM TipoChamado WHERE CONVERT(VARCHAR(50), Id) = @Filtro
ELSE
	SELECT Id, Descricao FROM TipoChamado WHERE Descricao LIKE '%' + @filtro + '%'
GO
--EXEC SP_BuscarTipoChamado ''
--INSERT DA TABELA "TIPO DE CHAMADO"
--SELECT * FROM TipoChamado
INSERT INTO TipoChamado(Descricao)
	VALUES('SUPORTE LOSS'),
	('SUPORTE FIBRA'),
	('INSTALAÇÃO FIBRA'),
	('MUDANÇA DE ENDEREÇO')
GO

--DROP PROC SP_AlterarUsuario
CREATE PROC SP_AlterarUsuario
	@Id INT, --OUTPUT,
	@Ativo BIT,
	@NomeUsuario VARCHAR(150),
	@Senha VARCHAR(150),
	@NomeCompleto VARCHAR(150),
	@Cpf VARCHAR(14),
	@Rg VARCHAR(13),
	@OrgaoExpeditor VARCHAR(6),
	@DataNascimento DATETIME,
	@Cep VARCHAR(10),
	@Rua VARCHAR(150),
	@Bairro VARCHAR(150),
	@NumCasa VARCHAR(10),
	@EstadoCivil VARCHAR(10),
	@Nacionalidade VARCHAR(10),
	@Email VARCHAR(30),
	@Telefone VARCHAR(15),
	@CelularUm VARCHAR(16),
	@CelularDois VARCHAR(16),
	@Cidade VARCHAR(10),
	@Uf VARCHAR(2),
	@Foto VARCHAR(150),
	@Funcionario BIT,
	@Id_Permissao INT,
	@Salario FLOAT,
	@Cargo VARCHAR(50),
	@DataAdmissao DATETIME = NULL,
	@DataDemissao DATETIME = NULL,
	@Banco VARCHAR(40),
	@NumeroAgenciaBanco VARCHAR(10),
	@NumeroContaBanco VARCHAR(15),
	@Cliente BIT,
	@InicioDoContrato DATETIME = NULL,
	@FimDoContrato DATETIME = NULL,
	@Observacao VARCHAR(250),
	@Id_Plano INT
AS
	UPDATE Pessoa SET
	Ativo = @Ativo,
	NomeUsuario = @NomeUsuario,
	Senha = @Senha,
	NomeCompleto = @NomeCompleto,
	Cpf = @Cpf,
	Rg = @Rg,
	OrgaoExpeditor = @OrgaoExpeditor,
	DataNascimento = @DataNascimento,
	Cep = @Cep,
	Rua = @Rua,
	NumCasa = @NumCasa,
	Bairro = @Bairro,
	EstadoCivil = @EstadoCivil,
	Nacionalidade = @Nacionalidade,
	Email = @Email,
	Telefone = @Telefone,
	CelularUm = @CelularUm,
	CelularDois = @CelularDois,
	Cidade = @Cidade,
	Uf = @Uf,
	Foto = @Foto,
	Funcionario = @Funcionario,
	Id_Permissao = @Id_Permissao,
	Salario = @Salario,
	Cargo = @Cargo,
	DataAdmissao = @DataAdmissao,
	DataDemissao = @DataDemissao,
	Banco = @Banco,
	NumeroAgenciaBanco = @NumeroAgenciaBanco,
	NumeroContaBanco = @NumeroContaBanco,
	Cliente = @Cliente,
	InicioDoContrato = @InicioDoContrato,
	FimDoContrato = @FimDoContrato,
	Observacao = @Observacao,
	Id_Plano = @Id_Plano
	WHERE Id = @Id
GO

--SELECT * FROM Plano
--SELECT NomeCompleto, Cpf, Ativo, Cliente, Funcionario, Id_Plano, Id_Permissao, InicioDoContrato, DataAdmissao, Foto FROM Pessoa
--GO
--TABELA "STATUS DA O.S"
CREATE TABLE StatusOS
	(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Descricao VARCHAR(20) 
)
GO
--TABELA "STATUS DA O.S"
INSERT INTO StatusOS(Descricao)
	VALUES ('ABERTO'),
	('FECHADO'),
	('ENCAMINHADO')
GO
--SELECT * FROM StatusOS
--EXEC SP_InserirStatusOS 0, "TESTE DE INSERIR"
CREATE PROCEDURE SP_InserirStatusOS
	@Id INT OUTPUT,
	@Descricao VARCHAR(150)
AS
	INSERT INTO StatusOS(Descricao)
		VALUES(@Descricao)
	SET @Id = (SELECT @@IDENTITY)
GO
--EXEC SP_ExcluirStatusOS 4
CREATE PROC SP_ExcluirStatusOS
	@Id INT
AS
	DELETE FROM StatusOS WHERE Id = @Id
GO
--EXEC SP_AlterarStatusOS 5, "TESTE DE ALTERAÇÃO"
CREATE PROC SP_AlterarStatusOS
	@Id INT,
	@Descricao VARCHAR(150)
AS
	UPDATE StatusOS SET
	Descricao = @Descricao
	WHERE Id = @Id
GO
--EXEC SP_BuscarStatusOS "5"
CREATE PROC SP_BuscarStatusOS
	@Filtro VARCHAR(50)
	as
IF EXISTS(SELECT 1 FROM StatusOS WHERE CONVERT(VARCHAR(50), Id) = @Filtro)
	SELECT Id, Descricao FROM StatusOS WHERE CONVERT(VARCHAR(50), Id) = @Filtro
ELSE
	SELECT Id, Descricao FROM StatusOS WHERE Descricao LIKE '%' + @filtro + '%'
GO

--################################################--
CREATE PROC SP_BuscarUsuario
	@Filtro VARCHAR(250) = ''
AS
	SELECT
	Pessoa.Id,
	Ativo,
	NomeUsuario,
	Senha,
	NomeCompleto,
	Cpf,
	Rg,
	OrgaoExpeditor,
	DataNascimento,
	Cep,
	Rua,
	NumCasa,
	Bairro,
	EstadoCivil,
	Nacionalidade,
	Email,
	Telefone,
	CelularUm,
	CelularDois,
	Cidade,
	Uf,
	Foto,
	Funcionario,
	Id_Permissao,
	Salario,
	Cargo,
	DataAdmissao,
	DataDemissao,
	Banco,
	NumeroAgenciaBanco,
	NumeroContaBanco,
	Cliente,
	InicioDoContrato,
	FimDoContrato,
	Observacao,
	Id_Plano,
	Plano.Descricao AS Plano
	FROM Pessoa 
	LEFT JOIN Plano ON Pessoa.Id_Plano = Plano.Id
	WHERE NomeCompleto LIKE '%' + @filtro + '%'
	OR Cpf = @filtro OR NomeUsuario = @filtro --CONVERT(VARCHAR(50), Id) = @Filtro
GO
--###################################################################################
CREATE PROC SP_BuscarFuncionario --FUNCIONARIO ATIVO
	@Filtro VARCHAR(250) = ''
AS
	SELECT
	Pessoa.Id,
	NomeUsuario,
	NomeCompleto,
	Cpf,
	Email,
	Funcionario,
	Cliente,
	Ativo,
	Id_Permissao
	FROM Pessoa
	WHERE Funcionario LIKE '%' + @filtro + '%' AND Ativo = 1
GO

CREATE PROC SP_BuscarFuncionarioInativo
AS
	SELECT
	Pessoa.Id,
	NomeUsuario,
	NomeCompleto,
	Cpf,
	Email,
	Funcionario,
	Cliente,
	Ativo,
	Id_Permissao
	FROM Pessoa
	WHERE Funcionario = 1 AND Cliente = 0 AND Ativo = 0
GO
--EXEC SP_BuscarFuncionarioInativo
CREATE PROC SP_BuscarClienteAtivo
AS
	SELECT
	Pessoa.Id,
	NomeUsuario,
	NomeCompleto,
	Cpf,
	Email,
	Funcionario,
	Cliente,
	Ativo,
	Id_Permissao
	FROM Pessoa
	WHERE Cliente = 1 AND Funcionario = 0 AND Ativo = 1
GO

CREATE PROC SP_BuscarClienteInativo
AS
	SELECT
	Pessoa.Id,
	NomeUsuario,
	NomeCompleto,
	Cpf,
	Email,
	Funcionario,
	Cliente,
	Ativo,
	Id_Permissao
	FROM Pessoa
	WHERE Cliente = 1 AND Funcionario = 0 AND Ativo = 0
GO

CREATE PROC SP_BuscarClienteFuncionarioAtivo
AS
	SELECT
	Pessoa.Id,
	NomeUsuario,
	NomeCompleto,
	Cpf,
	Email,
	Funcionario,
	Cliente,
	Ativo,
	Id_Permissao
	FROM Pessoa
	WHERE Cliente = 1 AND Funcionario = 1 AND Ativo = 1
GO

CREATE PROC SP_BuscarClienteFuncionarioInativo
AS
	SELECT
	Pessoa.Id,
	NomeUsuario,
	NomeCompleto,
	Cpf,
	Email,
	Funcionario,
	Cliente,
	Ativo,
	Id_Permissao
	FROM Pessoa
	WHERE Cliente = 1 AND Funcionario = 1 AND Ativo = 0
GO

--SELECT NomeCompleto, Cliente, Funcionario, Ativo FROM Pessoa
--EXEC SP_BuscarFuncionario '1'
--EXEC SP_BuscarFuncionario '0'
--EXEC SP_BuscarFuncionarioInativo
--EXEC SP_BuscarClienteAtivo
--EXEC SP_BuscarClienteInativo
--EXEC SP_BuscarClienteFuncionarioInativo
--EXEC SP_BuscarClienteFuncionarioAtivo
--####################################################################################

CREATE PROC SP_ExcluirUsuario
	@Id INT
AS
	DELETE FROM Pessoa WHERE Id = @Id
GO

--TABELA "GESTÃO DE O.S"
CREATE TABLE OrdemServico
	(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Protocolo VARCHAR (20),
	Id_Cliente INT,
	TipoChamado VARCHAR(50),
	Descricao VARCHAR(1000),
	DataAbertura DATETIME NULL,
	DataPrazo DATETIME NULL,
	DataDeFechamento DATETIME NULL,
	TecnicoResponsavel VARCHAR(150),
	Atendente VARCHAR(150),
	EstatusOS VARCHAR(20),
	LigarAntes VARCHAR(5)
)
GO

CREATE PROCEDURE SP_AbrirOrdemServico
	@Id INT OUTPUT,
	@Protocolo VARCHAR (20),
	@Id_Cliente INT,
	@TipoChamado VARCHAR(50),
	@Descricao VARCHAR(1000),
	@DataAbertura DATETIME NULL,
	@DataPrazo DATETIME NULL,
	@TecnicoResponsavel VARCHAR(150),
	@Atendente VARCHAR(150),
	@EstatusOS VARCHAR(20),
	@LigarAntes VARCHAR(5)
AS
	INSERT INTO OrdemServico(
	Protocolo,
	Id_Cliente,
	TipoChamado,
	Descricao,
	DataAbertura,
	DataPrazo,
	TecnicoResponsavel,
	Atendente,
	EstatusOS,
	LigarAntes
	)
		VALUES(
		@Protocolo,
		@Id_Cliente,
		@TipoChamado,
		@Descricao,
		@DataAbertura,
		@DataPrazo,
		@TecnicoResponsavel,
		@Atendente,
		@EstatusOS,
		@LigarAntes
		)
	SET @Id = (SELECT @@IDENTITY)
GO

CREATE PROC SP_BuscarOS
	@Filtro VARCHAR(50) = ''
AS
	SELECT
	OrdemServico.Id,
	Protocolo,
	Id_Cliente,
	TipoChamado,
	Descricao,
	DataAbertura,
	DataPrazo,
	TecnicoResponsavel,
	Atendente,
	EstatusOS,
	LigarAntes,
	Pessoa.NomeCompleto,
	Pessoa.Cpf,
	Pessoa.Cep,
	Pessoa.Rua,
	Pessoa.NumCasa,
	Pessoa.Bairro,
	Pessoa.Email,
	Pessoa.Telefone,
	Pessoa.CelularUm,
	Pessoa.CelularDois,
	Pessoa.Cidade,
	Pessoa.Uf,
	Pessoa.Id_Plano
	FROM OrdemServico
	LEFT JOIN Pessoa ON OrdemServico.Id_Cliente = Pessoa.Id
	WHERE Protocolo LIKE '%' + @filtro + '%'
GO

CREATE PROC SP_BuscarOSPendente
AS
	SELECT
	OrdemServico.Id,
	Protocolo,
	Id_Cliente,
	TipoChamado,
	Descricao,
	DataAbertura,
	DataPrazo,
	TecnicoResponsavel,
	Atendente,
	EstatusOS,
	LigarAntes,
	Pessoa.NomeCompleto AS NomeCompleto
	FROM OrdemServico
	LEFT JOIN Pessoa ON OrdemServico.Id_Cliente = Pessoa.Id
	WHERE EstatusOS != 'FECHADO'
GO

/*'ABERTO' 'FECHADO' 'ENCAMINHADO'///////////////////////////////////// ESSE ESTA FUNCIONANDO
CREATE PROC SP_BuscarOS
	@Filtro VARCHAR(50) = ''
AS
	SELECT
	Protocolo,
	Id_Cliente,
	TipoChamado,
	Descricao,
	DataAbertura,
	DataPrazo,
	TecnicoResponsavel,
	Atendente,
	EstatusOS,
	LigarAntes
	FROM OrdemServico
	WHERE Protocolo LIKE '%' + @filtro + '%'
GO

////////////////////////////////////

CREATE PROC SP_BuscarPlano
	@Filtro VARCHAR(50)
	as
IF EXISTS(SELECT 1 FROM Plano WHERE CONVERT(VARCHAR(50), Id) = @Filtro)
	SELECT Id, Descricao, Valor FROM Plano WHERE CONVERT(VARCHAR(50), Id) = @Filtro
ELSE
	SELECT Id, Descricao, Valor FROM Plano WHERE Descricao LIKE '%' + @filtro + '%'
GO
'SUPORTE LOSS'
'SUPORTE FIBRA'
'INSTALAÇÃO FIBRA'
'MUDANÇA DE ENDEREÇO' */

INSERT INTO Pessoa(Ativo, NomeUsuario, Senha, NomeCompleto, DataNascimento, Cep, Rua, NumCasa, Bairro, EstadoCivil, Nacionalidade, Cpf, Rg, OrgaoExpeditor, Email, Telefone, CelularUm, CelularDois, Cidade, Uf, Cliente, Funcionario, Id_Plano, Id_Permissao, Foto)
	VALUES (1, '3V4ND3R50N', 'Senha@123', 'EVANDERSON RIBEIRO', '05-01-1988', '77827150', 'RUA DOS ABACATEIROS', '543', 'ARAG SL', 'SOLTEIRO', 'BRASILEIRO', '02227866193', '6666666', 'SSPTO', 'evanderson@email.com', '6334112300', '13992019277', '63992019277', 'ARAGUAINA', 'TO', 1, 1, 4, 3, '')
GO

INSERT INTO Pessoa(NomeUsuario, Senha, NomeCompleto, DataNascimento, Cpf, Cliente, Funcionario, Id_Plano, Id_Permissao, Foto, Ativo)
	VALUES ('admin', 'admin', 'ADMINISTRADOR DO SISTEMA', '01-01-1995', '999.999.999-99', 1, 1, 4, 3, '', 1)
GO

INSERT INTO Pessoa(NomeCompleto, DataNascimento, Cpf, Cliente, Funcionario, Id_Plano, Id_Permissao, Foto, Ativo)
	VALUES ('USUARIO TESTE UM', '01-01-2001', '111.111.111-11', 1, 1, 1, 1, '', 1)
GO

INSERT INTO Pessoa(NomeCompleto, DataNascimento, Cpf, Cliente, Funcionario, Id_Plano, Id_Permissao, Foto, Ativo)
	VALUES ('USUARIO TESTE DOIS', '02-02-2002', '222.222.222-22', 1, 1, 1, 1, '', 0)
GO

INSERT INTO Pessoa(NomeCompleto, DataNascimento, Cpf, Cliente, Funcionario, Id_Plano, Id_Permissao, Foto, Ativo)
	VALUES ('USUARIO TESTE TRES', '03-03-2003', '333.333.333.33', 1, 0, 1, 1, '', 1)
GO

INSERT INTO Pessoa(NomeCompleto, DataNascimento, Cpf, Cliente, Funcionario, Id_Plano, Id_Permissao, Foto, Ativo)
	VALUES ('USUARIO TESTE QUATRO', '04-04-2004', '444.444.444.44', 1, 0, 1, 1, '', 0)
GO

EXEC SP_AbrirOrdemServico 0, 2022080101, 1, 'INSTALAÇÃO FIBRA','REALIZAR A INSTALAÇÃO', '28-07-2022', '30-07-2022', 'TECNICO JÃO', 'ATEND. UM', 'ENCAMINHADO', 'SIM'
EXEC SP_AbrirOrdemServico 0, 2022080102, 1, 'SUPORTE LOSS','TESTE DA DESCRIÇÃO DA O.S UM', '28-07-2022', '30-07-2022', 'TECNICO JÃO', 'ATEND. UM', 'ENCAMINHADO', 'SIM'
EXEC SP_AbrirOrdemServico 0, 2022080103, 2, 'SUPORTE FIBRA','TESTE DA DESCRIÇÃO DA O.S DOIS', '30-07-2022', '01-08-2022', 'TECNICO ZÉ', 'ATEND. DOIS', 'ABERTO', 'NAO'
EXEC SP_AbrirOrdemServico 0, 2022080104, 2, 'MUDANÇA DE ENDEREÇO','TESTE DA DESCRIÇÃO DA O.S DOIS', '30-07-2022', '01-08-2022', 'TECNICO ZÉ', 'ATEND. DOIS', 'ABERTO', 'NAO'
EXEC SP_AbrirOrdemServico 0, 2022080105, 3, 'INSTALAÇÃO FIBRA','TESTE DA DESCRIÇÃO DA O.S UM', '28-07-2022', '30-07-2022', 'TECNICO JÃO', 'ATEND. UM', 'ENCAMINHADO', 'SIM'
EXEC SP_AbrirOrdemServico 0, 2022080106, 3, 'SUPORTE LOSS','TESTE DA DESCRIÇÃO DA O.S DOIS', '30-07-2022', '01-08-2022', 'TECNICO ZÉ', 'ATEND. DOIS', 'ABERTO', 'NAO'
EXEC SP_AbrirOrdemServico 0, 2022080107, 4, 'SUPORTE FIBRA','TESTE DA DESCRIÇÃO DA O.S DOIS', '30-07-2022', '01-08-2022', 'TECNICO ZÉ', 'ATEND. DOIS', 'FECHADO', 'NAO'
EXEC SP_AbrirOrdemServico 0, 2022080108, 4, 'SUPORTE FIBRA','TESTE DA DESCRIÇÃO DA O.S DOIS', '30-07-2022', '01-08-2022', 'TECNICO ZÉ', 'ATEND. DOIS', 'ABERTO', 'NAO'
EXEC SP_AbrirOrdemServico 0, 2022080109, 4, 'SUPORTE FIBRA','TESTE DA DESCRIÇÃO DA O.S DOIS', '30-07-2022', '01-08-2022', 'TECNICO ZÉ', 'ATEND. DOIS', 'FECHADO', 'NAO'
GO

--EXEC SP_BuscarOS '123456789'
--EXEC SP_BuscarOSAberta
--SELECT * FROM OrdemServico
--SELECT * FROM Pessoa
--SELECT * FROM Plano
SELECT NomeCompleto, Cliente, Funcionario, Ativo FROM Pessoa
GO