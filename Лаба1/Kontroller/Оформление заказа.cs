using ConsoleApp8.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;

namespace ConsoleApp8.Kontroller
{
    class OformlenieZakaza
    {
        public double Itogo { get; set; }
        public int Time { get; set; }
        public List<ZakazannoeBlyudo> MAX = new List<ZakazannoeBlyudo>();
        public List<ZakazDannie> MAX2 = new List<ZakazDannie>();
        public bool Vybrat (Bludo Eda, int Kolichvo)
        {
            ZakazannoeBlyudo aaa = new ZakazannoeBlyudo();
            aaa.bludo = Eda;
            aaa.Kolichestvo = Kolichvo;
            MAX.Add(aaa);
            return true;
        }
        public bool Sozdat()
        {
            Itogo = 0;
            foreach (ZakazannoeBlyudo MAX1 in MAX)
            {
                Itogo = MAX1.bludo.Prise * MAX1.Kolichestvo + Itogo;
            }

            Time = 0;
            foreach (ZakazannoeBlyudo MAX1 in MAX)
            {
                if (MAX1.bludo.Time > Time)
                {
                    Time = MAX1.bludo.Time;
                }
            }
            ZakazDannie aaa1 = new ZakazDannie();
            aaa1.SpisokBlyud = MAX;
            aaa1.Summa = Itogo;
            aaa1.Time = Time;
            MAX2.Add(aaa1);
            MAX = new List<ZakazannoeBlyudo>();
            return true;

        }
        
    }
}