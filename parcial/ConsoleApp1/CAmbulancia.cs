using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SegundoParcial
{
    class CAmbulancia : CVehiculo
    {
        string tipo;
        public CAmbulancia(string pat, string marca, string modelo, string tipo) : base(pat, marca, modelo)
        {
            this.tipo = tipo;
        }
        public override string DarDatos()
        {
            return base.DarDatos() + "[" + this.tipo + "]";
        }
    }
}
