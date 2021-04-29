using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp8.Model
{
    class Eda
    {
        public List<Bludo> Edaa = new List<Bludo>();
        public Eda()
        {
            Bludo makarons = new Hot(10, 40, "Макарошки", 1, 15);
            Bludo Pure = new Hot(15, 100, "Пюрешка", 2, 0);
            Bludo kolbasa = new Hot(10, 80, "Колбаски", 3, 40);
            Bludo dima = new Cold(10, 150, "Блюдо для гурманов", 4, 70);
            Bludo pesok = new Cold(10, 250, "Салат с тертым грецким орехом", 5, 120);
            Bludo porosenok = new Cold(10, 200, "Жаренный свин", 6, 100);
            Bludo ledenez = new Desert(10, 25, "Леденцы", 7, 5.99);
            Bludo pystin9 = new Desert(5, 30, "Мороженое 'Пустыня'", 8, 15);
            Bludo sladost = new Desert(3, 50, "Фруктовый салатик", 9, 20);
            Bludo Baltika9 = new Drink(1, 50, "Лучшее пиво", 10, 39.99);
            Bludo wiski = new Drink(1, 300, "Whiskas", 11, 0);
            Bludo vodka = new Drink(1, 25, "Манна небесная", 12, 0);
            Bludo chipsi = new Snacks(10, 100, "Лейс", 13, 50);
            Bludo m9so = new Snacks(10, 100, "Вяленное мясо", 14, 50);
            Bludo Ovoschi = new Snacks(10, 85, "Овощи тушенные", 15, 40);
            Edaa.Add(makarons);
            Edaa.Add(Pure);
            Edaa.Add(dima);
            Edaa.Add(pesok);
            Edaa.Add(porosenok);
            Edaa.Add(ledenez);
            Edaa.Add(pystin9);
            Edaa.Add(sladost);
            Edaa.Add(kolbasa);
            Edaa.Add(Baltika9);
            Edaa.Add(wiski);
            Edaa.Add(vodka);
            Edaa.Add(chipsi);
            Edaa.Add(m9so);
            Edaa.Add(Ovoschi);
        }
        
        

    }
}
