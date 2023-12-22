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
                                if ((Convert.ToInt32(Dex_start_box) >=1) && (Convert.ToInt32(Con_start_box )>= 1) && (Convert.ToInt32(Inte_start_box) >= 1) && (Convert.ToInt32(Wis_start_box) >=1) && (Convert.ToInt32(Cha_start_box) >= 1) && (Convert.ToInt32(Str_start_box) >= 1)&&(Convert.ToInt32(Dex_start_box) <=20) && (Convert.ToInt32(Con_start_box) <=20) && (Convert.ToInt32(Inte_start_box) <= 20) && (Convert.ToInt32(Wis_start_box) <= 20) && (Convert.ToInt32(Cha_start_box) <= 20) && (Convert.ToInt32(Str_start_box) <= 20))
                                    { 
                                    Character_make = new Character(Convert.ToInt32(Str_start_box), Convert.ToInt32(Dex_start_box), Convert.ToInt32(Con_start_box), Convert.ToInt32(Inte_start_box), Convert.ToInt32(Wis_start_box), Convert.ToInt32(Cha_start_box), SelectedRase, SelectedClass);
                                    Str_cha = Character_make.stats.Str.ToString();
                                    Dex_cha = Character_make.stats.Dex.ToString();
                                    Con_cha = Character_make.stats.Con.ToString();
                                    Inte_cha = Character_make.stats.Inte.ToString();
                                    Wis_cha = Character_make.stats.Wis.ToString();
                                    Cha_cha = Character_make.stats.Cha.ToString();
                                    Str_dise_cha = Character_make.stats.Str_dise.ToString();
                                    Dex_dise_cha = Character_make.stats.Dex_dise.ToString();
                                    Con_dise_cha = Character_make.stats.Con_dise.ToString();
                                    Inte_dise_cha = Character_make.stats.Inte_dise.ToString();
                                    Wis_dise_cha = Character_make.stats.Wis_dise.ToString();
                                    Cha_dise_cha = Character_make.stats.Cha_dise.ToString();
                                    Rase_cha = Character_make.stats.Rase.Name;
                                    Class_cha = Character_make.stats.Game_class.Name;




                                }
                                else
                                {
                                    MessageBox.Show("Введите значение от 1 до 20");

                                }
                            }
                            else
                            {
                                MessageBox.Show("Введите значение от 1 до 20");

                            }

                        }
                        
                        else
                        {
                            MessageBox.Show("Заполнены не все поля");

                        }

                    }));
            }

        }
        private string str_cha;
        public string Str_cha
        {
            get { return str_cha; } 
            set { str_cha = value; OnPropertyChanged("Str_cha"); }

        }
        private string dex_cha;
        public string Dex_cha
        {
            get { return dex_cha; }
            set { dex_cha = value; OnPropertyChanged("Dex_cha"); }

        }


        private string con_cha;
        public string Con_cha
        {
            get { return con_cha; }
            set { con_cha = value; OnPropertyChanged("Con_cha"); }

        }


        private string inte_cha;
        public string Inte_cha
        {
            get { return inte_cha; }
            set { inte_cha = value; OnPropertyChanged("Inte_cha"); }

        }


        private string wis_cha;
        public string Wis_cha
        {
            get { return wis_cha; }
            set { wis_cha = value; OnPropertyChanged("Wis_cha"); }

        }


        private string cha_cha;
        public string Cha_cha
        {
            get { return cha_cha; }
            set { cha_cha = value; OnPropertyChanged("Cha_cha"); }

        }


        private string rase_cha;
        public string Rase_cha
        {
            get { return rase_cha; }
            set { rase_cha = value; OnPropertyChanged("Rase_cha"); }

        }


        private string class_cha;
        public string Class_cha
        {
            get { return class_cha; }
            set { class_cha = value; OnPropertyChanged("Class_cha"); }

        }


        private string str_dise_cha;
        public string Str_dise_cha
        {
            get { return str_dise_cha; }
            set { str_dise_cha = value; OnPropertyChanged("Str_dise_cha"); }

        }


        private string dex_dise_cha;
        public string Dex_dise_cha
        {
            get { return dex_dise_cha; }
            set { dex_dise_cha = value; OnPropertyChanged("Dex_dise_cha"); }

        }


        private string con_dise_cha;
        public string Con_dise_cha
        {
            get { return con_dise_cha; }
            set { con_dise_cha = value; OnPropertyChanged("Con_dise_cha"); }

        }


        private string inte_dise_cha;
        public string Inte_dise_cha
        {
            get { return inte_dise_cha; }
            set { inte_dise_cha = value; OnPropertyChanged("Inte_dise_cha"); }

        }


        private string wis_dise_cha;
        public string Wis_dise_cha
        {
            get { return wis_dise_cha; }
            set { wis_dise_cha = value; OnPropertyChanged("Wis_dise_cha"); }

        }


        private string cha_dise_cha;
        public string Cha_dise_cha
        {
            get { return cha_dise_cha; }
            set { cha_dise_cha = value; OnPropertyChanged("Cha_dise_cha"); }

        }

        private RelayCommand strGena;
        public RelayCommand StrGena
        {
            get
            {
                return strGena ??
                    (strGena = new RelayCommand(obj =>
                    {
                        int gen=0;
                        int min = 7;
                        int a = 0;
                        Random rnd = new Random();
                        for (int j = 0; j < 4; j++)
                        {
                            a = rnd.Next(1, 7);
                            gen += a;
                            if (a < min) min = a;
                        }
                        gen -= min;
                        Str_start_box = gen.ToString();
                    }));
            }
        }
        private RelayCommand dexGena;
        public RelayCommand DexGena
        {
            get
            {
                return dexGena ??
                    (dexGena = new RelayCommand(obj =>
                    {
                        int gen = 0;
                        int min = 7;
                        int a = 0;
                        Random rnd = new Random();
                        for (int j = 0; j < 4; j++)
                        {
                            a = rnd.Next(1, 7);
                            gen += a;
                            if (a < min) min = a;
                        }
                        gen -= min;
                        Dex_start_box = gen.ToString();
                    }));
            }
        }
        private RelayCommand conGena;
        public RelayCommand ConGena
        {
            get
            {
                return conGena ??
                    (conGena = new RelayCommand(obj =>
                    {
                        int gen = 0;
                        int min = 7;
                        int a = 0;
                        Random rnd = new Random();
                        for (int j = 0; j < 4; j++)
                        {
                            a = rnd.Next(1, 7);
                            gen += a;
                            if (a < min) min = a;
                        }
                        gen -= min;
                        Con_start_box = gen.ToString();
                    }));
            }
        }
        private RelayCommand inteGena;
        public RelayCommand InteGena
        {
            get
            {
                return inteGena ??
                    (inteGena = new RelayCommand(obj =>
                    {
                        int gen = 0;
                        int min = 7;
                        int a = 0;
                        Random rnd = new Random();
                        for (int j = 0; j < 4; j++)
                        {
                            a = rnd.Next(1, 7);
                            gen += a;
                            if (a < min) min = a;
                        }
                        gen -= min;
                        Inte_start_box = gen.ToString();
                    }));
            }
        }
        private RelayCommand wisGena;
        public RelayCommand WisGena
        {
            get
            {
                return wisGena ??
                    (wisGena = new RelayCommand(obj =>
                    {
                        int gen = 0;
                        int min = 7;
                        int a = 0;
                        Random rnd = new Random();
                        for (int j = 0; j < 4; j++)
                        {
                            a = rnd.Next(1, 7);
                            gen += a;
                            if (a < min) min = a;
                        }
                        gen -= min;
                        Wis_start_box = gen.ToString();
                    }));
            }
        }
        private RelayCommand chaGena;
        public RelayCommand ChaGena
        {
            get
            {
                return chaGena ??
                    (chaGena = new RelayCommand(obj =>
                    {
                        int gen = 0;
                        int min = 7;
                        int a = 0;
                        Random rnd = new Random();
                        for (int j = 0; j < 4; j++)
                        {
                            a = rnd.Next(1, 7);
                            gen += a;
                            if (a < min) min = a;
                        }
                        gen -= min;
                        Cha_start_box = gen.ToString();
                    }));
            }
        }
    }
}
