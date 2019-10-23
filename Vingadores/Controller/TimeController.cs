using System;
using Vingadores.Model;

namespace Vingadores.Controller
{
    public class TimeController
    {

        public void MenuInicial(){
              int opcao = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Vamos jogar um jogo?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Escolha seu personagem:");

                Console.WriteLine("1 - Capitão América");
                Console.WriteLine("2 - Homem de Ferro");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                    EscolhaCapitaoAmerica();
                        
                        break;
                    case 2:
                    EscolhaHomemDeFerro();
                        break;
                    case 0:
                    Console.WriteLine("Tchau!");
                    break;
                    default:
                        // Console.WriteLine("Você saiu do jogo");
                    break;
                }
            } while (opcao != 0);
         
        }
        int jogo;
        public void EscolhaCapitaoAmerica()
        {              
            CapitaoAmerica capitao = new CapitaoAmerica();
         
            do{
            
            Console.WriteLine("1 - Lançar Escudo");
            Console.WriteLine("2 - Defender");
            Console.WriteLine("0 - Voltar");
            capitao.Vida = 2;
            jogo = int.Parse(Console.ReadLine());

            switch (jogo)
            {
                case 1:
                capitao.LancarEscudo();
                break;
                case 2:
                capitao.Defender();
                break;
                case 0:
                Console.WriteLine(".");
                break;
                default:
                Console.WriteLine("Opção Inválida!");
                break;
            }
        }while(capitao.Vida != 0);{
            Console.WriteLine("Game Over!");
        }
    }

    public void EscolhaHomemDeFerro(){
        HomemDeFerro ironMan = new HomemDeFerro();

            do{
            Console.WriteLine("1 - Voar");
            Console.WriteLine("2 - Atirar");
            Console.WriteLine("0 - Voltar");
            ironMan.Vida = 2;
            jogo = int.Parse(Console.ReadLine());

            switch (jogo)
            {
                case 1:
                ironMan.Voe();
                break;
                case 2:
                ironMan.Atire();
                break;
                case 0:
                Console.WriteLine(".");
                break;
                default:
                Console.WriteLine("Opção Inválida!");
                break;
            }
        }while(ironMan.Vida != 0);{
            Console.WriteLine("Game Over!");
        }
    }
}
}