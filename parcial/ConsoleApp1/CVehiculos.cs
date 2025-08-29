using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace SegundoParcial
{
    class CVehiculos
    {
        private ArrayList lista;
        public CVehiculos()
        {
            this.lista = new ArrayList();

        }
        public void Registrar(string patente, string marca, string modelo, string tipo)
        {
            this.lista.Add(new CAmbulancia(patente, marca, modelo, tipo));
        }
        public void Registrar(string patente, string marca, string modelo)
        {
            this.lista.Add(new CAuto(patente, marca, modelo));
        }
        public void Ordenar()
        {
            this.lista.Sort();
        }
        public void Mostrar()
        {
            foreach (CVehiculo aux in this.lista)
            {
                Console.WriteLine(aux.DarDatos());
            }
        }
    }
}