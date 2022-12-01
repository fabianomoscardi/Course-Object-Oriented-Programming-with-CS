using System;
using System.Collections.Generic;

namespace Prova_1._2
{
  class Program
  {
    static void Main(string[] args)
    {
      Matriz matriz = new Matriz();
      matriz.gerarvalores();
      matriz.print();
      

      Console.Write("Digite um valor x: ");
      int x = int.Parse(Console.ReadLine());

      
      int primeiraColuna = matriz.primeiraColuna(x);
      Console.WriteLine("Primeira coluna da primeira ocorrência do elemento x na matriz: " + primeiraColuna);
      int primeiraLinha = matriz.primeiraLinha(x);
      Console.WriteLine("Primeria linha da primeira ocorrência do elemento x na matriz: " + primeiraLinha);
       int ultimaColuna = matriz.ultimaColuna(x);
      Console.WriteLine("Ultima coluna da primeira ocorrência do elemento x na matriz: " + ultimaColuna);
      int ultimaLinha = matriz.ultimaLinha(x);
      Console.WriteLine("Ultima linha da primeira ocorrência do elemento x na matriz: " + ultimaLinha);
       string[] todasPosicoes = matriz.todasPosicoes(x);
      for (int i = 0; i < todasPosicoes.Length; i++)
      {
        Console.WriteLine("Todas as posições, linha e coluna, de ocorrência do elemento x na matriz: " + todasPosicoes[i]);
      }
      
      int numeroOcorrencias = matriz.numeroOcorrencias(x);
      Console.WriteLine("Número de ocorrências de um elemento x na matriz:" + numeroOcorrencias);
      






    }
  }
}
