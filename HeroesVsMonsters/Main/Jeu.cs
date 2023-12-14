using System.Threading.Channels;
using HeroesVsMonsters.Personnages.Heros;
using HeroesVsMonsters.Personnages.Monstres;
using HeroesVsMonsters.Personnages.Toolbox;

namespace HeroesVsMonsters.Main;

public class Jeu
{
    public static void Initialiser()
    {
        Console.WriteLine("Bonjour et bienvenu dans mon super jeu original fait de ma propre imagination sans meme l'avis de qui que ce soit....");
        Console.WriteLine("©️ GAVIN CHAINEUX");

        Console.WriteLine("Veuillez selectionner une race : ");
        Console.WriteLine("1. Humain");
        Console.WriteLine("2. Nain");

        int selection = ConsoleTools.ReadInt("Selection : ",1,2);

        Heros monHero = null;

        switch (selection)
        {
            case 1:
                monHero = new Humain();
                break;
            case 2:
                monHero = new Nain();
                break;
        }

        

        while (monHero?.PV > 0)
        {
            int nbrMonstre = new Random().Next(1,4);

            Monstre monstre = null;

            switch (nbrMonstre)
            {
                case 1:
                    monstre = new Loup();
                    Console.WriteLine("Un Loup Apparait !");
                    break;
                case 2 :
                    monstre = new Orcs();
                    Console.WriteLine("Un Orc Apparait !");
                    break;
                default:
                    monstre = new Dragonnet();
                    Console.WriteLine("Un Dragonnet Apparait !");
                    break;
            }

            

            bool TourJoueur = true;
            Console.WriteLine("Appuyez pour continuer...");
            Console.ReadLine();
            

            while (monHero.PV > 0 && monstre.PV > 0)
            {
                Console.Clear();
                Console.WriteLine("Hero : " + monHero);
                Console.WriteLine("Monstre : " + monstre);
                Console.WriteLine("Appuyez pour continuer...");
                Console.ReadLine();
                if (TourJoueur)
                {
                    int damage = monHero.Frappe(monstre);
                    Console.WriteLine($"Hero : Tiens ! prend ca dans ta mouille ! moins {damage} !");
                    Thread.Sleep(2000);
                }
                else
                {
                    int damage = monstre.Frappe(monHero);
                    Console.WriteLine($"Monstre : Grouhahahouhha {damage}");
                    Thread.Sleep(2000);
                }

                TourJoueur = !TourJoueur;

                if (monHero.PV <= 0)
                {
                    Console.WriteLine("Vous etes mort");
                }

                if (monstre.PV <= 0)
                {
                    Console.WriteLine("Monstre est mort");
                    monHero.Reposer();
                    monHero.Loot(monstre);
                    TourJoueur = true;
                }
                
            }
            
        }

        Console.WriteLine("Fin du jeu.");
        
        
    }
}