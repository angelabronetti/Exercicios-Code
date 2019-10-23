using System;

namespace Exercicio.Model
{
    public class ExercicioModel : BaseModel 
    {
        public int Id {get; set;}
        public string Nome {get; set;}

        public string Categoria {get; set;}
    }
}