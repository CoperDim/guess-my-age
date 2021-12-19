using Microsoft.EntityFrameworkCore;

namespace GuessMyAge.Database.Repositories;

// Ici, le concept de base, on va pouvoir faire un GetAll car on peut utiliser la même méthode mais tu peux aussi le faire pour le create/update etc...
// Le <T> est un élément générique, cela signifie qu'il attend juste n'importe quelle classe
// abstract signifie que la classe doit être héritée, elle ne peut pas être seule
public abstract class BaseRepository<T>
where T: class
{
    protected readonly GuessMyAgeDbContext _dbContext;

    protected readonly DbSet<T> _dbSet;

    protected BaseRepository(GuessMyAgeDbContext context)
    {
        _dbContext = context;
        _dbSet = _dbContext.Set<T>();
    }
    // Ici on ajoute virtual si on veut laisser la possibilité de surcharger la méthode par une autre méthode

    public virtual IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }
}