using System;

namespace Atividade_04
{
  class Program
  {
    static void Main(string[] args)
    {
      vetor v = new vetor(20);
      v.imprimir_vetor();
      v.maior_menor();

    Console.WriteLine("Digite um número inteiro: ");
    int x = int.Parse(Console.ReadLine());
      v.primeira_ocorrencia(x);
      Console.Write("As ocorrências estão nas posições: ");
      v.todas_ocorrencias(x);
      Console.WriteLine("A quantidade de aparições são: " + v.quant_ocorrencias(x));










    }
  }
}


