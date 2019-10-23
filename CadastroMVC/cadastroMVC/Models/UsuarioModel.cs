using System;

namespace cadastroMVC.Model

{
    public class UsuarioModel : BaseModel
    {
        public string Email { get; set; }

        public string Senha { get; set; }

        public DateTime DataNascimento {get; set;}

    }
}