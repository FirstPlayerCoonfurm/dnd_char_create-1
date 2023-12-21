using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.dataContext.Rases
{
    public static class Dwarf
    {

        public static Rase dwarf { get; set; } = new Rase()
        {
            Id = 3,
            Name = "Дварф",
            Appearance = "Коренастый коротышка",
            Str_bonus = 2,
            Dex_bonus = 0,
            Con_bonus = 2,
            Inte_bonus = 0,
            Wis_bonus = 0,
            Cha_bonus = 0,
            Rase_bonus = "Тёмное зрение, Дварфская устойчивость, Боевая тренировка, Знание камня, Языки: общий и дварфийский"
        }
        ;
    }
}
