using System;

namespace Diagrama.Domain
{
    public class Aluno:IComparavel
    {
        public string Nome { get; set; }
        public double Nota { get; set; }

        public Aluno(string nome, double nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public int CompararCom(IComparavel comparavel)
        {
            return comparavel.GetHashCode();
        }

        public void Imprimir()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(Nota);
        }
    }
}