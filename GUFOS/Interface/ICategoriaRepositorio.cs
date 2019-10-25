using System.Collections.Generic;
using System.Threading.Tasks;
using GUFOS.Models;

namespace GUFOS.Interface
{
    public interface ICategoriaRepositorio
    {
        //Definindo todos os métodos que irão ter no repositório
        Task<List<Categoria>> Get();

        Task<Categoria> Get(int id);

        Task<Categoria> Post(Categoria categoria);

        Task<Categoria> Put(int id, Categoria categoria);

        Task<Categoria> Delete(int id);
    }
}