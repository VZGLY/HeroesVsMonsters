namespace HeroesVsMonsters.Personnages.Toolbox;

public class De
{
    private int Minimum { get; }

    private int Maximum { get; }

    public De(int min, int max)
    {
        Minimum = min;
        Maximum = max;
    }

    public int Lancer()
    {
        return new Random().Next(Minimum, Maximum + 1);
    }
    
    
    
    
}