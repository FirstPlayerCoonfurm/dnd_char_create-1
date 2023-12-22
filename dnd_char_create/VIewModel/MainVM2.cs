using dnd_char_create.model;
using dnd_char_create.model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnd_char_create;

namespace dnd_char_create.VIewModel
{
    public class MainVM2 :Notify
    {
        Character character;
        public MainVM2(Character cr)
        {
            character = cr;
        }


        private string str_cha;
        public string Str_cha
        { 
            get { return character.stats.Str.ToString(); } 
        }


        private string dex_cha;
        public string Dex_cha
        {
            get { return character.stats.Dex.ToString(); }
        }


        private string con_cha;
        public string Con_cha
        {
            get { return character.stats.Con.ToString(); }
        }


        private string inte_cha;
        public string Inte_cha
        {
            get { return character.stats.Inte.ToString(); }
        }


        private string wis_cha;
        public string Wis_cha
        {
            get { return character.stats.Wis.ToString(); }
        }


        private string cha_cha;
        public string Cha_cha
        {
            get { return character.stats.Cha.ToString(); }
        }


        private string rase_cha;
        public string Rase_cha
        {
            get { return character.stats.Rase.Name; }
        }


        private string class_cha;
        public string Class_cha
        {
            get { return character.stats.Game_class.Name; }
        }


        private string str_dise_cha;
        public string Str_dise_cha
        {
            get { return character.stats.Str_dise.ToString(); }
        }


        private string dex_dise_cha;
        public string Dex_dise_cha
        {
            get { return character.stats.Dex_dise.ToString(); }
        }


        private string con_dise_cha;
        public string Con_dise_cha
        {
            get { return character.stats.Con_dise.ToString(); }
        }


        private string inte_dise_cha;
        public string Inte_dise_cha
        {
            get { return character.stats.Inte_dise.ToString(); }
        }


        private string wis_dise_cha;
        public string Wis_dise_cha
        {
            get { return character.stats.Wis_dise.ToString(); }
        }


        private string cha_dise_cha;
        public string Cha_dise_cha
        {
            get { return character.stats.Cha_dise.ToString(); }
        }
        
    }
}
