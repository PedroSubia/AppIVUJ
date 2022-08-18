using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Pre_Titular
    {
        public int pre_id { get; set; }
        public int pre_ficha { get; set; }
        public string pre_tipflia { get; set; }
        public DateTime pre_fecins { get; set; }
        public string pre_nombre { get; set; }
        public string pre_tipdoc { get; set; }
        public int pre_numdoc { get; set; }
        public string pre_nacion { get; set; }
        public DateTime pre_fecnac { get; set; }
        public string pre_estciv { get; set; }
        public char pre_sexo { get; set; } /*char*/
        public string pre_direc { get; set; }
        public string pre_barrio { get; set; }
        public string pre_depto { get; set; }
        public string pre_local { get; set; }
        public bool pre_disca { get; set; }
        public string pre_tipdis { get; set; }
        public bool pre_vetmal { get; set; }
        public bool pre_miner { get; set; }
        public string pre_cuil { get; set; }
        public string pre_telef { get; set; }
        public string pre_email { get; set; }
        /*public char pre_estado { get; set; }
        public DateTime pre_fecalt { get; set; }
        public int enin_id { get; set; }
        public int sor_id { get; set; }
        public int pri_id { get; set; }*/
    }
}
