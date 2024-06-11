using API_CRUD_.DBContext;
using API_CRUD_.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControleVendaController : Controller
    {
        private readonly AppDbContext dbContext;

        public ControleVendaController(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [HttpPost()]
        public ControleVenda Post([FromBody] ControleVenda controle)
        {
            dbContext.ControleVenda.Add(controle);
            dbContext.SaveChanges();

            return controle;
        }

        [HttpGet()]
        public IEnumerable<ControleVenda> Get()
        {
            return dbContext.ControleVenda.ToList();
        }
    }
}
