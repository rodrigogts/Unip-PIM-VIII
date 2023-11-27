namespace MarketPlaceMecAcessoAPI.Model;

public class Carrinho
{
    public int Id { get; set; }
    public DateTime DataPedido { get; set; }
    public decimal ValorTotal { get; set; }
    public int StatusPedidoId { get; set; }
    public Cliente Cliente { get; set; }
    public List<Produto> Produtos { get; set; }
}
