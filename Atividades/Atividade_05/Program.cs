using System;

namespace Atividade_05
{
  class Program
  {
    static void Main(string[] args)
    {
      empregados a = new empregados();
      empregados b = new empregados();
      empregados c = new empregados();
      empregados d = new empregados();
      empregados e = new empregados();
      empregados[] vetor = new empregados[5];

      vetor[0] = a;
      vetor[1] = b;
      vetor[2] = c;
      vetor[3] = d;
      vetor[4] = e;

      for (int i = 0; i < vetor.Length; i++)
      {
        Console.WriteLine("Digite o código do empregado " + i + ":");
        int codigo = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade horas trabalhadas pelo empregado: ");
        int horas_trabalhadas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o sálario semanal fixo do empregado: ");
        double salario_fixo = double.Parse(Console.ReadLine());
        vetor[i].setcodigo(codigo);
        vetor[i].setsalario_fixo(salario_fixo);
        vetor[i].sethoras_trabalhadas(horas_trabalhadas);
        vetor[i].setsalario_variavel(horas_trabalhadas);
        vetor[i].calcular_salario();
        vetor[i].imprimir_salario();
      }

      folha_pagamento(vetor);

    }


    public static void folha_pagamento(empregados[] vetor)
    {
      double somatorio = 0;
      Console.WriteLine("Folha de pagamento da empresa:");
      for (int i = 0; i < vetor.Length; i++)
      {
        vetor[i].imprimir_salario();
        somatorio += vetor[i].calcular_salario();
      }
      Console.WriteLine("O somatório do salário semanal de todos os empregados foi de R$" + somatorio);

    }
  }
}
