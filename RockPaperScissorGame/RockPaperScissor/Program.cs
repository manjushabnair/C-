using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Program
    {
        enum SpielChoice
        {
            Schere,
            Stein,
            Papier,
        }

        enum Spielerin
        { 
            You,
            Computer,
            None,
        }
        static void Main(string[] args)
        {
            DisplayConsole();
            if (Enum.TryParse(Console.ReadLine(), out SpielChoice spielEinWahl))
            {
                Spielerin winner = Spielen(spielEinWahl);
                DisplayResult(winner.ToString());
            }
            Console.ReadLine();
        }

        private static void DisplayResult(string result)
        {
            Print(String.Format($"{result} won"));
        }

        private static void DisplayConsole()
        {
            Print("Lass uns Schere-Stein-Papier!");
            Print("Du bist Spieler 1 und ist der Computer Spieler 2!");
            Print("Schere, Stein oder Papier? Spiel du deine Wahl:");
        }

        private static Spielerin Spielen(SpielChoice Spiel_ein_Wahl)
        {
            Random random = new Random();
            var wahl = Enum.GetValues(typeof(SpielChoice));
            var comWahl = (SpielChoice)wahl.GetValue(random.Next(wahl.Length));
            Print(String.Format($"{Spielerin.Computer} played {comWahl}"));
            if (Spiel_ein_Wahl == comWahl)
            {
                return Spielerin.None;
            }
            if (Spiel_ein_Wahl == SpielChoice.Stein)
            {
                if (comWahl == SpielChoice.Papier)
                {
                    return (Spielerin.Computer);
                }
                else
                {
                    return (Spielerin.You);
                }
            }
            else 
            {
                if (Spiel_ein_Wahl == SpielChoice.Schere)
                {
                    if (comWahl == SpielChoice.Stein)
                    {
                        return (Spielerin.Computer);
                    }
                    else
                    {
                        return (Spielerin.You);
                    }
                }
                else 
                {
                    if (Spiel_ein_Wahl == SpielChoice.Papier)
                    {
                        if (comWahl == SpielChoice.Schere)
                        {
                            return (Spielerin.Computer);
                        }
                        else
                        {
                            return (Spielerin.You);
                        }
                    }
                }
            }

            return 0;
        }

        static void Print(string toPrint)
        {
            Console.WriteLine(toPrint);
        }
    }
}
