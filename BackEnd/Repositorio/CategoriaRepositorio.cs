using DBModel;
using IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class CategoriaRepositorio : ICategoriaRepositorio<Categoria>
    {
        //NOSTROS TENEMOS QUE IMPLEMENTAR NUESTROS METODOS DEL CRUD
        //LISTAR TODO / INSERTAR / ATUALIZAR / ELIMINAR
        public Categoria Actualizar(Categoria request)
        {
            throw new NotImplementedException();
        }

        public Categoria Crear(Categoria request)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(Categoria request)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
