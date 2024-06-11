using API_CRUD_.DBContext;
using API_CRUD_.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstoqueController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public EstoqueController(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public static List<Estoque> produto = new List<Estoque>();

        [HttpGet()]
        public IEnumerable<Estoque> Get()
        {
            return dbContext.Estoque.ToList();
        }

        [HttpPost()]
        public Estoque Post([FromBody] Estoque estoque)
        {
            dbContext.Estoque.Add(estoque);
            dbContext.SaveChanges();

            return estoque;
        }
    }
}
