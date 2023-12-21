using dnd_char_create.model;
using dnd_char_create.model.Base;
using dnd_char_create.View;
using Labrary.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace dnd_char_create.VIewModel
{
    public class MainVM : Notify
    {
        private string str_start_box;
        public string Str_start_box
        {
            get { return str_start_box; }
            set
            {
                str_start_box = value;
                OnPropertyChanged(nameof(Str_start_box));
            }
        }
        private string dex_start_box;
        public string Dex_start_box
        {
            get { return dex_start_box; }
            set
            {
                dex_start_box = value;
                OnPropertyChanged(nameof(Dex_start_box));
            }
        }
        private string con_start_box;
        public string Con_start_box
        {
            get { return con_start_box; }
            set
            {
                con_start_box = value;
                OnPropertyChanged(nameof(Con_start_box));
            }
        }
        private string inte_start_box;
        public string Inte_start_box
        {
            get { return inte_start_box; }
            set
            {
                inte_start_box = value;
                OnPropertyChanged(nameof(Inte_start_box));
            }
        }
        private string wis_start_box;
        public string Wis_start_box
        {
            get { return wis_start_box; }
            set
            {
                wis_start_box = value;
                OnPropertyChanged(nameof(Wis_start_box));
            }
        }
        private string cha_start_box;
        public string Cha_start_box
        {
            get { return cha_start_box; }
            set
            {
                cha_start_box = value;
                OnPropertyChanged(nameof(Cha_start_box));
            }
        }
        private Character character_make;
        public Character Character_make
        {
            get { return character_make; }
            set
            {
                character_make = value;
                OnPropertyChanged(nameof(Character_make));
            }
        }

        private Rase selectedRase;
        public Rase SelectedRase
        {
            get { return selectedRase; }
            set
            {
                selectedRase = value;
                OnPropertyChanged(nameof(SelectedRase));
            }
        }
        private dndClass selectedClass;
        public dndClass SelectedClass
        {
            get { return selectedClass; }
            set
            {
                selectedClass = value;
                OnPropertyChanged(nameof(SelectedClass));
            }
        }
        private string lab;
        public string Lab
        {
            get { return lab; }
            set { lab = value; OnPropertyChanged(nameof(Lab)); }
        }

        private RelayCommand stats_create;
        public RelayCommand Stats_create
        {
            get
            {
                return stats_create ??
                    (stats_create = new RelayCommand(obj =>
                    {
                        int[] arr = { 0, 0, 0, 0, 0, 0 };
                        int min = 7;
                        int a = 0;
                        Random rnd = new Random();
                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                a = rnd.Next(1, 6);
                                arr[i] += a;
                                if (a < min) min = a;
                            }
                            arr[i] -= min;
                            min = 7;
                        }
                        Lab = arr[0].ToString() + " " + arr[1].ToString() + " " + arr[2].ToString() + " " + arr[3].ToString() + " " + arr[4].ToString() + " " + arr[5].ToString();
                    }));
            }
        }
        private RelayCommand char_create;
        public RelayCommand Char_create
        {
            get
            {
                return char_create ??
                    (char_create = new RelayCommand(obj =>
                    {
                        if ((SelectedRase != null) && (SelectedClass != null) && (Dex_start_box != null) && (Con_start_box != null) && (Inte_start_box != null) && (Wis_start_box != null) && (Cha_start_box != null) && (Str_start_box != null))
                        {
                            string check_cha="1";
                            bool check_t_f = true;
                            for (int i=0;i<6; i++)
                            {
                                if (i == 0) 
                                {
                                    check_cha = Str_start_box;
                                }
                                if (i == 1)
                                {
                                    check_cha = Dex_start_box;
                                }
                                if (i == 2)
                                {
                                    check_cha = Con_start_box;
                                }
                                if (i == 3)
                                {
                                    check_cha = Inte_start_box;
                                }
                                if (i == 4)
                                {
                                    check_cha = Wis_start_box;
                                }
                                if (i == 5)
                                {
                                    check_cha = Cha_start_box;
                                }
                                for (int j = 0; j < check_cha.Length; j++)
                                {
                                    if (!(check_cha[j] >= '0' && check_cha[j] <= '9'))
                                    {
                                        check_t_f=false;
                                        break;
                                    }
                                    
                                }
                                if (!check_t_f)
                                {
                                    break;
                                }
                            }
                            if (check_t_f)
                            {
                                Character_make = new Character(Convert.ToInt32(Str_start_box), Convert.ToInt32(Dex_start_box), Convert.ToInt32(Con_start_box), Convert.ToInt32(Inte_start_box), Convert.ToInt32(Wis_start_box), Convert.ToInt32(Cha_start_box), SelectedRase, SelectedClass);

                                Char_Show ch = new Char_Show(Character_make);
                                ch.Show();
                            }
                            else
                            {
                                MessageBox.Show("Поля заполнены некорректно");

                            }

                        }
                        
                        else
                        {
                            MessageBox.Show("Заполнены не все поля");

                        }

                    }));
            }
        }
    }
}
