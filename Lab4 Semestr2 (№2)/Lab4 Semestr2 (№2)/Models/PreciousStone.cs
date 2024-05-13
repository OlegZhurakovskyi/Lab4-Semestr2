using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Semestr2___2_.Models
{
    public class PreciousStone : Gemstone
    {
        public double Quality { get; set; }

        // Конструктор
        public PreciousStone(string name, double weightInCarats, double transparency, double quality, double price)
            : base(name, weightInCarats, transparency, price)
        {
            Quality = quality;
        }

        // Перевизначений метод для розрахунку вартості дорогоцінного каменя
        public override double CalculateValue()
        {
            // Розрахунок вартості на основі якості
            return base.CalculateValue() * Quality;
        }
    }
}
