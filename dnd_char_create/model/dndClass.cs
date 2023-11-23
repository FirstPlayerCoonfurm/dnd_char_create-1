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
        private string mainStats1;
        public string MainStats1{ get { return mainStats1; } set {mainStats1 = value; OnPropertyChanged("MainStats1"); } }
        private string mainStats2;
        public string MainStats2{ get { return mainStats2; } set {mainStats2 = value; OnPropertyChanged("MainStats2"); } }
        private string skills;
        public string Skills { get { return skills; } set { skills = value; OnPropertyChanged("skills"); } }
    }
}
