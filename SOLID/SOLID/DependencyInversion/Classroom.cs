using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public interface Teacher
    {
        public void Teach();
    }
    public class Classroom
    {
        Teacher teacher;
        Teacher teacher2;
        public Classroom()
        {

            teacher = new PrimaryTeacher();
            teacher2 = new MathTeacher();
        }
        public void Explain()
        {

            teacher.Teach();
            teacher2.Teach();

        }
    }
    public class PrimaryTeacher : Teacher
    {
        public void Teach()
        {
            Console.WriteLine("Sınıf öğretmeni");
        }
    }
    public class MathTeacher : Teacher
    {
        public void Teach()
        {
            Console.WriteLine("Matematik öğretmeni");
        }
    }
}
