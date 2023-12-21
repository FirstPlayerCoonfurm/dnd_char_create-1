using dnd_char_create.dataContext.Classes;
using dnd_char_create.dataContext.Rases;
using dnd_char_create.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using dnd_char_create.dataContext;
using dnd_char_create.model.Base;
using System.ComponentModel;
using dnd_char_create.VIewModel;

namespace dnd_char_create
{

    public partial class MainWindow : Window
    {
        MainVM mainVM = new MainVM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = mainVM;
            raseView.ItemsSource = new List<Rase>() { Human.human ,Elf.elf, Dwarf.dwarf, Gearforged.gearforged, Halfling.halfling, Tabaxi.tabaxi, Tiefling.tiefling, Orc.orc};

            //Character cha = new Character();
            
            classView.ItemsSource = new List<dndClass>() { Bard.bard, Barbarian.barbarian,Fighter.fighter, Wizard.wizard,Druid.druid,Cleric.cleric,Artificer.artificer,Warlock.warlock,Monk.monk,Paladin.paladin,Rogue.rogue,Ranger.ranger,Sorcerer.sorcerer};
        }
        
        

        
    }
}
