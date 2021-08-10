using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto
{
    public class Calculadora
    {
        public static double Pi = 3.14;
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }

        //public double Pi = 3.14;
        //public double Circunferencia(double r)
        //{
        //    return 2.0 * Pi * r;
        //}
        //public double Volume(double r)
        //{
        //    return 4.0 / 3.0 * Pi * r * r * r;
        //}
    }
}
