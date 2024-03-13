namespace capaNegocio.Acciones;
using capaDatos.Database;
using System.Data;

public class AccionesBasicas
{
    public DbLibraryEntityDataContext dbLibContext = new DbLibraryEntityDataContext("Data Source=localhost;Initial Catalog=Turismo_Seguro;Integrated Security=True");

}

