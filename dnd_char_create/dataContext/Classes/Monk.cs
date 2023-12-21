using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.dataContext.Classes
{
    public static class Monk
    {

        public static dndClass monk { get; set; } = new dndClass()
        {
            Id = 9,
            Name = "Монах",
            StrMain = 2,
            DexMain = 2,
            ConMain = 0,
            InteMain = 0,
            WisMain = 0,
            ChaMain = 0,
        }
        ;
    }
}
