#nullable enable

namespace Lab2.Classes;

/// <summary>
/// Представляет математическую дробь с целыми числителем и знаменателем.
/// Дробь неизменяема.
/// </summary>
public class Fraction
{
    private readonly int _numerator;
    private readonly int _denominator;

    /// <summary>
    /// Числитель дроби.
    /// </summary>
    public int Numerator => _numerator;

    /// <summary>
    /// Знаменатель дроби (всегда положительный).
    /// </summary>
    public int Denominator => _denominator;

    /// <summary>
    /// Создаёт дробь с указанными числителем и знаменателем.
    /// </summary>
    /// <param name="numerator">Числитель.</param>
    /// <param name="denominator">Знаменатель (не может быть 0).</param>
    /// <exception cref="ArgumentException">Если знаменатель равен 0.</exception>
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Знаменатель не может быть нулём.", nameof(denominator));

        // Приводим знаменатель к положительному числу
        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }

        _numerator = numerator;
        _denominator = denominator;
    }

    /// <summary>
    /// Сложение с другой дробью.
    /// </summary>
    /// <param name="other">Другая дробь.</param>
    /// <returns>Новая дробь – результат сложения.</returns>
    public Fraction Add(Fraction other)
    {
        if (other == null) throw new ArgumentNullException(nameof(other));
        int newNum = _numerator * other._denominator + other._numerator * _denominator;
        int newDen = _denominator * other._denominator;
        return new Fraction(newNum, newDen).Simplify();
    }

    /// <summary>
    /// Сложение с целым числом.
    /// </summary>
    /// <param name="number">Целое число.</param>
    /// <returns>Новая дробь.</returns>
    public Fraction Add(int number) => Add(new Fraction(number, 1));

    /// <summary>
    /// Вычитание другой дроби.
    /// </summary>
    /// <param name="other">Другая дробь.</param>
    /// <returns>Новая дробь – разность.</returns>
    public Fraction Subtract(Fraction other)
    {
        if (other == null) throw new ArgumentNullException(nameof(other));
        int newNum = _numerator * other._denominator - other._numerator * _denominator;
        int newDen = _denominator * other._denominator;
        return new Fraction(newNum, newDen).Simplify();
    }

    /// <summary>
    /// Вычитание целого числа.
    /// </summary>
    /// <param name="number">Целое число.</param>
    /// <returns>Новая дробь.</returns>
    public Fraction Subtract(int number) => Subtract(new Fraction(number, 1));

    /// <summary>
    /// Умножение на другую дробь.
    /// </summary>
    /// <param name="other">Другая дробь.</param>
    /// <returns>Новая дробь – произведение.</returns>
    public Fraction Multiply(Fraction other)
    {
        if (other == null) throw new ArgumentNullException(nameof(other));
        return new Fraction(_numerator * other._numerator, _denominator * other._denominator).Simplify();
    }

    /// <summary>
    /// Умножение на целое число.
    /// </summary>
    /// <param name="number">Целое число.</param>
    /// <returns>Новая дробь.</returns>
    public Fraction Multiply(int number) => Multiply(new Fraction(number, 1));

    /// <summary>
    /// Деление на другую дробь.
    /// </summary>
    /// <param name="other">Другая дробь.</param>
    /// <returns>Новая дробь – частное.</returns>
    public Fraction Divide(Fraction other)
    {
        if (other == null) throw new ArgumentNullException(nameof(other));
        if (other._numerator == 0)
            throw new DivideByZeroException("Деление на дробь с нулевым числителем.");
        return new Fraction(_numerator * other._denominator, _denominator * other._numerator).Simplify();
    }

    /// <summary>
    /// Деление на целое число.
    /// </summary>
    /// <param name="number">Целое число (не может быть 0).</param>
    /// <returns>Новая дробь.</returns>
    public Fraction Divide(int number)
    {
        if (number == 0) throw new DivideByZeroException("Деление на ноль.");
        return Divide(new Fraction(number, 1));
    }

    /// <summary>
    /// Упрощает дробь (сокращает на НОД).
    /// </summary>
    /// <returns>Новая упрощённая дробь.</returns>
    private Fraction Simplify()
    {
        int gcd = Gcd(Math.Abs(_numerator), Math.Abs(_denominator));
        return new Fraction(_numerator / gcd, _denominator / gcd);
    }

    private static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    /// <summary>
    /// Возвращает строковое представление дроби в формате "числитель/знаменатель".
    /// </summary>
    /// <returns>Строка вида "N/D".</returns>
    public override string ToString() => $"{_numerator}/{_denominator}";
}
