using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Diagrama.Domain;
using Diagrama.Domain.Sorts;

namespace Diagrama
{
    class Program
    {
        static void Main(string[] args)
        {
            var automoveis = new Automoveis();
            
            var fusca = new Automovel("Fusca", 100);
            var bmw = new Automovel("BMW", 300);
            var camaro = new Automovel("Camaro", 250);
            var hilux = new Automovel("Camaro", 200);
            
            automoveis.ListaDeAutomoveis = new Automovel[] { 
                fusca,
                bmw,
                camaro,
                hilux
            };
            
            var selection = new SelectionSort();
            
            selection.Ordenar(automoveis.ListaDeAutomoveis);

            foreach (var auto in automoveis.ListaDeAutomoveis)
            {
                Console.WriteLine(auto.VelocidadeMaxima);
            }
        }
    }
}
