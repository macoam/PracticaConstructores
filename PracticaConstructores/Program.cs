using System;

namespace PracticaConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Console.WriteLine("Alumno 1");
            Console.WriteLine("Nombre: " + alumno1.Nombre);
            Console.WriteLine("Matricula: " + alumno1.Matricula);

            Alumno alumno2 = new Alumno("Juanito", "12345");
            Console.WriteLine("Alumno 2");
            Console.WriteLine("Nombre: " + alumno2.Nombre);
            Console.WriteLine("Matricula: " + alumno2.Matricula);

            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Pedro";
            alumno3.Matricula = "09876";
            Console.WriteLine("Alumno 3");
            Console.WriteLine("Nombre: " + alumno3.Nombre);
            Console.WriteLine("Matricula: " + alumno3.Matricula);


            Console.Read();


        }
    }
}
