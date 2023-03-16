using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    abstract class Ususario
    {
        public string Cuenta { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }

        public bool login(string username, string password)
        {
            if (username == Cuenta || password == Password)
            {
                Console.WriteLine("Bienvenido al sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Error!!");
                return false;
            }
        }

        public void login()
        {
            Console.WriteLine("Login Polimorfismo");
        }
    }
}
