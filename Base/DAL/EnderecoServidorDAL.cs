using Model;
using System;
using System.Data;
using System.Data.SqlClient;
// ALT + ENTER + ENTER = RETIRA AS BIBLIOTECAS DESNECESSARIAS
namespace DAL
{
    public class EnderecoServidorDAL
    {
        public EnderecoServidor Inserir(EnderecoServidor _enderecoServidor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;//ESTRUTURA DE CONEXÃO
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirEnderecoServidor";

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _enderecoServidor.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Descricao", SqlDbType.VarChar)
                {
                    Value = _enderecoServidor.Descricao
                });

                cmd.Parameters.Add(new SqlParameter("@StringDeConexao", SqlDbType.VarChar)
                {
                    Value = _enderecoServidor.StringDeConexao
                });

                cn.Open();
                _enderecoServidor.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _enderecoServidor;
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
                da.SelectCommand.CommandText = "SP_BuscarEnderecoServidor";//PROCEDURE DO BANCO SQL
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
                cmd.CommandText = "SP_ExcluirEnderecoServidor";
                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();//EXECUTA O COMANDO SQL NO BANCO DE DADOS
                if (resultado != 1)
                    throw new Exception("NÃO FOI POSSIVEL EXCLUIR O ENDEREÇO: " + _id.ToString());
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
        public EnderecoServidor Alterar(EnderecoServidor _enderecoServidor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarEnderecoServidor";

                SqlParameter id = new SqlParameter("@Id", SqlDbType.Int);
                id.Value = _enderecoServidor.Id;
                cmd.Parameters.Add(id);

                SqlParameter descricao = new SqlParameter("@Descricao", SqlDbType.VarChar);
                descricao.Value = _enderecoServidor.Descricao;
                cmd.Parameters.Add(descricao);

                SqlParameter stringDeConexao = new SqlParameter("@StringDeConexao", SqlDbType.VarChar);
                stringDeConexao.Value = _enderecoServidor.StringDeConexao;
                cmd.Parameters.Add(stringDeConexao);

                cn.Open();
                cmd.ExecuteNonQuery();
                return _enderecoServidor;
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
    }
}
