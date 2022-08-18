using AccesoDatos.Contratos;
using AccesoDatos.Entidades;
using AccesoDatos.Repositorios;
using Dominio.ObjValores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos
{
    public class Pre_TitFamiliaModel
    {
       private int pref_id;
       private string pref_paren;
       private string pref_nombre;
       private int pref_numdoc;
       private string pref_nacion;
       private DateTime pref_fecnac;
       private string pref_estciv;
       private string pref_sexo;
       private bool pref_disca;
       private string pref_tipdis;
       private bool pref_vetmal;
       private bool pref_miner;
       private bool pref_cotit;
       private string pref_cuil;
       private DateTime pref_fecalt;
       private int pre_id;

       private IPre_TitFamiliaRepositorio familiaRepositorio;
       protected EstadoEntidad estadoEntidad { private get; set; }

        public int Pref_id { get => pref_id; set => pref_id = value; }
        public string Pref_paren { get => pref_paren; set => pref_paren = value; }
        public string Pref_nombre { get => pref_nombre; set => pref_nombre = value; }
        public int Pref_numdoc { get => pref_numdoc; set => pref_numdoc = value; }
        public string Pref_nacion { get => pref_nacion; set => pref_nacion = value; }
        public DateTime Pref_fecnac { get => pref_fecnac; set => pref_fecnac = value; }
        public string Pref_estciv { get => pref_estciv; set => pref_estciv = value; }
        public string Pref_sexo { get => pref_sexo; set => pref_sexo = value; }
        public bool Pref_disca { get => pref_disca; set => pref_disca = value; }
        public string Pref_tipdis { get => pref_tipdis; set => pref_tipdis = value; }
        public bool Pref_vetmal { get => pref_vetmal; set => pref_vetmal = value; }
        public bool Pref_miner { get => pref_miner; set => pref_miner = value; }
        public bool Pref_cotit { get => pref_cotit; set => pref_cotit = value; }
        public string Pref_cuil { get => pref_cuil; set => pref_cuil = value; }
        public DateTime Pref_fecalt { get => pref_fecalt; set => pref_fecalt = value; }
        public int Pre_id { get => pre_id; set => pre_id = value; }

        public Pre_TitFamiliaModel()
       {
            familiaRepositorio = new Pre_TitFamiliaRepositorio();

       }

       public List<Pre_TitFamiliaModel> GetAll()
       {
            var FamiliaDataModel = familiaRepositorio.GetAll();
            var listaFamilia = new List<Pre_TitFamiliaModel>();
            foreach (Pre_TitFamilia item in FamiliaDataModel)
            {
                listaFamilia.Add(new Pre_TitFamiliaModel
                {
                    pref_id= item.pref_id,
                    pref_paren= item.pref_paren,
                    pref_nombre=item.pref_nombre,
                    pref_numdoc=item.pref_numdoc,
                    pref_nacion=item.pref_nacion,
                    pref_fecnac=item.pref_fecnac,
                    pref_estciv= item.pref_estciv,
                    pref_sexo= item.pref_sexo,
                    pref_disca= item.pref_disca,
                    pref_tipdis= item.pref_tipdis,
                    pref_vetmal= item.pref_vetmal,
                    pref_miner= item.pref_miner,
                    pref_cotit=item.pref_cotit,
                    pref_cuil=item.pref_cuil,
                    pref_fecalt=item.pref_fecalt,
                    pre_id=item.pre_id
                });
            }
            return listaFamilia;
        }

    }

    

    
}
