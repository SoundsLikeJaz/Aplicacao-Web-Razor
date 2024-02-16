using AplicacaoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicacaoWeb.Pages
{
    public class IndexModel : PageModel

        
    {
        public Produto prod { get; set; }

        public List<Produto> ProdutoList { get; set; }

        public string nome;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            nome = "Desenvolver uma aplicação com ASPNET Core";
            prod = new Produto();
            
            prod.Id = 1;
            prod.Nome = "Coca-Cola";
            prod.Valor = 5.99;

            ProdutoList = new List<Produto>();
            ProdutoList.Add(prod);
            ProdutoList.Add(new Produto { Id = 5, Nome = "Pepsi", Valor = 4.99 });
            ProdutoList.Add(new Produto { Id = 6, Nome = "Fanta", Valor = 6.99 });


        }
    }
}
