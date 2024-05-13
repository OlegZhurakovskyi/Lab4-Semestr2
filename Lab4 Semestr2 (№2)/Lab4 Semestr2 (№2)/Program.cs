using Lab4_Semestr2___2_.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо об'єкти каменів з вказанням ціни
        PreciousStone diamond = new PreciousStone("Дiамант", 2.5, 0.9, 0.95, 5000); // Якість дорогоцінного каменя 0.95
        PreciousStone emerald = new PreciousStone("Смарагд", 3.0, 0.8, 0.90, 3000); // Якість дорогоцінного каменя 0.90
        SemiPreciousStone ruby = new SemiPreciousStone("Рубiн", 1.8, 0.7, "Червоний", 800);
        SemiPreciousStone sapphire = new SemiPreciousStone("Сапфiр", 2.2, 0.6, "Синiй", 700);

        // Створюємо намисто та додаємо камені
        Necklace necklace = new Necklace();
        necklace.AddGemstone(diamond);
        necklace.AddGemstone(emerald);
        necklace.AddGemstone(ruby);
        necklace.AddGemstone(sapphire);

        // Виводимо загальну вагу та вартість намиста
        Console.WriteLine("Загальна вага намиста: " + necklace.CalculateTotalWeight() + " карат");
        Console.WriteLine("Загальна вартiсть намиста: $" + necklace.CalculateTotalValue());

        // Сортуємо камені у намисті за цінністю
        necklace.Gemstones.Sort((x, y) => x.CalculateValue().CompareTo(y.CalculateValue()));

        // Виводимо відсортовані камені
        Console.WriteLine("\nКаменi в намистi вiдсортованi за вартiстю:");
        foreach (var stone in necklace.Gemstones)
        {
            Console.WriteLine($"{stone.Name} - Вартiсть: ${stone.CalculateValue():0.##}");
        }

        // Пошук каменів у намисті за діапазоном прозорості
        double minTransparency = 0.6;
        double maxTransparency = 0.8;
        var stonesInTransparencyRange = necklace.Gemstones.Where(stone => stone.Transparency >= minTransparency && stone.Transparency <= maxTransparency);

        // Виводимо камені, які відповідають заданому діапазону прозорості
        Console.WriteLine($"\nКаменi, якi вiдповiдають заданому дiапазону прозоростi вiд {minTransparency} до {maxTransparency}:");
        foreach (var stone in stonesInTransparencyRange)
        {
            Console.WriteLine($"{stone.Name} - Прозорiсть: {stone.Transparency}");
        }
    }
}