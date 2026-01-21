namespace Lab2.Classes
{
    public class City
    {
        public string Name { get; set; }
        public Dictionary<City, int> Paths { get; set; }

        public City(string name)
        {
            Name = name;
            Paths = new Dictionary<City, int>();
        }

        public City(string name, Dictionary<City, int> paths)
        {
            Name = name;
            Paths = paths;
        }

        public void AddPath(City city, int cost)
        {
            Paths[city] = cost;
        }

        public override string ToString()
        {
            string result = $"Город: {Name}";
            if (Paths.Count > 0)
            {
                result += "\nПути:";
                foreach (var path in Paths)
                {
                    result += $"\n  -> {path.Key.Name}: {path.Value}";
                }
            }
            return result;
        }
    }
}