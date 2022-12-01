using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProdutorXConsumidor
{
    class Program
    {
        static char[] vet = new char[10];
        static void Main(string[] args)
        {
            Thread thdPrint = new Thread(print);
            Thread thdProd = new Thread(produtor);
            Thread thdCons = new Thread(consumidor);
            thdPrint.Start();
            thdCons.Start();
            thdProd.Start();
        }

        static void consumidor() {
            while (true) {                
                for (int index = 0; index < vet.Length; index++)  {
                    if (vet[index] != '\0') {
                        vet[index] = '\0';
                        Thread.Sleep(300);
                    }
                }
            }
        }
        static void produtor()  {
            while (true) {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Escape)
                {
                    
                }
                else {
                    addIntoVet(cki.KeyChar);
                }
                
            }            
        }

        static void addIntoVet(char x) {
            for (int index = 0; index < vet.Length; index++) {
                if (vet[index] == '\0') 
                {
                    vet[index] = x;
                    break;
                }            
                
            }
        }
        static void print() {
            while (true)
            {
                Console.WriteLine(" PRECIONE ESC PARA SAIR DO PROGRAMA ");
                Console.WriteLine(" -------------- Vetor -------------- ");
                for (int index = 0; index < vet.Length; index++)
                {
                    Console.Write(" [{0}]", vet[index]);
                }
                Console.WriteLine();
                Console.WriteLine(" -------------- Vetor -------------- ");
                Thread.Sleep(150);                
                Console.Clear();

            }
        }

    }
}