using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.dataContext.Classes
{
    public static class Sorcerer
    {

        public static dndClass sorcerer { get; set; } = new dndClass()
        {
            Id = 13,
            Name = "Чародей",
            StrMain = 0,
            DexMain = 0,
            ConMain = 2,
            InteMain = 0,
            WisMain = 0,
            ChaMain = 2,
        }
        ;
    }
}
