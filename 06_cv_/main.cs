using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_cv_
{
    internal class main
    {
        static void Main()
        {
            double celkovaPlocha = 0;
            double celkovyPovrch = 0;
            double celkovyObjem = 0;

            GrObject[] grObjects = new GrObject[]
            {
                new Kruh(2),
                new Obdelnik(3, 4),
                new Elipsa(3, 4),
                new Trojuhelnik(3, 4, 5),
                new Kvadr(3, 4, 5),
                new Valec(5, 3),
                new Koule(5),
                new Jehlan(5, 3, 4)
            };

            foreach (GrObject grObject in grObjects)
            {
                grObject.Kresli();

                if (grObject is Objekt2D)
                {
                    celkovaPlocha += ((Objekt2D)grObject).SpoctiPlochu();
                }

                if (grObject is Objekt3D)
                {
                    celkovyObjem += ((Objekt3D)grObject).SpoctiObjem();
                    celkovyPovrch += ((Objekt3D)grObject).SpoctiPovrch();
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Celková plocha: {celkovaPlocha}");
            Console.WriteLine($"Celkový povrch: {celkovyPovrch}");
            Console.WriteLine($"Celkový objem: {celkovyObjem}");
        }
    }
}
