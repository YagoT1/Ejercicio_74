using System;

namespace Ejercicio_74
{
    class Program
    {
        static void Main(string[] args)
        {
            int CantidadAlumnos;
            int Nota1, Nota2, Nota3;
            int Promedio;
            do
            {
                Console.WriteLine("Ingrese uno cantidad de alumnos");
                CantidadAlumnos = int.Parse(Console.ReadLine());
            } while (CantidadAlumnos < 0);

            for (int i = 0; i < CantidadAlumnos; i++)
            {
                Console.WriteLine("INGRESE EL NOMBRE DE UN ALUMNO");
                var NombreAlumno = Console.ReadLine();

                do
                {
                    Console.Write("Ingrese la primer nota del alumno: ");
                    Nota1 = int.Parse(Console.ReadLine());
                } while (Nota1 <= 1 && Nota1 > 11);

                do
                {
                    Console.Write("Ingrese la segunda nota del alumno: ");
                    Nota2 = int.Parse(Console.ReadLine());
                } while (Nota2 <= 1 && Nota2 > 11);

                do
                {
                    Console.Write("Ingrese la tercer nota del alumno: ");
                    Nota3 = int.Parse(Console.ReadLine());
                } while (Nota3 <= 1 && Nota3 > 11);
                var suma = Nota1 + Nota2 + Nota3;
                Promedio = (int)Math.Truncate((double)suma / 3);

                Console.WriteLine($"El alumno {NombreAlumno} obtuvo un promedio {Promedio}");
                if (Promedio >= 1 && Promedio <= 3)
                {
                    Console.WriteLine("El alumno es *APLAZADO*");
                }
                else
                {
                    if (Promedio >= 4 && Promedio <= 6)
                    {
                        Console.WriteLine("El alumno es *DESAPROBADO*");
                    }
                    else
                    {
                        if (Promedio >= 7 && Promedio <= 8)
                        {
                            Console.WriteLine("El alumno es *APROBADO*");
                        }
                        else
                        {
                            if (Promedio == 9)
                            {
                                Console.WriteLine("El alumno es *NOTABLE*");
                            }
                            else
                            {
                                if (Promedio == 10)
                                {
                                    Console.WriteLine("El alumno es *SOBRESALIENTE*");
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("*************************************************");
            }
            Console.ReadLine();
        }
    }
}
