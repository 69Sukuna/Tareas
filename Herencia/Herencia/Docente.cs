using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Docente : Ususario
    {
        public decimal Sueldo { get; set; }

        public override string ToString()
        {
            return $"Cuenta: {Cuenta}| Pass: {Password} | Nombre: {Nombre} | Sueldo: {Sueldo}";
        }
    }
}
