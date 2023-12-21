using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_char_create.dataContext.Classes
{
    public static class Wizard
    {

        public static dndClass wizard { get; set; } = new dndClass()
        {
            Id = 4,
            Name = "Волшебник",
            StrMain = 0,
            DexMain = 0,
            ConMain = 0,
            InteMain = 2,
            WisMain = 2,
            ChaMain = 0,
        }
        ;
    }
}
