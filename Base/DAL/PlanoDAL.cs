using Model;
using System;
using System.Data;
using System.Data.SqlClient;
// ALT + ENTER + ENTER = RETIRA AS BIBLIOTECAS DESNECESSARIAS
namespace DAL
{
    public class PlanoDAL
    {
        public Plano Inserir(Plano _plano)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;//ESTRUTURA DE CONEXÃO
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cn,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "SP_InserirPlano"
                };

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.VarChar)
                {
                    Value = _plano.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Descricao", SqlDbType.VarChar)
                {
                    Value = _plano.Descricao
                });

                cmd.Parameters.Add(new SqlParameter("@Valor", SqlDbType.VarChar)
                {
                    Value = _plano.Valor
                });



                /////////////////////////////////////////////////////////////
                cn.Open();
                _plano.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _plano;
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
                cmd.CommandText = "SP_ExcluirPlano";
                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);

                //ABRE A CONEXÃO COM O BANCO DE DADOS
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();//EXECUTA O COMANDO SQL NO BANCO DE DADOS
                if (resultado != 1)
                    throw new Exception("NÃO FOI POSSIVEL EXCLUIR O PLANO: " + _id.ToString());
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
        public Plano Alterar(Plano _plano)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarPlano";

                SqlParameter pplano = new SqlParameter("@Id", SqlDbType.Int);
                pplano.Value = _plano.Id;
                cmd.Parameters.Add(pplano);

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
