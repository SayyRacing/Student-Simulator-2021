using System;
using System.Threading;

namespace Projekt_Zaliczeńowy_Zarys
{


    class Program
    {
        
        static void RandomEventShow(int randomoption, int chances, Player player)
        {
            //Ta funkcja odpowaida za to czy wydarzy się zdarzenie losowe 
            if (randomoption <= chances)
            {
                RandomEvent randomEvent = new RandomEvent(player);
                Conf();
            }
        }

        static string Conf()
        {
            /*Ta funkcja wymusza na użytkowniku wciśnięcie klawisza na klawiaturze 
            Jest ona potrzebna ponieważ po każdej akcji czyszczona jest konsola a użytkownik musi zobaczyć wynik swojego działania*/
            Console.WriteLine("Wciśnij dowolny klawisz aby kontynuować");
            return Console.ReadLine();
        }

        static void WriteText(string text)
        {
            //Ta funkcja odpowiada za wyświetlanie animowanego tekstu
            foreach(char c in text)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
        }

        static void Main(string[] args)
        {
            string name;
            int option;
            int time;
            bool end = true;
            int day = 1;
            int examDay = 15;
            int daysToExam;
            Console.ForegroundColor = ConsoleColor.Cyan;           
         
            WriteText("Podaj swoje imię\n");
            
            name = Convert.ToString(Console.ReadLine());


            Player player = new Player(name);
            WriteText("Do sesji pozostało tylko 14 dni, a ty w ogóle się nie uczyłeś!\nJeżeli nie zdasz tego semsestru rodzice wyrzucą cię z domu, więc lepiej postaraj się przygotować!\n");
            Conf();
            while (end)
            {
            Start:
                Console.ResetColor();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("|----------------------STUDENT SIMULATOR----------------------|");  
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;                
                Console.WriteLine(player);
                Console.WriteLine("|-------------------------------------------------------------|");

                //To wbudowany zegar który odlicza dni do egzaminu
                daysToExam = examDay - day;
                if (daysToExam > 0) { Console.WriteLine("\nZostało " + daysToExam + " dni do egzaminu!"); }
                else { Console.WriteLine("\nDzisiaj Egzamin!"); }

                //To menu podróży
                Console.WriteLine("\nGdzie chciałbyś się udać? \n 1: Biblioteka \n 2: Praca \n 3: Sklep \n 4: Egzamin");
                Console.WriteLine("|-------------------------------------------------------------|");
                option = Convert.ToInt32(Console.ReadLine());

                //Ten fragment odpowiada za wylosowanie losowej liczby potrzebnej do wydarzenia losowego
                Random random = new Random();
                int randomoption = random.Next(0, 101);

                switch (option)
                {

                    //Case 1 odpowiada za opcje wybrania się do biblioteki
                    case 1:
                        if (daysToExam <= 0)
                        {
                            WriteText("Musisz dzisiaj iść na egzamin!\n");
                            Conf();
                            goto Start;
                        }

                        WriteText("Jak długo zamierzasz się uczyć w bibliotece? [1 godzina = -10 Morale +10 Inteligencja]\n");
                        
                        time = Convert.ToInt32(Console.ReadLine());

                        Biblioteka biblioteka = new Biblioteka(time, player);

                        RandomEventShow(randomoption, 30, player);
                        break;
                    case 2:
                        //Case 2 odpowiada za opcje wybrania się do do pracy
                        if (daysToExam <= 0)
                        {
                            WriteText("Musisz dzisiaj iść na egzamin!\n");
                            Conf();
                            goto Start;
                        }

                        WriteText("Jak długo zamierzasz pracować? [1 godzina = -15 Morale +19 Zł]\n");
                        time = Convert.ToInt32(Console.ReadLine());

                        Work work = new Work(time, player);

                        RandomEventShow(randomoption, 30, player);
                        break;
                    case 3:
                        //Case 3 odpowiada za opcje wybrania się do sklepu
                        if (daysToExam <= 0)
                        {

                            //Ten if uniemożliwi graczowi wybranie się w dane miejsce jeżeli musi udać sie na egzamin
                            WriteText("Musisz dzisiaj iść na egzamin!\n");
                            Conf();

                            goto Start;
                        }

                        Sklep sklep = new Sklep(player);

                        RandomEventShow(randomoption, 30, player);
                        break;
                    case 4:
                        //Case 4 odpowiada za opcje wybrania się na egzamin
                        if (daysToExam <= 0)
                        {
                            Exam exam = new Exam(player);
                            end = false;
                        }
                        else
                        {
                            //ten if uniemożliwi udanie się egzamin jeżeli w dany dzień go nie ma
                            WriteText("Dzisiaj nie ma egzaminu!\n");
                            Conf();

                            goto Start;
                        }
                        break;
                    case 98:
                        //Kod oszukujący pozwalający na zamknięcie gry 
                        end = false;
                        break;
                    case 99:
                        //Kod oszukujący pozwalający na wywołanie zdarzenia losowego
                        RandomEventShow(randomoption, 100, player);

                        break;
                    default:
                        //Ten fragment uniemożliwia wybranie innej opcji niż te podane w menu i kody oszukujące 
                        WriteText("Wybierz poprawną opcje!\n");
                        goto Start;
                }

                //W tym miejscu następuje postęp czasu
                day++;

                if (player.morale <= 0)
                {
                    //ekran końcowy w przypadku porażki wynikającej z zbyt niskiego morale
                    WriteText("Popadłeś w depresję, przegrywasz!\n");
                    Conf();
                    end = false;
                }

                //W tym miejscu normalizowne są wartości poszczególnych parametrów klasy Player(Morale nie może przekroczyć 100, Pieniądze nie mogą spaść poniżej 0)
                player.morale = Math.Min(player.morale, 100);
                player.money = Math.Max(player.money, 0);


            }
        }
    }
}
