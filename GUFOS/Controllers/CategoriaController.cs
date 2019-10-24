using System.Collections.Generic;
using System.Threading.Tasks;
using GUFOS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GUFOS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CategoriaController : ControllerBase
    {
        GufosContext context = new GufosContext();

        [HttpGet]

        public async Task<ActionResult<List<Categoria>>> Get()
        {
            List<Categoria> listaDeCategoria = await context.Categoria.ToListAsync();

            if(listaDeCategoria == null)
            {
                return NotFound();
            }
            return listaDeCategoria;
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Categoria>> Get(int id)
        {
            Categoria categoriaRetornada = await context.Categoria.FindAsync(id);
            if (categoriaRetornada == null)
            {
                return NotFound();
            }
            return categoriaRetornada;
        }
        [HttpPost]

        public async Task<ActionResult<Categoria>> Post(Categoria categoria)
        {
            try //usado para tentar algo/retornar erros
            {
                await context.Categoria.AddAsync(categoria);
                await context.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return categoria;
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Categoria categoria)
        {
            Categoria categoriaRetornada = await context.Categoria.FindAsync(id);
            if (categoriaRetornada == null)
            {
                return NotFound();
            }
            categoriaRetornada.Titulo = categoria.Titulo;
            context.Categoria.Update(categoriaRetornada);
            await context.SaveChangesAsync();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Categoria>> Delete(int id)
        {
            Categoria categoriaRetornada = await context.Categoria.FindAsync(id);
            if (categoriaRetornada == null)
            {
                return NotFound();
            }
            context.Categoria.Remove(categoriaRetornada);
            await context.SaveChangesAsync();

            return categoriaRetornada;
        }
    }
}