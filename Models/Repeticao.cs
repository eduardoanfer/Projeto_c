using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Projeto_c.Models
{
    public class Repeticao
    {
        public void repetir( double y){
            for(int contador=0 ; contador <= y; contador++){
                Console.WriteLine($"{contador} x {y} = {y*contador}");
            }
        }
        
        public void repetindo01(double y, double contador=1){
            while(y >= contador){
                Console.WriteLine($"{contador} x {y} = {y*contador}");
                contador++; 
                if (contador==6){ 
                    break;
                }//idependente da condicao vai sair do codigo
            }
        }
        public void repetindo02(int soma=0, int numero =0){
          do
          {
            // aqui coloco o bloco a ser executado
            Console.WriteLine("Digite um Número (0 para parar)"); 
            numero= Convert.ToInt32(Console.ReadLine());
            soma+=numero; 
          }while(numero != 0); // minha condicao, ou seja enquanto esse numero for diferente de zero continuará executando 
          Console.WriteLine($"o valor da soma é igual a {soma}");
        }

    }

    
}

