
// See https://aka.ms/new-console-template for more information

using curso_ef_core.Business.Services;
using curso_ef_core.Data;
using curso_ef_core.Data.Repository;

using var db = new ApplicationContext();
ClienteRepository clienteRepository = new ClienteRepository(db);
var clienteService = new ClienteService(clienteRepository);



//using var db = new ApplicationContext();

//var existe = db.Database.GetPendingMigrations().Any();

//InserirDados();
//InserirDadosEmMassa();
//ConsultarDados();
//CadastrarPedido();
//ConsultarPedidoCarregamentoAdiantado();
//AtualizarDados();
//RemovendoDados()

//static void InserirDados()
//{
//    Produto produto = new()
//    {
//        Descricao = "Produto Teste",
//        CodigoBarras = "1234567891231",
//        Valor = 10m,
//        TipoProduto = TipoProduto.MercadoriaParaRevenda,
//        Ativo = true,
//    };

//    using var db = new ApplicationContext();
//    //db.Add(p);
//    //db.Set<Produto>().Add(p);
//    //db.Entry(p).State = EntityState.Added;
//    db.Add(produto);
//    int registros = db.SaveChanges();
//    Console.WriteLine($"Total Registros: {registros}");
//}
//static void InserirDadosEmMassa()
//{
//    Produto p = new()
//    {
//        Descricao = "Produto Teste 2",
//        CodigoBarras = "1234567891231",
//        Valor = 10m,
//        TipoProduto = TipoProduto.MercadoriaParaRevenda,
//        Ativo = true,
//    };

//    Cliente cliente = new()
//    {
//        Nome = "John Doe",
//        CEP = "9999000",
//        Cidade = "Curitiba",
//        Estado = "PR",
//        Telefone = "99000001111",
//    };

//    Cliente cliente2 = new()
//    {
//        Nome = "John Troe",
//        CEP = "9999000",
//        Cidade = "Curitiba",
//        Estado = "PR",
//        Telefone = "99000001122",
//    };

//    var listaDeClientes = new List<Cliente> { cliente, cliente2 };

//    using var db = new ApplicationContext();

//    db.AddRange(p, cliente);
//    //db.AddRange(listaDeClientes);
//    int registros = db.SaveChanges();
//    Console.WriteLine($"Total Registros Em Massa: {registros}");
//    Console.ReadKey();
//}

//static void ConsultarDados()
//{
//    using var db = new ApplicationContext();

//    foreach (var c in db.Clientes.AsNoTracking().Where(c => c.Id > 0).ToList())
//    {
//        Console.WriteLine($"{c.Nome}\n");
//    }

//}

//static void CadastrarPedido()
//{
//    using var db = new ApplicationContext();

//    var cliente = db.Clientes.FirstOrDefault();
//    var produto = db.Produtos.FirstOrDefault();

//    Pedido pedido = new()
//    {
//        ClienteId = cliente.Id,
//        IniciadoEm = DateTime.Now,
//        FinalizadoEm = DateTime.Now,
//        Observacao = "Pedido Teste",
//        Status = StatusPedido.Analise,
//        TipoFrete = TipoFrete.SemFrete,
//        PedidoItems = new List<PedidoItem>
//        {
//            new()
//            {
//                ProdutoId = produto.Id,
//                Desconto = 0,
//                Quantidade = 1,
//                Valor = 10
//            }
//        }
//    };

//    db.Pedidos.Add(pedido);
//    db.SaveChanges();
//}

//static void ConsultarPedidoCarregamentoAdiantado()
//{
//    using var db = new ApplicationContext();
//    var pedidos = db.Pedidos
//        .Include(p => p.PedidoItems)
//            .ThenInclude(p => p.Produto)
//        .ToList();

//    Console.WriteLine(pedidos.Count);
//    Console.ReadKey();
//}

//static void AtualizarDados()
//{
//    using var db = new ApplicationContext();
//    var clienteParaAtualizar = db.Clientes.Find(1);
//    var clienteDesconectado = new
//    {
//        Nome = "Cliente Desconectado",
//        Telefone = "33988044991",
//    };
//    db.Entry(clienteParaAtualizar).CurrentValues.SetValues(clienteDesconectado);

//    clienteParaAtualizar.Nome = "Cliente Alterado Passo 1";

//    //db.Entry(clienteParaAtualizar).State = EntityState.Modified;
//    //db.Update(clienteParaAtualizar);
//    db.SaveChanges();

//}

//static void RemovendoDados()
//{
//    using var db = new ApplicationContext();
//    var cliente = db.Clientes.Find(1);
//    db.Clientes.Remove(cliente);

//    // db.Entry(cliente).State = EntityState.Deleted;
//    // db.Update(clienteParaAtualizar);
//    db.SaveChanges();

//}
