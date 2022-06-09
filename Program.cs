namespace ConsoleApp1
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
          
            bool salir = false;
           Persona empleado = new Persona();
            
            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Registrar Empleados");
                    Console.WriteLine("2. Obtener la edad de un empleado");
                    Console.WriteLine("3. Obtener lista de empleados por orden alfabetico apellido");
                    Console.WriteLine("4. Obtener lista de empleados por orden de edad");
                    Console.WriteLine("5. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            empleado.registro();
                            break;

                        case 2:
                            empleado.listarId();
                           
                            break;

                        case 3:
                            empleado.listaOrdenAlfabetico();
                            break;
                        case 4:
                            empleado.listarEdad();
                            break;

                        case 5:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta, ingrese una opcion valida");
                            break;
                    }

                }
                catch (FormatException e)
                {

                }
            }

            Console.ReadLine();
        }
    }
}