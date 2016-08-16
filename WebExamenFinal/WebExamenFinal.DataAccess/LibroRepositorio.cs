using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebExamenFinal.Model;

namespace WebExamenFinal.DataAccess
{
    public class LibrosRepositorio : BaseAccesoDatos<Libros>
    {
        public  Libros ObtenerLibroPorID(int id)
        {
            using (var dbContext = new ContextoDatos())
            {
                return dbContext.Libro.FirstOrDefault(x=>x.titulo_id == id);
            }
        } 
    }
}
