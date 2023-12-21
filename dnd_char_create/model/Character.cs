using dnd_char_create.dataContext.Classes;
using dnd_char_create.dataContext.Rases;
using dnd_char_create.model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.model
{
    public class Character:Notify
    {
        public stats stats;

        public Character(int str_start, int dex_start, int con_start, int inte_start, int wis_start, int cha_start, Rase rase, dndClass dndClass)
        {
            stats = new stats()
            {
                Str_start = str_start,
                Dex_start = dex_start,
                Con_start = con_start,
                Inte_start = inte_start,
                Wis_start = wis_start,
                Cha_start = cha_start,
                Rase = rase,
                Game_class = dndClass,
            };
        }
    }
}
