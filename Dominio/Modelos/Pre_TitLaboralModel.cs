using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Contratos;
using AccesoDatos.Entidades;
using AccesoDatos.Repositorios;
using Dominio.ObjValores;
using System.ComponentModel.DataAnnotations; 

namespace Dominio.Modelos
{
    public class Pre_TitLaboralModel
    {
        private int prel_id;
        private string prel_lugtra;
        private string prel_activ;
        private string prel_tipo;
        private string prel_ingr;
        private string prel_period;
        private string prel_estado;
        private DateTime prel_fecalt;
        private int pref_id;
        private int pre_id;

        private IPre_TitLaboralRepositorio pre_TitLaboralRepository;
        public EstadoEntidad State { private get; set; }

        // PROPIEDADES / MODELOS DE VISTA / VALIDAR DATOS 
        public int Prel_id { get => prel_id; set => prel_id = value; }

        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "El campo Lugar Trabajo debe contener solo numeros")]
        public string Prel_lugtra { get => prel_lugtra; set => prel_lugtra = value; }
        public string Prel_activ { get => prel_activ; set => prel_activ = value; }
        public string Prel_tipo { get => prel_tipo; set => prel_tipo = value; }

        [Required]
        [RegularExpression("([0-9]+)", ErrorMessage = "El campo ingreso debe contener solo numeros")]
        public string Prel_ingr { get => prel_ingr; set => prel_ingr = value; }
        public string Prel_period { get => prel_period; set => prel_period = value; }
        public string Prel_estado { get => prel_estado; set => prel_estado = value; }
        public DateTime Prel_fecalt { get => prel_fecalt; set => prel_fecalt = value; }
        public int Pref_id { get => pref_id; set => pref_id = value; }
        public int Pre_id { get => pre_id; set => pre_id = value; }

        public Pre_TitLaboralModel()
        {
            pre_TitLaboralRepository = new Pre_TitLaboralRepositorio();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var pre_TitLaboralDataModel = new Pre_TitLaboral();
                pre_TitLaboralDataModel.prel_id = prel_id;
                pre_TitLaboralDataModel.prel_lugtra = prel_lugtra;
                pre_TitLaboralDataModel.prel_activ = prel_activ;
                pre_TitLaboralDataModel.prel_tipo = prel_tipo;
                pre_TitLaboralDataModel.prel_ingr = prel_ingr;
                pre_TitLaboralDataModel.prel_period = prel_period;
                pre_TitLaboralDataModel.prel_estado = prel_estado;
                pre_TitLaboralDataModel.prel_fecalt = prel_fecalt;
                pre_TitLaboralDataModel.pref_id = pref_id;
                pre_TitLaboralDataModel.pre_id = pre_id;

                switch (State)
                {
                    case EstadoEntidad.Agregado:
                        // Ejecutar reglas comerciales / calculos 
                        pre_TitLaboralRepository.Agregar(pre_TitLaboralDataModel);
                        message = "Successfully record";
                        break;
                    case EstadoEntidad.Modificado:
                        pre_TitLaboralRepository.Editar(pre_TitLaboralDataModel);
                        message = "Successfully modified";
                        break;
                    case EstadoEntidad.Eliminado:
                        pre_TitLaboralRepository.Eliminar(prel_id);
                        message = "Successfully removed";
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                {
                    message = "Duplicate Record";
                }
                else
                {
                    message = ex.ToString();
                }
            }
            return message;
        }

        public List<Pre_TitLaboralModel> GetAll()
        {
            var pre_titLaboralDataModel = pre_TitLaboralRepository.GetAll();
            var listPre_TitLaborals = new List<Pre_TitLaboralModel>();
            foreach (Pre_TitLaboral item in pre_titLaboralDataModel)
            {
                listPre_TitLaborals.Add(new Pre_TitLaboralModel
                {
                    prel_id = item.prel_id,
                    prel_lugtra = item.prel_lugtra,
                    prel_activ = item.prel_activ,
                    prel_tipo = item.prel_tipo,
                    prel_ingr = item.prel_ingr,
                    prel_period = item.prel_period,
                    prel_estado = item.prel_estado,
                    prel_fecalt = item.prel_fecalt,
                    pref_id = item.pref_id,
                    pre_id = item.pre_id
                });
            }
            return listPre_TitLaborals;
        }

        public List<Pre_TitLaboralModel> FindById_Pre_Titular(int pre_id)
        {
            var pre_titLaboralDataModel = pre_TitLaboralRepository.GetById_Pre_TitLaboral(pre_id);
            var listPre_TitLaborals = new List<Pre_TitLaboralModel>();
            foreach (Pre_TitLaboral item in pre_titLaboralDataModel)
            {
                listPre_TitLaborals.Add(new Pre_TitLaboralModel
                {
                    prel_id = item.prel_id,
                    prel_lugtra = item.prel_lugtra,
                    prel_activ = item.prel_activ,
                    prel_tipo = item.prel_tipo,
                    prel_ingr = item.prel_ingr,
                    prel_period = item.prel_period,
                    prel_estado = item.prel_estado,
                    prel_fecalt = item.prel_fecalt,
                    pref_id = item.pref_id,
                    pre_id = item.pre_id
                });
            }
            return listPre_TitLaborals;
        }

    }
}
