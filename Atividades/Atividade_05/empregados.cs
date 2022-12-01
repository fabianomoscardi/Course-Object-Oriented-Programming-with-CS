using System;

class empregados
{
  public double horas_trabalhadas;

  public double salario_fixo;
  public double salario_variavel;
  public int codigo;

  public empregados()
  {

  }

  public empregados(double salario_fixo, double salario_variavel, int codigo, double horas_trabalhadas)
  {
    this.horas_trabalhadas = horas_trabalhadas;
    this.salario_fixo = salario_fixo;
    this.salario_variavel = salario_variavel;
    this.codigo = codigo;
  }

  public double gethoras_trabalhadas()
  {
    return this.horas_trabalhadas;
  }

  public void sethoras_trabalhadas(double horas_trabalhadas)
  {
    this.horas_trabalhadas = horas_trabalhadas;
  }

  public double getsalario_fixo()
  {
    return this.salario_fixo;
  }

  public void setsalario_fixo(double salario_fixo)
  {
    if (horas_trabalhadas < 40)
    {
      this.salario_fixo = salario_fixo;
    }
  }

  public double getsalario_variavel()
  {
    return this.salario_variavel;
  }

  public void setsalario_variavel(double salario_variavel)
  {
    if (horas_trabalhadas > 40)
    {
      this.salario_variavel = horas_trabalhadas - 40 * 0.5;
    }
  }

  public int getcodigo()
  {
    return this.codigo;
  }

  public void setcodigo(int codigo)
  {
    this.codigo = codigo;
  }

  public double calcular_salario()
  {
    return salario_fixo + salario_variavel;
  }

  public void imprimir_salario()
  {
    Console.WriteLine("O salário semanal do empregado " + codigo + " foi de R$" + calcular_salario());

  }





}
