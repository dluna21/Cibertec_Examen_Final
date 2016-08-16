using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebExamenFinal.Model;

namespace WebExamenFinal.DataAccess
{
    public class AutorRepositorio : BaseAccesoDatos<Autores>
    {
        public Autores ObtenerAutorPorID(int id)
        {
            using (var dbContext = new ContextoDatos())
            {
                return dbContext.Autor.FirstOrDefault(x => x.au_id == id);
            }
        }
    }
}
