using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.dataContext.Rases
{
    public static class Halfling
    {

        public static Rase halfling { get; set; } = new Rase()
        {
            Id = 7,
            Name = "Полурослик",
            Appearance = "Хоббиты из ВК",
            Str_bonus = 0,
            Dex_bonus = 2,
            Con_bonus = 0,
            Inte_bonus = 0,
            Wis_bonus = 0,
            Cha_bonus = 0,
            Rase_bonus = "Везучий, Храбрый, Проворство полуросликов, Языки: общий и язык полуросликов"
        }
        ;
    }
}
