using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class Bear : IAnimal
    {
        public void React()
        {
            Console.WriteLine("Pençe atar üstüne zıplar.");
        }
    }
}
