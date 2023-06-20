using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class MainClass
    {
        public string Name { get; set; }

        public void MainMethod()
        {
            Console.WriteLine("I'm in MainMethod");
        }

        public class NestedClass
        {
            public void NestedMethod()
            {
                Console.WriteLine("I'm in NestedMethod");
            }
        }

        public class DerivedNedted : BaseClass
        {
            public DerivedNedted(string text)
            {
                field = text;
            }
            public string field;

            public string GetField()
            {
                return field;
            }
        }
    }
}
