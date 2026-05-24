#nullable enable


namespace Lab2.Classes;

/// <summary>
/// Представляет город с именем и списком путей в другие города.
/// </summary>
public class City
{
    private readonly string _name;
    private readonly Dictionary<City, int> _paths;

    /// <summary>
    /// Название города.
    /// </summary>
    public string Name => _name;

    /// <summary>
    /// Доступ к путям только для чтения.
    /// </summary>
    public IReadOnlyDictionary<City, int> Paths => new ReadOnlyDictionary<City, int>(_paths);

    /// <summary>
    /// Создаёт город только с названием (без путей).
    /// </summary>
    /// <param name="name">Название города.</param>
    public City(string name)
    {
        _name = name ?? throw new ArgumentNullException(nameof(name));
        _paths = new Dictionary<City, int>();
    }

    /// <summary>
    /// Создаёт город с названием и начальным набором путей.
    /// </summary>
    /// <param name="name">Название города.</param>
    /// <param name="paths">Словарь (город -> стоимость).</param>
    public City(string name, Dictionary<City, int> paths)
    {
        _name = name ?? throw new ArgumentNullException(nameof(name));
        _paths = paths != null
            ? new Dictionary<City, int>(paths)
            : new Dictionary<City, int>();
    }

    /// <summary>
    /// Добавляет путь от текущего города к другому.
    /// </summary>
    /// <param name="city">Целевой город.</param>
    /// <param name="cost">Стоимость поездки.</param>
    public void AddPath(City city, int cost)
    {
        if (city == null) throw new ArgumentNullException(nameof(city));
        _paths[city] = cost;
    }

    /// <summary>
    /// Возвращает строковое представление города и его путей.
    /// </summary>
    /// <returns>Строка с названием и перечислением путей.</returns>
    public override string ToString()
    {
        var result = $"Город: {_name}";
        if (_paths.Count > 0)
        {
            result += "\nПути:";
            foreach (var path in _paths)
            {
                result += $"\n  -> {path.Key.Name}: {path.Value}";
            }
        }
        return result;
    }
}
