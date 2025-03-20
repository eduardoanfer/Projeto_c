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

        public void potencia(int x, int y){
            double resultado = Math.Pow(x,y); // resultado do tipo double // e operadores para calculo mais complexas tenho que usar a biblioteca Math. 
            Console.WriteLine($"O valor da operacao ficaria{x}^{y}:{resultado}");
 
        }
        public void seno(double angulo){
            double radiano = angulo * Math.PI /180; 
            angulo = Math.Sin(Math.Round(radiano,4)); 
            Console.WriteLine($"o valor do seno é {angulo}");

        }
        public void coseno(double angulo){
            double radiano = angulo * Math.PI /180; 
            angulo = Math.Cos(Math.Round(radiano,4)); 
            Console.WriteLine($"o valor do coseno é {angulo}");

        }
        public void tangente(double angulo){
            double radiano = angulo * Math.PI /180; 
            angulo = Math.Tan(Math.Round(radiano,4)); 
            Console.WriteLine($"o valor do coseno é {angulo}");

        }
        public void raiz(double x){
           double calculo= Math.Sqrt(x);
           Console.WriteLine($"O valor da raiz de {x} = {calculo} ");
         
        }
    }
}