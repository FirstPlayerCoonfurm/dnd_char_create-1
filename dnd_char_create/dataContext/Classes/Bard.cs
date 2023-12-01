using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.dataContext.Classes
{
    public static class Bard
    {

        public static dndClass bard { get; set; } = new dndClass()
        {
            Id = 1,
            Name = "Бард",
            StrMain = 0,
            DexMain = 2,
            ConMain = 0,
            InteMain = 0,
            WisMain = 0,
            ChaMain = 2,
        }
        ;
    }
}
