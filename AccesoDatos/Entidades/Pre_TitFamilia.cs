using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Pre_TitFamilia
    {
        public int pref_id { get; set; }
        public string pref_paren { get; set; }
        public string pref_nombre { get; set; }
        public int pref_numdoc { get; set; }
        public string pref_nacion { get; set; }
        public DateTime pref_fecnac { get; set; }
        public string pref_estciv { get; set; }
        public string pref_sexo { get; set; }
        public bool pref_disca { get; set; }
        public string pref_tipdis { get; set; }
        public bool pref_vetmal { get; set; }
        public bool pref_miner { get; set; }
        public bool pref_cotit { get; set; }
        public string pref_cuil { get; set; }
        //public char pref_estado { get; set; }
        public DateTime pref_fecalt { get; set; }
        public int pre_id { get; set; }

    }
}
