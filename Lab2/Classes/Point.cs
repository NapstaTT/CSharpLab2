#nullable enable

namespace Lab2.Classes;

/// <summary>
/// Представляет точку на двумерной плоскости. Координаты можно изменять.
/// </summary>
public class Point
{
    private double _x;
    private double _y;

    /// <summary>Координата X.</summary>
    public double X
    {
        get => _x;
        set => _x = value;
    }

    /// <summary>Координата Y.</summary>
    public double Y
    {
        get => _y;
        set => _y = value;
    }

    /// <summary>Создаёт новую точку.</summary>
    /// <param name="x">Координата X.</param>
    /// <param name="y">Координата Y.</param>
    public Point(double x, double y)
    {
        _x = x;
        _y = y;
    }

    /// <summary>Возвращает текстовое представление в формате "X;Y".</summary>
    public override string ToString() => $"{_x};{_y}";
}
