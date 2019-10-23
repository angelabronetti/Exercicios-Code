using System.Collections.Generic;
using System.Linq;
using aula1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AULA1.Controllers
{
    [ApiController]
    [Route("v1/[controller]")] //Cria uma rota pra acessar os métodos desse controller
    [Produces("application/json")] //Define o tipo de dado que vai ser transmitido
    public class UsuarioController : ControllerBase
    {
        List<UsuarioModel>ListaDeUsuarios = new List<UsuarioModel>();//Cria uma Lista

        //acesso os metodos dessa classe 
          [HttpGet("listar")]
        public IActionResult Usuarios(){ // Retorna a ação de um método
            // Primeiro Usuário

            UsuarioModel usuario1 = new UsuarioModel();
            usuario1.usuarioId = 1;
            usuario1.usuarioNome = "Carlos Eduardo Tsukamoto";
            usuario1.usuarioEmail = "Tsukamoto@gmail.com";
            usuario1.usuarioSenha = "123456";

            // Segundo Usuário

            UsuarioModel usuario2 = new UsuarioModel();
            usuario2.usuarioId = 2;
            usuario2.usuarioNome = "Vivian";
            usuario2.usuarioEmail = "vivi@gmail.com";
            usuario2.usuarioSenha = "789012";

            //Adicionado a Lista
            ListaDeUsuarios.Add(usuario1);
            ListaDeUsuarios.Add(usuario2);
            return Ok(ListaDeUsuarios);
        }
        [HttpGet("listar/{id}")]
        public IActionResult BuscarPorId(int id)
        {
        Usuarios();
        return Ok(ListaDeUsuarios.FirstOrDefault(u => u.usuarioId == id)); //Dentro do usuário "u" vamos pegar o user "u".usuarioId e comparar com o Id digitado

        }

        public UsuarioModel busca(UsuarioModel usuario){
        
          return usuario;
        }

        [HttpPost("Cadastro")]

        public IActionResult Cadastrar (UsuarioModel usuario){
            Usuarios();
            ListaDeUsuarios.Add(usuario);
            return Ok(ListaDeUsuarios);
        }
    }
}