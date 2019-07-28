using CadastroProduto.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CadastroProduto.Database;


namespace CadastroProduto.Controllers
{


    public class ProdutosController : Controller
    {
        private readonly AppDBConection database;

        public ProdutosController(AppDBConection database)
        {
            this.database = database;
        }
        public IActionResult Index()
        {
            var produtos = database.Produtos.ToList();
            return View(produtos);
        }

        // [HttpGet("cadastrar")]
        public IActionResult Cadastrar()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Salvar(Produto produto)
        {
            database.Produtos.Add(produto);
            database.SaveChanges();
            return Redirect("Index");
        }
    }
}