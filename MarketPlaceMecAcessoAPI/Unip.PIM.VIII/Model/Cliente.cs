namespace MarketPlaceMecAcessoAPI.Model;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    // Supondo que Endereco é outra classe, você precisaria definí-la também
    public Endereco Endereco { get; set; }
}
