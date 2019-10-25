using System.Collections.Generic;
using System.Threading.Tasks;
using GUFOS.Models;

namespace GUFOS.Interface
{

        public interface IEventoRepositorio
    {
        //Definindo todos os métodos que irão ter no repositório
        Task<List<Evento>> Get();

        Task<Evento> Get(int id);

        Task<Evento> Post(Evento evento);

        Task<Evento> Put(Evento evento);

        Task<Evento> Delete(int id);
    }
}
    