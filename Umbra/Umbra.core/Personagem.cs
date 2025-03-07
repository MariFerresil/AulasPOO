namespace Umbra.core
{
    public abstract class Personagem
    {
        protected double _vida;
        protected double _BarraDePoder;




        public double Vida { get { return _vida; } }
        public double BarraDePoder { get { return _BarraDePoder; } }

        protected Personagem(double vidaInicial, double BarraDePoderInicial)
        {
            _vida = vidaInicial;
            _BarraDePoder = BarraDePoderInicial;
        }
    }
}
