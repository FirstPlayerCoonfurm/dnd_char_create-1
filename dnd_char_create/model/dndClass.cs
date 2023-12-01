using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnd_char_create.model.Base;
namespace dnd_char_create.model
{
    public class dndClass : Notify
    {
        private int id;
        public int Id { get { return id; } set { id = value; OnPropertyChanged("Id"); } }
        private string name;
        public string Name { get { return name; } set { name = value; OnPropertyChanged("Name"); } }
        private int strMain;
        public int StrMain { get { return strMain; } set { strMain = value; OnPropertyChanged("StrMain"); } }


        private int dexMain;
        public int DexMain { get { return dexMain; } set { dexMain = value; OnPropertyChanged("DexMain"); } }


        private int conMain;
        public int ConMain { get { return conMain; } set { conMain = value; OnPropertyChanged("ConMain"); } }


        private int inteMain;
        public int InteMain { get { return inteMain; } set { inteMain = value; OnPropertyChanged("InteMain"); } }


        private int wisMain;
        public int WisMain { get { return wisMain; } set { wisMain = value; OnPropertyChanged("WisMain"); } }


        private int chaMain;
        public int ChaMain { get { return chaMain; } set { chaMain = value; OnPropertyChanged("chaMain"); } }
    }
}
