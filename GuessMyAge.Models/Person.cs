namespace GuessMyAge.Models
{
    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public DateTime BirthDate { get; set; }

        public Genre Genre { get; set; }

        public Person() { }

        public Person(int age, string name, string job, Genre genre, string description)
        {
            Age = age;
            Description = description;
            Name = name;
            Job = job;
        }

        public Person(DateTime birthDate, string name, string job, string genre, string description, int? id = null)
        {
            Id = id ?? 0;
            Age = new DateTime(DateTime.Now.Subtract(birthDate).Ticks).Year - 1;
            BirthDate = birthDate;
            Description = description;
            Name = name;
            Job = job;
            Genre parsedGenre = Genre.Man;
            Enum.TryParse(genre, out parsedGenre);
            Genre = parsedGenre;
        }
    }
}