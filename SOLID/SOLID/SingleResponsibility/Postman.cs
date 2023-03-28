using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Postman
    {
        public void PostaTopla()
        {
            PostOffice postOffice = PostOffice.GetPostOfficeInstance();
            var letters = postOffice.Letters;
            PostaDagit(letters);
            postOffice.Letters.RemoveRange(0, postOffice.Letters.Count);
        }

        public void PostaDagit(List<Letter> letters)
        {
            foreach (var item in letters)
            {
                Console.WriteLine($"{item.From} adlı kişiden olan posta {item.To} kişisine gönderilmiştir!");
                //Console.WriteLine("{0}  adlı kişiden olan posta {1} kişisine gönderilmiştir!",item.From,item.To);
            }
        }

    }

}
