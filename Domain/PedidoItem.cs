﻿namespace curso_ef_core.Domain;

public class PedidoItem : Entity
{
    public int PedidoId { get; set; }
    public Pedido Pedido { get; set; }
    public int ProdutoId { get; set; }
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal Valor { get; set; }
    public decimal Desconto { get; set; }
}