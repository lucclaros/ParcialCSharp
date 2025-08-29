using System;
namespace SegundoParcial
{
    class CChofer : CEmpleado
    {

        private ushort registro;
        private string distrito;

        public CChofer(ulong id, string apell, string nom, ushort reg, string dist) : base(id, apell, nom)
        {
            this.registro = reg;
            this.distrito = dist;
        }
        public override string DarDatos()
        {
            return base.DarDatos() + "[" + this.registro + "] - " + this.distrito;
        }
    }
}
