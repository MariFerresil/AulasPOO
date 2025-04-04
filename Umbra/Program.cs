using Umbra.core;
using Umbra.Core;
internal class Program

{
    private static void Main(string[] args)
    {
        //personagems
        // Druida druid = new Druida();
        //PublicaVidaPersonagem(druid);
        // Necromante necromance = new Necromante();
        // PublicaVidaPersonagem(necromance);
        // Peladinho naked = new Peladinho();
        // PublicaVidaPersonagem(naked);
        Ferreiro blacksmith = new Ferreiro();
        //PublicaVidaPersonagem(blacksmith);
        //Armas
        Machado machado = new Machado();
        Atacar(machado, blacksmith);
    }
    static void PublicaVidaPersonagem(Personagem personagem)
    {
        Console.WriteLine("Tipo: {0}, Vida: {1}, BarraDePoder: {2}", personagem.GetType().Name, personagem.Vida, personagem.BarraDePoder);

    }
    static void Atacar(Arma arma, Personagem personagem)
    {
        Console.WriteLine("O personagem {0} esta atacando com o{1} Dano do Machado é {2} e o de especialização {3}", personagem.GetType().Name, arma.GetType().Name, arma.Dano, arma.TipoEspecializacao);
    }
}