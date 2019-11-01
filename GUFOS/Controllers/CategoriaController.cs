using System.Collections.Generic;
using System.Threading.Tasks;
using GUFOS.Models;
using GUFOS.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GUFOS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CategoriaController : ControllerBase
    {
        
        CategoriaRepositorio repositorio = new CategoriaRepositorio();

        [HttpGet]


        public async Task<ActionResult<List<Categoria>>> Get()
        {
           try{
               return await repositorio.Get();
           }catch(System.Exception){
               throw;
           }
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Categoria>> Get(int id)
        {
            Categoria categoriaRetornada = await repositorio.Get(id); //Manda buscar a informação no BD (repositório) e após a resposta eu faço a verificação
            if (categoriaRetornada == null)
            {
                return NotFound();
            }
            return categoriaRetornada; // Retorno da variável com a resposta do repositório
        }
        [HttpPost]

        public async Task<ActionResult<Categoria>> Post(Categoria categoria)
        {
            try{
               return await repositorio.Post(categoria); //Manda cadastrar nformação no BD através do respositório
            }
            catch(System.Exception ex){ // E se houver erro ele mostra qual foi
               return BadRequest(new{mensagem = "Erro" + ex.Message});//BadRequest Mostra o erro, Mensagem (var) mostra qual foi recebendo o erro da exceção
           }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Categoria>> Put(int id, Categoria categoria)//Definir sempre o tipo de retorno <categoria>
        {
            Categoria categoriaRetornada = await repositorio.Get(id); //buscando informação no banco
            if (categoriaRetornada == null)//verificando se é nulo
            {
                return NotFound("Categoria não encontrada");//mensagem de erro
            }
           try{
               return await repositorio.Put(id, categoria);// após a espera do retorno trás a informação de categoria (altera)
           }
           catch(System.Exception ex)//cria uma exceção
           {
                return BadRequest(new{mensagem = "Erro" + ex.Message});//caso haja erro informa-o
           }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Categoria>> Delete(int id)
        {
            Categoria categoriaRetornada = await repositorio.Get(id);//buscando informação no banco
            if (categoriaRetornada == null)//verificando se é nulo
            {
                return NotFound("Categoria não encontrada");//mensagem de erro
            }
            try{
                return await repositorio.Delete(id);// se não tiver erro ele apaga a informação no BD (repositório) por Id ---> Nos parenteses é necessário chamar exatamente o que está chamando o início da função
            }
            catch(System.Exception ex)//cria uma exceção
            {
                return BadRequest(new{mensagem = "Erro" + ex.Message});//caso haja erro informa-o
            }
            

          
        }
    }
}