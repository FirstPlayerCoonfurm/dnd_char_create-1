using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.dataContext.Classes
{
    public static class Artificer
    {

        public static dndClass artificer { get; set; } = new dndClass()
        {
            Id = 7,
            Name = "Изобретатель",
            StrMain = 0,
            DexMain = 0,
            ConMain = 2,
            InteMain = 2,
            WisMain = 0,
            ChaMain = 0,
        }
        ;
    }
}
