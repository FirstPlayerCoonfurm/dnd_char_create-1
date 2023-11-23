using dnd_char_create.dataContext.Rases;
using dnd_char_create.model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.model
{
    public class Character
    {
        public stats stats;

        public Character()
        {
            stats = new stats()
            {
                Str_start = 10,
                Dex_start = 10,
                Con_start = 10,
                Inte_start = 10,
                Wis_start = 10,
                Cha_start = 10,
                Rase = Human.human
            };
        }
    }
}
