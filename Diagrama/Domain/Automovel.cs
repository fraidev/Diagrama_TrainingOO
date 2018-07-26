using System;

namespace Diagrama.Domain
{
    public class Automovel:IComparavel
    {
        public string Marca { get; set; }
        public float VelocidadeMaxima { get; set; }

        public Automovel(string marca, float velocidadeMaxima)
        {
            Marca = marca;
            VelocidadeMaxima = velocidadeMaxima;
        }
        
        public void SetMarca(string marca)
        {
            Marca = marca;
        }
        
        public void SetVelocidadeMaxima(float velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }
        
        public int CompararCom(IComparavel comparavel)
        {
            var other = comparavel as Automovel;
            
            if (VelocidadeMaxima < other.VelocidadeMaxima) {
                return -1;
            }
            return VelocidadeMaxima > other.VelocidadeMaxima ? 1 : 0;
        }
        
        public void Imprimir()
        {
            Console.WriteLine(Marca);
            Console.WriteLine(VelocidadeMaxima);
        }
    }
}