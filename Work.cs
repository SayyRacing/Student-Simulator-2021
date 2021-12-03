using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_Zaliczeńowy_Zarys
{
    class Work
    {
        public Work(int time, Player player)
        {
            //pętla odpowiadająca za ilość godzin przebytych w pracy 
            for (int i = 0; i < time; i++)
            {
                player.money += 20; //zwiększenie ilości pieniędzy
                player.morale -= 15; //zmniejszenie ilości morali
            }
        }
    }
}
