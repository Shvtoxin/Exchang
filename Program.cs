using System;

namespace obmen_valyt;

class Program
{
    static void Main(string[] args)
    {
        decimal kurs = 60.75m;
        decimal kom1 = 8.0m;
        decimal kom2 = 0.37m;
        var vnes = false;
        var rez = 0.0m;

        while (!vnes)
        {
            Console.Write("Введите количество долоров для обмена: ");
            vnes = decimal.TryParse(Console.ReadLine(), out rez);
        }
        var obmen = rez * kurs;
        if (rez > 500)
        {
            Console.WriteLine("Количество доларов больше 500. Коммисия будет 0,37%.");
            Console.WriteLine("Выдано: " + (obmen - ((obmen * kom2) / 100)) + "рублей.");
        }
        else
        {
            Console.WriteLine("Количество доларов меньше 500. Коммисия будет 8 рублей.");
            Console.WriteLine("Выдано: " + (obmen - kom1) + "рублей.");
        }

    }
}