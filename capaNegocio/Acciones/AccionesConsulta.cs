using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capaDatos.Database;

namespace capaNegocio.Acciones
{
    public class AccionesConsulta : AccionesBasicas
    {
        // Metodos de listar
        #region Listados genericos
        public List<TM_Cobertura> ListTM_Cobertura()
        { return dbLibContext.TM_Coberturas.ToList(); }

        public List<TM_Pai> ListTM_Pais()
        { return dbLibContext.TM_Pais.ToList(); }

        public List<TM_CategoriaAsistencia> ListTM_CategoriaAsistencia()
        { return dbLibContext.TM_CategoriaAsistencias.ToList(); }

        public List<TM_ExtraOpcional> ListTM_ExtraOpcional()
        { return dbLibContext.TM_ExtraOpcionals.ToList(); }

        #endregion


        #region
        public List<TM_Asistencia> _getListAsistenciaxCategoria(int categoriaAsistenciaID)
        {
            return dbLibContext.TM_Asistencias.Where(x => x.CategoriaAsistencia_ID == categoriaAsistenciaID).ToList();
        }

        public List<TM_ExtraOpcional> _getListExtraxCategoria(int categoriaAsistenciaID)
        {
            return dbLibContext.TM_ExtraOpcionals.Where(x => x.CategoriaAsistencia_ID == categoriaAsistenciaID).ToList();
        }
        #endregion

        public List<TM_OperacionSistema> ListaOperacionSistema()
        {
            var lista = dbLibContext.TM_OperacionSistemas
                .Where(x=>x.flagActivo == true)
                .ToList();
            return lista == null ? new List<TM_OperacionSistema>(): lista;
        }

        public string GuardarOperacionSistema(string descripcion, string url)
        {
            // Mensaje retorno
            string msg = string.Empty;

            try
            {
                TM_OperacionSistema register = new TM_OperacionSistema()
                {
                    DescripcionOp = descripcion,
                    Operacion_URL = url,
                    fechaCreado = DateTime.Now,
                    creadoPor = Environment.UserName,
                    flagActivo = true,

                };

                msg = "La información ha sido registrada exitosamente";
            dbLibContext.TM_OperacionSistemas.InsertOnSubmit(register);
                dbLibContext.SubmitChanges();// Commit

                return msg;
            }
            catch (Exception e)
            {

                msg = $"Ha ocurrido un error en la operación {e.Message}";
                return msg;
            }

    
      
        }
}
        
}

