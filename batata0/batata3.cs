using System;
class Batata3Class
{
  enum DiasSemanas {domingo,segunda,terca,quarta,quinta,sexta,sabado};
  public static void Batata3 (string[] args)
  {
    DiasSemanas d = DiasSemanas.segunda;
    Console.WriteLine (d);
    DiasSemanas s = (DiasSemanas)2;
    Console.WriteLine (s);
    int b = (int)DiasSemanas.segunda;
    Console.WriteLine (b);
  }
}