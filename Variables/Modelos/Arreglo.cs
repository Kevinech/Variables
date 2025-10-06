using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Modelos
{
    public class Arreglo
    {
        public static int[] edades = new int[10];

        public static int pos = 0;

        public static int GetPromedioI()
        {
            int prom = 0;
            int suma = 0;
            
            foreach (int edad in edades)
            {
                suma += edad;

            }
            prom = (int) suma / pos;

            return prom;
        }

        public static double GetPromedioD()
        {
            double prom = 0;
            double suma = 0;

            foreach (int edad in edades)
            {
                suma += edad;

            }
            prom = suma / pos;

            return prom;

        }

        public static int GetEdadMaxima()
        {
            int edadmaxima = 0;

            foreach(int edad in edades)
            {
                if (edad > edadmaxima)
                {
                    edadmaxima = edad;
                }
            }    
            return edadmaxima;
        }

        public static int GetEdadMinima()
        {
            int edadminima = edades[0];

            for (int i = 1; i < pos; i++)
            {
                if (edades[i] < edadminima) 
                    edadminima = edades[i];
            }


            return edadminima;
        }

        public static int GetCantidadMayores()
        {
            int cantidad = 0;

            foreach(int edad in edades)
            {
                if (edad > 18 && edad < 120 )
                {
                    cantidad++;
                }
                   
            }
            return cantidad;

        }

        public static int GetCantidadMenores()
        {
            int cantidad1 = 0;

            foreach (int edad in edades)
            {
                if (edad < 18 && edad < 0)
                {
                    cantidad1++;
                }
                    
            }
            return cantidad1;
        }







    }
}
