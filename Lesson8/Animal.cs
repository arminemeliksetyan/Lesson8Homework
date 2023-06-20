using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal struct Animal
    {
        public string name;
        public bool hat;
        public int speed;
        public string voice;

        public Animal(string name, bool hat, int speed, string voice)
        {
            this.name = name;  
            this.hat = hat;
            this.speed = speed;
            this.voice = voice;
        }



    }
}
