using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Persona
    {
        //atributos
        int id;
        string nombre;
        string apellido_paterno;
        string apellido_materno;
        DateTime fecha_nac_s;
        double edad;
        
        //getters & setters

        public int Id
        {
            get { return id; }
            set { id = value; } 
        }

        public string Nombre
        {
            get { return nombre; }  
            set { nombre = value; }
        }
        public string Apellido_Paterno
        {
            get { return apellido_paterno; }
            set { apellido_paterno = value; }
        }

        public string Apellido_Materno {
            get { return apellido_materno; }
            set { apellido_materno = value;}   
        }

        public DateTime Fecha_Nac_S
        {
            get { return fecha_nac_s; }
            set { fecha_nac_s = value;}
        }
        public double Edad
        {
            get { return edad; }
            set { edad = value; }
        }


        //constructores


        public Persona()
        {
            id = 0;
            nombre = "";
            apellido_paterno = "";
            apellido_materno = "";
            fecha_nac_s = new DateTime();
            edad = 0.0;

        }
        public Persona(int id, string nombre, string apellido_paterno, string apellido_materno, DateTime fecha_nac_s, double edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido_paterno = apellido_paterno;
            this.apellido_materno = apellido_materno;
            this.fecha_nac_s = fecha_nac_s;
            this.edad = edad;
     
        }

        //Methods

        //  **Registrar empleados **/
        List<Persona> lista = new List<Persona>();
        public void registro()
        {
            try
            {
                Console.WriteLine("Ingrese Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar nombre: ");
                string Nombre = Console.ReadLine();
               
                Console.WriteLine("Ingresar apellido paterno: ");
                string Apellido_Paterno = Console.ReadLine();

                Console.WriteLine("Ingresar apellido materno: ");
                string Apellido_Materno = Console.ReadLine();

                Console.WriteLine("Ingresar fecha de nacimiento en el formato dd/mm/yyyy: ");
                DateTime fecha_nac_sR = DateTime.Parse(Console.ReadLine());

                lista.Add(new Persona(id, Nombre, Apellido_Paterno, Apellido_Materno, fecha_nac_sR, 0));

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Intenta de nuevo");
                registro();
            }
           
            
        }
       
        public void listarId()
        {
            try
            {
                Console.WriteLine("Ingresa el id: ");
                int idR = int.Parse(Console.ReadLine());

                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Id == idR)
                    {
                        DateTime fechaActual = DateTime.Now;
                        TimeSpan diferencia = fechaActual - lista[i].fecha_nac_s;
                        double dias = diferencia.TotalDays;
                        double años = Math.Floor(dias / 365);
                        Console.WriteLine("El empleado " + lista[i].nombre + " tiene " + años + " años");

                    }

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Favor de ingresar un numero");
                listarId();
            }
        }

        public void listaOrdenAlfabetico()
        {
           
            var ordenAlfabetico = lista.OrderBy(x => x.apellido_paterno).ToList();

            for(int i=0; i<ordenAlfabetico.Count; i++)
            {
                Console.WriteLine(ordenAlfabetico[i].apellido_paterno +" "
                                 + ordenAlfabetico[i].apellido_materno + " "
                                 + ordenAlfabetico[i].nombre + " "
                                 + ordenAlfabetico[i].fecha_nac_s);
            }
        }

        public void listarEdad()
        {
            for(int i=0; i<lista.Count; i++)
            {
                DateTime fechaActual = DateTime.Now;
                TimeSpan diferencia = fechaActual - lista[i].fecha_nac_s;
                double dias = diferencia.TotalDays;
                double años = Math.Floor(dias / 365);
                lista[i].edad = años;
                
            }

            var ordenEdad = lista.OrderBy(x => x.edad).ToList();

            for (int i = 0; i < ordenEdad.Count; i++)
            {
                Console.WriteLine(ordenEdad[i].edad + " "
                                 + ordenEdad[i].apellido_paterno + " "
                                 + ordenEdad[i].apellido_materno + " "
                                 + ordenEdad[i].nombre + " "
                                 + ordenEdad[i].fecha_nac_s);
            }

        }


    }
}
