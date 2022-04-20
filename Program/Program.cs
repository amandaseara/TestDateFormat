
using System;

namespace DateFormat
{
    public class Program
    {
        // La funciónes para cambiar el forma de la fecha están implementada en
        // los métodos de clase ChangeFormat y ChangeFormat2 de la clase Program. 
        // Estos métodos se invocan desde el método de clase Main de la clase Program que es el punto de
        // entrada del programa.


        // Recibe una cadena de caracteres como parámetro con una fecha de la forma
        // “dd/mm/aaaa” y devuelve la fecha en formato “aaaa­‐mm­‐dd”.
        // Ej.: 10/11/1977 -> 1977­‐11­‐10

        public static String ChangeFormat(String year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }


        // Recibe una cadena de caracteres como parámetro con una fecha de la forma
        // “dd/mm/aaaa” y devuelve la fecha en formato “dd.mm.aaaa”.
        // Ej.: 10/11/1977 -> 10.11.1977
        public static String ChangeFormat2(String year)
        {
            return year.Substring(0,2) + "." + year.Substring(3, 2) + "." + year.Substring(6);
        }

        public static void Main(string[] args)
        {
            string testDate = "10/11/1977";
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat(testDate));

            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat2(testDate));
        }
        
    }
}