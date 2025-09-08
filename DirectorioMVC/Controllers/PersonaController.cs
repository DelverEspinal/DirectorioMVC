using Microsoft.AspNetCore.Mvc;

namespace DirectorioMVC.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index() // GET: /Persona/
        {
            return View();
        }
    }
}
