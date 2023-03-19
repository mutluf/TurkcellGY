using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    public class Math : Lecture
    {
        public override string Name { get; set; } = "Matematik";
        public override string Teacher { get; set; } = "Cahit Arf";
        public void Calculate()
        {
            Console.WriteLine("İşlem yapıldı");
        }

    }
}
