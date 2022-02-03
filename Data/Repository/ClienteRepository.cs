using curso_ef_core.Domain;

namespace curso_ef_core.Data.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApplicationContext db) : base(db)
        {

        }
    }
}
