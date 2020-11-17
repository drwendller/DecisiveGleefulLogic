/*using System;
using System.Collections.Generic;

class aluno
{
  //atributos 
  private string nome;
  private float media;
  public float[] n = new float [4] ;
  public string notas;
  //metodos 
  public void alunos()
  {
    Console.WriteLine("qual o nome do aluno?");
    this.setNome(Console.ReadLine());
  }
  public void MediaDosSemestres()
  {
    Console.WriteLine("digite as 4 nota bimestral do aluno {0} de 0-100",this.getNome());
    for(int i=0;i<4;i++)
    { 
     notas = Console.ReadLine (); 
     n[i] = float.Parse(notas);
    }
    if(n[0] > 100 || n[1] > 100 || n[2] > 100 || n[3] > 100)
    {
     Console.WriteLine("erro...");
     MediaDosSemestres();
    }
  }  
  public void MediaDoAno()
  {
   media = (n[0]+n[1]+n[2]+n[3]) / 4;
   Console.WriteLine("a media do aluno {0} e {1}",this.getNome(),this.getMedia());
   if (media<60)
   { 
     Console.WriteLine("o aluno {0} foi reprovado",this.getNome());
   }else{
     Console.WriteLine("o aluno {0} foi aprovado",this.getNome());
   }
  }
  //metodos especiais 
  public string getNome()
  {
   return this.nome;
  }
    public void setNome(string na)
  {
   this.nome = na;
  }
  public float getMedia()
  {
    return this.media;
  }
  public void setMedia(float m)
  {
    this.media = m;
  }
}
class Program
{
  static void Main(string[] args)
  {
   while(true) 
    {
     aluno al = new aluno();
     al.alunos();
     al.MediaDosSemestres();
     al.MediaDoAno();
     Console.WriteLine("Deseja cadastrar um novo aluno? [Sim/Nao]");
     var DesejaCadastrar = Console.ReadLine();
     if(DesejaCadastrar.ToUpper() == "NAO")
    }
  } 
}  */