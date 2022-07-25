using Model;
using System;
using System.Data;
using System.Data.SqlClient;
// ALT + ENTER + ENTER = RETIRA AS BIBLIOTECAS DESNECESSARIAS
namespace DAL
{
    public class TipoChamadoDAL
    {
        public TipoChamado InserirTipoChamado(TipoChamado _tipoChamado)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;//ESTRUTURA DE CONEXÃO
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirTipoChamado";

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _tipoChamado.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Descricao", SqlDbType.VarChar)
                {
                    Value = _tipoChamado.Descricao
                });



                /////////////////////////////////////////////////////////////
                cn.Open();
                _tipoChamado.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _tipoChamado;
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

        public DataTable BuscarTipoChamado(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BuscarTipoChamado";//PROCEDURE DO BANCO SQL
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
        public void ExcluirTipoChamado(int _id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;//ESTRUTURA DE CONEXÃO;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExcluirTipoChamado";
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
        public TipoChamado AlterarTipoChamado(TipoChamado _tipoChamado)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarTipoChamado";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _tipoChamado.Id;
                cmd.Parameters.Add(pid);

                SqlParameter pdescricao = new SqlParameter("@Descricao", SqlDbType.VarChar);
                pdescricao.Value = _tipoChamado.Descricao;
                cmd.Parameters.Add(pdescricao);

                cn.Open();
                cmd.ExecuteNonQuery();
                return _tipoChamado;
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
