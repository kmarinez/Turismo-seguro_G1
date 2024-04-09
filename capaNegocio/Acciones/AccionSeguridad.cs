using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos.Database;
using Microsoft.Identity.Client;

namespace capaNegocio.Acciones
{
    public class AccionSeguridad : AccionesBasicas
    {
        /// Autenticacion 
        /// 
        public bool AutenticacionUsuario( string usuario, string clave)
        {
            bool _acceso = false;

            try
            {
                var validacion = dbLibContext.TM_Usuarios
                    .FirstOrDefault(x => x.Clave_Acceso == clave & x.Usuario == usuario);
                
                _acceso = (validacion != null) ? true : false;
            }
            catch (Exception ex)
            {
                return false;
            }
            return _acceso;

      
            }

        public string PerfilUsuario(string nomUsuario)
        {
            string perfil = String.Empty;

            try
            {
                perfil = dbLibContext.vw_Usuarios.FirstOrDefault(x => x.nomUsuario == nomUsuario).PerfilUsuario;
            }
            catch
            {
                return string.Empty;
            }
            return perfil;
        }

        public List<TM_Usuario> GetUsuarios()
        {
            var result = dbLibContext.TM_Usuarios.ToList();
            return result;
        }
    }
}
