using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Инспекция
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // Генерируем случайное количество газет
            int kg = random.Next(1, 11);

            // Генерируем случайное количество страниц в каждой газете
            int[] ksg = new int[kg];
            for (int i = 0; i < kg; i++)
            {
                ksg[i] = random.Next(1, 17); // От 1 до 16 страниц
            }

            // Генерируем случайное количество журналов
            int kzh = random.Next(1, 11);

            // Генерируем случайное количество страниц в каждом журнале, чтобы их общее количество было больше, чем у газет
            int[] kszh = new int[kzh];
            int oksg = ksg.Sum();
            int okszh = 0;
            for (int i = 0; i < kzh; i++)
            {
                kszh[i] = random.Next(1, 17) + oksg / kzh; // Гарантируем, что общее количество страниц в журналах больше, чем у газет
                okszh += kszh[i];
            }

            // Вывод данных о газетах
            Console.WriteLine("Количество газет:" + kg);
            Console.WriteLine("Данные о газетах:");
            for (int i = 0; i < kg; i++)
            {
                Console.WriteLine("Газета {0}: {1} страниц", i + 1, ksg[i]);
            }

            // Вывод данных о журналах
            Console.WriteLine("Количество журналов:" + kzh);
            Console.WriteLine("Данные о журналах:");
            for (int i = 0; i < kzh; i++)
            {
                Console.WriteLine("Журнал {0}: {1} страниц", i + 1, kszh[i]);
            }

            // Вывод результата
            Console.WriteLine("Общее число страниц во всех газетах: " + oksg);
            Console.WriteLine("Общее число страниц во всех журналах: " + okszh);
            if (okszh > oksg)
            {
                Console.WriteLine("Общее количество страниц во всех журналах превышает общее количество страниц во всех газетах");
            }
            else
            {
                Console.WriteLine("Общее количество страниц во всех журналах НЕ превышает общее количество страниц во всех газетах");
            }
        }
    }
}