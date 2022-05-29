using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasAlumnos
{
    internal class Program
    {
        //variables globales, almacenar alumnos y notas en arreglo
        static string[] alumnos = new string[5];
        static int[] notas = new int[5];

        static void Main(string[] args)
        {
            Menu();
        }
        //método para mostrar el menu
        private static void Menu()
        {
            string opcionesMenu = "***Notas y promedios de estudiantes***\n";
            opcionesMenu += "1.Ingresar nombres de estudiantes y notas.\n";
            opcionesMenu += "2.Calcular el promedio.\n";
            opcionesMenu += "3.notas más altas.\n";
            opcionesMenu += "4.Aprobados y reprobados.\n";
            opcionesMenu += "5.Salir.";
            int opcion;
            do
            {
                Console.WriteLine(opcionesMenu);
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        IngresarDatos();
                        break;
                    case 2:
                        Promedio();
                        break;
                    case 3:
                        NotasMasAltas();
                        break;
                    case 4:
                        AprobadosReprobados();
                        break;
                    case 5:
                        Console.WriteLine("Fin del programa");
                        break;
                    default:
                        Console.WriteLine("Error, la opción digitada no existe.");
                        break;
                }

            } while (opcion !=5);
        }

        //método para ingresar los nombres y las notas de los estudiantes
        public static void IngresarDatos()
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante " + i);
                alumnos[i]= Console.ReadLine();
                Console.WriteLine("Ingrese la nota del estudiante " + i);
                notas[i] = int.Parse(Console.ReadLine());
                
            }
        }
        //método para calcular el promedio
        public static void Promedio()
        {
            int suma = 0;
            float promedio = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                suma+=notas[i];
            }
            promedio=suma/alumnos.Length;
            Console.WriteLine("El promedio de notas es de "+promedio);
        }
        //método para calcular las dos notas más altas
        public static void NotasMasAltas()   
        {
            int notaMayor1;
            int notaMayor2; 
            for (int i = 0; i < notas.Length; i++)
            {
                for (int j = 0; j < notas.Length; j++)
                {
                    if (notas[i] > notas[j])
                    {
                        int aux = notas[i];
                        notas[i] = notas[j];
                        notas[j] = aux;
                    }
                }
                    
            }
            notaMayor1 = notas[0];
            notaMayor2 = notas[1];
            Console.WriteLine("Las 2 notas más altas son " + notaMayor1 + " y " + notaMayor2);
            Console.ReadLine();
        }
        //método para mostrar la cantidad de aprobados y reprobados
        public static void AprobadosReprobados()
        {
            int aprobados=0;
            int reprobados=0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >=70)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }
            Console.WriteLine("La cantidad de aprobados es de " + aprobados + "\nLa cantidad de reprobados es de " + reprobados);
        }
    }
}
