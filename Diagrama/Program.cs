using System;
using System.Runtime.InteropServices.ComTypes;
using Diagrama.Domain;
using Diagrama.Domain.Sorts;

namespace Diagrama
{
    class Program
    {
        static void Main(string[] args)
        {
            var aluno = new Aluno("Felipe",10);
            var aluno2= new Aluno("Felipe",10);
            var automoveis = new Automoveis();
            var selection = new SelectionSort();
            selection.Ordenar(aluno.CompararCom(aluno2));
        }
    }
}
