using DBModel;
using IRepositorio;

namespace Repositorio
{
    public class ProductoRepositorio : IProductoRepositorio<Producto>
    {
        //NOSTROS TENEMOS QUE IMPLEMENTAR NUESTROS METODOS DEL CRUD
        //LISTAR TODO / INSERTAR / ATUALIZAR / ELIMINAR
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
            List<Producto> res = new List<Producto>();

            for (int i = 0; i < 10; i++)
            {
                Producto tmp = new Producto();
                tmp.Id = i;
                tmp.Nombre = "nombre " + i.ToString();
                tmp.Categoria = "Categoria " + i.ToString();
                tmp.SubCategoria = "Sub categoria " + i.ToString();
                res.Add(tmp);

            }

            return res;

        }

        public List<Producto> ObtenerProductosPorNombre(string nombreProducto)
        {
            throw new NotImplementedException();
        }
    }
}