using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddGamesList
{   
    class Program
    {
        //static private string avsluta;
        static void Main(string[] args)
        {
            GameInformation games = new GameInformation();
            List<GameInformation> game = new List<GameInformation>();
            string avsluta = string.Empty;
            do
            {
                try
                {

                    Console.Write("Mata in en titel på ett spel: ");
                    string title = Console.ReadLine();


                    Console.Write("Vilket år släpptes spelet: ");
                    int releaseDate = Convert.ToInt32(Console.ReadLine());

                    game.Add(new GameInformation { Title = title, ReleaseDate = releaseDate });

                    Console.WriteLine("\nIfall du vill mata ut hela spellistan så matar du in 'Avsluta'. \nAnnars kan du bara klicka enter för att fortsätta lägga till spel i listan!");
                    avsluta = Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            while (avsluta != "Avsluta" && avsluta != "avsluta");

            foreach (var gameinfo in game)
            {
                Console.WriteLine($"Titel: {gameinfo.Title} \nUtgivningsår: {gameinfo.ReleaseDate}\n");
            }
            Console.ReadLine();
        }
    }
}
