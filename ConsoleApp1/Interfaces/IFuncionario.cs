using ConexaoBanco.Models;

namespace ConexaoBanco.Interfaces
{
    internal interface IFuncionario
    {
        void Create(Funcionario funcionario);

        void Update(Funcionario funcionario);

        void Delete(int id_funcionario);

        List<Funcionario> GetAll();
    }
}
