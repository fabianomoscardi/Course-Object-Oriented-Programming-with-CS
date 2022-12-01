using System;

class circulo {
  private double raio;  

  public circulo() {

  }

  public circulo(double raio){
    this.raio = raio;
  }

  public double getraio(){
    return this.raio;
  }

  public void setraio(double raio){
    this.raio = raio;
  }

  public double perimetro() {
    return 2 * Math.PI * this.raio;
  }
  
  public double calcular_perimetro(double raio){
    return 2 * Math.PI * raio;
  }

  public double area() {
  return Math.PI * Math.Pow(this.raio, 2);
  }

  public double calcular_area(double raio){
    return Math.PI * Math.Pow(raio, 2);
  }

}

