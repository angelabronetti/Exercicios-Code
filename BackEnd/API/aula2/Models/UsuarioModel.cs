using System.ComponentModel.DataAnnotations;

namespace aula2.Context.Models
{
    public class UsuarioModel
    {
        [Key]
        public int Usuario_Id{get; set;}

        public string Usuario_Nome{get; set;}

        public string Usuario_Email{get; set;}

        public string Usuario_Senha{get; set;}
    }
}