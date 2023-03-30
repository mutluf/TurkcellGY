using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class MovieRepository : IReadRepository<Movie>
    {
        public Movie GetAll()
        {
            Console.WriteLine("Filmler listelendi");
            return new Movie();
        }
        
    }

    public class Movie { }
}
