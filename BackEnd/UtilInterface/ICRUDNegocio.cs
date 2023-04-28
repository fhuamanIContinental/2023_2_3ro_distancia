namespace UtilInterface
{
    public interface ICRUDNegocio<T>
    {
        List<T> ListarTodo();
        T Crear(T request);
        T Actualizar(T request);
        int Eliminar(T request);
    }
}