using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.dataContext.Rases
{
    public static class Human
    {
        public static Rase human { get; set; } = new Rase()
        {
            Id= 1,
            Name="Человек",
            Appearance="Обычный человек",
            Str_bonus=1,
            Dex_bonus=1,
            Con_bonus=1,
            Inte_bonus=1,
            Wis_bonus=1,
            Cha_bonus=1,
            Rase_bonus="Языки: общий и любой на выбор"
        };
    }
}
