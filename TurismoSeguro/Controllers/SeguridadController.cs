using capaNegocio.Acciones;
using Microsoft.AspNetCore.Mvc;

namespace TurismoSeguro.Controllers
{
    public class SeguridadController : Controller
    {
        public AccionSeguridad accionSeguridad = new AccionSeguridad();
        public IActionResult Login()
        {
            return View();
        }

        public ActionResult ClickLogin(string username, string password)
        {
            string vista = string.Empty;
            if (accionSeguridad.AutenticacionUsuario(username, password))

            {
                vista = accionSeguridad.PerfilUsuario(username);
            }
            else
            { 
            
            }
            return View(vista); // para retornar al perfil usuario
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
