using System;
using System.Collections.Generic;
using System.Linq;

namespace SingleResponsibility
{
    public class PostOffice
    {
        private static PostOffice instance;
        private PostOffice()
        {

        }

        public static PostOffice GetPostOfficeInstance()
        {

            if (instance == null)
            {
                instance = new PostOffice();
            }
            return instance;
        }

        public List<Letter> Letters { get; set; } = new();
    }
}
