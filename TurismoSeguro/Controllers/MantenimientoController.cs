using capaModelo.View_Model;
using capaNegocio.Acciones;
using Microsoft.AspNetCore.Mvc;

namespace TurismoSeguro.Controllers
{
    public class MantenimientoController : Controller
    {
        public AccionesConsulta mantenimientos = new AccionesConsulta();
        public VMOperaciones oper = new VMOperaciones();
        public IActionResult Index()
        {
           
            oper.operaciones = mantenimientos.ListaOperacionSistema();
            return View(oper);
        }

        public ActionResult MantenimientoTablas()
        {
            oper.operaciones = mantenimientos.ListaOperacionSistema();
            return View(oper);
        }

        public ActionResult Usuario()
        {

            return View();
        }
        public ActionResult Roles()
        {

            return View();
        }
        public string GuardarOperacion(string descripcion, string url) 
        {
            
            return mantenimientos.GuardarOperacionSistema(descripcion, url);

        }
    }
}
