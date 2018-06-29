using System;
using System.Reflection;
using static EJ_Reflection.Program;


namespace EJ_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly myAssembly = typeof(Program).Assembly;
            //get type of class Calculator from just loaded assembly
            Type alumnoType = myAssembly.GetType("EJ_Reflection.Alumno");

            //create  instance  of  class Calculator
            object objetoDeAlumno = Activator.CreateInstance(alumnoType, 1,"Ares","Ordoñez","3243434x");
            //Console.WriteLine(((Alumno)objetoDeAlumno).Nombre);

            //((Alumno)alumno).Nombre
            /*  Alummno miAlumno = (Alumno)alumno;
             *  miAlumno.Nombre = "Ares";*/

            Alumno miAlumno = (Alumno)objetoDeAlumno;
            Console.WriteLine(miAlumno.Nombre);

        }
    }
}
