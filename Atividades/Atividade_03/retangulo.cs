using System;

class retangulo {
  private double altura;
  private double largura;

  public retangulo() {

  }

  public retangulo(double altura, double largura){
    this.altura = altura;
    this.largura = largura;
  }

  public void setaltura(double altura){
    this.altura = altura;
  }

  public double getaltura(){
    return this.altura;
  }

  public void setlargura(double largura){
    this.largura = largura;
  }

    public double getlargura(){
    return this.largura;
  }

  public double area(){
    return this.largura * this.altura;
  }


  public double calcular_area(double altura, double largura){
    return(altura * largura);
  }

  public double perimetro() {
    return this.largura * this.altura;
  }

  public double calcular_perimetro(double altura, double largura){
    return(altura * 2) + (largura * 2);
  }
}
