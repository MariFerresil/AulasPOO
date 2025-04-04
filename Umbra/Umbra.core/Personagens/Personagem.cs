namespace Umbra.core
{
    public enum Especializacao
    {
        Nenhum = 0,
        LongoAlcance = 1 << 0,
        Magico = 1 << 1,
        CorpoACorpo = 1 << 2,
        Explosivo = 1 << 3
    }
    public abstract class Personagem
    {
        protected double _vida;
        protected double _BarraDePoder;
        protected Especializacao _TipoEspecializacao;



        public double Vida { get { return _vida; } }
        public double BarraDePoder { get { return _BarraDePoder; } }
        public Especializacao TipoEspecializacao { get { return _TipoEspecializacao; } }

        protected Personagem(double vidaInicial, double BarraDePoderInicial, Especializacao especializacao)
        {
            _vida = vidaInicial;
            _BarraDePoder = BarraDePoderInicial;
            _TipoEspecializacao = especializacao;
        }
    }
}
