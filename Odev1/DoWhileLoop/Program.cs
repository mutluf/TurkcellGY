// do while ile kullanıcıdan alınan sayıların aritmetik toplamasını, en büyük ve en küçük sayıyı döndüren program
int count = 0;
int total = 0;
int minValue = int.MaxValue, maxValue = int.MinValue;
int number;
bool result = true;
string? answer = "evet";

while (answer == "evet")
{
    do
    {
        do
        {
            Console.WriteLine($"Bir sayı girin: {count}/5 ");
            result = int.TryParse(Console.ReadLine(), out number);
            if (result == true)
            {
                total += number;
                break;
            }
        }
        while (!result);

        if (number < minValue)
        {
            minValue = number;
        }

        if (number > maxValue)
        {
            maxValue = number;
        }
        count++;
    } while (count < 5);

    float average = total / 5f;
    Console.WriteLine($"\nGirdiğiniz beş sayının aritmetik ortalaması: {average}");
    Console.WriteLine($"\nGirdiğiniz beş sayıdan en küçüğü: {minValue}, en büyüğü: {maxValue}");
    Console.WriteLine("Devam etmek istiyorsanız evet yazın.");

    //değişkenleri sıfırlamak için oluşturulmuş bir metot.
    ClearVariables();
    answer = Console.ReadLine();
    Console.Clear();
}

void ClearVariables()
{
    count = 0; number = 0; minValue = int.MaxValue; maxValue = int.MinValue; total = 0; result = true;
}