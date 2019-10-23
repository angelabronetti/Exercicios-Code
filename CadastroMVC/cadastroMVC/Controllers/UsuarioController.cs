using System;
using cadastroMVC.Model;
using System.Collections.Generic;


namespace cadastroMVC.Controllers
{
    public class UsuarioController
    {       
        List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();


        public void CadastroUsuario(){

            Console.WriteLine("Informe o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o seu E-mail");
            string email = Console.ReadLine();

            Console.WriteLine("Informe sua Senha");
            string senha = Console.ReadLine();

            UsuarioModel usuario = new UsuarioModel();

            usuario.Id = listaDeUsuarios.Count + 1;
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.DataCriacao = DateTime.Now;

            listaDeUsuarios.Add(usuario);
        }//Fim cadastroUsuario
            public void ListarUsuarios(){
                foreach (var item in listaDeUsuarios)
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine($"Usuário: {item.Nome}");
                    Console.WriteLine($"Id: {item.Id}");
                    Console.WriteLine($"E-mail: {item.Email}");
                    Console.WriteLine($"Data do Cadastro: {item.DataCriacao}");
                    Console.WriteLine("------------------");

                }
            }

            public bool Logar(){
                Console.WriteLine("Insira o E-mail");
                string email = Console.ReadLine();

                Console.WriteLine("Insira sua Senha");
                string senha = Console.ReadLine();

                foreach (var item in listaDeUsuarios)
                {
                    if(item.Email == email && item.Senha == senha){
                        return true;
                    }//fim do if
                }//fim foreach
                return false;
            }//fim logar

    }
}

