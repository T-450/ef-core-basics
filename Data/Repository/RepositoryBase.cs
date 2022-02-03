using curso_ef_core.Business;
using curso_ef_core.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace curso_ef_core.Data.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : Entity, new()
    {
        protected readonly ApplicationContext Db;
        protected readonly DbSet<T> DbSet;

        public RepositoryBase(ApplicationContext db)
        {
            Db = db;
            DbSet = db.Set<T>();
        }

        public virtual async Task Adicionar(T entity)
        {
            await DbSet.AddAsync(entity);
            await SaveChanges();
        }

        public async Task AdicionarMuitos(IEnumerable<T> entities)
        {
            await DbSet.AddRangeAsync(entities);
            await SaveChanges();
        }

        public virtual async Task<T> ObterPorId(Guid id)
            => await DbSet.FindAsync(id);

        public virtual async Task<List<T>> Obtertodos()
            => await DbSet.ToListAsync();

        public virtual async Task Atualizar(T entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }

        public virtual async Task Remover(Guid id)
        {
            var entity = new T { Id = id };
            DbSet.Remove(entity);
            await SaveChanges();
        }

        public virtual async Task<IEnumerable<T>> Buscar(Expression<Func<T, bool>> predicate)
            => await DbSet.AsNoTracking().Where(predicate).ToListAsync();

        public virtual async Task<int> SaveChanges()
            => await Db.SaveChangesAsync();

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
