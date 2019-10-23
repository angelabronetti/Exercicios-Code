using System;

namespace Funcionario.Model
{
    public class FuncionarioModel : PessoaModel // Gera a herança de outra classe 
    {
        public string Cargo {get; set;}

        public void Cadastrar()
        {
            System.Console.WriteLine("Agora vamos trabalhar!");

            Console.WriteLine("Digite o Nome do funcionário");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite a Idade do funcionário");
            Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o cargo do funcionário");
            Cargo = Console.ReadLine();
        }
    }
}