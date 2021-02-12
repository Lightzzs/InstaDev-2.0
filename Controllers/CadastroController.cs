using Microsoft.AspNetCore.Mvc;

namespace InstaDev_2.Controllers
{
    [Route("Cadastro")]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}