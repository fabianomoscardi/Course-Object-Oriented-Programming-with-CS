using System;
using System.Collections.Generic;

namespace Atividade_06
{
  class Program
  {
    static void Main(string[] args)
    {

      int[,] matriz = new int[4, 4];
      Random random = new Random();
      List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

      for (int i = 0; i < matriz.GetLength(0); i++)
      {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
          int randomNumberIndex = random.Next(0, numbers.Count);
          int randomNumber = numbers[randomNumberIndex];
          numbers.RemoveAt(randomNumberIndex);
          matriz[i, j] = randomNumber;
        }
      }

      // print matrix
      for (int i = 0; i < matriz.GetLength(0); i++)
      {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
          Console.Write(matriz[i, j] + "\t");
        }
        Console.WriteLine();
      }

      int soma = 0;


      int maior = 0;
      for (int l = 0; l < matriz.GetLength(0); l++)
      {
        for (int c = 0; c < matriz.GetLength(1); c++)
        {
          if (maior < matriz[l, c]) maior = matriz[l, c];
        }
      }
      Console.WriteLine("O maior elemento da matriz é " + maior);

      int menor = 0;
      for (int l = 0; l < matriz.GetLength(0); l++)
      {
        for (int c = 0; c < matriz.GetLength(1); c++)
        {
          if (menor > matriz[l, c]) menor = matriz[l, c];
        }
      }
      Console.WriteLine("O menor elemento da matriz é " + menor);

      int lin, col;
      soma = 0;
      for (lin = 0; lin < 4; lin++)
      {
        soma = soma + matriz[lin, lin];
      }
      Console.WriteLine("Soma da diagonal principal = " + soma);


      soma = 0;
      for (col = 0; col < 4; col++)
      {
        soma = soma + matriz[2, col];
      }
      Console.WriteLine("Soma dos elementos da 2 linha = " + soma);

      soma = 0;
      for (lin = 0; lin < 4; lin++)
      {
        soma = soma + matriz[lin, 3];
      }
      Console.WriteLine("Soma dos elementos da 3 coluna = " + soma);




    }
  }
}
