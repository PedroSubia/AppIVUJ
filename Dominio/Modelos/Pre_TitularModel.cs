using AccesoDatos.Entidades;
using AccesoDatos.Repositorios;
using AccesoDatos.Contratos;
using Dominio.ObjValores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos
{
    public class Pre_TitularModel
    {
        private int pre_id;
        private int pre_ficha;
        private string pre_tipflia;
        private DateTime pre_fecins;
        private string pre_nombre;
        private string pre_tipdoc;
        private int pre_numdoc;
        private string pre_nacion;
        private DateTime pre_fecnac;
        private string pre_estciv;
        private char pre_sexo;
        private string pre_direc;
        private string pre_barrio;
        private string pre_depto;
        private string pre_local;
        private bool pre_disca;
        private string pre_tipdis;
        private bool pre_vetmal;
        private bool pre_miner;
        private string pre_cuil;
        private string pre_telef;
        private string pre_email;

        private IPre_TitularRepositorio titularRepositorio;
        protected EstadoEntidad estadoEntidad { private get; set; }

        //Propiedades /Modelo de vista y validar datos
        public int Pre_id { private get => pre_id; set => pre_id = value; }

        [Required(ErrorMessage = "El numero de ficha es necesario.")]
        public int Pre_ficha { get => pre_ficha; set => pre_ficha = value; }

        [Required]
        public DateTime Pre_fecins { get => pre_fecins; set => pre_fecins = value; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        //[RegularExpression("^[a-zA-Z]+$", ErrorMessage = "El nombre debe ser solo letras.")]
        [StringLength(maximumLength: 50, MinimumLength = 8)]
        public string Pre_nombre { get => pre_nombre; set => pre_nombre = value; }

        [Required]
        public string Pre_tipdoc { get => pre_tipdoc; set => pre_tipdoc = value; }

        [Required(ErrorMessage = "El numero de documento es requerido.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Deben ser solo números.")]
        [StringLength(maximumLength: 9, MinimumLength = 7, ErrorMessage = "Deben ser entre 7 y 9 digitos.")]
        public int Pre_numdoc { get => pre_numdoc; set => pre_numdoc = value; }

        [Required]
        public string Pre_cuil { get => pre_cuil; set => pre_cuil = value; }

        [Required]
        public DateTime Pre_fecnac { get => pre_fecnac; set => pre_fecnac = value; }

        [Required]
        public string Pre_direc { get => pre_direc; set => pre_direc = value; }
        [Required]
        public string Pre_barrio { get => pre_barrio; set => pre_barrio = value; }
        [Required]
        public string Pre_depto { get => pre_depto; set => pre_depto = value; }

        [Required]
        public string Pre_telef { get => pre_telef; set => pre_telef = value; }
        [Required]
        public string Pre_email { get => pre_email; set => pre_email = value; }

        [Required]
        public string Pre_local { get => pre_local; set => pre_local = value; }

        [Required]
        public string Pre_tipflia { get => pre_tipflia; set => pre_tipflia = value; }
        [Required]
        public string Pre_nacion { get => pre_nacion; set => pre_nacion = value; }

        [Required]
        public string Pre_estciv { get => pre_estciv; set => pre_estciv = value; }
        [Required]
        public char Pre_sexo { get => pre_sexo; set => pre_sexo = value; }

        public bool Pre_disca { get => pre_disca; set => pre_disca = value; }
        public string Pre_tipdis { get => pre_tipdis; set => pre_tipdis = value; }

        public bool Pre_vetmal { get => pre_vetmal; set => pre_vetmal = value; }

        public bool Pre_miner { get => pre_miner; set => pre_miner = value; }

        public Pre_TitularModel()
        {
            titularRepositorio = new Pre_TitularRepositorio();
        }
        public string GrabarCambios()
        {
            string message = null;
            try
            {
                var TitularDataModel = new Pre_Titular();
                TitularDataModel.pre_id = pre_id;
                TitularDataModel.pre_ficha = pre_ficha;
                TitularDataModel.pre_tipflia = pre_tipflia;
                TitularDataModel.pre_fecins = pre_fecins;
                TitularDataModel.pre_nombre = pre_nombre;
                TitularDataModel.pre_tipdoc = pre_tipdoc;
                TitularDataModel.pre_numdoc = pre_numdoc;
                TitularDataModel.pre_nacion = pre_nacion;
                TitularDataModel.pre_fecnac = pre_fecnac;
                TitularDataModel.pre_estciv = pre_estciv;
                TitularDataModel.pre_sexo = pre_sexo;
                TitularDataModel.pre_direc = pre_direc;
                TitularDataModel.pre_barrio = pre_barrio;
                TitularDataModel.pre_depto = pre_depto;
                TitularDataModel.pre_local = pre_local;
                TitularDataModel.pre_disca = pre_disca;
                TitularDataModel.pre_tipdis = pre_tipdis;
                TitularDataModel.pre_vetmal = pre_vetmal;
                TitularDataModel.pre_miner = pre_miner;
                TitularDataModel.pre_cuil = pre_cuil;
                TitularDataModel.pre_telef = pre_telef;
                TitularDataModel.pre_email = pre_email;
                switch (estadoEntidad)
                {
                    case EstadoEntidad.Agregado:
                        //Ejecutar reglas comerciales o calculos.
                        titularRepositorio.Agregar(TitularDataModel);
                        message = "Registro agregado correctamente.";
                        break;
                    case EstadoEntidad.Modificado:
                        titularRepositorio.Editar(TitularDataModel);
                        message = "Registro actualizado correctamente.";
                        break;
                    case EstadoEntidad.Eliminado:
                        titularRepositorio.Eliminar(pre_id);
                        message = "Registro eliminado correctamente.";
                        break;
                }

            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                    message = "Registro duplicado.";
                else
                    message = ex.ToString();
            }
            return message;

        }
        public List<Pre_TitularModel> GetAll()
        {
            var TitularDataModel = titularRepositorio.GetAll();
            var listaTitular = new List<Pre_TitularModel>();
            foreach(Pre_Titular item in TitularDataModel)
            {
                listaTitular.Add(new Pre_TitularModel
                {
                    pre_id = item.pre_id,
                    pre_ficha = item.pre_ficha,
                    pre_tipflia = item.pre_tipflia,
                    pre_fecins = item.pre_fecins,
                    pre_nombre = item.pre_nombre,
                    pre_tipdoc = item.pre_tipdoc,
                    pre_numdoc = item.pre_numdoc,
                    pre_nacion = item.pre_nacion,
                    pre_fecnac = item.pre_fecnac,
                    pre_estciv = item.pre_estciv,
                    pre_sexo = item.pre_sexo,
                    pre_direc = item.pre_direc,
                    pre_barrio = item.pre_barrio,
                    pre_depto = item.pre_depto,
                    pre_local = item.pre_local,
                    pre_disca = item.pre_disca,
                    pre_tipdis = item.pre_tipdis,
                    pre_vetmal = item.pre_vetmal,
                    pre_miner = item.pre_miner,
                    pre_cuil = item.pre_cuil,
                    pre_telef = item.pre_telef,
                    pre_email = item.pre_email,
            });
            }
            return listaTitular;
        }
        public IEnumerable<Pre_TitularModel> FindById(string filter)
        {
            //return GetAll().FindAll(e => e.Per_dni == filter);
            return GetAll().FindAll(e => e.Pre_numdoc.ToString().Contains(filter) || e.Pre_nombre.Contains(filter));
        }
    }   
}
