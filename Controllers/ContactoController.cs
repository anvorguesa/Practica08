using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Practica08.Controllers{
    public class ContactoController : Controller{
       private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contacto objContacto)
        {
            ViewData["Message"]="Se registro el contacto";
            return View("Index");
        }
    }
}