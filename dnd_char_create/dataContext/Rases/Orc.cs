using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.dataContext.Rases
{
    public static class Orc
    {

        public static Rase orc { get; set; } = new Rase()
        {
            Id = 8,
            Name = "Орк",
            Appearance = "Большой зелёный гуманоид",
            Str_bonus = 2,
            Dex_bonus = 0,
            Con_bonus = 1,
            Inte_bonus = 0,
            Wis_bonus = 0,
            Cha_bonus = 0,
            Rase_bonus = "Тёмное зрение, Агрессивный, Чутьё дикаря, Мощное телосложение, Языки: общий и орочий"
        }
        ;
    }
}
