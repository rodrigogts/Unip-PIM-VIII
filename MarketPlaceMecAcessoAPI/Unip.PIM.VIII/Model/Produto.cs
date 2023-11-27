namespace MarketPlaceMecAcessoAPI.Model;

public class Produto
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public string Imagem { get; set; }
    public bool Status { get; set; }
    public Vendedor Vendedor { get; set; }
    // Supondo que Categoria é outra classe, você precisaria definí-la também
    public Categoria Categoria { get; set; }
}
