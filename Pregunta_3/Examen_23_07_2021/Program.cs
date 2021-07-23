using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_23_07_2021
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] languages = { "Lisp", "ICI", "C#", "Angular", "F#" };

            var result = string.Join(string.Empty, languages.Reverse().Select(s => s[0]));

            Console.WriteLine(result);


            Console.ReadKey();
        }
    }
}
