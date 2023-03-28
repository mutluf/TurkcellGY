using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Abstraction
{
    public interface IHuman
    {
        public Letter Write(string Content, string From, string To);
        public ICollection<Letter> Postala(Letter letter);
        public void Read();
    }
}
