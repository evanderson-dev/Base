-- CTR + SHIFT + R = ATUALIZA O SCRIP CASO ESTEJA ACUSANDO ERROS
-- CTR + R = ATALHO PARA FECHAR RESULTADO
-- SET DATEFORMAT DMY
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

-- SENAI  | Initial Catalog=ORDEMSERVICO; Data Source = LAB05-03\SQLEXPRESS2019;   User ID=SA; Password = Senailab05
-- TOLEDO | Initial Catalog=ORDEMSERVICO; Data Source = TLD-AUX-SU-006\SQLEXPRESS; User ID=SA; Password = Senailab05
-- CASA   | Initial Catalog=ORDEMSERVICO; Data Source = EVANDERSON\SQLEXPRESS;	   Integrated Security  = True
--GO

CREATE TABLE Permissao
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Descricao VARCHAR(250)
)
GO

INSERT INTO Permissao(Descricao)
	VALUES('Abrir O.S'),
	('Abrir O.S, Fechar O.S'),
	('Abrir O.S, Fechar O.S, Encaminhar O.S')
GO

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

CREATE TABLE Pessoa
(
	-- DADOS PESSOAIS
	Id INT PRIMARY KEY IDENTITY(1,1),
	Ativo BIT,
	Sexo BIT,---------------------------- EM ANDAMENTO
	NomeUsuario VARCHAR(150),
	Senha VARCHAR(150),
	NomeCompleto VARCHAR(150),
	Cpf VARCHAR(14),
	Rg VARCHAR(13),
	OrgaoExpeditor VARCHAR(6),
	DataNascimento DATETIME,
	Cep VARCHAR(10),
	Rua VARCHAR(150),
	NumCasa VARCHAR(10),
	Bairro VARCHAR(150),
	EstadoCivil VARCHAR(10),
	Nacionalidade VARCHAR(10),
	Email VARCHAR(30),
	Telefone VARCHAR(15),
	CelularUm VARCHAR(16),
	CelularDois VARCHAR(16),
	Cidade VARCHAR(10),
	Uf VARCHAR(2),
	Foto VARCHAR(150),
	-- DADOS DO FUNCIONARIO
	Funcionario BIT,
	Id_Permissao INT,
	Salario varchar(15),
	Cargo VARCHAR(50),
	DataAdmissao DATETIME NULL,
	DataDemissao DATETIME NULL,
	Banco VARCHAR(40),
	NumeroAgenciaBanco VARCHAR(10),
	NumeroContaBanco VARCHAR(15),
	-- DADOS DO CLIENTE
	Cliente BIT,
	Id_Plano INT,
	InicioDoContrato DATETIME NULL,
	FimDoContrato DATETIME NULL,
	-- OBSERVAÇOES GERAIS
	Observacao VARCHAR(250)
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

EXEC SP_InserirUsuario 0, 0, 'Usuario123', 'U2VuaGExMjM=', 'MATHEUS NINGUEM', '111.111.111-11', '11.111.111', 'SSP',
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
	DataDeFechamento DATE NULL,
	TecnicoResponsavel VARCHAR(150),
	Atendente VARCHAR(150),
	EstatusOS VARCHAR(20),
	LigarAntes VARCHAR(5),
	MotivoFechamento VARCHAR(1000)
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
	MotivoFechamento,
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
--
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
	MotivoFechamento,
	Pessoa.NomeCompleto AS NomeCompleto
	FROM OrdemServico
	LEFT JOIN Pessoa ON OrdemServico.Id_Cliente = Pessoa.Id
	WHERE EstatusOS != 'FECHADO'
GO

CREATE PROC SP_BuscarOSFechada
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
	MotivoFechamento,
	Pessoa.NomeCompleto AS NomeCompleto
	FROM OrdemServico
	LEFT JOIN Pessoa ON OrdemServico.Id_Cliente = Pessoa.Id
	WHERE EstatusOS = 'FECHADO'
GO

CREATE PROC SP_BuscarOSAberta
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
	MotivoFechamento,
	Pessoa.NomeCompleto AS NomeCompleto
	FROM OrdemServico
	LEFT JOIN Pessoa ON OrdemServico.Id_Cliente = Pessoa.Id
	WHERE EstatusOS = 'ABERTO'
GO

CREATE PROC SP_BuscarOSEncaminhada
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
	MotivoFechamento,
	Pessoa.NomeCompleto AS NomeCompleto
	FROM OrdemServico
	LEFT JOIN Pessoa ON OrdemServico.Id_Cliente = Pessoa.Id
	WHERE EstatusOS = 'ENCAMINHADO'
GO

CREATE PROC SP_BuscarSuportes
	@Filtro VARCHAR(10) = ''
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
	MotivoFechamento,
	Pessoa.NomeCompleto AS NomeCompleto
	FROM OrdemServico
	LEFT JOIN Pessoa ON OrdemServico.Id_Cliente = Pessoa.Id
	WHERE Id_Cliente = @filtro
GO

--SP_BuscarSuportes '2'
--SP_BuscarOSPendente

CREATE PROC SP_FecharOrdemServico
	@Id INT,
	@MotivoFechamento VARCHAR(1000),
	@EstatusOS VARCHAR(20),
	@DataDeFechamento DATE NULL
AS
	UPDATE OrdemServico SET
	MotivoFechamento = @MotivoFechamento,
	EstatusOS = @EstatusOS,
	DataDeFechamento = @DataDeFechamento
	WHERE Id = @Id
GO

INSERT INTO Pessoa(Ativo, NomeUsuario, Senha, NomeCompleto, DataNascimento, Cep, Rua, NumCasa, Bairro, EstadoCivil, Nacionalidade, Cpf, Rg, OrgaoExpeditor, Email, Telefone, CelularUm, CelularDois, Cidade, Uf, Cliente, Funcionario, Id_Plano, Id_Permissao, Foto)
	VALUES (1, 'EVANDERSON', 'MTgwNzE5ODg=', 'EVANDERSON RIBEIRO', '05-01-1988', '77827150', 'RUA DOS ABACATEIROS', '543', 'ARAGUAINA SUL', 'SOLTEIRO', 'BRASILEIRO', '02227866193', '1159935', 'SSP-TO', 'evanderson@email.com', '6334112300', '13992019277', '63992019277', 'ARAGUAINA', 'TO', 1, 1, 4, 3, ''),
		   -- INSERT DO ADMINISTRADOR DO SISTEMA
		   (1, 'admin', 'YWRtaW4=', 'ADMINISTRADOR DO SISTEMA', '05-01-1989', '77827150', 'RUA DO ADMINISTRADOR', '540', 'ARAGUAINA SUL', 'CASADO', 'BRASILEIRO', '02227866190', '1260936', 'SSP-TO', 'administrador@email.com', '', '13992019278', '', 'ARAGUAINA', 'TO', 1, 1, 4, 3, ''),
		   -- INSERT DOS FUNCIONARIOS PARA TESTES DE CONSULTA
		   (1, 'TecnicoUm', 'tec1', 'TECNICO TESTE UM', '05-01-1990', '77827150', 'RUA TESTE UM', '540', 'SETOR TESTE UM', 'CASADO', 'BRASILEIRO', '02227866191', '1361937', 'SSP-TO', 'tecnico_um@email.com', '', '13992019279', '', 'ARAGUAINA', 'TO', 0, 1, 3, 2, ''),
		   (1, 'TecnicoDois', 'tec2', 'TECNICO TESTE DOIS', '05-01-1991', '77827151', 'RUA TESTE DOIS', '541', 'SETOR TESTE DOIS', 'CASADO', 'BRASILEIRO', '02227866192', '1462038', 'SSP-TO', 'tecnico_dois@email.com', '', '13992019280', '', 'ARAGUAINA', 'TO', 0, 1, 3, 2, ''),
		   (1, 'TecnicoTres', 'tec3', 'TECNICO TESTE TRES', '05-01-1992', '77827152', 'RUA TESTE TRES', '542', 'SETOR TESTE TRES', 'CASADO', 'BRASILEIRO', '02227866193', '1563039', 'SSP-TO', 'tecnico_tres@email.com', '', '13992019281', '', 'ARAGUAINA', 'TO', 0, 1, 3, 2, ''),
		   -- INSERT DOS CLIENTES PARA TESTES DE CONSULTA
		   (1, '', '', 'CLIENTE TESTE UM', '05-01-1999', '77827153', 'RUA TESTE QUATRO', '543', 'SETOR TESTE QUATRO', 'SOLTEIRO', 'BRASILEIRO', '12345678912', '1664040', 'SSP-TO', 'cliente_um@email.com', '', '63992010001', '', 'ARAGUAINA', 'TO', 1, 0, 1, 0, ''),
		   (1, '', '', 'CLIENTE TESTE DOIS', '06-02-2000', '77827154', 'RUA TESTE CINCO', '544', 'SETOR TESTE CINCO', 'SOLTEIRO', 'BRASILEIRO', '78945613278', '1765041', 'SSP-TO', 'cliente_dois@email.com', '', '63992010002', '', 'ARAGUAINA', 'TO', 1, 0, 2, 0, ''),
		   (1, '', '', 'CLIENTE TESTE TRES', '07-03-2001', '77827155', 'RUA TESTE SEIS', '545', 'SETOR TESTE SEIS', 'SOLTEIRO', 'BRASILEIRO', '14725836914', '1865042', 'SSP-TO', 'cliente_tres@email.com', '', '63992010003', '', 'ARAGUAINA', 'TO', 1, 0, 3, 0, '')
GO

EXEC SP_AbrirOrdemServico 0, 2022080101, 7, 'INSTALAÇÃO FIBRA','REALIZAR A INSTALAÇÃO E CONFIGURAÇÃO DO ROTEADOR', '28-07-2022', '30-07-2022', 'TECNICO TESTE UM', 'TECNICO TESTE DOIS', 'ENCAMINHADO', 'SIM'
EXEC SP_AbrirOrdemServico 0, 2022080102, 7, 'SUPORTE LOSS','LINK LOSS, CLIENTE RELATOU QUE UM CAMINHÃO ROMPEU OS CABOS PROXIMO A RESIDENCIA', '28-07-2022', '30-07-2022', 'TECNICO TESTE UM', 'TECNICO TESTE TRES', 'ENCAMINHADO', 'SIM'
EXEC SP_AbrirOrdemServico 0, 2022080103, 7, 'SUPORTE FIBRA','CLIENTE SEM CONEXÃO, ONU AC1200 APRESENTANDO PROBLEMAS, SOMENTE A LUZ POWER LIGADA, REALIZAR A TROCA DO EQUIPAMENTO', '30-07-2022', '01-08-2022', 'TECNICO TESTE UM', 'TECNICO TESTE DOIS', 'ABERTO', 'NAO'
EXEC SP_AbrirOrdemServico 0, 2022080104, 8, 'MUDANÇA DE ENDEREÇO','REALIZAR A MUDANÇA PARA O  NOVO ENDEREÇO, CLIENTE INSENTO DA TAXA DE MUDANÇA DE ENDEREÇO DEVIDO TER RENOVADO O PLANO', '30-07-2022', '01-08-2022', 'TECNICO TESTE UM', 'TECNICO TESTE TRES', 'ABERTO', 'NAO'
EXEC SP_AbrirOrdemServico 0, 2022080105, 8, 'INSTALAÇÃO FIBRA','REALIZAR A INSTALAÇÃO E CONFIGURAÇÃO DO ROTEADOR', '28-07-2022', '30-07-2022', 'TECNICO TESTE UM', 'TECNICO TESTE DOIS', 'ENCAMINHADO', 'SIM'
EXEC SP_AbrirOrdemServico 0, 2022080106, 8, 'SUPORTE LOSS','LINK LOSS, ONU CONSTA O LED PON PISCANDO', '30-07-2022', '01-08-2022', 'TECNICO TESTE UM', 'TECNICO TESTE TRES', 'ABERTO', 'NAO'
EXEC SP_AbrirOrdemServico 0, 2022080107, 9, 'SUPORTE FIBRA','CLIENTE RELATANDO LENTIDÃO EM TODOS OS ACESSOS DE TODOS OS DISPOSITIVOS, O MESMO RELATA QUE OS MEGAS CONTRATADOS NÃO CHEGAM EM SEUS TESTES REALIZADOS MESMO CONECTADO NA REDE 5G', '30-07-2022', '01-08-2022', 'TECNICO TESTE UM', 'TECNICO TESTE DOIS', 'ABERTO', 'NAO'
EXEC SP_AbrirOrdemServico 0, 2022080108, 9, 'SUPORTE FIBRA','REALIZAR A TROCA DA SENHA DO ROTEADOR DO CLIENTE, CLIENTE CIENTE DA TAXA DE SERVIÇO', '30-07-2022', '01-08-2022', 'TECNICO TESTE UM', 'TECNICO TESTE TRES', 'ABERTO', 'NAO'
EXEC SP_AbrirOrdemServico 0, 2022080109, 9, 'SUPORTE FIBRA','PARAFUSAR OS EQUIPAMENTOS NA PAREDE, POIS ESTAVAM FIXADOS COM FITA DUPLA FACE E SOLTARAM', '30-07-2022', '01-08-2022', 'TECNICO TESTE UM', 'TECNICO TESTE DOIS', 'ABERTO', 'NAO'
GO

--EXEC SP_FecharOrdemServico 4, 'MUDANÇA DE ENDEREÇO CONCLUIDA', 'FECHADO', '12-08-2022'
--GO

--EXEC SP_BuscarOS '123456789'
--EXEC SP_BuscarOSAberta
--SELECT Protocolo, Id_Cliente, TipoChamado, Descricao, DataDeFechamento, EstatusOS, MotivoFechamento FROM OrdemServico
--SELECT * FROM Pessoa
--SELECT * FROM Plano
--SELECT Cpf, NomeCompleto, Cliente, Funcionario, Ativo FROM Pessoa
SELECT NomeUsuario, Senha, NomeCompleto, Cliente, Funcionario, Ativo, Id_Permissao FROM Pessoa
--GO