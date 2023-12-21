using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.dataContext.Classes
{
    public static class Warlock
    {

        public static dndClass warlock { get; set; } = new dndClass()
        {
            Id = 8,
            Name = "Колдун",
            StrMain = 0,
            DexMain = 0,
            ConMain = 0,
            InteMain = 0,
            WisMain = 2,
            ChaMain = 2,
        }
        ;
    }
}
