using HeroesVsMonsters.Interfaces;
using HeroesVsMonsters.Personnages.Monstres;

namespace HeroesVsMonsters.Personnages.Heros;

public class Heros : Personnage, IOr, ICuir
{
    public Heros()
    {
        MaxPV = PV;
    }
    
    public int MaxPV { get;}
    
    public int Or { get; set; }
    public int Cuir { get; set; }

    public void Reposer()
    {
        PV = MaxPV;
    }

    public void Loot(Monstre monstre)
    {
        if (monstre is IOr orMonstre)
        {
            Or += orMonstre.Or;
        }

        if (monstre is ICuir cuirMonstre)
        {
            Cuir += cuirMonstre.Cuir;
        }
    }
    
    
}