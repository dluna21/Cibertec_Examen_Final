using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebExamenFinal.Model;

namespace WebExamenFinal.DataAccess
{
    public class AutorLibroRepositorio : BaseAccesoDatos<AutorLibro>
    {
        public AutorLibro ObtenerAutorLibroPorID(int titulo_id, int au_id)
        {
            using (var dbContext = new ContextoDatos())
            {
                return dbContext.AutorLibro.FirstOrDefault(x => x.titulo_id == titulo_id && x.au_id == au_id);
            }
        }
    }
}
