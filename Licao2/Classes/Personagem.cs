namespace Personagens.Core
[
    public abstract class Character
    [
                protected double _vida;
protected double _BarraDePoder
                protected int[,] _inventario



public double Vida { get { return _vida; } }
public double BarraDePoder { get { return _BarraDePoder; } }
public int[,] Inventario { get { return _Inventario} } = new int[5, 5];
protected Personagem(double vidaInicial, double BarraDePoderInicial, int[,] Inventario)
{
    _vida = vidaInicial;
    _BarraDePoder = BarraDePoderInicial
}
    ]
]