using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebExamenFinal.DataAccess
{
    public interface IAccesoDatos<T>
    {
        List<T> ObtenerLista();
        int Agregar(T entity);
        int Actualizar(T entity);
        int Eliminar(T entity);
    }
}
