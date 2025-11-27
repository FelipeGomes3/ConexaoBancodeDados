
using ConexaoBanco.Models;

namespace ConexaoBanco.Interfaces
{
    internal interface IPlano:IDao<Plano>
    {
        //void Create(Plano plano);
        //void Update (Plano plano);
        //void Delete (int  id_plano);
        //List<Plano> GetAll ();

        Plano GetId(int id);
    }
}
