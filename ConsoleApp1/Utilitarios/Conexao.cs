
using MySql.Data.MySqlClient;

namespace ConexaoBanco.Utilitarios
{
    internal class Conexao
    {
        // Define na compilção e não muda mais
        private const string striconexao =
            "server=localhost;port=3360;uid=root;pwd=root;database=FitnessTraining";

        public static MySqlConnection Conectar()
        { 
            MySqlConnection conectar = new MySqlConnection(striconexao);
            try
            {
                conectar.Open();
                return conectar;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
