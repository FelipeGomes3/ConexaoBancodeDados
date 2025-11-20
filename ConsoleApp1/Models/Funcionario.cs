
namespace ConexaoBanco.Models
{
    internal class Funcionario
    {
        public int Id_funcionario { get; set; }
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public DateOnly DataNasc {  get; set; }

        public DateOnly DataAdmissao { get; set; }

        public string Email { get; set; }

    }
}
