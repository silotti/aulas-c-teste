using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            //solicita ao user os valores
            Console.WriteLine("digite sua idade e press enter");
            int idade = int.Parse(Console.ReadLine());

            //mostra o ano de nascimento
            int ano = 2017 - idade;
            Console.WriteLine("Voce nasceu em:"+ ano);

            // condicao
            if (ano > 2000)
            {
                Console.WriteLine("Voce é muito jovem");
            } else if (ano <= 2000 )
            {
                Console.WriteLine("Voce não é mais jovem");
            }

            Console.ReadKey();
        }




            /*

        {
            //float valorFloat = 1.1f;
            //double valorDouble = 1.1;
            //decimal valorDecimal = 1.1m;
           // int x = 100;

            float valor = 1.0f + (10100000000 + -10100000000);
            Console.WriteLine(valor);
            float valor2 = (1.0f + 10100000000) + -10100000000;
            Console.WriteLine(valor2);
            Console.ReadKey();

        }
   
        */



            /*
            while (x-->0)
            {
                Console.WriteLine("Valor Float");
                Console.WriteLine(valorFloat *= 2);
                // (valorFloat *= 2) => valorFloat = valorFloat * 2
                Console.WriteLine("Valor Double");
                Console.WriteLine(valorDouble * 2);
                Console.WriteLine("Valor Decimal");
                Console.WriteLine(valorDecimal * 2);

            }
                Console.ReadKey();
        }
        */

            /*    
        {
            int x = 10;
            //int a = 5;
            //int b = 2;
            Console.WriteLine("Valor de x:" + x);
            Console.WriteLine("Valor de x:" + x++);
            Console.WriteLine("Valor de x:" + ++x);

            // Imprime Hello World na Tela
            Console.WriteLine("Hello World!");

            //solicita ao user os valores
            Console.WriteLine("digite o valor 1 e pressione enter");
            String stringlida = Console.ReadLine();
            int valor1 = int.Parse(stringlida);

            Console.WriteLine("digite o valor 2 e pressione enter");
            String stringlida2 = Console.ReadLine();
            int valor2 = int.Parse(stringlida2);

            // Imprime a função
            Console.WriteLine("o valor da soma é:"+somar(valor1,valor2));
            
            //Fazer o console não fechar e esperar
            //o usuario pressionar uma tecla
            Console.ReadKey();
        }
        static int somar(int a, int b)
        {
            // retorna o valor de soma entre dois numeros
            return a + b;
        }
        */

  }
}
