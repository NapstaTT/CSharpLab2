#nullable enable

using Lab2.Classes;
using Lab2.Services;

namespace Lab2;

public static class Program
{
    private static void Main()
    {
        var menu = new MenuService();
        var input = new InputService();

        bool isExit = false;
        while (!exit)
        {
            menu.ShowMainMenu();
            int choice = input.ReadInt("Выберите задание (1-5) или 0 для выхода:");

            switch (choice)
            {
                case 0: 
                {
                    exit = true; 
                    break;
                }
                case 1: 
                {
                    RunTask1(); 
                    break;
                }
                case 2: 
                {
                    RunTask2(); 
                    break;
                }
                case 3: 
                {
                    RunTask3(); 
                    break;
                }
                case 4: 
                {
                    RunTask4(); 
                    break;
                }
                case 5: 
                {
                    RunTask5(); 
                    break;
                }
                default: 
                {
                    Console.WriteLine("Неверный выбор."); 
                    break;
                }
            }
        }
    }

    private static void RunTask1()
    {
        Console.WriteLine("=== Задание 1.1: Точка ===");
        var p1 = new Point(1, 3);
        var p2 = new Point(23, 8);
        var p3 = new Point(5, 10);
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);

        Console.WriteLine("\n=== Задание 1.3: Имя ===");
        var name1 = new Name("Клеопатра");
        var name2 = new Name("Пушкин", "Александр", "Сергеевич");
        var name3 = new Name("Маяковский", "Владимир");
        Console.WriteLine(name1);
        Console.WriteLine(name2);
        Console.WriteLine(name3);
    }

    private static void RunTask2()
    {
        Console.WriteLine("=== Задание 2.1: Линия ===\n");

        // 1. Создаём Линию 1
        var line1Start = new Point(1, 3);
        var line1End = new Point(23, 8);
        var line1 = new Line(line1Start, line1End);
        Console.WriteLine($"Линия 1: {line1}");

        // 2. Создаём Линию 2 (горизонтальная, y=10, от x=5 до x=25)
        var line2Start = new Point(5, 10);
        var line2End = new Point(25, 10);
        var line2 = new Line(line2Start, line2End);
        Console.WriteLine($"Линия 2: {line2}");

        // 3. Создаём Линию 3: начало совпадает с началом Линии 1, конец – с концом Линии 2
        var line3 = new Line(line1.Start, line2.End);
        Console.WriteLine($"Линия 3 (связанная через объекты точек): {line3}");

        // 4. Меняем координаты первой и второй линий через изменение существующих точек
        Console.WriteLine("\n--- Изменяем координаты Линии 1 (начало) и Линии 2 (конец) ---");
        line1.Start.X = 10;
        line1.Start.Y = 5;
        line2.End.X = 30;
        line2.End.Y = 10;
        Console.WriteLine($"Линия 1 после изменения: {line1}");
        Console.WriteLine($"Линия 2 после изменения: {line2}");
        Console.WriteLine($"Линия 3 после изменения (должна измениться автоматически): {line3}");

        // 5. Изменяем Линию 1 так, чтобы Линия 3 не изменилась (присваиваем новую точку)
        Console.WriteLine("\n--- Присваиваем Линии 1 новую начальную точку (объект) ---");
        line1.Start = new Point(100, 100);
        Console.WriteLine($"Линия 1 после замены точки: {line1}");
        Console.WriteLine($"Линия 3 (осталась со старой точкой): {line3}");
    }

    private static void RunTask3()
    {
        Console.WriteLine("=== Задание 3.3: Города и пути ===");
        var cityA = new City("A");
        var cityB = new City("B");
        var cityC = new City("C");

        cityA.AddPath(cityB, 10);
        cityA.AddPath(cityC, 20);
        cityB.AddPath(cityC, 5);

        Console.WriteLine(cityA);
        Console.WriteLine(cityB);
        Console.WriteLine(cityC);
    }

    private static void RunTask4()
    {
        Console.WriteLine("=== Задание 4.8: Город (модифицированный) ===");
        var city1 = new City("Москва");
        Console.WriteLine(city1);

        var paths = new Dictionary<City, int>();
        var city2 = new City("Санкт-Петербург");
        paths.Add(city2, 700);
        var city3 = new City("Москва", paths);
        Console.WriteLine(city3);
    }

    private static void RunTask5()
    {
        Console.WriteLine("=== Задание 5.5: Дроби ===");
        var f1 = new Fraction(1, 2);
        var f2 = new Fraction(3, 4);
        var f3 = new Fraction(2, 3);

        Console.WriteLine($"{f1} + {f2} = {f1.Add(f2)}");
        Console.WriteLine($"{f1} - {f2} = {f1.Subtract(f2)}");
        Console.WriteLine($"{f1} * {f2} = {f1.Multiply(f2)}");
        Console.WriteLine($"{f1} / {f2} = {f1.Divide(f2)}");
        Console.WriteLine($"{f1} + 5 = {f1.Add(5)}");

        var result = f1.Add(f2).Divide(f3).Subtract(5);
        Console.WriteLine($"f1.Add(f2).Divide(f3).Subtract(5) = {result}");
    }
}
