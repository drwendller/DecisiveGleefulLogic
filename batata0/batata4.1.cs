/*using System;
using System.Collections.Generic;

namespace csharp
{
    class Aluno { // definição da classe Aluno com as propriedades e regras referentes ao Aluno
        public string Nome;
        public IList<float> Avaliacoes;

        public Aluno(string nome) // Construtor da classe que torna obrigatório criar a classe com um nome
        {
            Nome = nome;
            Avaliacoes = new List<float>();
        }

        public bool AddNotaAvaliacao(float nota){
            bool notaValida = ValidarNota(nota);
            if(!notaValida) return notaValida;

            Avaliacoes.Add(nota);

            return notaValida;
        }

        public float ObterMedia(){
            if(Avaliacoes.Count == 0) {
                Console.WriteLine($"Não é possível calcular a média do aluno {Nome}, pois não foram cadastradas avaliações para este aluno.");
                return -1;
            }

            float soma = 0;
            foreach (float nota in Avaliacoes) 
            {
                soma = soma + nota;
            }
            float media = soma / Avaliacoes.Count;
            return (float)Math.Round(media, 1, MidpointRounding.AwayFromZero);
        }

        public bool EstaAprovado(){
            return ObterMedia() >= 60;
        }

        private bool ValidarNota(float nota)
        {
            return nota >= 0 && nota <= 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Aluno> listaAlunos = new List<Aluno>(); // Lista de alunos sem limite de quantidade
            int qtdeAvaliacoes = ObterQuantidadeAvaliacoesPorAluno();
            
            while(true) // Loop infinito para cadastrar quantos alunos quiser
            {
                Console.WriteLine("Deseja cadastrar um novo aluno? [S/N]");
                var desejaCadastrar = Console.ReadLine();
                if(desejaCadastrar.ToUpper() == "N") break; // Caso seja digitado N o loop é interrompido
                
                string nomeAluno = ObterNomeDoAluno();
                Aluno aluno = new Aluno(nomeAluno); // Criação do objeto da classe aluno

                for ( int nAvaliacao = 1; nAvaliacao <= qtdeAvaliacoes; nAvaliacao++)
                {
                    ObterAvaliacoesDoAluno(aluno, nAvaliacao);
                }

                listaAlunos.Add(aluno);
            }
            
            Console.WriteLine("======================= Média dos alunos =======================\n");
            foreach(var aluno in listaAlunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome} | Média: {aluno.ObterMedia()} | Aprovado: {(aluno.EstaAprovado() ? "Sim" : "Não")}");
            }
        }

        // Métodos com recursão
        static int ObterQuantidadeAvaliacoesPorAluno()
        {
            Console.WriteLine("Quantas avaliações serão cadastradas para cada aluno? (de 1 a 10)");
            int qtdeAvaliacoes = int.Parse(Console.ReadLine());

            if(qtdeAvaliacoes < 1 || qtdeAvaliacoes > 10){
                Console.WriteLine("É obrigatório que a quantidade de avalições esteja entre 1 e 10. Digite novamente.");
                return ObterQuantidadeAvaliacoesPorAluno();
            }

            return qtdeAvaliacoes;
        }

        static string ObterNomeDoAluno(){
            Console.WriteLine("Digite o nome do Aluno: ");
            string nomeAluno = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(nomeAluno)){
                Console.WriteLine("Nome do aluno não pode estar vazio.");
                return ObterNomeDoAluno();
            }
            
            return nomeAluno;
        }

        static void ObterAvaliacoesDoAluno(Aluno aluno, int numeroDaAvaliacao){
            Console.WriteLine($"Digite a nota de {aluno.Nome} na avaliação {numeroDaAvaliacao}: (de 0 a 100)");
            float nota = float.Parse(Console.ReadLine());
            
            bool notaAdicionadaComSucesso = aluno.AddNotaAvaliacao(nota);
            if(!notaAdicionadaComSucesso) {
                Console.WriteLine("É obrigatório que a nota do aluno esteja entre 0 e 100. Digite novamente: ");
                ObterAvaliacoesDoAluno(aluno, numeroDaAvaliacao);
            }
        }
    }
}*/