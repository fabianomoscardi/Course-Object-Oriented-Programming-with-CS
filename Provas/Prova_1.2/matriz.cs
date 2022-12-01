using System;
using System.Collections.Generic;

class Matriz
{
  int[,] matriz = new int[4, 4];
  Random random = new Random();
  List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

  public void gerarvalores()
  {
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
      for (int j = 0; j < matriz.GetLength(1); j++)
      {
        this.matriz[i, j] = random.Next(1, 100);
      }
    }
  }

  public void print()
  {
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
      for (int j = 0; j < matriz.GetLength(1); j++)
      {
        Console.Write(matriz[i, j] + " ");
      }
      Console.WriteLine("");
    }
  }

  public int primeiraColuna(int x)
  {
    for (int i = 0; i < this.matriz.GetLongLength(0); i++)
      for (int j = 0; j < this.matriz.GetLongLength(1); j++)
      {
        if (matriz[i, j] == x)
        {
          return j;
        }
      }
    return -1;

  }

  public int primeiraLinha(int x)
  {
    for (int i = 0; i < this.matriz.GetLongLength(1); i++)
      for (int j = 0; j < this.matriz.GetLongLength(0); j++)
      {
        if (matriz[i, j] == x)
        {
          return i;
        }
      }
    return -1;

  }

  public int ultimaColuna(int x)
  {
    for (int i = Convert.ToInt32(this.matriz.GetLongLength(1)) - 1; i >= 0; i--)
      for (int j = Convert.ToInt32(this.matriz.GetLongLength(0)) - 1; j >= 0; j--)
      {
        if (matriz[i, j] == x)
        {
          return j;
        }
      }
    return -1;

  }

  public int ultimaLinha(int x)
  {

    for (int i = Convert.ToInt32(this.matriz.GetLongLength(0)) - 1; i >= 0; i--)
    {
      for (int j = Convert.ToInt32(this.matriz.GetLongLength(1)) - 1; j >= 0; j--)
      {
        if (matriz[i, j] == x)
        {
          return i;
        }
      }

    }
    return -1;
  }

    public string[] todasPosicoes(int x)
  {
    string[] ocorrencias = new string[numeroOcorrencias(x)];
    int index = 0;
      for (int i = 0; i < this.matriz.GetLongLength(1); i++)
      for (int j = 0; j < this.matriz.GetLongLength(0); j++)
      {
        if (matriz[i, j] == x)
        {
          ocorrencias[index] = i + "º linha, " + j + "º coluna";
        }
      }
    return ocorrencias;

  }

  
    public int numeroOcorrencias(int x)
  {
    int cont = 0;
    for (int i = 0; i < this.matriz.GetLongLength(1); i++)
      for (int j = 0; j < this.matriz.GetLongLength(0); j++)
      {
        if (matriz[i, j] == x)
        {
          cont++;
        }
      }
    return cont;

  }
}












/* print matrix
for (int i = 0; i<matriz.GetLength(0); i++)
{
  for (int j = 0; j<matriz.GetLength(1); j++)
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


}*/