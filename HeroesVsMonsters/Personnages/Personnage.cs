using HeroesVsMonsters.Interfaces;
using HeroesVsMonsters.Personnages.Toolbox;

namespace HeroesVsMonsters.Personnages;

public class Personnage
{

    public Personnage()
    {

        Endurance = Stats.Generer();

        Force = Stats.Generer();

        PV = Endurance + Stats.Modificateur(Endurance);

    }
    
    
    public int Endurance { get; protected set; }

    public int Force { get; protected set; }

    public int PV { get; set; }

    public int Frappe(Personnage adversaire)
    {
        int degats = new De(1, 4).Lancer() + Stats.Modificateur(Force);
        
        adversaire.PV -= degats;

        return degats;
    }

    public override string ToString()
    {
        string text = $"Points de vie : {PV} - Endurance : {Endurance} - Force : {Force}";
        text += this is IOr ior ? $" - Or : {ior.Or}": "";
        text += this is ICuir icuir ? $" - Cuir : {icuir.Cuir}" : "";
        return text ;
    }
}