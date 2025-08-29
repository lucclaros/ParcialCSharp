using System;
using System.Collections;

namespace SegundoParcial
{
    class CDotacion
    {
        private DateTime fecha;
        private CChofer chofer;
        private CVehiculo vehiculo;
        private ArrayList profesionales;

        public CDotacion(CChofer chofer, CVehiculo vehiculo, CProfesional prof)
        {
            this.chofer = chofer;
            this.vehiculo = vehiculo;
            this.profesionales.Add(prof);
        }

    }
}
