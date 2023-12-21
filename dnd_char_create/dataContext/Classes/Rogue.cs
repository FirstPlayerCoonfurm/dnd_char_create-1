using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.dataContext.Classes
{
    public static class Rogue
    {

        public static dndClass rogue { get; set; } = new dndClass()
        {
            Id = 11,
            Name = "Плут",
            StrMain = 0,
            DexMain = 2,
            ConMain = 0,
            InteMain = 2,
            WisMain = 0,
            ChaMain = 0,
        }
        ;
    }
}
