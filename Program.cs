using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Array1();
            ArrayImplicito();
            ArrayTipoAnonimo();

            Console.Read();
        }

        static void Array1()
        {
            int[] mi_matriz;
            mi_matriz = new int[4];
            int[] matriz = new int[4];
            int[] matriz2 = new int[] { 3, 2, 5 };
            Console.WriteLine(matriz[2]);//cuando no he asignado un valor me asignará el valor 0 por defecto.

            int[] edades;
            edades = new int[4];
            edades[0] = 15;
            edades[1] = 27;
            edades[2] = 19;
            edades[3] = 80;

            Console.WriteLine(edades[2]);
        }

        public static void ArrayImplicito()
        {
            //Array implicito

            // var datos = new[] { "Juan", "Díaz", "España" };
            // var datos = new[] { "Juan", "Díaz", 15 };// Me arrojaría un error

            var valores = new[] { 15, 28, 35, 75.5, 30.30, 90, 15, 28, 35, 75.5, 30.30, 90 }; // Todo a double// Atento que no implime en 90 --- vamos a otra clase a ver el bucle For Each
                                                                                              //https://www.youtube.com/watch?v=Cx0UW5PQJG0



            //arrays de objetos



            Empleados Ana = new Empleados("Ana", 27);
            Empleados[] arrayEmpleados = new Empleados[3];
            arrayEmpleados[0] = new Empleados("Sara", 37);
            arrayEmpleados[1] = Ana;
            arrayEmpleados[2] = new Empleados("Carolina", 30);

            

            //https://www.youtube.com/watch?v=Cx0UW5PQJG0
            //Insertar el blucle dentro del codigo 

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            /*//Bucle Normal
            for (int j = 0; j <arrayEmpleados.Length; j++)
            {
                Console.WriteLine(arrayEmpleados[j].getInfo());

            }*/

            // Bucle Foreach

            foreach (Empleados variable in arrayEmpleados)//Creamos una variable iterador
            {
                Console.WriteLine(variable.getInfo());
            }

            foreach (double variable in valores)
            {
                Console.WriteLine(variable);
            }             
    
        }

        public static void ArrayTipoAnonimo()//clases que no tienen nombre 
        {
            var personas = new[]
            {
                new{Nombre = "Juan", Edad = 19},
                new{Nombre = "María", Edad = 49},
                new{Nombre = "Diana", Edad = 35},
                new{Nombre = "Cristhian", Edad = 33},
                new{Nombre = "Tristán", Edad = 5}
            };

           // Console.WriteLine(personas[1]);

            foreach (var variable in personas)
            {
                Console.WriteLine(variable);
            }
        }

        static void ProcesaDatos(int [] datos)//ArraysPorParametros
        {
            foreach (int i in datos)
            {
                Console.WriteLine(i);

              // TODO  //https://www.youtube.com/watch?v=6BFiyFuaLYQ
            }
        }

    }

    class Empleados
    {
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public String getInfo()
        {
            return "Nombre del Empleado: " + nombre + " Edad: " + edad;
        }
        private String nombre;
        private int edad;
    }
}
