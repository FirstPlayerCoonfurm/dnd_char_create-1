using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using dnd_char_create.model.Base;

namespace dnd_char_create.model
{
    public class stats:Notify
    {
        
        private Rase rase;
        public Rase Rase { get { return rase; } set { rase = value;OnPropertyChanged("Rase"); } }
        private dndClass game_class;
        public dndClass Game_class { get { return game_class; } set { game_class = value; OnPropertyChanged("Rase"); } }


        private int str_start;
        public int Str_start { get { return str_start; } set { str_start = value; OnPropertyChanged("Str_start"); } }
        public int Str => rase.Str_bonus + str_start;
        public int Str_dise => game_class.StrMain + (int)((Str-10) / 2);



        private int dex_start;
        public int Dex_start { get { return dex_start; } set { dex_start = value; OnPropertyChanged("Dex_start"); } }
        public int Dex => rase.Dex_bonus + dex_start;
        public int Dex_dise => game_class.DexMain + (int)((Dex - 10) / 2);



        private int con_start;
        public int Con_start { get { return con_start; } set { con_start = value; OnPropertyChanged("Con_start"); } }
        public int Con => rase.Con_bonus + con_start;
        public int Con_dise => game_class.ConMain + (int)((Con - 10) / 2);



        private int inte_start;
        public int Inte_start { get { return inte_start; } set { inte_start = value; OnPropertyChanged("Inte_start"); } }
        public int Inte => rase.Inte_bonus + inte_start;
        public int Inte_dise => game_class.InteMain + (int)((Inte - 10) / 2);



        private int wis_start;
        public int Wis_start { get { return wis_start; } set { wis_start = value; OnPropertyChanged("Wis_start"); } }
        public int Wis => rase.Wis_bonus + wis_start;
        public int Wis_dise => game_class.WisMain + (int)((Wis - 10) / 2);



        private int cha_start;
        public int Cha_start { get { return cha_start; } set { cha_start = value; OnPropertyChanged("Cha_start"); } }
        public int Cha => rase.Cha_bonus + cha_start;
        public int Cha_dise => game_class.ChaMain + (int)((Cha - 10) / 2);


    }
}
