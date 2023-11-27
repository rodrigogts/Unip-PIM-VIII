namespace MarketPlaceMecAcessoAPI.Model;

public class Vendedor
{
    public int Id { get; set; }
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    public string CNPJ { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public decimal Comissao { get; set; }
    public Endereco Endereco { get; set; }
}
