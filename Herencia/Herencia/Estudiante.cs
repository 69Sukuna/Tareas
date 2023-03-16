using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Estudiante:Ususario
    {
        public string Matricula { get; set; }
        public int Edad { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre} | Edad: {Edad} | Cuenta: {Cuenta} | Password: {Password} | Matricula: {Matricula}";
        }
    }
}
