using ConexaoBanco.Interfaces;
using ConexaoBanco.Models;
using ConexaoBanco.Utilitarios;
using MySql.Data.MySqlClient;
using System.Numerics;
namespace ConexaoBanco.Dao
{
    internal class PlanoDAO : IPlano

    {
        public void Create(Plano plano)
        {
            try
            {
                string sql = @"INSERT INTO plano (Descricao, ValorSugerido, Atv) 
                                VALUES (@Descricao, @ValorSugerido, @Atv)";
                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Descricao", plano.Descricao);
                    cmd.Parameters.AddWithValue("@ValorSugerido", plano.ValorSugerido);
                    cmd.Parameters.AddWithValue("@Atv", plano.Atv);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id_plano)
        {
            try
            {
                string sql = @"DELETE FROM plano WHERE id_plano = @id_plano";
                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id_plano", id_plano);
                    var linhaAfetada = cmd.ExecuteNonQuery();

                    if (linhaAfetada == 0)
                        throw new Exception("Nenhum registro foi encontrado com esse ID).");

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Plano> GetAll()
        {
            List<Plano> listadePlanos = new List<Plano>();
            try
            {
                var sql = "SELECT * FROM  plano ORDER BY nome";
                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    var dR = cmd.ExecuteReader();
                    while (dR.Read())
                    {
                        Plano p = new Plano();
                        p.Id_plano = dR.GetInt32("id_plano");
                        p.Descricao = dR.GetString("descricao");
                        p.ValorSugerido = dR.GetDecimal("ValorSugerido");
                        p.Atv = dR.GetBoolean("Atv");
                        listadePlanos.Add(p);
                    }
                }
                return listadePlanos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Plano GetId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Plano plano)
        {
            try
            {
                string sql = @"UPDATE plano SET Descricao = @Descricao, ValorSugerido = @ValorSugerido, Atv = @Atv
                                WHERE id_plano = @id_plano";
                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Descricao", plano.Descricao);
                    cmd.Parameters.AddWithValue("@ValorSugerido", plano.ValorSugerido);
                    cmd.Parameters.AddWithValue("@Atv", plano.Atv);
                    cmd.Parameters.AddWithValue("@id_plano", plano.Id_plano);
                    var linha = cmd.ExecuteNonQuery();

                    if (linha == 0)
                        throw new Exception("Nenhum registro foi atualizado (verifique o id_plano).");

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
    

