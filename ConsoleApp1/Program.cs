using ConexaoBanco.Dao;
using ConexaoBanco.Models;
using ConexaoBanco.Utilitarios;


//Funcionario f = new Funcionario();

//f.Nome = "Felipe Gomes";
//f.Email = "Deletar2";
//f.DataNasc = new DateOnly(1998, 01, 16);
//f.DataAdmissao = new DateOnly(2025, 11, 11);
//f.Telefone = "69 99300 5832";

//FuncionarioDAO fdao = new FuncionarioDAO();
//fdao.Insert(f);


//Funcionario f = new Funcionario();
//f.Id_funcionario = 10;
//f.Nome = "Felipe Gomes";
//f.Email = "Deletar2";
//f.DataNasc = new DateOnly(1998, 01, 16);
//f.DataAdmissao = new DateOnly(2025, 11, 11);
//f.Telefone = "69 99300 5832";

//FuncionarioDAO fdao = new FuncionarioDAO();
//fdao.Update(f);


//fdao.Delete(10);

//FuncionarioDAO fdao = new FuncionarioDAO();
//List<Funcionario> lista = fdao.GetAll();

//foreach (Funcionario f in lista)
//{ 
//    Console.WriteLine(f.Nome);
//}
//FuncionarioDAO fdao = new FuncionarioDAO();
//fdao.Insert(f);

PlanoDAO pDao = new PlanoDAO();
Plano p = new Plano();
//p.Id_plano = 7;
//p.Descricao = "Plano Cooperativa";
//p.ValorSugerido = 85;
//p.Atv = true;
//pDao.Create(p);

////PlanoDAO pDao = new PlanoDAO();
////Plano p = new Plano();
//p.Id_plano = 6;
//p.Descricao = "Plano Funcionário";
//p.ValorSugerido = 45;
//p.Atv = true;
//pDao.Update(p);



pDao.Delete(7);
pDao.Delete(8);
pDao.Delete(9);