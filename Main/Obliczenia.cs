using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Task_Prostokat.Main
{
    internal class Obliczenia
    {
        public static void Main()
        {
            Prostokąt arkusz = Prostokąt.ArkuszPapieru("A8");
            Console.WriteLine($"Bok A (wysokość): {arkusz.BokA} mm");
            Console.WriteLine($"Bok B (szerokość): {arkusz.BokB} mm");
            Console.WriteLine($"Wymiary: {arkusz.BokB}x{arkusz.BokA} mm");

            Console.ReadLine();
        }
    }
}
