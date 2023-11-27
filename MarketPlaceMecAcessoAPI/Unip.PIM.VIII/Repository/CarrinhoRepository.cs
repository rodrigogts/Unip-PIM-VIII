using MarketPlaceMecAcessoAPI.Model;
using MarketPlaceMecAcessoAPI.Service;

namespace MarketPlaceMecAcessoAPI.Repository;

public class CarrinhoRepository : IRepository<Carrinho>
{
    private readonly DatabaseContext _contexto;

    public CarrinhoRepository(DatabaseContext contexto)
    {
        _contexto = contexto;
    }
    
    public void Adicionar(Carrinho entidade)
    {
        _contexto.Carrinhos.Add(entidade);
        _contexto.SaveChanges();
    }

    public void Atualizar(Carrinho entidade)
    {
        _contexto.Carrinhos.Update(entidade);
        _contexto.SaveChanges();
    }

    public void Excluir(Carrinho entidade)
    {
        _contexto.Carrinhos.Remove(entidade);
        _contexto.SaveChanges();
    }

    public Carrinho ObterPorId(int id)
    {
        return _contexto.Carrinhos.FirstOrDefault(c => c.Id == id);
    }

    public List<Carrinho> ObterTodos()
    {
        return _contexto.Carrinhos.ToList();
    }
}