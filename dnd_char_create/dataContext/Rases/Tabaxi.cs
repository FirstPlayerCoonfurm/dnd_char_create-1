using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.dataContext.Rases
{
    public static class Tabaxi
    {

        public static Rase tabaxi { get; set; } = new Rase()
        {
            Id = 4,
            Name = "Табакси",
            Appearance = "Антропоморфные кошачьи",
            Str_bonus = 0,
            Dex_bonus = 2,
            Con_bonus = 0,
            Inte_bonus = 0,
            Wis_bonus = 0,
            Cha_bonus = 1,
            Rase_bonus = "Тёмное зрение, Кошачье проворство, Кошачьи когти, Кошачьи способности, Языки: общий и любой на выбор"
        }
        ;
    }
}
