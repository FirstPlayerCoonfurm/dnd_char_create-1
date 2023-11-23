using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnd_char_create.model.Base;
namespace dnd_char_create.model
{
    public class Rase : Notify
    {
        private int id;
        public int Id { get { return id; } set { id = value; OnPropertyChanged("Id"); } }

        private string name;
        public string Name { get { return name; } set { name = value; OnPropertyChanged("Name"); } }

        private string appearance;
        public string Appearance { get { return appearance; } set { appearance = value; OnPropertyChanged("Appearance"); } }

        private int str_bonus;
        public int Str_bonus { get { return str_bonus; } set { str_bonus = value; OnPropertyChanged("Str_bonus"); } }

        private int dex_bonus;
        public int Dex_bonus { get { return dex_bonus; } set { dex_bonus = value; OnPropertyChanged("Dex_bonus"); } }

        private int con_bonus;
        public int Con_bonus { get { return con_bonus; } set { con_bonus = value; OnPropertyChanged("Con_bonus"); } }

        private int inte_bonus;
        public int Inte_bonus { get { return inte_bonus; } set { inte_bonus = value; OnPropertyChanged("Inte_bonus"); } }

        private int wis_bonus;
        public int Wis_bonus { get { return wis_bonus; } set { wis_bonus = value; OnPropertyChanged("Wis_bonus"); } }

        private int cha_bonus;
        public int Cha_bonus { get { return cha_bonus; } set { cha_bonus = value; OnPropertyChanged("Cha_bonus"); } }

        private string rase_bonus;
        public string Rase_bonus { get { return rase_bonus; } set { rase_bonus = value; OnPropertyChanged("Cha_bonus"); } }
    }
}
