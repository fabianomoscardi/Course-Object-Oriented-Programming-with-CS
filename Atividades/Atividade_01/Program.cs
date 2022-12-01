using System;

class main {

public static void Main (string[] args) {
  empregado e = new empregado();
    e.setHoras_Trabalhadas(190);
    e.setSalario_Hora(12);
    e.setINSS(11);
    Console.WriteLine("Salario = " + e.calcular_salario(e.getHoras_Trabalhadas(), e.getSalario_Hora(), e.getINSS()));
  }
}

