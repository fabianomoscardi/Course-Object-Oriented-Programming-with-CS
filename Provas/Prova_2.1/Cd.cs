using System;

namespace Prova_2._1
{
    public class Cd 
    {
  int nMusicas;

  public Cd()
  {
  }

  

  public Cd(int nMusicas)
  {
    this.nMusicas = nMusicas;
  }

  public void getNMusicas(int nMusicas){
      this.nMusicas = nMusicas;
    }

    
  public int setNMusicas(){
      return nMusicas;
    }

    public void toString(){
      Console.WriteLine("Código: " + codigo +
      "Preço: " + preco +
      "Nome: " + nome +
      "Número de músicas no cd: " + nMusicas);
    }
}
}