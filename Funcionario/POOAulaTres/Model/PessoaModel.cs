namespace POOAulaTres.Model
{
    public class PessoaModel
    {
        public string Nome{get;set;}
        public int Idade{get;set;}

        public void Comer()
        {
            System.Console.WriteLine("Bora comer");
        }
        public void Andar()
        {
            System.Console.WriteLine("Bora Andar");
        }
        public void Dormir()
        {
          System.Console.WriteLine("Bora Dormir");
        }
    }
}