string word = "bilgisayar";

for (int i = 0; i < word.Length; i++)
{
    if (word.Substring(i, 1) == "i")
    {
        Console.WriteLine(i);
    }
}