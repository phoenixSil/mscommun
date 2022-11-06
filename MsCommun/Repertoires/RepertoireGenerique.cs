using Microsoft.EntityFrameworkCore;
using MsCommun.Repertoires.Contrats;

namespace MsCommun.Repertoires
{
    public class RepertoireGenerique<T> :  IRepertoireGenerique<T>
        where T : class
        {

        private readonly DbContext _dbContext;
        public RepertoireGenerique(DbContext context)
        {
            _dbContext = context;
        }
        public async Task<T> Ajoutter(T entite)
        {
            await _dbContext.AddAsync(entite);
            await _dbContext.SaveChangesAsync();
            return entite;
        }

        public async Task<IEnumerable<T>> Lire()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> Lire(Guid id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> Modifier(T entite)
        {
            try
            {
                _dbContext.Entry(entite).State = EntityState.Modified;
                return entite;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public async Task<bool> Supprimer(T entite)
        {
            _dbContext.Set<T>().Remove(entite);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Exists(Guid id)
        {
            var entity = await Lire(id);
            return entity != null;
        }
    }
}