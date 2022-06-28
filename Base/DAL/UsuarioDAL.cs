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

                SqlParameter pativo = new SqlParameter("@Ativo", SqlDbType.Bit)
                {
                    Value = _usuario.Ativo
                };
                cmd.Parameters.Add(pativo);

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _usuario.Id
                };
                cmd.Parameters.Add(pid);

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
                /////////////////
                cmd.Parameters.Add(new SqlParameter("@Id_Permissao", SqlDbType.VarChar)
                {
                    Value = _usuario.Id_Permissao
                });
                ////////////////
                cmd.Parameters.Add(new SqlParameter("@Salario", SqlDbType.VarChar)
                {
                    Value = _usuario.Salario
                });

                cmd.Parameters.Add(new SqlParameter("@Cargo", SqlDbType.VarChar)
                {
                    Value = _usuario.Cargo
                });

                cmd.Parameters.Add(new SqlParameter("@DataAdmissao", SqlDbType.DateTime)
                {
                    Value = _usuario.DataAdmissao
                });

                if (_usuario.DataDemissao.ToString().Trim().Length > 6)
                    cmd.Parameters.Add(new SqlParameter("@DataDemissao", SqlDbType.DateTime)
                    {
                        Value = _usuario.DataDemissao
                    });

                cmd.Parameters.Add(new SqlParameter("@Funcionario", SqlDbType.Bit)
                {
                    Value = _usuario.Funcionario
                });

                cmd.Parameters.Add(new SqlParameter("@Cliente", SqlDbType.Bit)
                {
                    Value = _usuario.Cliente
                });

                cmd.Parameters.Add(new SqlParameter("@Cep", SqlDbType.VarChar)
                {
                    Value = _usuario.Cep
                });

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
                cn.Close();
            }
        }
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

                //ABRE A CONEXÃO COM O BANCO DE DADOS
                cn.Open();
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
                //FECHA A CONEÃO COM O BANDO DE DADOS
                cn.Close();
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

                SqlParameter pnomeUsuario = new SqlParameter("@NomeUsuario", SqlDbType.VarChar);
                pnomeUsuario.Value = _usuario.NomeUsuario;
                cmd.Parameters.Add(pnomeUsuario);

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _usuario.Id;
                cmd.Parameters.Add(pid);

                /*SqlParameter psenha = new SqlParameter("@Senha", SqlDbType.VarChar);
                psenha.Value = _usuario.Senha;
                cmd.Parameters.Add(psenha);*/

                SqlParameter pativo = new SqlParameter("@Ativo", SqlDbType.Bit);
                pativo.Value = _usuario.Ativo;
                cmd.Parameters.Add(pativo);

                SqlParameter pcpf = new SqlParameter("@Cpf", SqlDbType.VarChar);
                pcpf.Value = _usuario.Cpf;
                cmd.Parameters.Add(pcpf);

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
