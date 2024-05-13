using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Semestr2___2_.Models
{
    public class SemiPreciousStone : Gemstone
    {
        public string Color { get; set; }

        // Конструктор
        public SemiPreciousStone(string name, double weightInCarats, double transparency, string color, double price)
            : base(name, weightInCarats, transparency, price)
        {
            Color = color;
        }
    }
}
