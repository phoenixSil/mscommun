namespace MsCommun.Repertoires.Contrats
{
    public interface IRepertoireGenerique<T> where T : class
    {
        public Task<IEnumerable<T>> Lire();
        public Task<T> Lire(Guid id);
        public Task<T> Ajoutter(T entite);
        public Task<T> Modifier(T entite);
        public Task<bool> Supprimer(T entite);
        public Task<bool> Exists(Guid id);
    }
}
