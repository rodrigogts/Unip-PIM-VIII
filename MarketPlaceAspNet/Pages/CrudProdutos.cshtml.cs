using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MarketPlaceAspNet.Pages
{
    public class CrudProdutosModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public CrudProdutosModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}