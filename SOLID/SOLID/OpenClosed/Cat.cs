using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class Cat : IAnimal
    {
        public void React()
        {
            Console.WriteLine("Miyav der gelir.");
        }
    }
}
