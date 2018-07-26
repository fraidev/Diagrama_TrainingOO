using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Diagrama.Domain.Sorts
{
    public class SelectionSort
    {
        public void Ordenar(IComparavel[] comparavel)
        {
            var tamanho = comparavel.Length;
            
            int menor;
            for (int i = 0; i < tamanho; i++)
            {
                menor = i;
                for (int j = (i+1) ; j < tamanho; j++)
                {
                    if (comparavel[j].CompararCom(comparavel[menor]) == -1)
                    {
                        menor = j;
                    }
                }

                    var aux = comparavel[i];
                    comparavel[i] = comparavel[menor];
                    comparavel[menor] = aux;    
            }
        }
    }
}