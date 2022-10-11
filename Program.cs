using System;

namespace ejer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cursoName, turno;
            int cantAlumnos=0;
            int nota=0;
            float totalNotas=0f;
            float promedio=0f;
            
            
            Console.WriteLine(" - - SISTEMA DE NOTAS - -");
            Console.WriteLine("Ingrese nombre del curso: ");
            cursoName=Console.ReadLine();
            Console.WriteLine("Ingrese Turno: ");
            turno=Console.ReadLine();

            Console.WriteLine("Cantidad de Alumnos: ");
            cantAlumnos=Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for(int i=0; i<cantAlumnos; i++){
                Console.WriteLine("Ingrese Nota: ");
                nota=Convert.ToInt32(Console.ReadLine());
                totalNotas=totalNotas+nota;
                Console.Clear();
            }

            promedio=((float)totalNotas/(float)cantAlumnos);
            Console.WriteLine(" - - SISTEMA DE NOTAS - -");
            Console.WriteLine("Nombre del Curso: " + " " + cursoName);
            Console.WriteLine("  TURNO         : " + " " + turno);
            Console.WriteLine("  PROMEDIO      : " + " " + promedio);


        }
    }
}
