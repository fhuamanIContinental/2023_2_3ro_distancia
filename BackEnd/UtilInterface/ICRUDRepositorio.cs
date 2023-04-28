namespace UtilInterface
{
    public interface ICRUDRepositorio<T>
    {
        List<T> ListarTodo();
        T Crear(T request);
        T Actualizar(T request);
        int Eliminar(T request);
    }
}