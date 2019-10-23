using System.Collections.Generic;
using System.Linq;
using aula2.Context;
using aula2.Context.Models;
using Microsoft.AspNetCore.Mvc;

namespace aula2.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    [Produces("application/json")]

    public class UsuarioController : ControllerBase
    {
        aula2Context context = new aula2Context();
        
        [HttpGet]

        public IActionResult Listar()
        {
            List<UsuarioModel> ListaUsuarios = context.tbl_usuario.ToList();

            return Ok(ListaUsuarios);
        }

        [HttpPost]

        public IActionResult Cadastrar(UsuarioModel usuario)
        {
            context.tbl_usuario.Add(usuario);
            context.SaveChanges();
            return Ok();
        }

        [HttpGet("{Id}")]

        public IActionResult BuscarPorId(int Id)
        {
            UsuarioModel usuarioRetornado = context.tbl_usuario.FirstOrDefault(x => x.Usuario_Id == Id);

            return Ok(usuarioRetornado);
        }
    }


}
