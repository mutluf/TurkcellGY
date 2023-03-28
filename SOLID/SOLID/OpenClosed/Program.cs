using OpenClosed;

IAnimal animal = new Bear();

if (animal.GetType().Name == "Cat")
{
    animal.React();
    Console.WriteLine("Kaçmana gerek yok.");
}
else if (animal.GetType().Name == "Bear")
{
    animal.React();
    Console.WriteLine("Kaç!");
}
