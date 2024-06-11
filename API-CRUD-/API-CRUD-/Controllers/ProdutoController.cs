using API_CRUD_.DBContext;
using API_CRUD_.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController
    {
        private readonly AppDbContext dbContext;

        public ProdutoController(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [HttpGet()]
        public IEnumerable<Produto> Get()
        {
            return dbContext.Produto.ToList();
        }

        public static List<Produto> produto = new List<Produto>();

        [HttpPost()]
        public Produto Post([FromBody] Produto produto)
        {
            dbContext.Produto.Add(produto);
            dbContext.SaveChanges();

            return produto;
        }
    }
}
