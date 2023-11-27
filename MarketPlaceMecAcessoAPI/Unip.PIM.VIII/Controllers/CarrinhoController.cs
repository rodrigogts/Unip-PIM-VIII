using MarketPlaceMecAcessoAPI.Model;
using MarketPlaceMecAcessoAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlaceMecAcessoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CarrinhoController : ControllerBase
{
    private readonly IRepository<Carrinho> _carrinhoRepository;

    public CarrinhoController(IRepository<Carrinho> carrinhoRepository)
    {
        _carrinhoRepository = carrinhoRepository;
    }

    [HttpPost]
    public IActionResult Adicionar(Carrinho carrinho)
    {
        _carrinhoRepository.Adicionar(carrinho);
        return CreatedAtAction(nameof(ObterPorId), new { id = carrinho.Id }, carrinho);
    }

    [HttpGet("{id}")]
    public ActionResult<Carrinho> ObterPorId(int id)
    {
        var carrinho = _carrinhoRepository.ObterPorId(id);
        if (carrinho == null)
        {
            return NotFound();
        }
        return carrinho;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Carrinho>> ObterTodos()
    {
        var carrinhos = _carrinhoRepository.ObterTodos();
        return Ok(carrinhos);
    }

    [HttpPut("{id}")]
    public IActionResult Atualizar(int id, Carrinho carrinho)
    {
        if (id != carrinho.Id)
        {
            return BadRequest();
        }

        _carrinhoRepository.Atualizar(carrinho);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Excluir(int id)
    {
        var carrinhoExistente = _carrinhoRepository.ObterPorId(id);
        if (carrinhoExistente == null)
        {
            return NotFound();
        }

        _carrinhoRepository.Excluir(carrinhoExistente);
        return NoContent();
    }
}