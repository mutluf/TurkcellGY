using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{

    public class Philosophy : Lecture
    {

        //Encapsulation
        public string Lemma { get; set; }
        public string Questions { get; set; }
        public override string Name { get; set; } = "Felsefe";
        public override string Teacher { get; set; } = "Platon";

        public virtual void Question()
        {
            Console.WriteLine("Ateş olup isyan ettim de cürmüm kadar yerini yakabildim mi söylesene tanrım? Sana gücenmezdim ben seni bu düzenin içine koymuş olsaydım.\n");
        }

    }


    public class Epistemology : Philosophy //Inheritence
    {
        private string Lemma { get; set; } = "Bilgi Felsefesi";
        private string Questions { get; set; } = "Bilgi nedir? Öğeleri nelerdir? Nasıl oluşur? Bilginin kaynağı akıl ya da dış dünya mıdır?\r\n\r\nDoğru mutlak bilginin ölçütü nedir? Bilgi mutlak mı? Yoksa göreli midir?\r\n\r\nBir şey bilinebilir mi? Bir şeyi nasıl biliriz?\r\n\r\nBilgimiz nesneleri doğru olarak yansıtıyor mu?";


        //Polymorphism
        public override void Question()
        {

            Console.WriteLine($"{Lemma}, {Questions} sorularını sorar. Cevabın ne?");
            string answer = Console.ReadLine();

            Console.WriteLine($"{answer} cevabın için teşekkür ederiz.");
        }
    }

    public class Ontology : Philosophy
    {

        private string Lemma { get; set; } = "Varlık Felsefesi";
        private string Questions { get; set; } = "Varlık var mıdır? Yok mudur? Nedir? Varlığın özü nedir? Değişken midir?\r\n\r\nEvren sonlu mudur? Başlangıcı var mıdır? Evrende özgürlük var mıdır?\r\n\r\nKaç türlü varlık vardır? Varlığın niteliği nedir?\r\n\r\nİnsanın varlık amacı nedir? Evrende amaçlılık var mıdır?";
        public override void Question()
        {

            Console.WriteLine($"{Lemma}, {Questions} sorularını sorar. Cevabın ne?");
            string answer = Console.ReadLine();

            Console.WriteLine($"{answer} cevabın için teşekkür ederiz.");
        }
    }

    public class Ethics : Philosophy
    {
        private string Lemma { get; set; } = "Ahlak Felsefesi";
        private string Questions { get; set; } = "Ahlakın kaynağı nedir? Ahlaki eylemin bir amacı var mıdır?\r\n\r\nİnsan eylemlerinde özgür müdür? Ahlak yargılarının niteliği nedir?\r\n\r\nTüm insanların benimseyeceği ahlak yasaları var mıdır?Ahlak yargılarının niteliği nedir?\r\n\r\nİyi ve kötü nedir? İyilik doğuştan mıdır yoksa sonradan mı kazanılmıştır?";
        public override void Question()
        {

            Console.WriteLine($"{Lemma}, {Questions} sorularını sorar. Cevabın ne?");
            string answer = Console.ReadLine();

            Console.WriteLine($"{answer} cevabın için teşekkür ederiz.");
        }
    }

    public class PoliticalPhilosophy : Philosophy
    {
        private string Lemma { get; set; } = "Siyaset Felsefesi";
        private string Questions { get; set; } = "İktidar kaynağını nereden alır? Egemenliğin kullanılış biçimleri nelerdir?\r\n\r\nSivil toplumun bürokrasinin anlamı nedir? Meşruiyetin ölçütleri nelerdir?\r\n\r\nDevlet nasıl yönetilmelidir? En iyi yönetim biçimi hangisidir?\r\n\r\nDevlet-birey ilişkisi nasıl olmalıdır? Bireyin temel hakları nelerdir?";
        public override void Question()
        {

            Console.WriteLine($"{Lemma}, {Questions} sorularını sorar. Cevabın ne?");
            string answer = Console.ReadLine();

            Console.WriteLine($"{answer} cevabın için teşekkür ederiz.");
        }
    }

    public class PhilosophyOfScience : Philosophy
    {
        private string Lemma { get; set; } = "Bilim Felsefesi";
        private string Questions { get; set; } = "Çeşitli bilimler arasında ortak noktalar var mıdır? Varsa buna dayanarak bilimleri sınıflandırmak mümkün müdür?” Bilim nedir?\r\n\r\nBilgiler topluluğu mudur? Bilimde her şey olup bitmiş midir?";
        public override void Question()
        {

            Console.WriteLine($"{Lemma}, {Questions} sorularını sorar. Cevabın ne?");
            string answer = Console.ReadLine();

            Console.WriteLine($"{answer} cevabın için teşekkür ederiz.");
        }
    }

    public class Aesthetics : Philosophy
    {
        private string Lemma { get; set; } = "Estetik";
        private string Questions { get; set; } = "Sanat nedir? Sanat eserinin işlevi nedir?\r\n\r\nBir nesneyi güzel yapan şey nedir? Herkesin güzel dediği bir nesne olabilir mi?\r\n\r\nOrtak estetik yargılar var mıdır?";
        public override void Question()
        {

            Console.WriteLine($"{Lemma}, {Questions} sorularını sorar. Cevabın ne?");
            string answer = Console.ReadLine();

            Console.WriteLine($"{answer} cevabın için teşekkür ederiz.");
        }
    }

    public class PhilosophyOfReligion : Philosophy
    {
        private string Lemma { get; set; } = "Din Felsefesi";
        private string Questions { get; set; } = "Tanrı var mıdır? Onun varlığını gösteren kanıtlar gösterilebilir mi? Vahiy mümkün müdür?\r\n\r\nEvren Yaratılmış bir varlık mıdır? Yoksa Yaratılmamış (Ezeli ve Ebedi) bir varlık mıdır?\r\n\r\nÖlüm bir son mudur? Ölümden sonra bir hayat var mıdır?\r\n\r\nRuh var mıdır? Nedir? Ölümsüz müdür?";
        public override void Question()
        {

            Console.WriteLine($"{Lemma}, {Questions} sorularını sorar. Cevabın ne?");
            string answer = Console.ReadLine();

            Console.WriteLine($"{answer} cevabın için teşekkür ederiz.");
        }
    }
}
