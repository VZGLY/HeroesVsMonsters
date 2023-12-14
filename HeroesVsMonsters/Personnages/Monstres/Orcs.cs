using HeroesVsMonsters.Interfaces;

namespace HeroesVsMonsters.Personnages.Monstres;

public class Orcs : Monstre, IOr
{

    public Orcs()
    {
        Force += 1;
    }
    
    public int Or { get; set; }
}