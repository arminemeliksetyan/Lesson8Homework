using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class ApartamentClass
    {
        public string country;
        public string city;
        public string street;
        public int building;
        public int numberFlat;
        public float sqMeter;

        public ApartamentClass(string country, string city, string street, int building, int numberFlat, float sqMeter)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.building = building;
            this.numberFlat = numberFlat;
            this.sqMeter = sqMeter;
        }

        public class MaxSquare
        {
            public void PrintCountry(ApartamentClass apartament)
            {
                Console.WriteLine(" appartment3 country is " + apartament.country);
            }

            public string MaxSq(ApartamentClass apartament)
            {
                if (apartament.sqMeter > 70)
                {
                    return apartament.sqMeter.ToString();
                }
                else
                {
                    return "It is smaller than 70 qm";
                }

            }
        }
    }

}
