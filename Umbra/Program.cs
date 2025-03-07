using Umbra.core;
internal class Program

{
    private static void Main(string[] args)
    {
        Druida druid = new Druida();
        PublicaVidaPersonagem(druid);
        Necromante necromance = new Necromante();
        PublicaVidaPersonagem(necromance);
        Peladinho naked = new Peladinho();
        PublicaVidaPersonagem(naked);
        Ferreiro blacksmith = new Ferreiro();
        PublicaVidaPersonagem(blacksmith);
    }
    static void PublicaVidaPersonagem(Personagem personagem)
    {
        Console.WriteLine("Tipo: {0}, Vida: {1}, BarraDePoder: {2}", personagem.GetType().Name, personagem.Vida, personagem.BarraDePoder);

    }
}