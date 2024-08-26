using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillsTest
{
    public class Dog
    {
        #region Instance fields


        public int ID { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public int YearOfBirth { get; set; }

        #endregion

        public override string ToString()
    {
        return $"Id: {ID}, Name: {Name}, Race: {Race}, Year of birth {YearOfBirth} \n\n";
    }

    }

   
}
