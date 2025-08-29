using System;
namespace SegundoParcial
{
    public class CControladora
    {
        public static void Main()
        {
            CEmpleados listaEmpleados = new CEmpleados();
            CVehiculos listaVehiculos = new CVehiculos();
            char opcion;
            do
            {
                char.TryParse(CInterfaz.DarOpcion().ToUpper(), out opcion);
                //.ToUpper() Convierte la cadena a MAYÚSCULAS.
                switch (opcion)
                {
                    case 'A':
                        ulong id = Convert.ToUInt64(CInterfaz.PedirDato("Codigo de identificacion del personal"));
                        string apellido = CInterfaz.PedirDato("Apellido");
                        string nombre = CInterfaz.PedirDato("Nombre");
                        Console.WriteLine("Ingrese tipo de empleado");
                        string tipo = Console.ReadLine();
                        if (tipo == "profesional")
                        {
                            ushort mat = ushort.Parse(CInterfaz.PedirDato("Matricula"));
                            string cat = CInterfaz.PedirDato("Categoria");
                            listaEmpleados.RegistrarProf(id, apellido, nombre, mat, cat);
                        }
                        else
                        {
                            ushort reg = ushort.Parse(CInterfaz.PedirDato("Registro"));
                            string dist = CInterfaz.PedirDato("Distrito");
                            listaEmpleados.RegistrarChof
                                (id, apellido, nombre, reg, dist);
                        }
                        break;
                    case 'B':
                        listaEmpleados.Ordenar();
                        listaEmpleados.Mostrar();
                        break;
                    case 'C':
                        string patente = CInterfaz.PedirDato("Patente");
                        string marca = CInterfaz.PedirDato("MArca");
                        string modelo = CInterfaz.PedirDato("Modelo");
                        Console.WriteLine("¿Es una ambulancia?");
                        string respuesta = Console.ReadLine();
                        if (respuesta == "si")
                        {
                            string tip = CInterfaz.PedirDato("Tipo de ambulancia");
                            listaVehiculos.Registrar(patente, marca, modelo, tip);
                        }
                        else
                        {
                            listaVehiculos.Registrar(patente, marca, modelo);
                        }
                        break;
                    case 'D':
                        listaVehiculos.Ordenar();
                       // listaVehiculos.Mostrar();
                        break;
                    case 'E':

                        break;
                    //case 'R':
                    //    codigo = CInterfaz.PedirDato("Código de vuelo").ToUpper();
                    //    if (!listadoVuelos.Remover(codigo))
                    //    {
                    //        CInterfaz.MostrarInfo("Vuelo inexistente");
                    //    }
                    //    else
                    //    {
                    //        CInterfaz.MostrarInfo("Vuelo removido");
                    //    }
                    //    break;
                    //case 'T':
                    //    listadoVuelos.Remover();
                    //    CInterfaz.MostrarInfo("Vuelos removidos");
                    //    break;
                    //case 'S':
                    //    break;
                    default:
                        CInterfaz.MostrarInfo("Opción inválida");
                        break;
                }
            } while (opcion != 'S');
        }
    }
}
