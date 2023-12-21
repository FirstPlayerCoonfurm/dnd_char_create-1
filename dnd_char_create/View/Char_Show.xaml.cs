using dnd_char_create.model;
using dnd_char_create.VIewModel;
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
using System.Windows.Shapes;

namespace dnd_char_create.View
{
    /// <summary>
    /// Логика взаимодействия для Char_Show.xaml
    /// </summary>
    public partial class Char_Show : Window
    {
        public Char_Show(Character character)
        {
            InitializeComponent();

            MainVM2 mainVM2 = new MainVM2(character);

            DataContext = mainVM2;
               
            
        }
    }
}
