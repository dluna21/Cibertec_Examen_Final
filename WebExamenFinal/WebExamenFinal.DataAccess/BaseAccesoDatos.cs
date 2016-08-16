using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebExamenFinal.DataAccess
{
    public class BaseAccesoDatos<T> : IAccesoDatos<T> where T : class
    {
        public int Actualizar(T entity)
        {
            using (var dbContext = new ContextoDatos())
            {
                dbContext.Entry(entity).State = EntityState.Modified;
                return dbContext.SaveChanges();
            }
        }

        public int Agregar(T entity)
        {
            using (var dbContext = new ContextoDatos())
            {
                dbContext.Entry(entity).State = EntityState.Added;
                return dbContext.SaveChanges();
            }
        }

        public int Eliminar(T entity)
        {
            using (var dbContext = new ContextoDatos())
            {
                dbContext.Entry(entity).State = EntityState.Deleted;
                return dbContext.SaveChanges();
            }
        }

        public List<T> ObtenerLista()
        {
            using (var dbContext = new ContextoDatos())
            {
                return dbContext.Set<T>().ToList();

            }
        }
    }
}
