using System;



// Формат файла выбрать самостоятельно. В главной функции создать объект класса TouristicOperator и заполнить массив в диалоговом режиме
//(предварительно запросив размер массива у пользователя). Далее отсортировать массив. Вывести результат в файл.

namespace Vlasenko
{


    class Program
    {
        static void Main(string[] args)
        {
            TouristicOperator touristicOperator = new TouristicOperator();

            Console.WriteLine("Введите размер массива: ");

            int count = 0;
            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.WriteLine("Введите корректное число для массива");

            }

            for (int i = 0; i <= count; i++)
            {
                Console.Write($"Массив: {i + 1}");
            


            Console.Clear();
            Console.WriteLine("Введите продолжительность поездки: ");
            string prodol = Console.ReadLine();

            Console.WriteLine("Введите цену поездки:");
            double prise;
            while (!double.TryParse(Console.ReadLine(), out prise) || prise < 0)
            {
                Console.WriteLine("Введите корректное число для цены поездки");

            }

            Console.WriteLine("Введите размер группы:");
            int razmer;
            while (!int.TryParse(Console.ReadLine(), out razmer) || razmer < 0)
            {
                Console.WriteLine("Введите корректное число для размера группы");

            }

            Trip trip = new Trip(prodol, prise, razmer);
            touristicOperator.AddTrip(trip);

            touristicOperator.Sortirovka();
        }

            //Console.WriteLine("Введите имя файла:");
            string filename = "filename1.txt";
            touristicOperator.SaveToFile(filename);
            Console.WriteLine("Файл успешно сохранен:");

        }

        

    }
}
