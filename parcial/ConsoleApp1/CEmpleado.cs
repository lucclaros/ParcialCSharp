using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SegundoParcial
{
    abstract class CEmpleado : IComparable
    {
        private ulong id;
        private string apellido;
        private string nombre;
        public CEmpleado(ulong id, string apell, string nom)
        {
            this.id = id;
            this.apellido = apell;
            this.nombre = nom;
        }
        public CEmpleado(ulong id) : this(id, "", "")
        {

        }
        public virtual string DarDatos()
        {
            return "[" + this.id + "] - " + this.apellido + " => " + this.nombre;
        }
        public int CompareTo(object obj)
        {
            if (obj is CEmpleado)
            {
                return this.apellido.CompareTo(((CEmpleado)obj).apellido);
            }
            else
            {
                throw new Exception("Sólo se puede comparar instancias de CEmpleado");
            }
        }
    }

}
