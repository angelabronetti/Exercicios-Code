using System;

namespace Vingadores.Model
{
    public class CapitaoAmerica : BaseModel
    
    {
        public object Escudo { get; private set; }
    

        int vida = 5;
        public void LancarEscudo(){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Capitão América lançou seu escudo");
            Console.ForegroundColor = ConsoleColor.White;
            if(Vida == 0){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Você Morreu!");
            Console.ForegroundColor = ConsoleColor.White;
            }

        }

        public void Defender(){
            Console.WriteLine("Capitao América se Defende");
        }
        
    }
}