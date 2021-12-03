using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_Zaliczeńowy_Zarys
{
    class Player
    {
        private string name;
        public int morale;
        public int money;
        public int inteligence;
        //statystyki startowe
        public Player(string name)
        {
            this.name = name;
            money = 50;
            morale = 50;
            inteligence = 0;
        }
        
        //ekran eksponujący aktualne statystyki
        public override string ToString()
        {
            return $"Gracz:{name} \n Morale:{morale} \n Inteligencja:{inteligence} \n Stan Konta:{money}";
        }
    }
}
