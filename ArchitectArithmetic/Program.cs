using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectArithmetic
{
    class Program
    {
        /*
            Architects have big ideas – but big ideas can be expensive. How expensive? Depends on the size.

            In this project, you’ll use methods to build a program that calculates the material cost for any architect’s floor plan. 
            For example, the floor plan of the a) Teotichuacan in Mexico City, Mexico, b) Taj Mahal in Agra, India and c) Al-Masjid al-haram (Great Mosque) in Mecca, Saudi Arabia: 
        */

        static void CalculateTotalCost()
        {
            string monument = "";
            double totalArea;

            while(monument!="1" && monument!="2" && monument != "3")
            {
                Console.WriteLine("What monument would you like to work with?");
                Console.Write("Choose number (1) for Teotihuacan, (2) for Taj Mahal or (3) for Great Mosque of Mecca: ");
                monument = Console.ReadLine();
            }

            switch (monument)
            {
                case "1":
                    totalArea = Rect(1500, 2500) + Triangle(750, 500) + Circle(375) / 2;
                 break;

                case "2":
                    totalArea = Rect(90.5, 90.5) - 4 * Triangle(24, 24);
                 break;

                case "3":
                    totalArea = Rect(180, 106) + Rect(284, 284) - Triangle(264, 84);
                    break;

                default:
                    totalArea = 0;
                break;
            }

            double totalCost = totalArea * 180;
            Console.WriteLine($"My plans cost {Math.Round(totalCost, 2)} euros.");
        }

        static double Rect(double length, double width)
        {
            return length * width;
        }
        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }

        static void Main(string[] args)
        {
            CalculateTotalCost();
        }
    }
}
