using System;
using System.Collections.Generic;
using cadastroMVC.Controllers;
using cadastroMVC.Model;

namespace cadastroMVC
{
    class Program{
        private static bool usuarioRetornado;

        /// <sumary>
        /// Cadastro de usuário usando lista e csv
        /// E autenticação
        /// </sumary>
        static void Main(string[] args)
        {
            UsuarioController usuarioController = new UsuarioController();

            int opcao = 0;
            do{
                Console.WriteLine("1 - Cadastrar Usuários");
                Console.WriteLine("2 - Listar Usuários");
                Console.WriteLine("3 - Autenticação");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse (Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    //Cadastrar
                    usuarioController.CadastroUsuario();
                    break;
                    case 2:
                    //Listar
                    usuarioController.ListarUsuarios();
                    break;
                    case 3:
                    //Autenticação de E-mail e Senha
                    bool usuarioRetornado = usuarioController.Logar();
                    if(usuarioRetornado)// seo o usuarioRetornado for true 
                    {
                        Console.WriteLine("Bem Vindo a Área Administrativa");
                        Console.WriteLine("Aqui quem manda é nóis kakakaka");

                    }else{
                        Console.WriteLine("Usuário não localizado");
                    }
                    break;
                    case 0:
                    //Sair
                    Console.WriteLine("Tchau");
                    break;
                    default:
                    Console.WriteLine("Opção Inválida!");
                    break;
                }
            }while(opcao != 0);

            
        }
    
    }
}
