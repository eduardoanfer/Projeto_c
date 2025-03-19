namespace Projeto_c.PessoaCopia  // nome do projeto e pasta
{
    public class Pessoa
    {
        // propriedades com get e set
        public string Nome { get; set; }  
        public int Idade { get; set; } 

        // método para apresentar o indivíduo
        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}
