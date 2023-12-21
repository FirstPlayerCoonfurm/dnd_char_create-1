using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.dataContext.Rases
{
    public static class Tiefling
    {

        public static Rase tiefling { get; set; } = new Rase()
        {
            Id = 6,
            Name = "Тифлинг",
            Appearance = "Рогатые люди с красными оттенками кожи",
            Str_bonus = 0,
            Dex_bonus = 0,
            Con_bonus = 0,
            Inte_bonus = 1,
            Wis_bonus = 0,
            Cha_bonus = 2,
            Rase_bonus = "Тёмное зрение, Адское сопротивление, Дьявольское наследие, Языки: общий и инфернальный"
        }
        ;
    }
}
