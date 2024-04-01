using Microsoft.AspNetCore.Mvc;

namespace TurismoSeguro.Controllers
{
    public class SeguridadController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public ActionResult ClickLogin(string username = "", string password = "")
        {
            return View("_UsuarioFinal"); // para retornar al perfil usuario
        }

        public ActionResult _UsuarioFinal()
        {
            return View();
        }

        public ActionResult _UsuarioTecnico()
        {
            return View();
        }

        public ActionResult _UsuarioAdministrador()
        {
            return View();
        }
    }
}
