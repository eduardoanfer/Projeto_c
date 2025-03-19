using System;

namespace Projeto_c.Pessoa // nome do projeto e pasta
{
    public class Pessoa
    {
        // Propriedades com get e set
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Método para apresentar o indivíduo
        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}
