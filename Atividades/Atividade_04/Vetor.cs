using System;

    class vetor
    {
  public int[] vet;


  public vetor(){
    this.vet = new int [20];
    this.gerar_vetor();
  }

  public vetor(int tamanho){
    this.vet = new int [tamanho];
    this.gerar_vetor();
  }

  public vetor(int[] vet){
    this.vet = vet;
  }

  public void setvet(int[] vet){
    this.vet = vet;
  }

  public int[] getvet(){
    return this.vet;
  }


  public void maior_menor(){
    int menor = this.vet[0];
    int maior = this.vet[0];

    foreach (int elemento in this.vet){
      if(menor > elemento){
        menor = elemento;
      }
       if(maior < elemento){
        maior = elemento;
      }
    }
    Console.WriteLine("Maior: {0} e menor: {1}", maior, menor);
  }


  public void gerar_vetor(){
    Random nums = new Random();
    for (int i = 0; i < this.vet.Length; i++){
      this.vet[i] = nums.Next(1, 100);
    }
  }

  public void imprimir_vetor(){
    for (int i = 0; i < this.vet.Length; i++)
    {
      Console.WriteLine(this.vet[i]);
    }
  }

  public string primeira_ocorrencia(int num)
  {
    for (int i = 0; i < this.vet.Length; i++)
    {
      if (this.vet[i] == num)
      {
        Console.WriteLine("O número {0} foi encontrado na posição {1}", num, i);
        return "";
      }
    }
    Console.WriteLine("Não foi encontrado esse valor no vetor.");
    return "";
  }



  public void todas_ocorrencias(int x){
    int quant = quant_ocorrencias(x);
    int[] aux = new int[quant];
    int y = 0;
    for (int i = 0; i < this.vet.Length; i++){
      if(this.vet[i] == x){
        aux[y] = i;
        y++;
      }
    }
    string s = "";
    for (int i = 0; i < aux.Length; i++) {
      s += aux[i] + " ";
    }
    Console.WriteLine(s);
  }

   public int quant_ocorrencias(int x){
    int quant = 0;
    foreach(int num in vet){
      if(num == x){
        quant++;
      }
     }
    return quant;


  }
}
