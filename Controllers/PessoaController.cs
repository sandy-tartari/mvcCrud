using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcCrud.Data;
using mvcCrud.Models.DB;

namespace mvcCrud.Controllers
{
    public class PessoaController : Controller
    {
        private readonly ILogger<PessoaController> _logger;
        private readonly appContext _context;
        public PessoaController(ILogger<PessoaController> logger, appContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            IList<Pessoa> pessoass = _context.pessoas.ToList();
            return View(pessoass);
        }
    }
}