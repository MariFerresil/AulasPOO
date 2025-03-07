using Umbra.core;
internal class Program

{
    private static void Main(string[] args)
    {
        Druida druid = new Druida();
        PublicaVidaPersonagem(druid);
    }
    static void PublicaVidaPersonagem(Personagem personagem)
    {
        Console.WriteLine("Tipo: {0}, Vida: {1}, BarraDePoder: {2}", personagem.GetType().Name, personagem.Vida, personagem.BarraDePoder);

    }
}