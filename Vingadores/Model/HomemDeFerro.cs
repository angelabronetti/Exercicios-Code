using System;

namespace Vingadores.Model
{
    public class HomemDeFerro : BaseModel
    {


        public string Armadura{get; set;}

        public void Voe(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Homem de Ferro Voou");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Atire(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Homem de Ferro Atira");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Armacao(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Homem de Ferro vestiu sua Armadura");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
