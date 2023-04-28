using DBModel;
using UtilInterface;

namespace IRepositorio
{
    public interface IProductoRepositorio<T> : ICRUDRepositorio<T>
    {

        List<T> ObtenerProductosPorNombre(string nombreProducto);

    }
}