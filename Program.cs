using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using fundamentos_dotnet.Models;

//Calculadora calc = new Calculadora();
//calc.Somar(10, 30);
//calc.Subtrair(10, 50);
//calc.Multiplicar(15, 45);
//calc.Dividir(2, 2);
//calc.RaizQuadrada(9);

//calc.Potencia(3, 3);
//calc.Seno(30);
//calc.Coseno(30);
//calc.Tangente(30);


//int numero = 5;
//int contador = 0;

//while (contador <= 10)
//{
    //Console.WriteLine($"{contador + 1}° Execucao: {numero} x {contador} = {numero * contador}");
    //contador++;
//}


//Do While abaixo:

//int soma = 0 , numero = 0;


//do //  executa independente da condicao

//{   
   // Console.WriteLine("Digite seu numero");
   // numero = Convert.ToInt32(Console.ReadLine()); // apenas retorna stgring, tem que usar o Convert.ToInt32.
     //   soma += numero;

//}while(numero != 0); // verifica em primeiro lugar a condicao se verdadeira, != significa diferente.

//Console.WriteLine($"Total da soma dos numeros digitados {soma}");



string opcao;
bool exibirMenu = true;

while (exibirMenu)

{   
    Console.WriteLine("Digite a sua opcao");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {   
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Buscar cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("O programa foi encerrado");
            exibirMenu = false;
            //Environment = (0);
            break;
        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }
}
