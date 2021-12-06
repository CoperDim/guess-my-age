using GuessMyAge.Models;

namespace GuessMyAge.Services
{
    public class PersonService : IPersonService
    {
        List<Person> persons = new List<Person>
            {
                new Person(74, "Steven Spielberg", "Réalisateur", Genre.Man, "Réalisateur, producteur et scénariste Américain. Connu entre autres pour ses films Jurassic Park, ET, Indiana Jones..."),
                new Person(67, "François Hollande", "Politique", Genre.Man, "Président de la République française du 15 mai 2012 au 14 mai 2017."),
                new Person(56, "Joanne Rowling", "Auteure", Genre.Woman, "Romancière britanique de livres pour enfants, notamment la série de livres Harry Potter" ),
                new Person(57, "Brad Pitt", "Réalisateur", Genre.Man, "Acteur américain, a joué dans Fight Club, Benjamin Button"),
                new Person(78, "Catherine Deneuve", "Réalisateur", Genre.Woman, "Actrice français dont les films les plus célèbres sont Les Parapluies de Cherbourg, Belle de jour, Le Dernier Métro ainsi qu'Indochine.")
            };
        public IEnumerable<Person> GetAll()
        {
            return persons;
        }

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
    }
}