using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Projeto_c.Models
{
    public class Calculadora
    {
        public void Somar (int x, int y){
            Console.WriteLine($" o valor da operação é {x} + {y} = {x + y}"); 
        }
    
        public void Multiplicar (int x, int y){
            Console.WriteLine($" o valor da operação é {x} x {y} = {x * y}"); 
        }
    
        public void Subtracao (int x, int y){
            Console.WriteLine($" o valor da operação é {x} - {y} = {x - y}"); 
        }
    }
}