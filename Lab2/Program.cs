using Lab2.Classes;
using Lab2.Services;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuService menu = new MenuService();
            InputService input = new InputService();

            bool exit = false;

            while (!exit)
            {
                menu.ShowMainMenu();
                int choice = input.ReadInt("Выберите задание (1-5) или 0 для выхода:");

                switch (choice)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        RunTask1();
                        break;
                    case 2:
                        RunTask2();
                        break;
                    case 3:
                        RunTask3();
                        break;
                    case 4:
                        RunTask4();
                        break;
                    case 5:
                        RunTask5();
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }

        static void RunTask1()
        {
            Console.WriteLine("=== Задание 1.1: Точка ===");
            Point p1 = new Point(1, 3);
            Point p2 = new Point(23, 8);
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.WriteLine("\n=== Задание 1.3: Имя ===");
            Name name1 = new Name("Клеопатра");
            Name name2 = new Name("Александр", "Пушкин", "Сергеевич");
            Name name3 = new Name("Владимир", "Маяковский");
            Console.WriteLine(name1);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
        }

        static void RunTask2()
        {
            Console.WriteLine("=== Задание 2.1: Линия ===");
            Point start = new Point(1, 3);
            Point end = new Point(23, 8);
            Line line = new Line(start, end);
            Console.WriteLine(line);
        }

        static void RunTask3()
        {
            Console.WriteLine("=== Задание 3.3: Города и пути ===");
            City cityA = new City("A");
            City cityB = new City("B");
            City cityC = new City("C");

            cityA.AddPath(cityB, 10);
            cityA.AddPath(cityC, 20);
            cityB.AddPath(cityC, 5);

            Console.WriteLine(cityA);
            Console.WriteLine(cityB);
            Console.WriteLine(cityC);
        }

        static void RunTask4()
        {
            Console.WriteLine("=== Задание 4.8: Город (модифицированный) ===");
            City city1 = new City("Москва");
            Console.WriteLine(city1);

            Dictionary<City, int> paths = new Dictionary<City, int>();
            City city2 = new City("Санкт-Петербург");
            paths.Add(city2, 700);
            City city3 = new City("Москва", paths);
            Console.WriteLine(city3);
        }

        static void RunTask5()
        {
            Console.WriteLine("=== Задание 5.5: Дроби ===");
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);
            Fraction f3 = new Fraction(2, 3);

            Console.WriteLine($"{f1} + {f2} = {f1.Add(f2)}");
            Console.WriteLine($"{f1} - {f2} = {f1.Subtract(f2)}");
            Console.WriteLine($"{f1} * {f2} = {f1.Multiply(f2)}");
            Console.WriteLine($"{f1} / {f2} = {f1.Divide(f2)}");
            Console.WriteLine($"{f1} + 5 = {f1.Add(5)}");

            Fraction result = f1.Add(f2).Divide(f3).Subtract(5);
            Console.WriteLine($"f1.Add(f2).Divide(f3).Subtract(5) = {result}");
        }
    }
} 