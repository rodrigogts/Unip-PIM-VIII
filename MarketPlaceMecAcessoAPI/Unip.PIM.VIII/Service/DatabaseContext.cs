using MarketPlaceMecAcessoAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace MarketPlaceMecAcessoAPI.Service;

public class DatabaseContext: DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options, 
        DbSet<Carrinho> carrinhos) : base(options)
    {
        Carrinhos = carrinhos;
    }

    public DbSet<Carrinho> Carrinhos { get; set; }
}

