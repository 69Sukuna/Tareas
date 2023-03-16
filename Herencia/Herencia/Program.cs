using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Cuenta = "jperez";
            estudiante.Password = "1234";
            estudiante.Nombre = "Juan";
            estudiante.Matricula = "34J";

            estudiante.login("jperez", "1234");
            estudiante.login();

            List<Docente> listaDocente = new List<Docente>();

            listaDocente.Add(new Docente()
            {
                Cuenta = "jgarcia",
                Password ="12",
                Nombre="Jose",
                Sueldo=1200                
            });

            listaDocente.Add(new Docente()
            {
                Cuenta = "acabrera",
                Password = "664",
                Nombre = "Ana",
                Sueldo = 2300
            });
            listaDocente.Add(new Docente()
            {
                Cuenta = "epez",
                Password = "152",
                Nombre = "Elio",
                Sueldo = 1250
            });

            MostrarLista(listaDocente);

            Double promedio = getPromedio(listaDocente);
            Console.WriteLine("\nEl Promedio: {0}",promedio.ToString("##.##"));

            double promedio2= getPromedio2(listaDocente);
            Console.WriteLine("\nEl Promedio 2: {0}", promedio2.ToString("##.##"));

            double promedio3 = getPromedio3(listaDocente);
            Console.WriteLine("\nEl Promedio 3: {0}", promedio3.ToString("##.##"));

            double promedio4 = getPromedio4(listaDocente);
            Console.WriteLine("\nEl Promedio 4: {0}", promedio4.ToString("##.##"));

            //Tarea

            List<Estudiante> lisEst = new List<Estudiante>();

            lisEst.Add(new Estudiante()
            {
                Nombre = "Carlos",
                Edad=23,
                Cuenta = "cAndrade",
                Password="256",
                Matricula="c454a"
            });

            lisEst.Add(new Estudiante()
            {
                Nombre = "Juan",
                Edad = 20,
                Cuenta = "jchoque",
                Password = "487",
                Matricula = "j781c"
            });

            lisEst.Add(new Estudiante()
            {
                Nombre = "Ana",
                Edad = 22,
                Cuenta = "aOlpelia",
                Password = "789",
                Matricula = "a485o"
            });

            lisEst.Add(new Estudiante()
            {
                Nombre = "Carla",
                Edad = 21,
                Cuenta = "cAntezana",
                Password = "148",
                Matricula = "c650a"
            });

            lisEst.Add(new Estudiante()
            {
                Nombre = "Felipe",
                Edad = 25,
                Cuenta = "fAnzua",
                Password = "291",
                Matricula = "f233a"
            });

            MostrarEst(lisEst);

            Double promEd = getProed1(lisEst);
            Console.WriteLine("\nEl Promedio: {0}", promEd.ToString("##.##"));

            double promEd2 = getProed2(lisEst);
            Console.WriteLine("\nEl Promedio 2: {0}", promEd2.ToString("##.##"));

            double promEd3 = getProed3(lisEst);
            Console.WriteLine("\nEl Promedio 3: {0}", promEd3.ToString("##.##"));

            double promEd4 = getProed4(lisEst);
            Console.WriteLine("\nEl Promedio 4: {0}", promEd4.ToString("##.##"));

            Console.ReadKey();
        }

        private static double getProed4(List<Estudiante> lisEst)
        {
            var prom = (from s in lisEst
                        where s.Edad>=23
                        select s.Edad).Average();
            return (double) prom;
        }

        private static double getProed3(List<Estudiante> lisEst)
        {
            int sum = lisEst.Sum(s => s.Edad);
            int total = lisEst.Count();
            return (double)sum / total;
        }

        private static double getProed2(List<Estudiante> lisEst)
        {
            double prom = lisEst.Average(s => s.Edad);
            return prom;
        }

        private static double getProed1(List<Estudiante> lisEst)
        {
            int sum = 0;
            foreach (Estudiante es in lisEst)
            {
                sum += es.Edad;
            }
            return (double)sum/lisEst.Count;
        }

        private static void MostrarEst(List<Estudiante> lisEst)
        {
            Console.WriteLine("\n----LISTA ESTUDIANTES----\n");
            foreach (Estudiante est in lisEst) {
                Console.WriteLine(est.ToString());
            }
        }


        //Clase del sabado
        private static double getPromedio4(List<Docente> listaDocente)
        {
            var prom = (from item in listaDocente
                        where item.Sueldo < 2000
                        select item.Sueldo).Average();
            return (double) prom;
        }

        private static double getPromedio3(List<Docente> listaDocente)
        {
            decimal sum = listaDocente.Sum(x => x.Sueldo);
            int total = listaDocente.Count();
            return (double)sum / total;
        }

        private static double getPromedio2(List<Docente> listaDocente)
        {
            decimal promedio = listaDocente.Average(x => x.Sueldo);
            return (double)promedio;
        }

        private static double getPromedio(List<Docente> listaDocente)
        {
            Decimal sum = 0;
            foreach (Docente item in listaDocente)
            {
                sum += item.Sueldo;
            }
            return (double)sum / listaDocente.Count;
        }

        private static void MostrarLista(List<Docente> listaDocente)
        {
            Console.WriteLine("\n----LISTA DE DOCENTES\n-----");

            foreach (Docente item in listaDocente)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
