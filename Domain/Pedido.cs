using curso_ef_core.ValueObjects;

namespace curso_ef_core.Domain
{
    public class Pedido : Entity
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime IniciadoEm { get; set; }
        public DateTime FinalizadoEm { get; set; }
        public TipoFrete TipoFrete { get; set; }
        public StatusPedido Status { get; set; }
        public string Observacao { get; set; }
        public ICollection<PedidoItem> PedidoItems { get; set; }
    }
}
