using Persistencia.Contexto;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Persistencia.Repositorios
{
    public class Repositorio<T> : IRepositorio<T> where T : class, new()
    {
        private static OpheliaEntities _db;

        public static OpheliaEntities db
        {
            get
            {
                // The first call will create the one and only instance.
                if (_db == null)
                {
                    _db = new OpheliaEntities();
                }
                
                return _db;
            }
        }
        
        public bool Algun(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>().Any(predicate);
        }
        public T PorId(int id)
        {
            return db.Set<T>().Find(id);
        }

        public IQueryable<T> BuscarPor(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>().Where(predicate);
        }

        public void Crear(T entidad)
        {
            db.Set<T>().Add(entidad);
        }

        public void Editar(T entidad)
        {
            db.Entry<T>(entidad).State = System.Data.Entity.EntityState.Modified;
        }

        public void Eliminar(T entidad)
        {
            db.Set<T>().Remove(entidad);
        }

        public IQueryable<T> Todos()
        {
            return db.Set<T>();
        }

        public void GuardarCambios()
        {
            db.SaveChanges();
        }
    }
}
