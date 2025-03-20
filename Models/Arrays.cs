using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_c.Models
{
    public class Arrays
    {
        public void arryss (){
            int [] value01 = {1,2,3,4};
            Console.WriteLine($"o valor da variavel na posição 0 é {value01[0]}");
            for(int contador=0; contador < value01.Length; contador ++){
                Console.WriteLine($"Posição n*{contador} - {value01[contador]}");
            }
            // um for para percorrer a lista sem eu precisar colocar um contador. o signficado de foreach é para cada -> para cada valor percorrido em value01 eu mostro valor
            Console.WriteLine("Percorrendo o Array com foreach: ");
            int constadorforeach=0;
            foreach(int valor in value01){
                Console.WriteLine($"valor na posição {constadorforeach} é : {valor}");
                constadorforeach ++;
            }
            //aumentando a capacidade do meu array - no caso aqui eu dupliquei os espaços // ele copia e faz outro maior
            Array.Resize(ref value01 , value01.Length *2);
            // copiando um array 
            int [] Arraysos = new int[value01.Length * 2 ]; 
            Array.Copy(value01,Arraysos, value01.Length );
        }


        public void Listonas (int posicao){
            List<string> funcionarios = new List<string>();
            funcionarios.Add("Eduardo"); 
            funcionarios.Add("Carlos"); 
            funcionarios.Add("Fernando"); 
            Console.WriteLine($"O funcionario com ID selecionado é {funcionarios[posicao]}"); 

        }
    }




}