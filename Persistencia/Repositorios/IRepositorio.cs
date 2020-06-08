using Persistencia.Contexto;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Persistencia.Repositorios
{
    public interface IRepositorio<T> where  T: class, new()
    {

        IQueryable<T> BuscarPor(Expression<Func<T, bool>> predicate);
        T PorId(int id);
        void Crear(T entidad);
        void Editar(T entidad);
        void Eliminar(T entidad);
        bool Algun(Expression<Func<T, bool>> predicate);
        IQueryable<T> Todos();
        void GuardarCambios();
    }
}
