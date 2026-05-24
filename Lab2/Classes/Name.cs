#nullable enable

namespace Lab2.Classes;

/// <summary>
/// Представляет ФИО человека. Отдельные части могут быть не заданы.
/// </summary>
public class Name
{
    private readonly string? _lastName;
    private readonly string? _firstName;
    private readonly string? _patronymic;

    /// <summary>
    /// Фамилия (может быть null).
    /// </summary>
    public string? LastName => _lastName;

    /// <summary>
    /// Имя (может быть null).
    /// </summary>
    public string? FirstName => _firstName;

    /// <summary>
    /// Отчество (может быть null).
    /// </summary>
    public string? Patronymic => _patronymic;

    /// <summary>
    /// Создаёт имя только по личному имени.
    /// </summary>
    /// <param name="firstName">Личное имя.</param>
    public Name(string firstName)
    {
        _firstName = firstName;
    }

    /// <summary>
    /// Создаёт имя по фамилии и личному имени.
    /// </summary>
    /// <param name="lastName">Фамилия.</param>
    /// <param name="firstName">Личное имя.</param>
    public Name(string lastName, string firstName)
    {
        _lastName = lastName;
        _firstName = firstName;
    }

    /// <summary>
    /// Создаёт полное имя: фамилия, личное имя, отчество.
    /// </summary>
    /// <param name="lastName">Фамилия.</param>
    /// <param name="firstName">Личное имя.</param>
    /// <param name="patronymic">Отчество.</param>
    public Name(string lastName, string firstName, string patronymic)
    {
        _lastName = lastName;
        _firstName = firstName;
        _patronymic = patronymic;
    }

    /// <summary>
    /// Возвращает строку в формате "Фамилия Имя Отчество", пропуская незаданные части.
    /// </summary>
    /// <returns>Текстовое представление имени.</returns>
    public override string ToString()
    {
        var parts = new List<string>();
        if (!string.IsNullOrEmpty(_lastName)) parts.Add(_lastName);
        if (!string.IsNullOrEmpty(_firstName)) parts.Add(_firstName);
        if (!string.IsNullOrEmpty(_patronymic)) parts.Add(_patronymic);
        return string.Join(" ", parts);
    }
}
