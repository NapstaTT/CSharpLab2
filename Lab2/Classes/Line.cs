#nullable enable

namespace Lab2.Classes;

/// <summary>Представляет отрезок прямой на плоскости.</summary>
public class Line
{
    private Point _start;
    private Point _end;

    /// <summary>Начальная точка линии.</summary>
    public Point Start
    {
        get => _start;
        set => _start = value ?? throw new ArgumentNullException(nameof(value));
    }

    /// <summary>Конечная точка линии.</summary>
    public Point End
    {
        get => _end;
        set => _end = value ?? throw new ArgumentNullException(nameof(value));
    }

    /// <summary>Создаёт линию по начальной и конечной точкам.</summary>
    public Line(Point start, Point end)
    {
        _start = start ?? throw new ArgumentNullException(nameof(start));
        _end = end ?? throw new ArgumentNullException(nameof(end));
    }

    /// <summary>Возвращает текстовое представление линии.</summary>
    public override string ToString() => $"Линия от {{{_start}}} до {{{_end}}}";
}
