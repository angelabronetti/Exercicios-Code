using System;
using System.Collections.Generic;
using Exercicio.Model;

namespace Exercicio.Controller
{
    public class ExercicioController
    {
        List<ExercicioModel> listaDeProdutos = new List<ExercicioModel>();
        public object exercicio;

        public void CadastroProdutos(){

            Console.WriteLine("Digite o Nome do Produto");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a Categoria do Produto");
            string categoria = Console.ReadLine();

            Console.WriteLine("Quantidade de itens no Estoque?");
            int estoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o preço deste produto?");
            double preco = double.Parse(Console.ReadLine());

            ExercicioModel exercicio = new ExercicioModel();

            exercicio.Id = listaDeProdutos.Count + 1;
            exercicio.Nome = nome;
            exercicio.Categoria = categoria;
            exercicio.DataCadastro = DateTime.Now;
            exercicio.Estoque = estoque;
            exercicio.Preco = preco;

            listaDeProdutos.Add(exercicio);
        }//Fim do cadastro de produtos

        public void ListarProduto(){
            foreach (var item in listaDeProdutos)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"Produto: {item.Nome}");
                Console.WriteLine($"Id: {item.Id}");
                Console.WriteLine($"Categoria: {item.Categoria}");
                Console.WriteLine($"Estoque: {item.Estoque}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
                Console.WriteLine("------------------");
            }
        }

        public void CalcularProduto(){
            double qtd = 0;
            foreach (var item in listaDeProdutos)
            {
              qtd = (item.Preco * item.Estoque) + qtd ;
              Console.WriteLine($"A soma total de valor em estoque é: {qtd}" );
            }
        }
        

    }
}