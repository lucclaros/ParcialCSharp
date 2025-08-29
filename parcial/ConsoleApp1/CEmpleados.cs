using System;
using System.Collections;

namespace SegundoParcial
{
    class CEmpleados
    {
        private ArrayList lista;
        public CEmpleados()
        {
            this.lista = new ArrayList();

        }
        public void RegistrarProf(ulong id, string apell, string nom, ushort mat, string cat)
        {
            this.lista.Add(new CProfesional(id, apell, nom, mat, cat));
        }
        public void RegistrarChof(ulong id, string apell, string nom, ushort reg, string dist)
        {
            this.lista.Add(new CChofer(id, apell, nom, reg, dist));
        }
        public void Ordenar()
        {
            this.lista.Sort();
        }
        public void Mostrar()
        {
            foreach (CEmpleado aux in this.lista)
            {
                Console.WriteLine(aux.DarDatos());
            }
        }

    }
}