namespace HeroesVsMonsters.Personnages.Toolbox;

public class Stats
{

    public static int Generer()
    {
        List<int> Lancee = new List<int>();

        De de = new De(1, 6);

        for (int i = 0; i < 4; i++)
        {
            Lancee.Add(de.Lancer());
        }
        
        Lancee.Sort();

        Lancee.RemoveAt(0);

        return Lancee.Sum();
    }
    
    public static int Modificateur(int statValue)
    {
        switch (statValue)
        {
            case < 5:
                return -1;
            case < 10:
                return 0;
            case < 15:
                return 1;
            default:
                return 2;
            
        }
    }
}