using HeroesVsMonsters.Interfaces;

namespace HeroesVsMonsters.Personnages.Monstres;

public class Dragonnet : Monstre, IOr, ICuir
{
    public Dragonnet()
    {
        Endurance += 1;
    }
    
    public int Or { get; set; }
    public int Cuir { get; set; }
}