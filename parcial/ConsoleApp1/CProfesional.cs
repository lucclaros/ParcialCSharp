using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SegundoParcial
{
    class CProfesional : CEmpleado
    {

        private ushort matricula;
        private string categoria;

        public CProfesional(ulong id, string apell, string nom, ushort mat, string cat) : base(id, apell, nom)
        {

            this.matricula = mat;
            this.categoria = cat;
        }
        public override string DarDatos()
        {
            return base.DarDatos() + "[" + this.matricula + "] - " + this.categoria;
        }
    }
}
