using Model;
using System;
using System.Data;
using System.Data.SqlClient;
// ALT + ENTER + ENTER = RETIRA AS BIBLIOTECAS DESNECESSARIAS
namespace DAL
{
    public class UsuarioDAL
    {
        public Usuario Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;//ESTRUTURA DE CONEXÃO
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cn,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "SP_InserirUsuario"
                };

                #region Parâmetros

                /*SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int)
                { Value = _usuario.Id };
                cmd.Parameters.Add(pid);*/

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _usuario.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Ativo", SqlDbType.Bit)
                {
                    Value = _usuario.Ativo
                });

                cmd.Parameters.Add(new SqlParameter("@NomeUsuario", SqlDbType.VarChar)
                {
                    Value = _usuario.NomeUsuario
                });

                cmd.Parameters.Add(new SqlParameter("@Senha", SqlDbType.VarChar)
                {
                    Value = _usuario.Senha
                });

                cmd.Parameters.Add(new SqlParameter("@NomeCompleto", SqlDbType.VarChar)
                {
                    Value = _usuario.NomeCompleto
                });

                cmd.Parameters.Add(new SqlParameter("@Cpf", SqlDbType.VarChar)
                {
                    Value = _usuario.Cpf
                });

                cmd.Parameters.Add(new SqlParameter("@Rg", SqlDbType.VarChar)
                {
                    Value = _usuario.Rg
                });

                cmd.Parameters.Add(new SqlParameter("@OrgaoExpeditor", SqlDbType.VarChar)
                {
                    Value = _usuario.OrgaoExpeditor
                });

                cmd.Parameters.Add(new SqlParameter("@DataNascimento", SqlDbType.DateTime)
                {
                    Value = _usuario.DataNascimento
                });

                cmd.Parameters.Add(new SqlParameter("@Cep", SqlDbType.VarChar)
                {
                    Value = _usuario.Cep
                });

                cmd.Parameters.Add(new SqlParameter("@Rua", SqlDbType.VarChar)
                {
                    Value = _usuario.Rua
                });

                cmd.Parameters.Add(new SqlParameter("@NumCasa", SqlDbType.VarChar)
                {
                    Value = _usuario.NumCasa
                });

                cmd.Parameters.Add(new SqlParameter("@EstadoCivil", SqlDbType.VarChar)
                {
                    Value = _usuario.EstadoCivil
                });

                cmd.Parameters.Add(new SqlParameter("@Nacionalidade", SqlDbType.VarChar)
                {
                    Value = _usuario.Nacionalidade
                });

                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar)
                {
                    Value = _usuario.Email
                });

                cmd.Parameters.Add(new SqlParameter("@Telefone", SqlDbType.VarChar)
                {
                    Value = _usuario.Telefone
                });

                cmd.Parameters.Add(new SqlParameter("@CelularUm", SqlDbType.VarChar)
                {
                    Value = _usuario.CelularUm
                });

                cmd.Parameters.Add(new SqlParameter("@CelularDois", SqlDbType.VarChar)
                {
                    Value = _usuario.CelularDois
                });

                cmd.Parameters.Add(new SqlParameter("@Cidade", SqlDbType.VarChar)
                {
                    Value = _usuario.Cidade
                });

                cmd.Parameters.Add(new SqlParameter("@Uf", SqlDbType.VarChar)
                {
                    Value = _usuario.Uf
                });

                cmd.Parameters.Add(new SqlParameter("@Funcionario", SqlDbType.Bit)
                {
                    Value = _usuario.Funcionario
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Permissao", SqlDbType.VarChar)
                {
                    Value = _usuario.Id_Permissao
                });

                cmd.Parameters.Add(new SqlParameter("@Salario", SqlDbType.VarChar)
                {
                    Value = _usuario.Salario
                });

                cmd.Parameters.Add(new SqlParameter("@Cargo", SqlDbType.VarChar)
                {
                    Value = _usuario.Cargo
                });

                if (_usuario.DataAdmissao.ToString().Trim().Length > 6)
                    cmd.Parameters.Add(new SqlParameter("@DataAdmissao", SqlDbType.DateTime)
                    {
                        Value = _usuario.DataAdmissao
                    });

                if (_usuario.DataDemissao.ToString().Trim().Length > 6)
                    cmd.Parameters.Add(new SqlParameter("@DataDemissao", SqlDbType.DateTime)
                    {
                        Value = _usuario.DataDemissao
                    });

                cmd.Parameters.Add(new SqlParameter("@Banco", SqlDbType.VarChar)
                {
                    Value = _usuario.Banco
                });

                cmd.Parameters.Add(new SqlParameter("@NumeroAgenciaBanco", SqlDbType.VarChar)
                {
                    Value = _usuario.NumeroAgenciaBanco
                });

                cmd.Parameters.Add(new SqlParameter("@NumeroContaBanco", SqlDbType.VarChar)
                {
                    Value = _usuario.NumeroContaBanco
                });

                cmd.Parameters.Add(new SqlParameter("@Cliente", SqlDbType.Bit)
                {
                    Value = _usuario.Cliente
                });

                if (_usuario.InicioDoContrato.ToString().Trim().Length > 6)
                    cmd.Parameters.Add(new SqlParameter("@InicioDoContrato", SqlDbType.DateTime)
                    {
                        Value = _usuario.InicioDoContrato
                    });

                if (_usuario.FimDoContrato.ToString().Trim().Length > 6)
                    cmd.Parameters.Add(new SqlParameter("@FimDoContrato", SqlDbType.DateTime)
                    {
                        Value = _usuario.FimDoContrato
                    });

                cmd.Parameters.Add(new SqlParameter("@Observacao", SqlDbType.VarChar)
                {
                    Value = _usuario.Observacao
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Plano", SqlDbType.Int)
                {
                    Value = _usuario.Id_Plano
                });

                #endregion

                /////////////////////////////////////////////////////////////
                cn.Open();
                _usuario.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _usuario;
            }
            catch (SqlException ex)
            {
                throw new Exception("SERVIDOR SQL ERRO: " + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable Buscar(string _filtro)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;//ESTRUTURA DE CONEXÃO
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "SP_BuscarUsuario";//PROCEDURE DO BANCO SQL
                da.SelectCommand.CommandType = CommandType.StoredProcedure;//TIPO DE COMANDO QUE SERÁ EXECUTADO

                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar);
                pfiltro.Value = _filtro;

                da.SelectCommand.Parameters.Add(pfiltro);

                cn.Open();//ABERTURA DA CONEXÃO COM O BANCO
                da.Fill(dt);

                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("SERVIDOR SQL ERRO: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();//FECHAMENTO DA CONEXÃO COM O BANCO
            }
        }
        /////////////////////  BUSCAR PLANO  /////////////////////////////////
        public DataTable BuscarPlano(string _filtro)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;//ESTRUTURA DE CONEXÃO
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "SP_BuscarPlano";//PROCEDURE DO BANCO SQL
                da.SelectCommand.CommandType = CommandType.StoredProcedure;//TIPO DE COMANDO QUE SERÁ EXECUTADO

                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar);
                pfiltro.Value = _filtro;

                da.SelectCommand.Parameters.Add(pfiltro);

                cn.Open();//ABERTURA DA CONEXÃO COM O BANCO
                da.Fill(dt);

                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("SERVIDOR SQL ERRO: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();//FECHAMENTO DA CONEXÃO COM O BANCO
            }
        }//////////////////////////////////////////////////////

        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;//ESTRUTURA DE CONEXÃO;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExcluirUsuario";
                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);

                cn.Open();//ABERTURA DA CONEXÃO COM O BANCO
                int resultado = cmd.ExecuteNonQuery();//EXECUTA O COMANDO SQL NO BANCO DE DADOS
                if (resultado != 1)
                    throw new Exception("NÃO FOI POSSIVEL EXCLUIR O USUARIO: " + _id.ToString());
            }
            catch (SqlException ex)
            {
                throw new Exception("SERVIDOR SQL ERRO: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();//FECHAMENTO DA CONEXÃO COM O BANCO
            }
        }
        public Usuario Alterar(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarUsuario";

                SqlParameter id = new SqlParameter("@Id", SqlDbType.Int);
                id.Value = _usuario.Id;
                cmd.Parameters.Add(id);

                SqlParameter ativo = new SqlParameter("@Ativo", SqlDbType.Bit);
                ativo.Value = _usuario.Ativo;
                cmd.Parameters.Add(ativo);

                SqlParameter nomeUsuario = new SqlParameter("@NomeUsuario", SqlDbType.VarChar);
                nomeUsuario.Value = _usuario.NomeUsuario;
                cmd.Parameters.Add(nomeUsuario);

                SqlParameter senha = new SqlParameter("@Senha", SqlDbType.VarChar);
                senha.Value = _usuario.Senha;
                cmd.Parameters.Add(senha);

                SqlParameter nomeCompleto = new SqlParameter("@NomeCompleto", SqlDbType.VarChar);
                nomeCompleto.Value = _usuario.NomeCompleto;
                cmd.Parameters.Add(nomeCompleto);

                SqlParameter cpf = new SqlParameter("@Cpf", SqlDbType.VarChar);
                cpf.Value = _usuario.Cpf;
                cmd.Parameters.Add(cpf);

                SqlParameter rg = new SqlParameter("@Rg", SqlDbType.VarChar);
                rg.Value = _usuario.Rg;
                cmd.Parameters.Add(rg);

                SqlParameter orgaoExpeditor = new SqlParameter("@OrgaoExpeditor", SqlDbType.VarChar); // varchar??
                orgaoExpeditor.Value = _usuario.OrgaoExpeditor;
                cmd.Parameters.Add(orgaoExpeditor);

                SqlParameter dataNascimento = new SqlParameter("@DataNascimento", SqlDbType.DateTime); // varchar??
                dataNascimento.Value = _usuario.DataNascimento;
                cmd.Parameters.Add(dataNascimento);

                SqlParameter cep = new SqlParameter("@Cep", SqlDbType.VarChar);
                cep.Value = _usuario.Cep;
                cmd.Parameters.Add(cep);

                SqlParameter rua = new SqlParameter("@Rua", SqlDbType.VarChar);
                rua.Value = _usuario.Rua;
                cmd.Parameters.Add(rua);

                SqlParameter numCasa = new SqlParameter("@NumCasa", SqlDbType.VarChar);
                numCasa.Value = _usuario.NumCasa;
                cmd.Parameters.Add(numCasa);

                SqlParameter estadoCivil = new SqlParameter("@EstadoCivil", SqlDbType.VarChar);
                estadoCivil.Value = _usuario.EstadoCivil;
                cmd.Parameters.Add(estadoCivil);

                SqlParameter nacionalidade = new SqlParameter("@Nacionalidade", SqlDbType.VarChar);
                nacionalidade.Value = _usuario.Nacionalidade;
                cmd.Parameters.Add(nacionalidade);

                SqlParameter email = new SqlParameter("@Email", SqlDbType.VarChar);
                email.Value = _usuario.Email;
                cmd.Parameters.Add(email);

                SqlParameter telefone = new SqlParameter("@Telefone", SqlDbType.VarChar);
                telefone.Value = _usuario.Telefone;
                cmd.Parameters.Add(telefone);

                SqlParameter celularUm = new SqlParameter("@CelularUm", SqlDbType.VarChar);
                celularUm.Value = _usuario.CelularUm;
                cmd.Parameters.Add(celularUm);

                SqlParameter celularDois = new SqlParameter("@CelularDois", SqlDbType.VarChar);
                celularDois.Value = _usuario.CelularDois;
                cmd.Parameters.Add(celularDois);

                SqlParameter cidade = new SqlParameter("@Cidade", SqlDbType.VarChar);
                cidade.Value = _usuario.Cidade;
                cmd.Parameters.Add(cidade);

                SqlParameter uf = new SqlParameter("@Uf", SqlDbType.VarChar);
                uf.Value = _usuario.Uf;
                cmd.Parameters.Add(uf);

                SqlParameter funcionario = new SqlParameter("@Funcionario", SqlDbType.Bit);
                funcionario.Value = _usuario.Funcionario;
                cmd.Parameters.Add(funcionario);

                SqlParameter id_Permissao = new SqlParameter("@Id_Permissao", SqlDbType.Int); // int ???
                id_Permissao.Value = _usuario.Id_Permissao;
                cmd.Parameters.Add(id_Permissao);

                SqlParameter salario = new SqlParameter("@Salario", SqlDbType.VarChar);
                salario.Value = _usuario.Salario;
                cmd.Parameters.Add(salario);

                SqlParameter cargo = new SqlParameter("@Cargo", SqlDbType.VarChar);
                cargo.Value = _usuario.Cargo;
                cmd.Parameters.Add(cargo);

                if (_usuario.DataAdmissao.ToString().Trim().Length > 6)
                    cmd.Parameters.Add(new SqlParameter("@DataAdmissao", SqlDbType.DateTime)
                    {
                        Value = _usuario.DataAdmissao
                    });

                if (_usuario.DataDemissao.ToString().Trim().Length > 6)
                    cmd.Parameters.Add(new SqlParameter("@DataDemissao", SqlDbType.DateTime)
                    {
                        Value = _usuario.DataDemissao
                    });

                cmd.Parameters.Add(new SqlParameter("@Banco", SqlDbType.VarChar)
                {
                    Value = _usuario.Banco
                });

                cmd.Parameters.Add(new SqlParameter("@NumeroAgenciaBanco", SqlDbType.VarChar)
                {
                    Value = _usuario.NumeroAgenciaBanco
                });

                cmd.Parameters.Add(new SqlParameter("@NumeroContaBanco", SqlDbType.VarChar)
                {
                    Value = _usuario.NumeroContaBanco
                });

                cmd.Parameters.Add(new SqlParameter("@Cliente", SqlDbType.Bit)
                {
                    Value = _usuario.Cliente
                });

                if (_usuario.InicioDoContrato.ToString().Trim().Length > 6)
                    cmd.Parameters.Add(new SqlParameter("@InicioDoContrato", SqlDbType.DateTime)
                    {
                        Value = _usuario.InicioDoContrato
                    });

                if (_usuario.FimDoContrato.ToString().Trim().Length > 6)
                    cmd.Parameters.Add(new SqlParameter("@FimDoContrato", SqlDbType.DateTime)
                    {
                        Value = _usuario.FimDoContrato
                    });

                cmd.Parameters.Add(new SqlParameter("@Observacao", SqlDbType.VarChar)
                {
                    Value = _usuario.Observacao
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Plano", SqlDbType.Int)
                {
                    Value = _usuario.Id_Plano
                });

                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("SERVIDOR SQL ERRO: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return null;
        }
    }
}
