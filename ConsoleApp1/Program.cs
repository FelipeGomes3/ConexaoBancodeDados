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

FuncionarioDAO fdao = new FuncionarioDAO();
List<Funcionario> lista = fdao.List();

foreach (Funcionario f in lista)
{ 
    Console.WriteLine(f.Nome);
}