using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2A_DU2_Pešek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program vypočítá za jak dlouho a v jaké vzdálenosti první auto dožene druhé auto");

            Console.ReadKey();
            Console.Clear();

            Console.Write("Napiš prosím rychlost prvního auta (auto které dojíždí) v km/h: ");
            double rychlost1 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.Write("Napiš prosím rychlost druhého auta (auto které má náskok) v km/h: ");
            double rychlost2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            if (rychlost1 <= rychlost2)
            {
                Console.WriteLine("Druhé vozidlo nikdy nedožene první vozidlo, protože je pomalejší nebo stejně rychlé.");
            }
            else
            {
                Console.Write("Napiš prosím náskok prvního vozidla před druhým (v hodinách): ");
                double naskok = Convert.ToDouble(Console.ReadLine());

                Console.Clear();

                double cas = naskok * rychlost2 / (rychlost1 - rychlost2);
                double vzdalenost = rychlost1 * cas;

                Console.WriteLine("Druhé vozidlo dožene první vozidlo za "+ cas + " hodin a ve vzdálenosti "+ vzdalenost +" km od počátku.");
            }
            Console.ReadKey();

        }
    }
}