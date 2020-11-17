/*using System;
using System.Collections.Generic;
using System.Linq;

class aluno
{
    //atributos 
    private string nome;
    private float media;
    public float[] nota = new float [4];
    public string notas;
    public string AprovadoOuReprovado;
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
            nota[i] = float.Parse(notas);
        }
        if(nota[0] > 100 || nota[1] > 100 || nota[2] > 100 || nota[3] > 100)
        {
            Console.Clear();
            Console.WriteLine("erro...");
            MediaDosSemestres();
        }
    }  
    public void MediaDoAno()
    {
        media = (nota[0] + nota[1] + nota[2] + nota[3]) / 4;
        Console.WriteLine("a media do aluno {0} e {1}",this.getNome(),this.getMedia());
        if (media<60)
        { 
            AprovadoOuReprovado = "reprovado";
            Console.WriteLine("o aluno {0} foi {1}",this.getNome(),AprovadoOuReprovado);
        }
        else
        {
            AprovadoOuReprovado = "aprovado";
            Console.WriteLine("o aluno {0} foi {1}",this.getNome(),AprovadoOuReprovado);
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
class escola
{
    //atributos
    private string materia;
    private string NomeDaEscola;
    public int turno;
    public int AnoEscolar;
    public int EnsinoEscolar;
    public string colegio;
    public string SouUmaString;
    public char turma;
    public string TurnoString;  
    public string EnsinoEscolarString;
    //metodos
    aluno pegar = new aluno();
    public void AlunoDaEscola()
    {
        pegar.alunos();
    }
    public void matricula()
    {
        pegar.MediaDosSemestres();
        pegar.MediaDoAno();
    }
    public void NomeEscola()
    {
        Console.WriteLine("qual o nome da escolar do aluno que deseja cadastrar?");
        NomeDaEscola = Console.ReadLine();  
    }
    public void PeriodoEscolar()
    {
        Console.Clear();
        Console.WriteLine("qual periodo escolar do aluno que deseja cadastrar?\ndigite:\n1-ensino fundamenta I\n2-ensino fundamental II\n3-ensino medio");
        SouUmaString  = Console.ReadLine();
        EnsinoEscolar = int.Parse(SouUmaString);
        if(EnsinoEscolar > 3)
        {
            Console.Clear();
            Console.WriteLine("erro...nao existe {0}",EnsinoEscolar);
            PeriodoEscolar();
        }
    }
    public void AnoLetivo()
    {
        Console.Clear();
        Console.WriteLine("qual o ano escolar do aluno que deseja cadastrar?");
        SouUmaString = Console.ReadLine();
        AnoEscolar = int.Parse(SouUmaString);
        if(EnsinoEscolar == 1)
        {   
            EnsinoEscolarString = "Ensino Fundamental I";
            while(AnoEscolar > 5)
            {
                Console.Clear();
                Console.WriteLine("erro...O Ensino Fundamental I fica entre o 1°-5º ano nao o {0}º ano",AnoEscolar);
                AnoLetivo();
            }
        }else if(EnsinoEscolar == 2)
        {
            EnsinoEscolarString = "Ensino Fundamental II";
            while(AnoEscolar > 9)
            {
                Console.Clear();
                Console.WriteLine("erro...O Ensino Fundamental II fica entre o 6°-9º ano nao o {0}º ano",AnoEscolar);
                AnoLetivo();
            }
        }else if(EnsinoEscolar == 3)
        {
            EnsinoEscolarString = "Ensino Medio";
            while(AnoEscolar > 3)
            {
                Console.Clear();
                Console.WriteLine("erro...O Ensino Medio fica entre o 1º-3º ano nao o {0}º ano",AnoEscolar);
                AnoLetivo();
            }
        }
    }
    public void TurmaEscolar()
    {
        Console.Clear();
        Console.WriteLine("qual a turma do aluno que deseja cadastrar?");
        SouUmaString  = Console.ReadLine();
        turma = char.Parse(SouUmaString);
    }
    public void TurnoEscolar()
    {
        Console.Clear();
        Console.WriteLine("qual o turno do aluno que deseja cadastrar?\ndigite:\n1-matutino\n2-vespertino\n3-noturno\n4-integral");
        SouUmaString  = Console.ReadLine();
        turno = int.Parse(SouUmaString);
        if(turno == 1)
        {
            TurnoString  = "matutino";
        }else if(turno == 2)
        {
            TurnoString  = "vespertino";
        }else if(turno == 3)
        {
            TurnoString  = "noturno";
        }else if(turno == 4)
        {
            TurnoString  = "integral";
        }else
        {
            Console.Clear();
            Console.WriteLine("erro...Nao existe {0}",turno);
            TurnoEscolar();
        }
    }
    public void TipoDeColegio()
    {
        if(EnsinoEscolar == 1)
        {
            colegio = "municipal";
        }
        else if(EnsinoEscolar <= 3)
        {
            colegio = "estadual";
        }
    } 
    public void lista()
    {
        NomeEscola();
        PeriodoEscolar();
        AnoLetivo();
        TurmaEscolar();
        TurnoEscolar();
        TipoDeColegio();
    }
    public void registro()
    {
        Console.WriteLine("-----------------------REGISTRO-DO-ALUNO-----------------------");
        Console.WriteLine("Nome do aluno: {0}\nEscola: Colegio {1} {2}\nSerie: {3}º ano do {4}\nTurma: {5}\nTurno: {6}\nInformacao: o aluno {7} foi {8} no ano letivo sua media do ano foi {9}",this.pegar.getNome(),colegio,NomeDaEscola,AnoEscolar,EnsinoEscolarString,turma,TurnoString,this.pegar.getNome(),this.pegar.AprovadoOuReprovado,this.pegar.getMedia());
    }
    //metodos especiais 
    public string getMateria()
    {
        return this.materia;
    }
    public void setMateria(string ma)
    {
        this.materia = ma;
    }
    public string getNomeDaEscola()
    {
        return this.NomeDaEscola;
    }
    public void setNomeDaEscola(string ne)
    {
        this.NomeDaEscola = ne;
    }
}
class login
{
    //atributos
    private string senha;
    private int NumeroDaMatricula;
    public string SouString;
    public string SouStringM;
    public int numero;
    escola es = new escola();
    aluno pegar = new aluno();
    //metodos
    public void CadastroSenha(string senha)
    {
        Console.WriteLine("digite uma senha:");
        Console.WriteLine("A senha do aluno tem que ser 8-20 caracteres, pelo menos um numero, uma letra maiuscula, uma letra minusula e um caractere especial");
        senha = Console.ReadLine();
        if(senha.Length < 8 || senha.Length > 20 /*quantidade*/ //|| !senha.Any(c => char.IsDigit(c))/*numero*/ || !senha.Any(c => char.IsUpper(c))/*maiuscula*/ || !senha.Any(c => char.IsLower(c))/*minuscula*/ || !(senha.Any(c => char.IsLetter(c) || char.IsDigit(c)))/*caractere especial*/ || !senha.Any(c => char.IsSymbol(c))/*caractere especial*/)
        /*{
            Console.Clear();
            Console.WriteLine("erro....");
            CadastroSenha(senha);
        }
        var contadorRepetido = 0;//caractere repetido 
        var ultimoCaracter = '\0'; 
        foreach(var c in senha)
        { 
            if (c == ultimoCaracter)
            {
            contadorRepetido++; 
            }else
            {
            contadorRepetido = 0; 
            }
            if (contadorRepetido == 2)
            {
                Console.Clear();
                Console.WriteLine("erro... a senha do aluno nao pode ter caractere repidido mais do que 2 vezes");
                CadastroSenha(senha); 
                ultimoCaracter = c; 
            }
        } 
    }
    public void EntrarSenha(string senha)
    {
        Console.WriteLine("digite a senha do aluno:");
        Console.WriteLine("A senha do aluno tem que ser 8-20 caracteres, pelo menos um numero, uma letra maiuscula, uma letra minusula e um caractere especial");
        senha = Console.ReadLine();
        if(senha.Length < 8 || senha.Length > 20/*quantidade*/ //|| !senha.Any(c => char.IsDigit(c))/*numero*/ || !senha.Any(c => char.IsUpper(c))/*maiuscula*/ || !senha.Any(c => char.IsLower(c))/*minuscula*/ || !(senha.Any(c => char.IsLetter(c) || char.IsDigit(c)))/*caractere especial*/ || !senha.Any(c => char.IsSymbol(c))/*caractere especial*/)
        /*{
            Console.Clear();
            Console.WriteLine("erro....");
            CadastroSenha(senha);
        }
        var contadorRepetido = 0;//caractere repetido 
        var ultimoCaracter = '\0'; 
        foreach(var c in senha)
        { 
            if (c == ultimoCaracter)
            {
            contadorRepetido++; 
            }else
            {
            contadorRepetido = 0; 
            }
            if (contadorRepetido == 2)
            {
                Console.Clear();
                Console.WriteLine("erro... a senha do aluno nao pode ter caractere repidido mais do que 2 vezes");
                CadastroSenha(senha); 
                ultimoCaracter = c; 
            }
        } 
    }
    public void CadastroNumeroDaMatricula()
    {
        Random gerador = new Random();
        int NumeroDaMatricula = gerador.Next(10^9,9*(10^9));
        Console.WriteLine("o numero da matricula do aluno {0} e {1}",pegar.getNome(),NumeroDaMatricula);
    }
    public void EntrarNumeroDaMatricula()
    {
        Console.WriteLine("digite o numero da matricula do aluno:");
        SouStringM = Console.ReadLine();
        NumeroDaMatricula = int.Parse(SouStringM);
        if(NumeroDaMatricula < 1000000000 || NumeroDaMatricula > 9999999999)
        {
            Console.Clear();
            Console.WriteLine("erro... o numero da matricula do aluno tem que ser igual a 10 caracteres");
            EntrarNumeroDaMatricula();
        }
    }
    public void MatriculaDoAluno()
    {
        Console.WriteLine("digite:\n1.Entrar(ver registro)\n2.Cadastrar\n3.Sair");
        SouString = Console.ReadLine();
        numero = int.Parse(SouString);
        switch(numero)
        {
            case 1:
            while(true) 
            {   
                Console.Clear();
                EntrarSenha(senha);
                Console.Clear();
                EntrarNumeroDaMatricula();
                Console.Clear();
                es.registro();
                Console.WriteLine("Deseja ver o registro de outro aluno aluno? [Sim/Nao]");
                var DesejaCadastrar = Console.ReadLine();
                if(DesejaCadastrar.ToUpper() == "NAO")
                {
                Console.Clear();
                MatriculaDoAluno();
                }
            }
            case 2:
            while(true) 
            {   
                Console.Clear();
                es.AlunoDaEscola();
                Console.Clear();
                es.lista();
                Console.Clear();
                es.matricula();
                Console.Clear();
                CadastroSenha(senha);
                Console.Clear();
                CadastroNumeroDaMatricula();
                Console.WriteLine("Deseja cadastrar um novo aluno? [Sim/Nao]");
                var DesejaCadastrar = Console.ReadLine();
                if(DesejaCadastrar.ToUpper() == "NAO")
                {
                Console.Clear();
                MatriculaDoAluno();
                }
            }
            case 3:
            Console.WriteLine("Você digitou o numero " + numero + " para sair." + "\n"+"ate logo!",null);
            break;
            default:
            Console.Clear();
            Console.WriteLine("erro...");
            MatriculaDoAluno();
            break;
        }
    }
    //metodos especiais
    public string getSenha()
    {
        return this.senha;
    }
    public void setMateria(string sa)
    {
        this.senha = sa;
    }
    public int getNumeroDaMatricula()
    {
        return this.NumeroDaMatricula;
    }
    public void setNumeroDaMatricula(int nm)
    {
        this.NumeroDaMatricula = nm;
    }
}
class Program
{
    static void Main(string[] args)
    {
        login lo = new login();
        
        lo.MatriculaDoAluno();
    } 
}*/