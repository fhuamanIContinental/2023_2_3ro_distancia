using DBModel;
using INegocio;
using Repositorio;

namespace Negocio
{
    public class ProductoNegocio : IProductoNegocio<Producto>
    {
        public Producto Actualizar(Producto request)
        {
            throw new NotImplementedException();
        }

        public Producto Crear(Producto request)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(Producto request)
        {
            throw new NotImplementedException();
        }

        public List<Producto> ListarTodo()
        {
            ProductoRepositorio repo = new ProductoRepositorio();
            List<Producto> lst = repo.ListarTodo();
            return lst;
        }
    }
}