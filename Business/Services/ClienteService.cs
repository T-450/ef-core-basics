using curso_ef_core.Data.Repository;
using curso_ef_core.Domain;
using System.Reflection;

namespace curso_ef_core.Business.Services
{
    public class ClienteService : ServiceBase, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task Adicionar(Cliente cliente)
        {
            if (_clienteRepository.Buscar(c => c.Id == cliente.Id).Result.Any())
            {
                throw new ArgumentException("Já Existe um cliente cadastrado", nameof(cliente));
            }

            if (IsAnyNullOrEmpty(cliente))
            {
                throw new ArgumentException("Já Existe um cliente cadastrado", nameof(cliente));
            }

            await _clienteRepository.Adicionar(cliente);
        }

        public async Task Atualizar(Cliente cliente)
        {
            if (_clienteRepository.Buscar(c => c.Nome == cliente.Nome).Result.Any())
            {
                throw new ArgumentException("Já Existe um cliente com o mesmo nome cadastrado", nameof(cliente));

            }

            await _clienteRepository.Atualizar(cliente);
        }

        public async Task Remover(Guid id)
        {
            if (!_clienteRepository.Buscar(c => c.Id == id).Result.Any())
            {
                throw new ArgumentException("Cliente não existe na base de dados", nameof(id));
            }

            await _clienteRepository.Remover(id);
        }

        public bool IsAnyNullOrEmpty(object myObject)
        {
            foreach (PropertyInfo pi in myObject.GetType().GetProperties())
            {
                if (pi.PropertyType == typeof(string))
                {
                    string value = (string)pi.GetValue(myObject);
                    if (string.IsNullOrEmpty(value))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
    }
}
