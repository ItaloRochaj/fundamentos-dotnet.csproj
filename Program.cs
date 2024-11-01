using System;
using System.Collections.Generic;
using System.Linq;
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

int soma = 0 , numero = 0;


do //  executa independente da condicao

{   
    Console.WriteLine("Digite seu numero");
    numero = Convert.ToInt32(Console.ReadLine()); // apenas retorna stgring, tem que usar o Convert.ToInt32.
        soma += numero;

}while(numero != 0); // verifica em primeiro lugar a condicao se verdadeira, != significa diferente.

Console.WriteLine($"Total da soma dos numeros digitados {soma}");
