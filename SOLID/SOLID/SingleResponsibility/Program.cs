using SingleResponsibility;
using SingleResponsibility.Abstraction;


IHuman human = new Human();
Postman postman = new Postman();
ICollection<Letter> letters = new List<Letter>();

Console.WriteLine("Selam ne yapmak istiyorsunuz?\n (Mektup yazmak için 1, mektuplarınızı görmek için 2)");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Kime göndereceksin?");
    string to = Console.ReadLine();

    Console.WriteLine("Mektubunu yaz.");
    string content = Console.ReadLine();

    Console.WriteLine("Adını yaz.");
    string from = Console.ReadLine();

    Letter letter = human.Write(content, from, to);
    Console.WriteLine("Mektubunuz hazırdır" + letter.Content + letter.From + letter.To);
    Console.WriteLine("Göndermek için 1'e basınız");
    int gonder = int.Parse(Console.ReadLine());
    if (gonder == 1)
    {
        letters = human.Postala(letter);
    }

}
postman.PostaTopla();
//Console.WriteLine("Selam ne yapmak istiyorsunuz?\n (Mektup yazmak için 1, mektuplarınızı görmek için 2)");
//int gormek = int.Parse(Console.ReadLine());

//if (gormek == 2)
//{
//    Console.WriteLine(letters.ElementAt(0).Content);
//}


//foreach (var item in letterss)
//{
//    Console.WriteLine(item.Content);
//}

