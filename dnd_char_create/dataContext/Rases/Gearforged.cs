using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.dataContext.Rases
{
    public static class Gearforged
    {

        public static Rase gearforged { get; set; } = new Rase()
        {
            Id = 5,
            Name = "Кованный",
            Appearance = "Живые роботы",
            Str_bonus = 0,
            Dex_bonus = 0,
            Con_bonus = 2,
            Inte_bonus = 0,
            Wis_bonus = 0,
            Cha_bonus = 2,
            Rase_bonus = "Механическое тело, Стальная плоть, Прочная конструкция, Языки: общий и C#"
        }
        ;
    }
}
