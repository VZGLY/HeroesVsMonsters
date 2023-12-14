namespace HeroesVsMonsters.Personnages.Toolbox;

public static class ConsoleTools
{
    public static int ReadInt(string message, int min = int.MinValue, int max = int.MaxValue)
    {
        bool firstTry = true;
        int value;
        do
        {
            if (firstTry)
            {
                Console.WriteLine(message);
                firstTry = false;
            }
            else
            {
                Console.WriteLine("Veuillez reessayer...");
            }
            
            
        } while ( !int.TryParse(Console.ReadLine(), out value) && value < min && value > max);

        return value;
    }
}