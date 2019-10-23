using System;

namespace Vingadores.Model
{
    public class BaseModel
    {
        //Atributos 
        public int Vida { get; set; }
        public string Cor { get; set; }

        public string Equipe { get; set; }


        public void MostarInformacoes() // comportamento - método 
        {
            Console.WriteLine($@"
            Sua vida é: {Vida}
            Sua cor é: {Cor}
            Sua Equipe é: {Equipe}");
        }
    }
}