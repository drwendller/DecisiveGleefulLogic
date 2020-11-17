/*
if(!senha.Any(c = >char.isDigit(c)))//numero
if(!senha.Any(c = >char.isUpper(c)))//maiuscula
if(senha.length < 8 ||senha.length > 20)//quantidade 
if(!senha.Any(c = >char.isLower(c)))//minusculo
if(!senha.Any(c = >char.isSymbol(c)))//caractere especial
if(!(senha.Any(c = >char.isLetter(c) || char.isDigit(c))))//verificar se existe caractere especial
var contadorRepetido = 0;//caractere repetido 
var ultimoCaracter = '\0'; 
foreach(var c in senha)k 
{ 
if (c == ultimoCaracter) contadorRepetido++; 
else contadorRepetido = 0; 
if (contadorRepetido == 2) 
return false; 
ultimoCaracter = c; 
}
using System;
class Batata1Class
{
  public static void Batata1 (string[] args) 
  {
    Console.WriteLine ("qual seu nome ?");
    string nome = Console.ReadLine ();
    Console.WriteLine ("seu nome e {0}",nome);
  }string[] materia = new string [15];
  private string materia
  private int AnoEscolar;
  public void materias()
  {
   Console.WriteLine("Escolha quantas materias pretende ");
   
  }
  public string getMateria()
  {
   return this.materia;
  }
    public void setMateria(string ma)
  {
   this.materia = ma;
  }public string getAnoEscolar()
  {
   return this.AnoEscolar;
  }
    public void setAnoEscolar(string ae)
  {
   this.AnoEscolar = ae;
  }
}*/
