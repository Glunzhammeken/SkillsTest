using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Events
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Events ()
        {

        }

        public override string ToString()
        {
            return $"Id: {ID}, Name: {Name}, Price: {Price} \n\n";
        }

    }
}
