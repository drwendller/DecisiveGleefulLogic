/*using System;

class batata4testeclass
{
  public static void batata4teste (string[] args)
  {
  
   float[,] NA = new float [4,4];
   float[] MA = new float [4];
   string[] nome = new string [4];
   string NAII;
   
   Console.WriteLine("digite 1 para continuar");
   
   Console.WriteLine ("\n=========================aluno===============================\n");
    for(int aluno = 0 ; aluno < 4 ; aluno++)
    {
     for(int nota = 0 ; nota < 4 ; nota++)
     {
       NAII = Console.ReadLine ();
       NA [aluno,nota] = float.Parse(NAII);
       MA [aluno] += NA [aluno,nota];
      } 
       MA [aluno] /= 4;
       Console.WriteLine ("insira o nome do aluno {0}:\n",aluno+1);
       nome[aluno] = Console.ReadLine ();
       Console.WriteLine ("insira a nota bimestral do {0} :\n",nome[aluno]);
       }
      Console.WriteLine ("===============================MEDIA===================================\n");
      for(int aluno = 0 ; aluno < 4 ; ++aluno)
      {
        Console.WriteLine ("a media do aluno {0} e {1} \n",nome[aluno],MA[aluno]); 
        if (MA[aluno]>=60)
        {
        Console.WriteLine ("o aluno {0} foi APROVADO\n",nome[aluno]);
        }
        else
        {
        Console.WriteLine ("o aluno {0} foi REPROVADO\n",nome[aluno]);
      }
    }
  }
}*/
