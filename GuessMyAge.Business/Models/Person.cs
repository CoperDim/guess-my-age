<<<<<<< HEAD
﻿using GuessMyAge.Business.Models;

namespace GuessMyAge.Business.Models
=======
﻿namespace GuessMyAge.Business.Models
>>>>>>> Partie1-Exercice9-Models
{
    public class Person
    {
        public int Age { get; private set; }
        public string Description { get; private set; }
        public string Name { get; private set; }
        public string Job { get; private set; }

        public Genre Genre { get; private set; }

        public Person(int age, string name, string job, Genre genre, string description)
        {
            Age = age;
            Description = description;
            Name = name;
            Job = job;
            Genre = genre;
        }
    }
}