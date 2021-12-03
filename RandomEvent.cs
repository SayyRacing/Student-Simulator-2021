using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Projekt_Zaliczeńowy_Zarys
{
    class RandomEvent
    {
        void Event(ref int value, int howMuch, bool plus)
        {
            //funkcja odpowiadająca za edycję poszczególnych parametrów klasy Player w zdarzeniu losowym
            if(plus) { value += howMuch; }
            else { value -= howMuch; }
        }
        //Ta funkcja odpowiada za wyświetlanie animowanego tekstu
        void WriteText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
        }

        public RandomEvent(Player player)
        {
            //Tu losowane jest jedno z 6 możliwych zdarzeń losowych
            Random random = new Random();
            int randomoption = random.Next(0, 7);

            switch (randomoption)
            {
                case 0:
                    Console.Beep(659, 125); //komunikat dźwiękowy
                    Console.Beep(659, 125);
                    Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|\n");
                    WriteText("Napotkałeś wojownika ortalionu który zabrał ci portfel [-50zł]\n");
                    Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|");
                    Event(ref player.money, 50, false);
                    Event(ref player.morale, 20, false);
                    break;
                case 1:
                    Console.Beep(659, 125);
                    Console.Beep(659, 125);
                    Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|\n");
                    WriteText("Podejrzany typ w garniturze proponuje ci zainwestowanie twoich pieniędzy, zgadzasz się? [-50zł]\n");
                    WriteText("1. Tak \n2. Nie\n");
                    Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Event(ref player.money, 50, false);
                            int invest = random.Next(2);
                            if (invest == 0) { Event(ref player.money, 100, true); 
                            Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|\n");
                                WriteText("Inwestycja się udała, twój kapitał został pomnożony o 100%\n");
                            Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|");  }

                            else if (invest != 0) { 
                                Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|\n");
                                WriteText("Inwestycja się nie powiodła, straciłeś swój kapitał\n");
                                Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|"); }
                            break;
                        case 2:
                            break;
                        default:
                            break;
                    }

                    break;
                case 2:
                    Console.Beep(659, 125);
                    Console.Beep(659, 125);
                    Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|\n");
                    WriteText("Kiedy wracałeś do domu, twój autobus odjechał ci przed nosem, a następny dopiero za godzinę [-20 Morale] \n");
                    Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|");
                    Event(ref player.morale, 20, false);
                    break;
                case 3:
                    Console.Beep(659, 125);
                    Console.Beep(659, 125);
                    Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|\n");
                    WriteText("Napotykasz pod sklepem starego mędrca, który za jedynie dwa złote oferuje ci podzielenie się swoją wiedzą, akceptujesz? [+10 Inteligencji -2 zł]\n");
                    WriteText("1. Tak \n2. Nie\n");
                    Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|");
                    int option1 = Convert.ToInt32(Console.ReadLine());
                    switch (option1)
                    {
                        case 1:
                            Event(ref player.inteligence, 10, true);
                            Event(ref player.money, 2, false);
                            break;
                        case 2:
                            break;
                        default:
                            break;
                    }                   
                    break;
                case 4:
                    Console.Beep(659, 125);
                    Console.Beep(659, 125);
                    Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|\n");
                    WriteText("Na swojej drodze napotykasz youtubera nagrywającego pranka. Po tym co zobaczyłeś od razu czujesz się głupszy [-20 Inteligencji]\n");
                    Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|");
                    Event(ref player.inteligence, 20, false);
                    break;
                case 5:
                    Console.Beep(659, 125);
                    Console.Beep(659, 125);
                    Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|\n");
                    WriteText("Napotykasz dżentelmena, który proponuje ci napad na hurtownie tanich wyrobów alkoholowych, zgadasz się? [???]\n");
                    WriteText("1. Tak \n2. Nie\n");
                    Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|");
                    int option2 = Convert.ToInt32(Console.ReadLine());
                    switch (option2)
                    {
                        case 1:
                            int heist = random.Next(2);
                            if (heist == 0)
                            {
                                Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|\n");
                                WriteText("Skok zakończył się pomyślnie, otrzymujesz swoją część z zarobku [+100 zł]\n");
                                Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|");
                                Event(ref player.money, 100, true);
                            }
                            else if (heist == 1)
                            {
                                Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|\n");
                                WriteText("Napad zakończył się niepowodzeniem, ponieważ Polonez którym uciekaliście z hurtowni uległ awarii" +
                                    "\n Na szczęście wartość skradzionych dóbr była na tak niska, że skończyło się tylko na grzywnie [-20 Morale, -100 zł]\n");
                                    Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|");
                                Event(ref player.money, 100, false);
                                Event(ref player.morale, 20, false);
                            }
                            break;
                        case 2:
                            break;
                        default:
                            break;
                    }
                    break;
                case 6:
                    {
                        Console.Beep(659, 125);
                        Console.Beep(659, 125);
                        Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|\n");
                        WriteText("Idąc chodnikiem, zauważasz na nim coś świecącego. Okazuje się że to 5 złotych [+20 Morale, +5zł]\n");
                        Console.WriteLine("|*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*|");
                        Event(ref player.money, 5, true);
                        Event(ref player.morale, 20, true);
                        break;
                    }
                    
                    
            }


        }
    }
}
