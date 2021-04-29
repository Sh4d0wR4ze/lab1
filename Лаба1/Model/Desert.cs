using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp8.Model
{
    class Desert : Bludo
    {
        int _Time, _Number;
        double _Prise, _Sebestoimost;
        string _Name;
        public Desert (int time, double prise, string name, int number, double sebestoimost)
        {
            _Time = time;
            _Prise = prise;
            _Name = name;
            _Number = number;
            _Sebestoimost = sebestoimost;
        }
        public int Time { get => _Time; set => _Time = value; }
        public double Prise { get => _Prise; set => _Prise = value; }
        public string Name { get => _Name; set => _Name = value; }
        public int Number { get => _Number; set => _Number = value; }
        public double Sebestoimost { get => _Sebestoimost; set => _Sebestoimost = value; }
    }
}
