using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    //Abstraction
    public abstract class Lecture
    {
        public abstract string Name { get; set; }

        public abstract string Teacher { get; set; }
    }
}
