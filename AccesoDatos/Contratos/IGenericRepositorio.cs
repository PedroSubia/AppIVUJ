using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Contratos
{
    public interface IGenericRepositorio<Entity> where Entity:class
    {
        int Agregar(Entity entity);
        int Editar(Entity entity);
        int Eliminar(int per_id);
        IEnumerable<Entity> GetAll();



    }
}
