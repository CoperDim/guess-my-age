using GuessMyAge.Business.Models;

namespace GuessMyAge.Business.Services
{
    public class PersonService : IPersonService
    {
        public IEnumerable<Person> GetAll()
        {
            return new List<Person>
            {
                new Person(74, "Steven Spielberg", "Réalisateur", Genre.Man, "Réalisateur, producteur et scénariste Américain. Connu entre autres pour ses films Jurassic Park, ET, Indiana Jones..."),
                new Person(67, "François Hollande", "Politique", Genre.Man, " Président de la République française du 15 mai 2012 au 14 mai 2017."),
                new Person(56, "Joanne Rowling", "Auteure", Genre.Woman, "Romancière britanique de livres pour enfants, notamment la série de livres Harry Potter" ),
                new Person(57, "Brad Pitt", "Réalisateur", Genre.Man, "Acteur américain, a joué dans Fight Club, Benjamin Button"),
<<<<<<< HEAD
                new Person(78, "Catherine Deneuve", "Réalisateur", Genre.Woman, "Actrice français dont les films les plus célèbres sont Les Parapluies de Cherbourg, Belle de jour, Le Dernier Métro ainsi qu'Indochine.")
            };
        }
    }
}
=======
                new Person(78, "Catherine Deneuve", "Actrice", Genre.Woman, "Actrice français dont les films les plus célèbres sont Les Parapluies de Cherbourg, Belle de jour, Le Dernier Métro ainsi qu'Indochine.")
            };
        }
    }
}
>>>>>>> Partie1-Exercice9-Models
