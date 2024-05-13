using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Semestr2___2_.Models
{
    public class Gemstone
    {
        public string Name { get; set; }
        public double WeightInCarats { get; set; }
        public double Transparency { get; set; }
        public double Price { get; set; } // Додана властивість "ціна"

        // Конструктор
        public Gemstone(string name, double weightInCarats, double transparency, double price)
        {
            Name = name;
            WeightInCarats = weightInCarats;
            Transparency = transparency;
            Price = price;
        }

        // Метод для розрахунку вартості каменя
        public virtual double CalculateValue()
        {
            // Формула для розрахунку вартості на основі ваги, прозорості та ціни
            return WeightInCarats * Transparency * Price;
        }
    }
}
