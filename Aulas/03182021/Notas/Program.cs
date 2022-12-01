/*Dada uma disciplina que é avaliada com 4 provas de 20 pontos e uma prova final de 40 pontos. Nota final do aluno é obtida pela soma das 3 maiores provas de 20 com a nota da prova de 40.O conceito segue a seguinte regra:
  de 90 a 100 conceito A 
  de 80 a 89           B
  de 70 a 79           C 
  de 60 a 69           D 
  de 40 a 59           E 
  de 00 a 39           F 
  Ler os dados e calcular as notas finais e conceitos dos alunos*/
using System;

class MainClass
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Hello World");
  }
}
class Aluno
{
  private int[] nota = new int[4];
  private int pF;
  string nome;
  public Aluno() { }
  public Aluno(string n, int[] nt, int pf)
  {
    nome = n;
    nota = nt;
    pF = pf;
  }
  public void setNome(string n)
  {
    nome = n;
  }
  public string getNome()
  {
    return nome;
  }
  public void setNota(int[] nt)
  {
    nota = nt;
  }
  public int[] getNota() { return nota; }
  public void setPf(int pf) { pF = pf; }
  public int getPF() { return pF; }
  public int CalculaSN()
  {
    int somaM = 0, aux, i, j;
    for (i = 0; i < nota.Length - 1; i++)
      for (j = i + 1; j < nota.Length; j++)
        if (nota[i] < nota[j])
        {
          aux = nota[i];
          nota[i] = nota[j];
          nota[j] = aux;
        }
    for (i = 0; i < nota.Length - 1; i++)
      somaM = somaM + nota[i];
    return somaM;
  }
  public int getNotaFinal()
  {
    return CalculaSN() + pF;
  }
  public char Conceito()
  {
    char conc;
    int nf = getNotaFinal();
    if (nf >= 90)
      conc = 'A';
    else
      if (nf >= 80)
      conc = 'B';
    else
        if (nf >= 70)
      conc = 'C';
    else
          if (nf >= 60)
      conc = 'D';
    else
            if (nf >= 40)
      conc = 'E';
    else
      conc = 'F';
    return conc;
  }
}
class Disciplina
{
  private Aluno[] info = new Aluno[10];
  private string nome;
  private string codigo;

  public Disciplina() { }

  public Disciplina(string n, string cod, Aluno[] dados)
  {
    nome = n;
    codigo = cod;
    info = dados;
  }
  public void setNome(string n) { nome = n; }
  public string getNome() { return nome; }
  public void setCodigo(string cod) { codigo = cod; }
  public string getCodigo() { return codigo; }
  public void setAluno(Aluno[] dados) { info = dados; }
  public Aluno[] getAluno() { return info; }
