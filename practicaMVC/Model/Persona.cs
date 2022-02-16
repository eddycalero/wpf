using System;
using System.Collections.Generic;
using System.Text;

namespace practicaMVC
{
    public class Persona
    {
        public double a
        {
            get;set;
        }

        public string Nombre
        {
            get; set;
        }

        public string Apellido
        {

            get; set;
        }

        public DateTime fecha
        {
            get; set;
        }

        public double b
        {
            get;set;
        }

        public double r
        {
            get;set;
        }

        public double sum(double a , double b)
        {
            this.a = a;
            this.b = b;
            r = a + b;
            return r;
        }

    }
}
