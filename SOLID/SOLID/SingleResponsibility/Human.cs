using SingleResponsibility.Abstraction;
using System.Diagnostics.Metrics;

namespace SingleResponsibility
{
    public class Human : IHuman
    {

        public ICollection<Letter> Postala(Letter letter)
        {
            PostOffice postOffice = PostOffice.GetPostOfficeInstance();
            postOffice.Letters.Add(letter);
            return postOffice.Letters;

        }

        public void Read()
        {
            Console.WriteLine("İnsan Okur");
        }

        public Letter Write(string Content, string From, string To)
        {
            Letter letter = new Letter { Content = Content, From = From, To = To };
            return letter;

        }
    }
}
