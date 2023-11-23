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
        public Rase Rase { get { return Rase; } set { } }
        private int str_start;
        public int Str_start { get { return str_start; } set { str_start = value; OnPropertyChanged("Str_start"); } }
        private int str;
        public int Str { get { return str; } set { str = str_start + Rase.Str_bonus + value ; OnPropertyChanged("Str"); } }
        private int str_dise;   
        public int Str_dise { get { return str_dise; } set { str_dise = value; OnPropertyChanged("Str_dise"); } }


        private int dex_start;
        public int Dex_start { get { return dex_start; } set { dex_start = value; OnPropertyChanged("Dex_start"); } }
        private int dex;
        public int Dex { get { return dex; } set { dex = value; OnPropertyChanged("Dex"); } }
        private int dex_dise;
        public int Dex_dise { get { return dex_dise; } set { dex_dise = value; OnPropertyChanged("Dex_dise"); } }


        private int con_start;
        public int Con_start { get { return con_start; } set { con_start = value; OnPropertyChanged("Con_start"); } }
        private int con;
        public int Con { get { return con; } set { con = value; OnPropertyChanged("Con"); } }
        private int con_dise;
        public int Con_dise { get { return con_dise; } set { con_dise = value; OnPropertyChanged("Con_dise"); } }


        private int inte_start;
        public int Inte_start { get { return inte_start; } set { inte_start = value; OnPropertyChanged("Inte_start"); } }
        private int inte;
        public int Inte { get { return inte; } set { inte = value; OnPropertyChanged("Inte"); } }
        private int inte_dise;
        public int Inte_dise { get { return inte_dise; } set { inte_dise = value; OnPropertyChanged("Inte_dise"); } }


        private int wis_start;
        public int Wis_start { get { return wis_start; } set { wis_start = value; OnPropertyChanged("Wis_start"); } }
        private int wis;
        public int Wis { get { return wis; } set { wis = value; OnPropertyChanged("Wis"); } }
        private int wis_dise;
        public int Wis_dise { get { return wis_dise; } set { wis_dise = value; OnPropertyChanged("Wis_dise"); } }


        private int cha_start;
        public int Cha_start { get { return cha_start; } set { cha_start = value; OnPropertyChanged("Cha_start"); } }
        private int cha;
        public int Cha { get { return cha; } set { cha = value; OnPropertyChanged("Cha"); } }
        private int cha_dise;
        public int Cha_dise { get { return cha_dise; } set { cha_dise = value; OnPropertyChanged("Cha_dise"); } }
        
    }
}
