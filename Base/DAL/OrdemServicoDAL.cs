using Model;
using System;
using System.Data;
using System.Data.SqlClient;
// ALT + ENTER + ENTER = RETIRA AS BIBLIOTECAS DESNECESSARIAS
namespace DAL
{
    public class OrdemServicoDAL
    {
        public OrdemServico AbrirOS(OrdemServico _ordemServico)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;//ESTRUTURA DE CONEXÃO
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AbrirOrdemServico";

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _ordemServico.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Protocolo", SqlDbType.VarChar)
                {
                    Value = _ordemServico.Protocolo
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Cliente", SqlDbType.Int)
                {
                    Value = _ordemServico.Id_Cliente
                });

                cmd.Parameters.Add(new SqlParameter("@TipoChamado", SqlDbType.VarChar)
                {
                    Value = _ordemServico.TipoChamado
                });

                cmd.Parameters.Add(new SqlParameter("@Descricao", SqlDbType.VarChar)
                {
                    Value = _ordemServico.Descricao
                });

                if (_ordemServico.DataAbertura.ToString().Trim().Length > 6)
                    cmd.Parameters.Add(new SqlParameter("@DataAbertura", SqlDbType.DateTime)
                    {
                        Value = _ordemServico.DataAbertura
                    });

                if (_ordemServico.DataPrazo.ToString().Trim().Length > 6)
                {
                    cmd.Parameters.Add(new SqlParameter("@DataPrazo", SqlDbType.DateTime)
                    {
                        Value = _ordemServico.DataPrazo
                    });
                }

                cmd.Parameters.Add(new SqlParameter("@TecnicoResponsavel", SqlDbType.VarChar)
                {
                    Value = _ordemServico.TecnicoResponsavel
                });

                cmd.Parameters.Add(new SqlParameter("@Atendente", SqlDbType.VarChar)
                {
                    Value = _ordemServico.Atendente
                });

                cmd.Parameters.Add(new SqlParameter("@EstatusOS", SqlDbType.VarChar)
                {
                    Value = _ordemServico.EstatusOS
                });

                cmd.Parameters.Add(new SqlParameter("@LigarAntes", SqlDbType.VarChar)
                {
                    Value = _ordemServico.LigarAntes
                });

                cn.Open();
                _ordemServico.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _ordemServico;
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

        public DataTable BuscarOrdemServico(string _filtro)
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
                da.SelectCommand.CommandText = "SP_BuscarOrdemServico";//PROCEDURE DO BANCO SQL
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

        public OrdemServico AlterarOrdemServico(OrdemServico _ordemServico)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarOrdemServico";

                SqlParameter protocolo = new SqlParameter("@Protocolo", SqlDbType.VarChar);
                protocolo.Value = _ordemServico.Protocolo;
                cmd.Parameters.Add(protocolo);

                cn.Open();
                cmd.ExecuteNonQuery();
                return _ordemServico;
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
