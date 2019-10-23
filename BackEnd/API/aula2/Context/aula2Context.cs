using aula2.Context.Models;
using Microsoft.EntityFrameworkCore;

namespace aula2.Context
{
    public class aula2Context : DbContext
    {
        public aula2Context(){}

        // Configurando o acesso ao banco
        public aula2Context(DbContextOptions<aula2Context> options): base(options){

        }
        public virtual DbSet<UsuarioModel> tbl_usuario{get; set;} //Linha de código onde pega a tabela do Banco de Dados que eu vou utilizar
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; DataBase=aula_api; Integrated Security=true"); //Conexão com o Banco mostrando quando o local, Db e a integração serã realizadas
            }
        }
    }
}