using System.Linq.Expressions;

namespace curso_ef_core.Data.Repository
{
    public interface IRepository<T> : IDisposable
    {
        Task Adicionar(T entity);
        Task AdicionarMuitos(IEnumerable<T> entities);
        Task<T> ObterPorId(Guid id);
        Task<List<T>> Obtertodos();
        Task Atualizar(T entity);
        Task Remover(Guid id);
        Task<IEnumerable<T>> Buscar(Expression<Func<T, bool>> predicate);
        Task<int> SaveChanges();
    }
}
