using System;

namespace Prova_2._1
{
    class Midia
    {
    int codigo;
    double preco;
    string nome;

    public Midia(){
    }

    public Midia(int codigo, double preco, string nome){
      this.codigo = codigo;
      this.preco = preco;
      this.nome = nome;
    }

    public void getCodigo(int codigo){
      this.codigo = codigo;
    }

    public int setCodigo(){
      return codigo;
    }

    public void getPreco(double preco){
      this.preco = preco;
    }

    public double setPreco(){
      return preco;
    }

    
    public void getNome(string nome){
      this.nome = nome;
    }

    public string setNome(){
      return nome;
    }

    public void toString(){
      Console.WriteLine("Código: " + codigo +
      "Preço: " + preco +
      "Nome: " + nome);
    }


  }
}
