using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcCrud.Data;

namespace mvcCrud.Controllers
{
    public class PessoaController : Controller
    {
        private readonly ILogger<PessoaController> _logger;
        private readonly appContext _context;
        public PessoaController(ILogger<PessoaController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}