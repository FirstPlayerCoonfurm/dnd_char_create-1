using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnd_char_create.model.Base;
using Labrary.Model.Base;
using System.Collections.ObjectModel;
using System.Windows;

namespace dnd_char_create.model
{
    
    public  class start :Notify
    {
        private Rase selectedRase;
        public Rase SelectedRase { get { return selectedRase; } set { selectedRase = value; OnPropertyChanged("SelectedRase"); } }
        private dndClass selectedClass;
        public dndClass SelectedClass { get { return selectedClass; } set { selectedClass = value; OnPropertyChanged("SelectedClass"); } }
        private RelayCommand rase_Chose;
        public RelayCommand Rase_Chose
        { get   
            {
                return rase_Chose ??
                    (rase_Chose = new RelayCommand(obj =>
                    {
                        if ((SelectedRase != null )&& (SelectedClass!= null))
                        {
                            MessageBox.Show("");

                        }

                    }));
                    } }
    }
}
