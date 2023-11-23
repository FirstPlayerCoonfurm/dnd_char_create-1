using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.dataContext.Rases
{
    public static class Elf
    {

        public static Rase elf { get; set; } = new Rase()
        {
            Id = 1,
            Name = "Эльф",
            Appearance = "Долгоживущий гуманоид с длинными острыми ушами",
            Str_bonus = 0,
            Dex_bonus = 2,
            Con_bonus = 0,
            Inte_bonus = 0,
            Wis_bonus = 0,
            Cha_bonus = 0,
            Rase_bonus = "Тёмное зрение, Обострённые чувства, Наследие фей, Транс, Языки: общий и любой на выбор"
        }
        ;
    }
}
