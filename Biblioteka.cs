using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_Zaliczeńowy_Zarys
{
    class Biblioteka
    {
        public Biblioteka(int time, Player player)
        {    
            //pętla odpowiadająca za ilość godzin przebytych w bibliotece         
            for (int i = 0; i < time; i++)
            {
                player.inteligence += 10;//zwiększenie ilości inteligencji 
                player.morale -= 10; //zmniejszenie ilości morali
            }
        }
    }
}
