using System;
using TallerCRUD_LINQ.Controllers;

namespace TallerCRUD_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            int op2 = 0;
            int id = 0, IdEmpleado = 0,  dia = 0, idArea = 0;
            decimal sueldo = 0m, otro =0m;
            string nombre = string.Empty, apellido = string.Empty, direc = string.Empty, telefono= string.Empty;

            DateTime fecha = new DateTime();
            NominaController nc = new NominaController();
            EmpleadoController cemp = new EmpleadoController();
            AreaController ac = new AreaController();


            do
            {
                //Menú principal módulos
                Console.WriteLine("Escoja Modulo:\n 1. Empleados\n" +
                    " 2. Areas\n 3. Nominas\n 4. Salir");
                
                op = Convert.ToInt32(Console.ReadLine());

                //switch menú principal
                switch (op)
                {

                    case 1:
                        #region sbModEmpleado
                        
                        //Submenu módulo empleados
                        Console.WriteLine("Escoja Accion a realizar:\n 1. Mostrar Empleados\n" +
                            " 2. Mostrar empleado por Id\n 3. Crear empleado\n 4. Actualizar Empleado\n 5. Eliminar empleado x Id");
                        
                        op2 = Convert.ToInt32(Console.ReadLine());

                        cemp.MostrarEmpleados(); //Listamos empleados
                        
                        //switch módulo empleado
                        switch (op2)
                        {
                            //Opciones submenu módulo de empleados
                            case 1:
                                Console.WriteLine("-- Listado empleados --");
                                cemp.GetEmpleados();

                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 2:
                                Console.WriteLine("-- Listado empleados por Id --");
                                Console.WriteLine("Ingrese id empleado: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                cemp.GetbyIdEmp(id);
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 3:
                                Console.WriteLine("-- Crear nuevo empleado --");
                                Console.Write("Ingrese id empleado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese nombre empleado: ");
                                nombre = Console.ReadLine();

                                Console.Write("Ingrese apellido empleado: ");
                                apellido = Console.ReadLine();

                                Console.Write("Ingrese dirección empleado: ");
                                direc = Console.ReadLine();

                                Console.Write("Ingrese teléfono empleado: ");
                                telefono = Console.ReadLine();

                                Console.Write("Ingrese fecha ingreso: ");
                                fecha = Convert.ToDateTime(Console.ReadLine());

                                Console.Write("Ingrese id area: ");
                                idArea = Convert.ToInt32(Console.ReadLine());

                                cemp.PostEmpleado(id, nombre, apellido, direc, telefono, fecha, idArea);
                                cemp.GetEmpleados();

                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 4:
                                Console.WriteLine("-- Modificar empleado existente --");
                                Console.Write("Ingrese id empleado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese nombre empleado: ");
                                nombre = Console.ReadLine();

                                Console.Write("Ingrese apellido empleado: ");
                                apellido = Console.ReadLine();

                                Console.Write("Ingrese dirección empleado: ");
                                direc = Console.ReadLine();

                                Console.Write("Ingrese teléfono empleado: ");
                                telefono = Console.ReadLine();

                                Console.Write("Ingrese fecha ingreso: ");
                                fecha = Convert.ToDateTime(Console.ReadLine());

                                Console.Write("Ingrese id area: ");
                                idArea = Convert.ToInt32(Console.ReadLine());

                                cemp.UpdateEmpleado(id, nombre, apellido, direc, telefono, fecha, idArea);
                                cemp.GetEmpleados();

                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 5:
                                Console.WriteLine("-- Eliminar empleado por Id --");
                                Console.Write("Introduza id a eliminar: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                cemp.DeletebyIdE(id);
                                cemp.GetEmpleados();

                                Console.ReadKey();
                                Console.Clear();

                                break;

                            default:
                                Console.WriteLine("Funcion no valida");

                                Console.ReadKey();
                                Console.Clear();

                                break;
                        }
                        #endregion sbModEmpleado
                        break;

                    case 2:
                        #region sbModArea
                        
                        //Submenu módulo area
                        Console.WriteLine("Escoja Accion a realizar:\n 1. Mostrar Area\n" +
                            " 2. Mostrar Area x Id\n 3. Crear Area\n 4. Actualizar Area\n 5. Eliminar Area x Id");

                        op2 = Convert.ToInt32(Console.ReadLine());
                        ac.MostrarArea(); //Listamos areas

                        //switch módulo area
                        switch (op2)
                        {
                            //Opciones submenu módulo area
                            case 1:
                                Console.WriteLine("-- Listado Areas --");
                                ac.GetArea();

                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 2:
                                Console.WriteLine("-- Listado areas por Id --");
                                Console.WriteLine("Ingrese id area: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                ac.GetAreabyId(id);

                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 3:
                                Console.WriteLine("-- Crear nueva area --");
                                Console.Write("Ingrese id area: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese nombre area: ");
                                nombre = Console.ReadLine();

                                ac.PostArea(id, nombre);
                                ac.GetArea();

                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 4:
                                Console.WriteLine("-- Actualizar area --");

                                Console.Write("Ingrese Id: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese nombre: ");
                                nombre = Console.ReadLine();

                                ac.UpdateArea(id, nombre);
                                ac.GetArea();

                                Console.ReadKey();
                                Console.Clear();
                                break;

                            case 5:
                                Console.WriteLine("-- Eliminar area por id --");
                                Console.WriteLine("Ingrese id area a eliminar: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                ac.DeletebyIdA(id);
                                ac.GetArea();

                                Console.ReadKey();
                                Console.Clear();
                                break;

                            default:
                                Console.WriteLine("Funcion no valida");

                                Console.ReadKey();
                                Console.Clear();

                                break;
                        }
                        #endregion sbModArea
                        break;

                    case 3:
                        #region sbModNomina
                        
                        //Submenu módulo Nómina
                        Console.WriteLine("Escoja Accion a realizar:\n 1. Mostrar Nomina\n" +
                            " 2. Mostrar Nomina x Id\n 3. Crear Nomina\n 4. Actualizar Nomina\n 5. Eliminar Nomina x Id");

                        op2 = Convert.ToInt32(Console.ReadLine());
                        nc.LlenarLista(); //Listamos nómina
                        
                        //switch módulo nómina
                        switch (op2)
                        {
                            //Opciones submenu módulo nómina
                            case 1:
                                Console.WriteLine("-- Listado Nómina --");
                                nc.get();

                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 2:
                                Console.WriteLine("-- Listado Nómina por id --");
                                Console.WriteLine("Ingrese id nómina: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                nc.getbyID(id);

                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 3:
                                Console.WriteLine("-- Registre Nomina --");

                                Console.Write("Ingrese Id: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese fecha: ");
                                fecha = DateTime.Parse(Console.ReadLine());

                                Console.Write("Ingrese id empleado: ");
                                IdEmpleado = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese sueldo: ");
                                sueldo = Convert.ToDecimal(Console.ReadLine());

                                Console.Write("Ingrese dias de trabajo: ");
                                dia = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese otros pagos: ");
                                otro = Convert.ToDecimal(Console.ReadLine());

                                nc.post(id, fecha, IdEmpleado, sueldo, dia, otro);
                                nc.get();

                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 4:
                                Console.WriteLine("-- Editar nomina por id --");

                                Console.Write("Ingrese Id: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese fecha: ");
                                fecha = DateTime.Parse(Console.ReadLine());

                                Console.Write("Ingrese id empleado: ");
                                IdEmpleado = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese sueldo: ");
                                sueldo = Convert.ToDecimal(Console.ReadLine());

                                Console.Write("Ingrese dias de trabajo: ");
                                dia = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese otros pagos: ");
                                otro = Convert.ToDecimal(Console.ReadLine());

                                nc.update(id, fecha, IdEmpleado, sueldo, dia, otro);
                                nc.get();

                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 5:
                                Console.WriteLine("-- Eliminar nomina por id --");
                                Console.WriteLine("Ingrese id nómina que desea eliminar: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                nc.DeletexId(id);
                                nc.get();

                                Console.ReadKey();
                                Console.Clear();

                                break;

                            default:
                                Console.WriteLine("Funcion no valida");
                                Console.ReadLine();
                                
                                break;
                        }
                        #endregion sbModNomina
                        break;

                    case 4:
                        #region AbandonarApp
                        
                        char confirmacion = 'N';
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Realmente quieres salir? (S/N)");

                        confirmacion = Convert.ToChar(Console.ReadLine());
                        if (confirmacion == 'S')
                        {
                            op = 4;
                        }
                        else
                        {
                            op = 1;
                        }
                        #endregion AbandonarApp
                        break;

                    default:
                        Console.WriteLine("Módulo no valido");
                        break;
                }

            } while (op != 4);
        }//Final static void Main
    }//Final class Program
}//Final namespace
