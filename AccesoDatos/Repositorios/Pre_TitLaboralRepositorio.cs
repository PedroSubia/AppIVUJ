using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Contratos;
using AccesoDatos.Entidades;
using System.Data;
using System.Data.SqlClient; 

namespace AccesoDatos.Repositorios
{
    public class Pre_TitLaboralRepositorio : MasterRepositorio, IPre_TitLaboralRepositorio
    {
        // Campos 
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        private string selectById_Pre_Titular;

        // Propiedades 
        // ... 

        // Constructores 
        public Pre_TitLaboralRepositorio()
        {
            // selectAll = "select titular.pre_nombre, labo.* from [dbAdju].[dbo].[Pre_TitLaboral] AS labo inner join [dbAdju].[dbo].[Pre_Titular] AS titular ON labo.pre_id = titular.pre_id WHERE titular.pre_id=@pre_id";
            selectAll = "select labo.* from [dbAdju].[dbo].[Pre_TitLaboral] AS labo inner join [dbAdju].[dbo].[Pre_Titular] AS titular ON labo.pre_id = titular.pre_id";
            insert = "INSERT INTO [dbo].[Pre_TitLaboral] VALUES (@prel_lugtra, @prel_activ, @prel_tipo, @prel_ingr, @prel_period, @prel_estado, @prel_fecalt, @pref_id, @pre_id) WHERE prel_id=@prel_id";
            update = "UPDATE [dbo].[Pre_TitLaboral] set prel_lugtra=@prel_lugtra, @prel_activ=prel_activ, prel_tipo=@prel_tipo, prel_ingr=@prel_ingr, prel_period=@prel_period, prel_estado=@prel_estado, prel_fecalt=@prel_fecalt, pref_id=@pref_id, pre_id=@pre_id WHERE prel_id=@prel_id";
            delete = "DELETE FROM [dbo].[Pre_TitLaboral] WHERE prel_id=@prel_id";
            selectById_Pre_Titular = "SELECT * FROM [dbAdju].[dbo].[Pre_TitLaboral] WHERE pre_id=";
        }

        // Metodos, comportamientos 
        public int Agregar(Pre_TitLaboral entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@prel_lugtra", entity.prel_lugtra));
            parameters.Add(new SqlParameter("@prel_activ", entity.prel_activ));
            parameters.Add(new SqlParameter("@prel_tipo", entity.prel_tipo));
            parameters.Add(new SqlParameter("@prel_ingr", entity.prel_ingr));
            parameters.Add(new SqlParameter("@prel_period", entity.prel_period));
            parameters.Add(new SqlParameter("@prel_estado", entity.prel_estado));
            parameters.Add(new SqlParameter("@prel_fecalt", entity.prel_fecalt));
            parameters.Add(new SqlParameter("@pref_id", entity.pref_id));
            parameters.Add(new SqlParameter("@pre_id", entity.pre_id));
            return ExecuteNonQuery(insert);

        }

        public int Editar(Pre_TitLaboral entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@prel_id", entity.prel_id));
            parameters.Add(new SqlParameter("@prel_lugtra", entity.prel_lugtra));
            parameters.Add(new SqlParameter("@prel_activ", entity.prel_activ));
            parameters.Add(new SqlParameter("@prel_tipo", entity.prel_tipo));
            parameters.Add(new SqlParameter("@prel_ingr", entity.prel_ingr));
            parameters.Add(new SqlParameter("@prel_period", entity.prel_period));
            parameters.Add(new SqlParameter("@prel_estado", entity.prel_estado));
            parameters.Add(new SqlParameter("@prel_fecalt", entity.prel_fecalt));
            parameters.Add(new SqlParameter("@pref_id", entity.pref_id));
            parameters.Add(new SqlParameter("@pre_id", entity.pre_id));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Pre_TitLaboral> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listPre_TitLaboral = new List<Pre_TitLaboral>();
            foreach (DataRow item in tableResult.Rows)
            {
                listPre_TitLaboral.Add(new Pre_TitLaboral
                {
                    prel_id = Convert.ToInt32(item[0]),
                    prel_lugtra = item[1].ToString(),
                    prel_activ = item[2].ToString(),
                    prel_tipo = item[3].ToString(),
                    prel_ingr = item[4].ToString(),
                    prel_period = item[5].ToString(),
                    prel_estado = item[6].ToString(),
                    prel_fecalt = Convert.ToDateTime(item[7]),
                    pref_id = Convert.ToInt32(item[8]),
                    pre_id = Convert.ToInt32(item[9])
                });
            }
            return listPre_TitLaboral;
        }

        public IEnumerable<Pre_TitLaboral> GetById_Pre_TitLaboral(int pre_id)
        {
            // selectById_Pre_Titular += pre_id; 
            Console.WriteLine(selectById_Pre_Titular + pre_id);
            // parameters = new List<SqlParameter>();
            // parameters.Add(new SqlParameter("@pre_id", pre_id));
            var tableResult = ExecuteReader(selectById_Pre_Titular + pre_id);
            var listPre_TitLaboral = new List<Pre_TitLaboral>();
            foreach (DataRow item in tableResult.Rows)
            {
                listPre_TitLaboral.Add(new Pre_TitLaboral
                {
                    prel_id = Convert.ToInt32(item[0]),
                    prel_lugtra = item[1].ToString(),
                    prel_activ = item[2].ToString(),
                    prel_tipo = item[3].ToString(),
                    prel_ingr = item[4].ToString(),
                    prel_period = item[5].ToString(),
                    prel_estado = item[6].ToString(),
                    prel_fecalt = Convert.ToDateTime(item[7]),
                    pref_id = Convert.ToInt32(item[8]),
                    pre_id = Convert.ToInt32(item[9])
                });
            }
            return listPre_TitLaboral;
        }

        public int Eliminar(int prel_id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@prel_id", prel_id));
            return ExecuteNonQuery(delete);
        }
    }
}
