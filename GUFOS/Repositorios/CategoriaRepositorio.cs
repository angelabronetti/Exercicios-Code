using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GUFOS.Interface;
using GUFOS.Models;
using Microsoft.EntityFrameworkCore;

namespace GUFOS.Repositorios
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        GufosContext context = new GufosContext();

        public async Task<Categoria> Delete(int id)
        {
           Categoria CategoriaRetornada = await context.Categoria.FindAsync(id);
           context.Categoria.Remove(CategoriaRetornada);
           await context.SaveChangesAsync();
           return CategoriaRetornada;
        }

        public async Task<List<Categoria>> Get()
        {
            return await context.Categoria.ToListAsync();
        }

        public async Task<Categoria> Get(int id)
        {
           return await context.Categoria.FindAsync(id);
        }

        public async Task<Categoria> Post(Categoria categoria)
        {
           await context.Categoria.AddAsync(categoria);
           await context.SaveChangesAsync();
           return categoria;
        }

        public async Task<Categoria> Put(int id, Categoria categoria)
        {
            Categoria categoriaRetornada = await context.Categoria.FindAsync(id);
            categoriaRetornada.Titulo = categoria.Titulo;
            await context.SaveChangesAsync();
            return categoriaRetornada;

        //   context.Entry(categoria).State = EntityState.Modified;
        //   await context.SaveChangesAsync();
        //   return categoria;
        }
    }
}


//Find - Procurar
// Context - Consulta
//SaveChanges - Salvar no Banco
//Task - Complemento do Async
//categoriaRetornada - é o que retorna após a consulta (nome da variável)