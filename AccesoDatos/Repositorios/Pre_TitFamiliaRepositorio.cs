using AccesoDatos.Contratos;
using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorios
{
    public class Pre_TitFamiliaRepositorio : MasterRepositorio, IPre_TitFamiliaRepositorio
    {
        private string selectAll;
        private string agregar;
        private string editar;
        private string eliminar;

        public Pre_TitFamiliaRepositorio()
        {
            selectAll = "Select pref_id, pref_paren, pref_nombre, pref_numdoc, pref_nacion, pref_fecnac, pref_estciv, pref_sexo, pref_disca, pref_tipdis,"+
                " pref_vetmal, pref_miner, pref_cotit, pref_cuil, pref_fecalt, pre_id from Pre_TitFamilia where pref_estado='A' order by pref_nombre";
            agregar = "";
            editar = "";
            eliminar = "";

        }

        public int Agregar(Pre_TitFamilia entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@pref_id", entity.pre_id));
            parameters.Add(new SqlParameter("@pref_paren", entity.pref_paren));
            parameters.Add(new SqlParameter("@pref_nombre", entity.pref_nombre));
            parameters.Add(new SqlParameter("@pref_numdoc", entity.pref_numdoc));
            parameters.Add(new SqlParameter("@pref_nacion", entity.pref_nacion));
            parameters.Add(new SqlParameter("@pref_fecnac", entity.pref_fecnac));
            parameters.Add(new SqlParameter("@pref_estciv", entity.pref_estciv));
            parameters.Add(new SqlParameter("@pref_sexo", entity.pref_sexo));
            parameters.Add(new SqlParameter("@pref_disca", entity.pref_disca));
            parameters.Add(new SqlParameter("@pref_tipdis", entity.pref_tipdis));
            parameters.Add(new SqlParameter("@pref_vetmal", entity.pref_vetmal));
            parameters.Add(new SqlParameter("@pref_miner", entity.pref_miner));
            parameters.Add(new SqlParameter("@pref_cotit", entity.pref_cotit));
            parameters.Add(new SqlParameter("@pref_cuil", entity.pref_cuil));
            parameters.Add(new SqlParameter("@pref_fecalt", entity.pref_fecalt));
            parameters.Add(new SqlParameter("@pre_id", entity.pre_id));
            return ExecuteNonQuery(agregar);
        }

        public int Editar(Pre_TitFamilia entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@pref_id", entity.pre_id));
            parameters.Add(new SqlParameter("@pref_paren", entity.pref_paren));
            parameters.Add(new SqlParameter("@pref_nombre", entity.pref_nombre));
            parameters.Add(new SqlParameter("@pref_numdoc", entity.pref_numdoc));
            parameters.Add(new SqlParameter("@pref_nacion", entity.pref_nacion));
            parameters.Add(new SqlParameter("@pref_fecnac", entity.pref_fecnac));
            parameters.Add(new SqlParameter("@pref_estciv", entity.pref_estciv));
            parameters.Add(new SqlParameter("@pref_sexo", entity.pref_sexo));
            parameters.Add(new SqlParameter("@pref_disca", entity.pref_disca));
            parameters.Add(new SqlParameter("@pref_tipdis", entity.pref_tipdis));
            parameters.Add(new SqlParameter("@pref_vetmal", entity.pref_vetmal));
            parameters.Add(new SqlParameter("@pref_miner", entity.pref_miner));
            parameters.Add(new SqlParameter("@pref_cotit", entity.pref_cotit));
            parameters.Add(new SqlParameter("@pref_cuil", entity.pref_cuil));
            parameters.Add(new SqlParameter("@pref_fecalt", entity.pref_fecalt));
            parameters.Add(new SqlParameter("@pre_id", entity.pre_id));
            return ExecuteNonQuery(editar);
        }

        public int Eliminar(int pref_id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@pref_id", pref_id));
            return ExecuteNonQuery(eliminar);
        }

        public IEnumerable<Pre_TitFamilia> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listFamiliar = new List<Pre_TitFamilia>();
            foreach(DataRow item in tableResult.Rows)
            {
                listFamiliar.Add(new Pre_TitFamilia
                {
                    pref_id = Convert.ToInt32(item[0]),
                    pref_paren = item[1].ToString(),
                    pref_nombre = item[2].ToString(),
                    pref_numdoc = Convert.ToInt32(item[3]),
                    pref_nacion = item[4].ToString(),
                    pref_fecnac = Convert.ToDateTime(item[5]),
                    pref_estciv = item[6].ToString(),
                    pref_sexo = item[7].ToString(),
                    pref_disca = Convert.ToBoolean(item[8]),
                    pref_tipdis = item[9].ToString(),
                    pref_vetmal = Convert.ToBoolean(item[10]),
                    pref_miner = Convert.ToBoolean(item[11]),
                    pref_cotit = Convert.ToBoolean(item[12]),
                    pref_cuil = item[13].ToString(),
                    pref_fecalt = Convert.ToDateTime(item[14]),
                    pre_id = Convert.ToInt32(item[15])
                });
            }
            return listFamiliar;
        }
    }
}
