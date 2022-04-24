
// Escribir una función que recibe una cadena de caracteres como parámetro con una fecha de la forma
// “dd/mm/aaaa” y devuelve la fecha en formato “aaaa­‐mm­‐dd”.
// Ej.: 10/11/1977 -> 1977­‐11­‐10
//
// La función para cambiar el forma de la fecha está implementada en el método de clase ChangeFormat de la
// clase Program. Ese método se invoca desde el método de clase Main de la clase Program que es el punto de
// entrada del programa.

using System;

namespace DateFormat
{
    public class Program
    {
        public static String ChangeFormat(String year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }

        public static void Main(string[] args)
        {
            string testDate = "10/11/1977";
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat(testDate));
        }
    }
}