namespace Umbra.core;
{
 public class Druida : Personagem
{
    public Druida() : base(300, 100)
    {

    }

    public void AtacarComPorrete()
    {
        Console.WriteLine("Atacando com porrete");
    }
}
}