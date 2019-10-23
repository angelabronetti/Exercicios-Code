namespace Funcionario.Model
{
    public class PessoaModel
    {
        public string Nome {get; set;}

        public int Idade {get; set;}
        public void Comer(){
            System.Console.WriteLine("Bora Comer!");
        }
        public void Andar(){
            System.Console.WriteLine("Bora Andar!");
        }
        public void Trabalhar(){
            System.Console.WriteLine("Bora Trabalhar!");
        }
        public void Dormir(){
            System.Console.WriteLine("Bora Dormir!");
        }

    }
}