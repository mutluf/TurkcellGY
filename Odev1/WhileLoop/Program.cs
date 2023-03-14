//Verilen dizideki en büyük ve en küçük elemanın ortalamasını bularak ortalamayı dizideki herbir elemandan çıkartıp elde edilen diziyi tersine çeviren program.

int[] array = { 25, 6, 52, 33, 79, 94 };
Console.WriteLine("Dizi: 25, 6, 52, 33, 79, 94");

int count = 0;
int smallestNumber = array[0];
int greatestNumber = array[0];
int index = 0;
int total = 0;

//find smallest and greatest element in array
while (count < array.Length)
{
    total += array[index];
    if (array[index] < smallestNumber)
    {
        smallestNumber = array[index];
    }

    if (array[index] > greatestNumber)
    {
        greatestNumber = array[index];
    }
    index++;
    count++;
}
int arrayAverage= total/ array.Length;
Console.WriteLine($"Dizinin aritemtik ortalaması: {arrayAverage}");
Console.WriteLine($"\n Dizideki en küçük sayı:{smallestNumber}, dizideki en büyük sayı:{greatestNumber}");

int average = (smallestNumber + greatestNumber) / 2;
Console.WriteLine($"\n En büyük sayı ile en küçük sayının aritmetik ortalaması:{average}");
int i = 0;

//subtract the average from each element in array
foreach (var item in array)
{
    array[i++] -= average;

}

//sort array element ascending
int temp;
for (int j = 0; j < array.Length - 1; j++)
{
    for (int k = 0; k < array.Length - 1 - j; k++)
    {
        if (array[k] > array[k + 1])

        {
            temp = array[k];
            array[k] = array[k + 1];
            array[k + 1] = temp;
        }
    }
}

Console.WriteLine("\nEn büyük sayı ile en küçük sayının aritmetik ortalaması her bir elemenden çıkartılarak oluşturulmuş yeni dizi:");
foreach (var item in array)
{
    Console.WriteLine(item);
}


// function for reversing the array(descending)
int temp2;
for (int l = 0; l < array.Length / 2; l++)
{
    temp2 = array[array.Length - l - 1];
    array[array.Length - l - 1] = array[l];
    array[l] = temp2;
}


Console.WriteLine("\nTersine çevrilmiş yeni dizi:");
//show array element on console
foreach (var item in array)
{
    Console.WriteLine(item);
}