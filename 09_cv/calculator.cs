using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_cv
{
    internal class Calculator : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _display = "0";
        private string _pamet = "";

        public string Display
        {
            get { return _display; }
            set
            {
                _display = value;
                //OnPropertyChanged("Display");
            }
        }

        public string Pamet
        {
            get { return _pamet; }
            set
            {
                _pamet = value;
                //OnPropertyChanged("Pamet");
            }
        }

        private enum Stav
        {
            PrvniCislo,
            Operace,
            DruheCislo,
            Vysledek
        };

        private Stav _stav = Stav.PrvniCislo;
        private double _cislo1 = 0;
        private double _cislo2 = 0;
        private string _operace = "";
        
        /*
        public Calculator()
        {
            _stav = Stav.PrvniCislo;
        }
        */

        public void Tlacitko(string tlacitko)
        {
            switch (_stav)
            {
                case Stav.PrvniCislo:
                    if (tlacitko == "C")
                    {
                        //_stav = Stav.PrvniCislo;
                        Display = "0";
                    }
                    else if (double.TryParse(tlacitko, out double cislo0))
                    {
                        if (Display == "0" && tlacitko != "0")
                            Display = tlacitko;
                        else
                            Display += tlacitko;
                    }
                    else if (tlacitko == ",")
                    {
                        if (!Display.Contains(","))
                            Display += ",";
                    }
                    else if (tlacitko == "+/-")
                    {
                        if (Display != "0" && double.TryParse(Display, out double cislo))
                        {
                            Display = (-cislo).ToString();
                        }
                    }
                    else if (tlacitko == "MS")
                    {
                        Pamet += Display;
                    }
                    else if (tlacitko == "M+" && Pamet != "")
                    {
                        Pamet = (double.Parse(Pamet) + double.Parse(Display)).ToString();
                    }
                    else if (tlacitko == "M-" && Pamet != "")
                    {
                        Pamet = (double.Parse(Pamet) - double.Parse(Display)).ToString();
                    }
                    else if (tlacitko == "MR" && Pamet != "")
                    {
                        Display = Pamet;
                    }
                    else if (tlacitko == "MC" && Pamet != "")
                    {
                        Pamet = "";
                    }
                    else if (tlacitko == "+" || tlacitko == "-" || tlacitko == "*" || tlacitko == "/")
                    {
                        _stav = Stav.DruheCislo;
                        _cislo1 = double.Parse(Display);
                        _operace = tlacitko;
                        //Display = tlacitko;
                        Display = "0";
                    }
                    break;

                case Stav.DruheCislo:
                    if (tlacitko == "C")
                    {
                        _stav = Stav.PrvniCislo;
                        Display = "0";
                    }
                    else if (double.TryParse(tlacitko, out double cislo1))
                    {
                        if (Display == "0" && tlacitko != "0")
                            Display = tlacitko;
                        else
                            Display += tlacitko;
                    }
                    else if (tlacitko == ",")
                    {
                        if (!Display.Contains(","))
                            Display += ",";
                    }
                    else if (tlacitko == "MS")
                    {
                        Pamet += Display;
                    }
                    else if (tlacitko == "M+" && Pamet != "")
                    {
                        Pamet = (double.Parse(Pamet) + double.Parse(Display)).ToString();
                    }
                    else if (tlacitko == "M-" && Pamet != "")
                    {
                        Pamet = (double.Parse(Pamet) - double.Parse(Display)).ToString();
                    }
                    else if (tlacitko == "MR" && Pamet != "")
                    {
                        Display = Pamet;
                    }
                    else if (tlacitko == "MC" && Pamet != "")
                    {
                        Pamet = "";
                    }
                    else if (tlacitko == "=")
                    {
                        _stav = Stav.Operace;
                        _cislo2 = double.Parse(Display);
                    }
                    break;

                case Stav.Operace:
                    if (double.TryParse(Display, out double cislo2))
                    {
                        switch (_operace)
                        {
                            case "+":
                                Display = (_cislo1 + _cislo2).ToString();
                                break;
                            case "-":
                                Display = (_cislo1 - _cislo2).ToString();
                                break;
                            case "*":
                                Display = (_cislo1 * _cislo2).ToString();
                                break;
                            case "/":
                                if (cislo2 != 0)
                                    Display = (_cislo1 / _cislo2).ToString();
                                else
                                    Display = "Error";
                                break;
                        }
                        _stav = Stav.Vysledek;
                    }
                    break;

                case Stav.Vysledek:
                    if (tlacitko == "C")
                    {
                        _stav = Stav.PrvniCislo;
                        Display = "0";
                    }
                    else if (double.TryParse(tlacitko, out double cislo3))
                    {
                        _stav = Stav.PrvniCislo;
                        Display = tlacitko;
                    }
                    break;
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
