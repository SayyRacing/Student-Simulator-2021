using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Projekt_Zaliczeńowy_Zarys
{
    class Sklep
    {
        //animacja tekstu
        void WriteText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
        }
        //sprawdzenie wymaganej ilości pieniędzy 
        bool CheckMoney(int money, int cost)
        {
            if(money < cost)
            {
                WriteText("Nie masz tyle pieniędzy\n");
                return false;
            }
            return true;
        }
        //menu sklepu
        public Sklep(Player player)
        {
            Start:
            WriteText("Co chcesz kupić?\n");
            WriteText("1: Zupka Chińska[Morale +30 Cena 20zł]\n");
            WriteText("2: Chleb[Morale +60 Cena 35zł]\n");
            WriteText("3: Piwo[Morale +100 Cena 70zł]\n");
            WriteText("4: Wyjście ze sklepu\n");
                int userinput = Convert.ToInt32(Console.ReadLine()); //zmienna przechowywująca wybraną opcje w sklepie

            switch (userinput)
            {
                case 1:
                    if(CheckMoney(player.money, 20)) //sprawdzenie wymaganej ilości pieniędzy 
                    {
                        //zamiana statytyk w zależności od opcji
                        player.morale += 30;
                        player.money -= 20;
                    }
                    else
                    {
                        WriteText("Wybierz coś innego\n"); //komunikat w przypadku braku wymaganej kwoty 
                    }

                    break;
                case 2:
                    if (CheckMoney(player.money, 35))
                    {
                        player.morale += 60;
                        player.money -= 35;
                    }
                    else
                    {
                        WriteText("Wybierz coś innego\n");                        
                    }

                    break;
                case 3:
                    if (CheckMoney(player.money, 70))
                    {
                        player.morale += 100;
                        player.money -= 70;
                    }
                    else
                    {
                        WriteText("Wybierz coś innego\n");                 
                    }

                    break;
                case 4:
                    WriteText("Wychodzisz ze sklepu\n"); //komunikat przy wybraniu opcji wyjścia
                    break;
                default:
                    WriteText("Wybierz poprawną opcje!\n"); //komunikat w przypadku wybrania nieistniejącej opcji
                    goto Start;

            }
        }
    }
}
