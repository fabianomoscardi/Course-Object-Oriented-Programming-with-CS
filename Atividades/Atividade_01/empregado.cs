using System;

class empregado {
  private double horas_trabalhadas;
  private double salario_hora;
  private double INSS;

  public empregado() {
    
  }

    public empregado(double horas_trabalhadas, double salario_hora, double INSS) {
      this.horas_trabalhadas = horas_trabalhadas;
      this.salario_hora = salario_hora;
      this.INSS = INSS;
  }

  public double getHoras_Trabalhadas(){
    return this.horas_trabalhadas;
  }

   public void setHoras_Trabalhadas(double horas_trabalhadas){
    this.horas_trabalhadas = horas_trabalhadas;
  }
   public double getSalario_Hora(){
    return this.salario_hora;
  }

   public void setSalario_Hora(double salario_hora){
    this.salario_hora = salario_hora;
  }
   public double getINSS(){
    return this.INSS;
  }

   public void setINSS(double INSS){
    this.INSS = INSS;
  }

  public double calcular_salario(double horas_trabalhadas, double salario_hora, double INSS){
  return (horas_trabalhadas * salario_hora) * (INSS/100);
  }

}