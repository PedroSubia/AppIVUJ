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
    public class Pre_TitularRepositorio : MasterRepositorio, IPre_TitularRepositorio
    {
        // Campos
        private string selectAll;
        private string agregar;
        private string editar;
        private string eliminar;

        public Pre_TitularRepositorio()
        {
            selectAll = "Select pre_id, pre_ficha, pre_tipflia, pre_fecins, pre_nombre, pre_tipdoc, pre_numdoc, pre_nacion, pre_fecnac, pre_estciv" +
                ", pre_sexo, pre_direc, pre_barrio, pre_depto, pre_local, pre_disca, pre_tipdis, pre_vetmal, pre_miner, pre_cuil, pre_telef, pre_email, enin_id, sor_id, pri_id"+
                        " from Pre_Titular where pre_estado='A' order by pre_id";

            agregar = "insert into Pre_Titular (pre_ficha, pre_tipflia, pre_fecins, pre_nombre, pre_tipdoc, pre_numdoc, pre_nacion, pre_fecnac, pre_estciv)" +
                        ", pre_sexo, pre_direc, pre_barrio, pre_depto, pre_local, pre_disca, pre_tipdis, pre_vetmal, pre_miner, pre_cuil, pre_telef, pre_email, enin_id, sor_id, pri_id) " +
                      "values (@pre_ficha, @pre_tipflia, @pre_fecins, @pre_nombre, @pre_tipdoc, @pre_numdoc, @pre_nacion, @pre_fecnac, @pre_estciv" +
                        ", @pre_sexo, @pre_direc, @pre_barrio, @pre_depto, @pre_local, @pre_disca, @pre_tipdis, @pre_vetmal, @pre_miner, @pre_cuil, @pre_telef, @pre_email, @enin_id, @sor_id, @pri_id)";
            
            editar = "update Pre_Titular set pre_ficha=@pre_ficha, pre_tipflia=@pre_tipflia, pre_fecins=@pre_fecins, pre_nombre=@pre_nombre, pre_tipdoc=@pre_tipdoc, pre_numdoc=@pre_numdoc"+
                     ", pre_nacion=@pre_nacion, pre_fecnac=@pre_fecnac, pre_estciv=@pre_estciv" +
                     " where pre_id=@pre_id";
            
            eliminar = "update Pre_Titular set pre_estado='B' where pre_id=@pre_id";
        }
        public int Agregar(Pre_Titular entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@pre_ficha", entity.pre_ficha));
            parameters.Add(new SqlParameter("@pre_tipflia", entity.pre_tipflia));
            parameters.Add(new SqlParameter("@pre_ficins", entity.pre_fecins));
            parameters.Add(new SqlParameter("@pre_nombre", entity.pre_nombre));
            parameters.Add(new SqlParameter("@pre_tipdoc", entity.pre_tipdoc));
            parameters.Add(new SqlParameter("@pre_numdoc", entity.pre_numdoc));
            parameters.Add(new SqlParameter("@pre_nacion", entity.pre_nacion));
            parameters.Add(new SqlParameter("@pre_fecnac", entity.pre_fecnac));
            parameters.Add(new SqlParameter("@pre_estciv", entity.pre_estciv));
            parameters.Add(new SqlParameter("@pre_sexo", entity.pre_sexo));
            parameters.Add(new SqlParameter("@pre_direc", entity.pre_direc));
            parameters.Add(new SqlParameter("@pre_barrio", entity.pre_barrio));
            parameters.Add(new SqlParameter("@pre_depto", entity.pre_depto));
            parameters.Add(new SqlParameter("@pre_local", entity.pre_local));
            parameters.Add(new SqlParameter("@pre_disca", entity.pre_disca));
            parameters.Add(new SqlParameter("@pre_tipdis", entity.pre_tipdis));
            parameters.Add(new SqlParameter("@pre_vetmal", entity.pre_vetmal));
            parameters.Add(new SqlParameter("@pre_miner", entity.pre_miner));
            parameters.Add(new SqlParameter("@pre_cuil", entity.pre_cuil));
            parameters.Add(new SqlParameter("@pre_telef", entity.pre_telef));
            parameters.Add(new SqlParameter("@pre_email", entity.pre_email));
            return ExecuteNonQuery(agregar);
        }

        public int Editar(Pre_Titular entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@pre_ficha", entity.pre_ficha));
            parameters.Add(new SqlParameter("@pre_tipflia", entity.pre_tipflia));
            parameters.Add(new SqlParameter("@pre_ficins", entity.pre_fecins));
            parameters.Add(new SqlParameter("@pre_nombre", entity.pre_nombre));
            parameters.Add(new SqlParameter("@pre_tipdoc", entity.pre_tipdoc));
            parameters.Add(new SqlParameter("@pre_numdoc", entity.pre_numdoc));
            parameters.Add(new SqlParameter("@pre_nacion", entity.pre_nacion));
            parameters.Add(new SqlParameter("@pre_fecnac", entity.pre_fecnac));
            parameters.Add(new SqlParameter("@pre_estciv", entity.pre_estciv));
            parameters.Add(new SqlParameter("@pre_sexo", entity.pre_sexo));
            parameters.Add(new SqlParameter("@pre_direc", entity.pre_direc));
            parameters.Add(new SqlParameter("@pre_barrio", entity.pre_barrio));
            parameters.Add(new SqlParameter("@pre_depto", entity.pre_depto));
            parameters.Add(new SqlParameter("@pre_local", entity.pre_local));
            parameters.Add(new SqlParameter("@pre_disca", entity.pre_disca));
            parameters.Add(new SqlParameter("@pre_tipdis", entity.pre_tipdis));
            parameters.Add(new SqlParameter("@pre_vetmal", entity.pre_vetmal));
            parameters.Add(new SqlParameter("@pre_miner", entity.pre_miner));
            parameters.Add(new SqlParameter("@pre_cuil", entity.pre_cuil));
            parameters.Add(new SqlParameter("@pre_telef", entity.pre_telef));
            parameters.Add(new SqlParameter("@pre_email", entity.pre_email));
            return ExecuteNonQuery(editar);
        }

        public int Eliminar(int pre_id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@pre_id", pre_id));
            return ExecuteNonQuery(eliminar);
        }

        public IEnumerable<Pre_Titular> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listTitular = new List<Pre_Titular>();
            foreach (DataRow item in tableResult.Rows)
            {
                listTitular.Add(new Pre_Titular
                {

                    pre_id = Convert.ToInt32(item[0]),
                    pre_ficha = Convert.ToInt32(item[1]),
                    pre_tipflia = item[2].ToString(),
                    pre_fecins = Convert.ToDateTime(item[3]),
                    pre_nombre = item[4].ToString(),
                    //pre_tipdoc = item[5].ToString(),
                    pre_tipdoc = (item[5] is DBNull ? '-' : item[5]).ToString(),
                    pre_numdoc = Convert.ToInt32(item[6]),
                    //pre_nacion= item[7].ToString(),
                    pre_nacion = (item[7] is DBNull ? '-' : item[7]).ToString(),
                    //pre_fecnac= Convert.ToDateTime(item[8]),
                    pre_fecnac = Convert.ToDateTime(item[8] is DBNull ? DateTime.Now : item[8]),
                    pre_estciv = item[9].ToString(),
                    pre_sexo = Convert.ToChar(item[10]),
                    pre_direc = item[11].ToString(),
                    pre_barrio = item[12].ToString(),
                    pre_depto = item[13].ToString(),
                    pre_local = item[14].ToString(),
                    //pre_disca = Convert.ToByte(item[15]),
                    pre_disca = Convert.ToBoolean(item[15]),
                    pre_tipdis = item[16].ToString(),
                    //pre_vetmal = Convert.ToByte(item[17]),
                    //pre_miner = Convert.ToByte(item[18]),
                    pre_vetmal = Convert.ToBoolean(item[17]),
                    pre_miner = Convert.ToBoolean(item[18]),
                    pre_cuil = item[19].ToString(),
                    pre_telef = item[20].ToString(),
                    pre_email = item[21].ToString(),
                    /*pre_estado = Convert.ToChar(item[22]),
                    pre_fecalt = Convert.ToDateTime(item[23]),
                    enin_id = Convert.ToInt32(item[24]),
                    sor_id = Convert.ToInt32(item[25]),
                    pri_id = Convert.ToInt32(item[26]),*/
                });
            }
            return listTitular;

        }
        
    }
}
