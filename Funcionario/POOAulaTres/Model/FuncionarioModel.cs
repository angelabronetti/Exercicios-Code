using System;
using System.Collections.Generic;

namespace POOAulaTres.Model
{
    public class FuncionarioModel : PessoaModel
    {
        public string Cargo{get;set;}

        // public List<FuncionarioModel> listaDeFuncionario = new List<FuncionarioModel>();

        public void Trabalhar()
        {
            System.Console.WriteLine("Agora vamos Trabalhar!");
        }
        public  FuncionarioModel CadastrarFuncionario()
        {
                    FuncionarioModel funcionario = new FuncionarioModel();
                    
                    Console.WriteLine("Digite o nome do funcionário");
                    Nome = Console.ReadLine();

                    Console.WriteLine("Digite a Idade do funcionário");
                    Idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o Cargo do Funcionario");
                    Cargo = Console.ReadLine();

                    return funcionario;
        }

    }
}