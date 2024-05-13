using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Semestr2___2_.Models
{
    public class Necklace
    {
        public List<Gemstone> Gemstones { get; set; }

        // Конструктор
        public Necklace()
        {
            Gemstones = new List<Gemstone>();
        }

        // Додати камінь до намиста
        public void AddGemstone(Gemstone stone)
        {
            Gemstones.Add(stone);
        }

        // Загальна вага намиста в каратах
        public double CalculateTotalWeight()
        {
            return Gemstones.Sum(stone => stone.WeightInCarats);
        }

        // Загальна вартість намиста в доларах
        public double CalculateTotalValue()
        {
            return Gemstones.Sum(stone => stone.CalculateValue());
        }
    }
}
