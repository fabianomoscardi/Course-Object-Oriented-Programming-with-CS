using System;
class main{
  public static void Main(string[] args){
    circulo cir = new circulo();
      cir.setraio(3);
    retangulo ret = new retangulo();
      ret.setaltura(18.35);
      ret.setlargura(30);
  Console.WriteLine("O volume do cilindro formado pelo círculo e pelo retângulo é: " + Math.PI * Math.Pow(cir.getraio(), 2) * ret.getaltura());
  }

}

