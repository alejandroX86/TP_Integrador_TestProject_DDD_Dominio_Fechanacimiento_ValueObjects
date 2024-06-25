using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_DDD_Fechadenacimiento_ValueObjects
{
    public class FechaNacimiento
    {
        private DateTime valor;

        public FechaNacimiento(DateTime valor)
        {
            this.valor = valor;
        }

        public bool EsMayorDeEdad()
        {
            int edad = DateTime.Today.Year - valor.Year;
            if (valor.Date > DateTime.Today.AddYears(-edad)) edad--;
            return edad >= 18;
        }

        public DateTime Valor()
        {
            return this.valor;
        }
    }
}
