using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Presentacion.Helps
{
    class ValidacionDatos
    {
        private ValidationContext context;
        private List<ValidationResult> results;
        private bool valido;
        private string mensaje;
        public ValidacionDatos(object instancia)
        {
            context = new ValidationContext(instancia);
            results = new List<ValidationResult>();
            valido = Validator.TryValidateObject(instancia, context, results, true);
        }

        public bool Validate()
        {
            if (valido == false)
            {
                foreach (ValidationResult item in results)
                {
                    mensaje += item.ErrorMessage + "\n";
                }
                System.Windows.Forms.MessageBox.Show(mensaje);
            }
            return valido;
        }
    }
}
