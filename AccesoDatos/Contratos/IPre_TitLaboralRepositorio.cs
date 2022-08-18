using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Entidades;

namespace AccesoDatos.Contratos
{
    public interface IPre_TitLaboralRepositorio : IGenericRepositorio<Pre_TitLaboral>
    {
        //Other methods
        //IEnumerable<Employee> GetBySalary(); 

        //Para buscar Datos Laborales segun ID de un Precandidato a Titular
        IEnumerable<Pre_TitLaboral> GetById_Pre_TitLaboral(int pre_id);

    }
}
