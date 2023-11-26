using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MarketPlaceAspNet.Pages
{
    public class FormProdutosModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public FormProdutosModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}