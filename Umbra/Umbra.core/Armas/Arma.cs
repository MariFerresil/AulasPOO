using System;

namespace Umbra.Core
{
    [Flags]
    public enum Especializacao
    {
        Nenhum = 0,
        LongoAlcance = 1 << 0,
        Magico = 1 << 1,
        CorpoACorpo = 1 << 2,
        Explosivo = 1 << 3
    }

    public abstract class Arma
    {
        protected int _Dano;
        protected Especializacao _TipoEspecializacao;
        public int Dano { get { return _Dano; } }
        public Especializacao TipoEspecializacao { get { return _TipoEspecializacao; } }
        protected Arma(int Danominimo, Especializacao especializacao)
        {
            _Dano = Danominimo;
            _TipoEspecializacao = especializacao;
        }
    }
}