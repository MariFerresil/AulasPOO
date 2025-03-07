using Umbra.core;
internal class Program

{
    private static void Main(string[] args)
    {
        Druida druid = new Druida();
        PublicaVidaPersonagem(druid);
    }
    void PublicaVidaPersonagem(Personagem Personagem)
    {
        Console.WriteLine("Tipo: {0}, Vida: {1}, BarraDePoder {2}", Personagem.GetType().Name, Personagem.Vida, Personagem.BarraDePoder);

    }
}