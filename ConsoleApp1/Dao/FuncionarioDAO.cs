using ConexaoBanco.Interfaces;
using ConexaoBanco.Models;
using ConexaoBanco.Utilitarios;
using MySql.Data.MySqlClient;
namespace ConexaoBanco.Dao
{
    internal class FuncionarioDAO : IDao <Funcionario>
    {

        public void Create(Funcionario funcionario)
        {
            try
            {
                string sql = @"INSERT INTO funcionario (Nome, Telefone, dataNasc, DataAdmissao, Email)
                                VALUES (@Nome, @Telefone, @dataNasc, @DataAdmissao, @Email)";
                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
                    cmd.Parameters.Add("@dataNasc", MySqlDbType.Date).Value = funcionario.DataNasc.ToDateTime(TimeOnly.MinValue);
                    cmd.Parameters.Add("@DataAdmissao", MySqlDbType.Date).Value = funcionario.DataAdmissao.ToDateTime(TimeOnly.MinValue);
                    cmd.Parameters.AddWithValue("@Email", funcionario.Email);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Update(Funcionario funcionario)
        {
            try
            {
                string sql = @"UPDATE funcionario SET Nome = @Nome, Telefone = @Telefone, dataNasc = @dataNasc, DataAdmissao = @DataAdmissao, 
                                    Email = @Email WHERE id_funcionario = @id_funcionario;";
                             ;
                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
                    cmd.Parameters.Add("@dataNasc", MySqlDbType.Date).Value = funcionario.DataNasc.ToDateTime(TimeOnly.MinValue);
                    cmd.Parameters.Add("@DataAdmissao", MySqlDbType.Date).Value = funcionario.DataAdmissao.ToDateTime(TimeOnly.MinValue);
                    cmd.Parameters.AddWithValue("@Email", funcionario.Email);
                    cmd.Parameters.AddWithValue("@id_funcionario", funcionario.Id_funcionario);
                    var linhas = cmd.ExecuteNonQuery();

                    if (linhas == 0)
                        throw new Exception("Nenhum registro foi atualizado (verifique o id_funcionário).");

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void Delete(int id_funcionario)
        { 
            try
            {
                string sql = "DELETE FROM funcionario WHERE id_funcionario = @id_funcionario";
                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                   
                    cmd.Parameters.AddWithValue("@id_funcionario", id_funcionario);
                    var linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas == 0)
                        throw new Exception("Nenhum registro foi encontrado com esse ID.");

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Funcionario> GetAll()
        { 
            List<Funcionario> listadeFuncionarios = new List<Funcionario>();
            try
            {
                var sql = "SELECT * FROM funcionario ORDER BY nome";
                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Funcionario f = new Funcionario();
                        f.Id_funcionario = dr.GetInt32("id_funcionario");
                        f.Nome = dr.GetString("nome");
                        f.Email = dr.GetString("email");
                        f.Telefone = dr.GetString("telefone");
                        f.DataNasc = DateOnly.FromDateTime(dr.GetDateTime("dataNasc"));
                        f.DataAdmissao = DateOnly.FromDateTime(dr.GetDateTime("dataAdmissao"));
                        listadeFuncionarios.Add(f);

                    }
                }
                return listadeFuncionarios;
            }
            catch (Exception ex) 
            {
                throw new Exception (ex.Message);   
            }
        
        }
    }
}
