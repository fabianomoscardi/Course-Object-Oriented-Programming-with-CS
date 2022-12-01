using System;

namespace Prova_2._1
{
    public class Dvd
    {
    int nFaixas;

    public Dvd()
    {
    }

    public Dvd(int nFaixas)
    {
      this.nFaixas = nFaixas;
    }

    public void getNFaixas(int nFaixas){
      this.nFaixas = nFaixas;
    }

    public int setNFaixas(){
      return nFaixas;
    }

     public void toString(){
      Console.WriteLine("Código: " + codigo +
      "Preço: " + preco +
      "Nome: " + nome +
      "Número de músicas no cd: " + nMusicas +
      "Número de faixas no cd: " + nFaixas);
    }
  }
}