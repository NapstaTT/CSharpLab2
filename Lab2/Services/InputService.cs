#nullable enable

namespace Lab2.Services;

/// <summary>Сервис для безопасного ввода данных с клавиатуры.</summary>
public class InputService
{
    /// <summary>Считывает целое число, повторяя запрос при ошибке.</summary>
    /// <param name="prompt">Текст-подсказка, выводимая перед вводом.</param>
    public int ReadInt(string prompt)
    {
        Console.Write(prompt + " ");
        int result;
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Неверный ввод. Попробуйте снова: ");
        }
        return result;
    }

    /// <summary>Считывает вещественное число.</summary>
    /// <param name="prompt">Текст-подсказка, выводимая перед вводом.</param>
    public double ReadDouble(string prompt)
    {
        Console.Write(prompt + " ");
        double result;
        while (!double.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Неверный ввод. Попробуйте снова: ");
        }
        return result;
    }

    /// <summary>Считывает строку. Возвращает null, если введена пустая строка.</summary>
    /// <param name="prompt">Текст-подсказка, выводимая перед вводом.</param>
    public string? ReadString(string prompt)
    {
        Console.Write(prompt + " ");
        string? input = Console.ReadLine();
        return string.IsNullOrWhiteSpace(input) ? null : input;
    }
}
