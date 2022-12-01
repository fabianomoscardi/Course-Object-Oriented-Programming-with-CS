/*Fazer um programa para controlar as reservas de passagem de vôos de uma companhia aérea.
Ler os dados de 5 vôos. Os dados de cada vôo são formados pelo:
 número do vôo; - int
 tipo de avião utilizado (707, 727, 737); - int
 preço da passagem.- double
1- Ler um número indeterminado de pedidos de reservas, contendo cada um:
 Número de identidade do passageiro;
 Número do vôo desejado; ( flag: número de identidade = 0 ).
2- Verificar, para cada passageiro, se há disponibilidade no vôo. Em caso afirmativo, atualizar o número de lugares disponíveis e imprimir:
 Número de identidade do passageiro;
 Número do vôo desejado;
 Preço da passagem;
 A mensagem "RESERVA CONFIRMADA". Em Caso negativo, imprimir os dois
primeiros itens e a mensagem "VÔO LOTADO".
Observação: Capacidade de cada avião : 707 - 10 lugares; 727 - 7 lugares; 737 - 5 lugares*/
using System;

class MainClass {
  public static void Main (string[] args) {
    Voo[] aeroZe = new Voo[5];
  
    int id,vooD;
    cadastro(aeroZe);
    Console.WriteLine("Digite a identidade, 0/fim ");
    id = int.Parse(Console.ReadLine());
    while(id!=0){
      Console.WriteLine("Digite o voo desejado");
      vooD = int.Parse(Console.ReadLine());
      reserva(id,vooD,aeroZe);

      Console.WriteLine("Digite a identidade, 0/fim ");
      id = int.Parse(Console.ReadLine());
    }

  }
  
  public static void reserva(int id,int vooD, Voo[] aero){
    int indice=-1;
    for(int i=0;i<aero.Length;i++){
      if(vooD == aero[i].getnVoo()){
        indice =i;
      }
    }
    if(indice==-1)
      Console.WriteLine("Número de Voo inexistente, tente novamente");
    else{
      if(aero[indice].getCap()>0){
        aero[indice].decrementaCap();
        Console.WriteLine("Identidade passageiro: "+id);
        Console.WriteLine("Voo desejado: "+aero[indice].getnVoo());
        Console.WriteLine("Preço da Passagem: "+aero[indice].getPreco());
        Console.WriteLine("Reserva Confirmada!");
      }
      else{
        Console.WriteLine("Identidade passageiro: "+id);
        Console.WriteLine("Voo desejado: "+aero[indice].getnVoo());
        Console.WriteLine("Voo lotado!");
      }
    }
  }
  public static void cadastro(Voo[] aero){
    int nv,tipo;
    double preco;

    for(int i=0;i<aero.Length;i++){
      Console.WriteLine("Digite o número do voo");
      nv = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o tipo de avião");
      tipo = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o preço da passagem");
      preco = double.Parse(Console.ReadLine());
      aero[i] = new Voo(nv,preco,tipo);
    }
  }
}
class Voo{
  private int nVoo;
  private double preco;
  private int tipo;
  private int cap;

  public Voo(){

  }
  public Voo(int nVoo, double preco, int tipo){
    this.nVoo = nVoo;
    this.preco = preco;
    this.tipo = tipo;
    if(tipo==707)
      cap = 10;
    else
      if(tipo==727)
        cap = 7;
      else
        cap =5;
  }
  public void setnVoo(int nVoo){
    this.nVoo = nVoo;
  }
  public int getnVoo(){
    return nVoo;
  }
  public void setPreco(double preco){
    this.preco = preco;
  }
  public double getPreco(){
    return preco;
  }
  public void setTipo(int tipo){
    this.tipo = tipo;
    if(tipo==707)
      cap = 10;
    else
      if(tipo==727)
        cap = 7;
      else
        cap =5;
  }
  public int getTipo(){
    return tipo;
  }
  public int getCap(){
    return cap;
  }
  public void decrementaCap(){
    cap--;
  }
}
