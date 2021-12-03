using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;

namespace Projekt_Zaliczeńowy_Zarys
{
    class Exam
        //egzamin skonstuowany jest tak aby pytania były zależne od inteligencji. Im mniejsza inteligencja tym trudniejsze pytania
    {

        public Exam(Player player)
        {
            int option = 0; //wersja testu
            int answer; //wybrana odpowiedź na pytanie
            int correctanswers = 0; //licznik poprawnych odpowiedzi
            //warunek który ustala wersję egzaminu
            if (player.inteligence <= 10)
            {
                option = 0;
            }
            else if (player.inteligence <= 50)
            {
                option = 1;
            }
            else if (player.inteligence <= 80)
            {
                option = 2;
            }
            else if (player.inteligence >= 100)
            {
                option = 3;
            }
            switch (option)
            {
                //najtrudniejszy zestaw pytań
                case 0:
                    Console.WriteLine("|-------------------------------------------------------------|\n");
                    Console.WriteLine("Kto wprowadził znak równowności (=) do zapisu matematycznego?\n");
                    Console.WriteLine("1. Euklides z Aleksandrii");
                    Console.WriteLine("2. Simon Stevin");
                    Console.WriteLine("3. Robert Rercorde\n");
                    Console.WriteLine("Wybierz poprawną odpowiedź (1, 2 lub 3)");
                    Console.WriteLine("|-------------------------------------------------------------|");
                    answer = Convert.ToInt32(Console.ReadLine()); //odebranie odpowiedzi od gracza
                    if (answer == 3)
                    {
                        correctanswers++; //zwiększenie licznika poprawnych odpowiedzi
                    }
                    Console.WriteLine("|-------------------------------------------------------------|\n");
                    Console.WriteLine("Jeden centylion - co to za liczba?\n");
                    Console.WriteLine("1. 10 do potęgi 42 ");
                    Console.WriteLine("2. 10 do potęgi 600");
                    Console.WriteLine("3. 10 do potęgi 1024\n");
                    Console.WriteLine("Wybierz poprawną odpowiedź (1, 2 lub 3)");
                    Console.WriteLine("|-------------------------------------------------------------|");
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 2)
                    {
                        correctanswers++;
                    }
                    Console.WriteLine("|-------------------------------------------------------------|\n");
                    Console.WriteLine("Za pomocą zasady Cavaleriego możemy:\n");
                    Console.WriteLine("1. Porównywać objętość brył");
                    Console.WriteLine("2. Znaleźć wszystkie liczby pierwsze w zadanym przedziale liczbowym");
                    Console.WriteLine("3. Szukać liczb pierwszych mniejszych od 2971\n");
                    Console.WriteLine("Wybierz poprawną odpowiedź (1, 2 lub 3)");
                    Console.WriteLine("|-------------------------------------------------------------|");
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 1)
                    {
                        correctanswers++;
                    }
                    break;
                case 1:
                    Console.WriteLine("|-------------------------------------------------------------|\n");
                    Console.WriteLine("Gdzie urodził się Fryderyk Chopin?\n");
                    Console.WriteLine("1. W Żelazowej woli");
                    Console.WriteLine("2. W Paryżu");
                    Console.WriteLine("3. Na Honolulu\n");
                    Console.WriteLine("Wybierz poprawną odpowiedź (1, 2 lub 3)");
                    Console.WriteLine("|-------------------------------------------------------------|");
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 1)
                    {
                        correctanswers++;
                    }
                    Console.WriteLine("|-------------------------------------------------------------|\n");
                    Console.WriteLine("Kto był autorem Iliady i Odysei?\n");
                    Console.WriteLine("1. Wisława Szymborska");
                    Console.WriteLine("2. Homer");
                    Console.WriteLine("3. J.K. Rowling\n");
                    Console.WriteLine("Wybierz poprawną odpowiedź (1, 2 lub 3)");
                    Console.WriteLine("|-------------------------------------------------------------|");
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 2)
                    {
                        correctanswers++;
                    }
                    Console.WriteLine("|-------------------------------------------------------------|\n");
                    Console.WriteLine("Kto rządzi Polską?\n");
                    Console.WriteLine("1. Andrzej Duda");
                    Console.WriteLine("2. Jarosław Kaczyński");
                    Console.WriteLine("3. Mateusz Morawiecki\n");
                    Console.WriteLine("Wybierz poprawną odpowiedź (1, 2 lub 3)");
                    Console.WriteLine("|-------------------------------------------------------------|");

                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 2)
                    {
                        correctanswers++;
                    }
                    break;
                    //test o średniej trudności
                case 2:
                    Console.WriteLine("|-------------------------------------------------------------|\n");
                    Console.WriteLine("Mikołaj Kopernik:\n");
                    Console.WriteLine("1. Wyszedł po mleko i nie wrócił");
                    Console.WriteLine("2. Był pierwszym człowiekiem w kosmosie");
                    Console.WriteLine("3. Wstrzymał Słońce, ruszył Ziemię\n");
                    Console.WriteLine("Wybierz poprawną odpowiedź (1, 2 lub 3)");
                    Console.WriteLine("|-------------------------------------------------------------|");
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 3)
                    {
                        correctanswers++;
                    }
                    Console.WriteLine("|-------------------------------------------------------------|\n");
                    Console.WriteLine("Ile było rozbiorów Polski?\n");
                    Console.WriteLine("1. Jeden");
                    Console.WriteLine("2. Trzy");
                    Console.WriteLine("3. Osiem\n");
                    Console.WriteLine("Wybierz poprawną odpowiedź (1, 2 lub 3)");
                    Console.WriteLine("|-------------------------------------------------------------|");
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 2)
                    {
                        correctanswers++;
                    }
                    Console.WriteLine("|-------------------------------------------------------------|\n");
                    Console.WriteLine("Jak nazywano królów starożytnych egipcjan?\n");
                    Console.WriteLine("1. Faraon");
                    Console.WriteLine("2. Prezydent");
                    Console.WriteLine("3. Dyktator\n");
                    Console.WriteLine("Wybierz poprawną odpowiedź (1, 2 lub 3)");
                    Console.WriteLine("|-------------------------------------------------------------|");
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 1)
                    {
                        correctanswers++;
                    }
                    break;

                    //najłatwiejszy test
                case 3:
                    Console.WriteLine("|-------------------------------------------------------------|\n");
                    Console.WriteLine("Ile jest 2+2?\n");
                    Console.WriteLine("1. Osiem");
                    Console.WriteLine("2. Czternaście");
                    Console.WriteLine("3. Cztery\n");
                    Console.WriteLine("Wybierz poprawną odpowiedź (1, 2 lub 3)");
                    Console.WriteLine("|-------------------------------------------------------------|");
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 3)
                    {
                        correctanswers++;
                    }
                    Console.WriteLine("|-------------------------------------------------------------|\n");
                    Console.WriteLine("Kto skonstruował pierwszy telefon?\n");
                    Console.WriteLine("1. Aleksander Bell");
                    Console.WriteLine("2. Nicola Tesla ");
                    Console.WriteLine("3. Albert Einstein\n");
                    Console.WriteLine("Wybierz poprawną odpowiedź (1, 2 lub 3)");
                    Console.WriteLine("|-------------------------------------------------------------|");
              
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 1)
                    {
                        correctanswers++;
                    }
                    Console.WriteLine("|-------------------------------------------------------------|\n");
                    Console.WriteLine("Jedno piwo to wstęp do trzech, a trzy to wstęp do: ?\n");
                    Console.WriteLine("1. Dziewięciu");
                    Console.WriteLine("2. Dwudziestu");
                    Console.WriteLine("3. Pięciu\n");
                    Console.WriteLine("Wybierz poprawną odpowiedź (1, 2 lub 3)");
                    Console.WriteLine("|-------------------------------------------------------------|");
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 1)
                    {
                        correctanswers++;
                    }
                   
                    break;
            }
            //podsumowanie egzaminu
            Console.WriteLine("Podsumowanie:");
            if (correctanswers >= 2)
            {
                //komunikat w przypadku zdania egzaminu 
                Console.WriteLine("Zdobyte punkty: " + correctanswers);
                Console.WriteLine("UDAŁO SIĘ! ZDAŁEŚ EGZAMIN!");
            }
            else
            {
                //komunikat w przypadku niezdania egzaminu
                Console.WriteLine("Zdobyte punkty: " + correctanswers);
                Console.WriteLine("NIE ZDAŁEŚ EGZAMINU! KONIEC GRY!");

            }
            //muzyka na koniec gry (motyw Mario)
Console.Beep(659, 125); 
Console.Beep(659, 125); 
Thread.Sleep(125); 
Console.Beep(659, 125); 
Thread.Sleep(167); 
Console.Beep(523, 125); 
Console.Beep(659, 125); 
Thread.Sleep(125); 
Console.Beep(784, 125); 
Thread.Sleep(375); 
Console.Beep(392, 125); 
Thread.Sleep(375); 
Console.Beep(523, 125); 
Thread.Sleep(250); 
Console.Beep(392, 125); 
Thread.Sleep(250); 
Console.Beep(330, 125); 
Thread.Sleep(250); 
Console.Beep(440, 125); 
Thread.Sleep(125); 
Console.Beep(494, 125); 
Thread.Sleep(125); 
Console.Beep(466, 125); 
Thread.Sleep(42); 
Console.Beep(440, 125); 
Thread.Sleep(125); 
Console.Beep(392, 125); 
Thread.Sleep(125); 
Console.Beep(659, 125); 
Thread.Sleep(125); 
Console.Beep(784, 125); 
Thread.Sleep(125); 
Console.Beep(880, 125); 
Thread.Sleep(125); 
Console.Beep(698, 125); 
Console.Beep(784, 125); 
Thread.Sleep(125); 
Console.Beep(659, 125); 
Thread.Sleep(125); 
Console.Beep(523, 125); 
Thread.Sleep(125); 
Console.Beep(587, 125); 
Console.Beep(494, 125); 
Thread.Sleep(125); 
Console.Beep(523, 125); 
Thread.Sleep(250); 
Console.Beep(392, 125); 
Thread.Sleep(250); 
Console.Beep(330, 125); 
Thread.Sleep(250); 
Console.Beep(440, 125); 
Thread.Sleep(125); 
Console.Beep(494, 125); 
Thread.Sleep(125); 
Console.Beep(466, 125); 
Thread.Sleep(42); 
Console.Beep(440, 125); 
Thread.Sleep(125); 
Console.Beep(392, 125); 
Thread.Sleep(125); 
Console.Beep(659, 125); 
Thread.Sleep(125); 
Console.Beep(784, 125); 
Thread.Sleep(125); 
Console.Beep(880, 125); 
Thread.Sleep(125); 
Console.Beep(698, 125); 
Console.Beep(784, 125); 
Thread.Sleep(125); 
Console.Beep(659, 125); 
Thread.Sleep(125); 
Console.Beep(523, 125); 
Thread.Sleep(125); 
Console.Beep(587, 125); 
Console.Beep(494, 125); 
Thread.Sleep(375); 
Console.Beep(784, 125); 
Console.Beep(740, 125); 
Console.Beep(698, 125); 
Thread.Sleep(42); 
Console.Beep(622, 125); 
Thread.Sleep(125); 
Console.Beep(659, 125); 
Thread.Sleep(167); 
Console.Beep(415, 125); 
Console.Beep(440, 125); 
Console.Beep(523, 125); 
Thread.Sleep(125); 
Console.Beep(440, 125); 
Console.Beep(523, 125); 
Console.Beep(587, 125); 
Thread.Sleep(250); 
Console.Beep(784, 125); 
Console.Beep(740, 125); 
Console.Beep(698, 125); 
Thread.Sleep(42); 
Console.Beep(622, 125); 
Thread.Sleep(125); 
Console.Beep(659, 125); 
Thread.Sleep(167); 
Console.Beep(698, 125); 
Thread.Sleep(125); 
Console.Beep(698, 125); 
Console.Beep(698, 125); 
Thread.Sleep(625); 
Console.Beep(784, 125); 
Console.Beep(740, 125); 
Console.Beep(698, 125); 
Thread.Sleep(42); 
Console.Beep(622, 125); 
Thread.Sleep(125); 
Console.Beep(659, 125); 
Thread.Sleep(167); 
Console.Beep(415, 125); 
Console.Beep(440, 125); 
Console.Beep(523, 125);
Thread.Sleep(125); 
Console.Beep(440, 125); 
Console.Beep(523, 125); 
Console.Beep(587, 125); 
Thread.Sleep(250); 
Console.Beep(622, 125); 
Thread.Sleep(250); 
Console.Beep(587, 125); 
Thread.Sleep(250); 
Console.Beep(523, 125); 
Thread.Sleep(1125); 
Console.Beep(784, 125);
Console.Beep(740, 125); 
Console.Beep(698, 125); 
Thread.Sleep(42); 
Console.Beep(622, 125); 
Thread.Sleep(125); 
Console.Beep(659, 125);
Thread.Sleep(167); 
Console.Beep(415, 125);
Console.Beep(440, 125);
Console.Beep(523, 125);
Thread.Sleep(125); 
Console.Beep(440, 125); 
Console.Beep(523, 125); 
Console.Beep(587, 125); 
Thread.Sleep(250); 
Console.Beep(784, 125); 
Console.Beep(740, 125); 
Console.Beep(698, 125); 
Thread.Sleep(42); 
Console.Beep(622, 125); 
Thread.Sleep(125); 
Console.Beep(659, 125); 
Thread.Sleep(167); 
Console.Beep(698, 125); 
Thread.Sleep(125); 
Console.Beep(698, 125); 
Console.Beep(698, 125); 
Thread.Sleep(625); 
Console.Beep(784, 125); 
Console.Beep(740, 125); 
Console.Beep(698, 125); 
Thread.Sleep(42); 
Console.Beep(622, 125); 
Thread.Sleep(125); 
Console.Beep(659, 125); 
Thread.Sleep(167); 
Console.Beep(415, 125); 
Console.Beep(440, 125); 
Console.Beep(523, 125); 
Thread.Sleep(125); 
Console.Beep(440, 125); 
Console.Beep(523, 125); 
Console.Beep(587, 125); 
Thread.Sleep(250); 
Console.Beep(622, 125); 
Thread.Sleep(250); 
Console.Beep(587, 125); 
Thread.Sleep(250); 
Console.Beep(523, 125);
            Console.WriteLine("Made by:\n Eliza Schwichtenberg \n Szymon Paluszewski \n Bartosz Suska \n Damian Kalita");
        }
    }
}
