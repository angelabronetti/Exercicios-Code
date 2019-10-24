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
    public class EventoController : ControllerBase
    {
        GufosContext context = new GufosContext();

        // [Authorize]
        [HttpGet]

        public async Task<ActionResult<List<Evento>>> Get()
        {
            List<Evento> listaDeEvento = await context.Evento.Include(l => l.Localizacao).Include(c => c.Categoria).ToListAsync(); // expressão lambida/ usado para puxar tabelas para otras tabelas

            if(listaDeEvento == null)
            {
                return NotFound();
            }
            foreach (var item in listaDeEvento) //usado manualmente para solucionar o problema de repetição de eventos
            {
                item.Categoria.Evento = null;
                item.Localizacao.Evento = null;
            }
            return listaDeEvento;
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Evento>> Get(int id)
        {
            Evento eventoRetornado = await context.Evento.Include(l => l.Localizacao).Include(c => c.Categoria).FirstOrDefaultAsync(e => e.EventoId == id);// usar assim quando usar o de cima
            if (eventoRetornado == null)
            {
                return NotFound();
            }
            return eventoRetornado;
        }
        [HttpPost]

        public async Task<ActionResult<Evento>> Post(Evento evento)
        {
            try //usado para tentar algo/retornar erros
            {
                await context.Evento.AddAsync(evento);
                await context.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return evento;
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Evento>> Put(int id, Evento evento)
        {
            if (id != evento.EventoId)
            {
                return BadRequest();
            }
            context.Entry(evento).State = EntityState.Modified; //usaf esse/ pq não necessita chamar um por um para as modificações 

            try
            {
            await context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                var eventoValido = context.Evento.FindAsync(id);
                if (eventoValido == null)
                {
                   return NotFound(); 
                }else{
                    throw;
                }
            }

            return evento;
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Evento>> Delete(int id)
        {
            Evento eventoRetornado = await context.Evento.FindAsync(id);
            if (eventoRetornado == null)
            {
                return NotFound();
            }
            context.Evento.Remove(eventoRetornado);
            await context.SaveChangesAsync();

            return eventoRetornado;
        }
    }
}