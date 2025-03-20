 using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Projeto_c.Models;
using Projeto_c.Pessoa; 
 Arrays arro= new Arrays();
// using Projeto_c.Models; 
// Calculadora calc = new Calculadora(); 
// Repeticao rep = new Repeticao();

// calc.Somar(2,3); 
// calc.Multiplicar(2,4);
// calc.Subtracao(4,2);
// calc.potencia(3,3);
// calc.seno(60);
// calc.coseno(60);
// calc.tangente(60);
// calc.raiz(25);
// //rep.repetir(10);
// rep.repetindo01(10);
// rep.repetindo02();

string opcao; 
bool ExibirMenu= true; 
while(ExibirMenu){
    
    Console.WriteLine("Digite sua opção:    ");
    Console.WriteLine("1- cadastrar cliente");
    Console.WriteLine("2- buscar cliente");
    Console.WriteLine("3- Apagar Cliente");
    Console.WriteLine("4- Encerrar");
    
    opcao = Console.ReadLine(); 
    switch(opcao)
    {
       case "1": 
       Console.WriteLine("O cliente foi Cadastrado"); 
       break;
       case "2": 
       Console.WriteLine("Buscando Cliente....");
       arro.Listonas(2);
       break;
       case "3": 
       //Console.WriteLine("Apagando Cliente....");
        arro.arryss();
        break;
       case "4": 
       Console.WriteLine("Encerrando o Acesso....");
       //Environment.Exit(0);//encerra o programa
       ExibirMenu=false;
       break;
        


       default:
       Console.WriteLine("opcao invalida");
       break;
    }


}






















// // double a = 4 / ( 2 + 2); 
// // Console.WriteLine(a);
// int quantidadeEmEstoque = 10; 
// int quantidadeDeCompra=0;
// //int excedente= quantidadeDeCompra-quantidadeEmEstoque;
// bool compara =  quantidadeDeCompra>=0 &&  quantidadeDeCompra >= quantidadeEmEstoque ; // minha condicao
// if (quantidadeDeCompra == 0){
//     Console.WriteLine($"Não é possível fazer a venda pois a quantidade de compra não está atingindo o minimo de 1 unidade de itens");
// } else if (compara){
//     Console.WriteLine("Compra efetuada com Sucesso");
// }else{
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
// }

// Console.WriteLine("Digite uma letra:    "); 
// string letra = Console.ReadLine(); // fazendo a leitura dos dados informados 
// // switch e o parametro que irei utilizar 
// switch(letra)
// {
//     case "a" :
//     case "e" :
//     case "i" :
//     case "o" :
//     case "u" :
//         Console.WriteLine("É uma vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }

// Console.WriteLine("Informe A sua idade:     "); 
// int idade = Console.Read(); 
// Console.WriteLine("se for menor de idade tem autorizacao 1-sim 2- não :     "); 
// int autorizacao = Console.Read(); 
// bool liberacao = idade >= 18 || autorizacao == 1; 

// if (liberacao){
//     Console.WriteLine($"Entrada Liberada, pois Têm mais que 18 ou autozicao do responsável"); 
// }else{
//     Console.WriteLine("Você não foi liberado por não ter idade e nem autorizacao"); 
// }
// int idade =10; 
// bool tempo= true;
// bool caso01 =  idade >= 18 && tempo == true; 
// if (!caso01){
//     Console.WriteLine("Você está autorizado"); 
// }else{ 
//     Console.WriteLine("O caso nao permite");
// }

// bool choveu = false;
// bool estaTarde = false; 

// if ( !choveu && !estaTarde){
//     Console.WriteLine("Vou pedalar"); 
// }
// else{
//     Console.WriteLine("Vou pedalar um outro dia"); 
// }

