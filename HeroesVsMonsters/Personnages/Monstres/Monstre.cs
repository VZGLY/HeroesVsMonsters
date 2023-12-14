using HeroesVsMonsters.Interfaces;
using HeroesVsMonsters.Personnages.Toolbox;

namespace HeroesVsMonsters.Personnages.Monstres;

public class Monstre : Personnage
{
    public Monstre()
    {
        if (this is IOr ior)
        {
            ior.Or = new De(1, 6).Lancer();
        }

        if (this is ICuir icuir)
        {
            icuir.Cuir = new De(1, 4).Lancer();
        }
    }
}