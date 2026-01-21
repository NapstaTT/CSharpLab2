namespace Lab2.Classes
{
    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }

        public Name(string firstName)
        {
            FirstName = firstName;
        }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Name(string firstName, string lastName, string patronymic)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
        }

        public override string ToString()
        {
            string result = "";
            if (!string.IsNullOrEmpty(LastName)) result += LastName + " ";
            if (!string.IsNullOrEmpty(FirstName)) result += FirstName + " ";
            if (!string.IsNullOrEmpty(Patronymic)) result += Patronymic;
            return result.Trim();
        }
    }
}