using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SegundoParcial
{
    class CVehiculo
    {
        private string patente;
        private string marca;
        private string modelo;

        public CVehiculo(string pat, string marca, string modelo)
        {
            this.patente = pat;
            this.marca = marca;
            this.modelo = modelo;
        }
        public CVehiculo(string patente) : this(patente, "", "") { }
        public virtual string DarDatos()
        {
            return "[" + this.patente + "] - " + this.marca + " => " + this.modelo;
        }
        public int CompareTo(object obj)
        {
            if (obj is CVehiculo)
            {
                return this.patente.CompareTo(((CVehiculo)obj).patente);
            }
            else
            {
                throw new Exception("Sólo se puede comparar instancias de CVehiculo");
            }
        }
    }

}
