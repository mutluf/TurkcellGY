//dizideki en büyük ve en küçük elemanı bulup iki sayının ortalamasını diziye yeni eleman olarak ekleyen ve diziyi kabarcık sıralamaya göre sıralayan program

int[] array = { 24, 6, 52, 38, 76, 94 };
int total = 0;
Console.Write("Dizi:");
foreach (var item in array)
{
    Console.Write($"{item} ");
}

List<int> arrayList = new List<int>();

int smallestNumber = array[0];
int greaterNumber = array[0];

// find smallest and greater number with for loop
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < smallestNumber)
    {
        smallestNumber = array[i];
    }

    if (array[i] > greaterNumber)
    {
        greaterNumber = array[i];
    }
    //for our new array which has average element
    arrayList.Add(array[i]);
}

Console.WriteLine($"\n Dizideki en küçük sayı:{smallestNumber}, dizideki en büyük sayı:{greaterNumber}");
//find average
int average = (smallestNumber + greaterNumber) / 2;

//our new array includes average element.
arrayList.Add(average);
int[] newArray = arrayList.ToArray();

//sorting array with bubble sort
int temp;
for (int i = 0; i < newArray.Length - 1; i++)
{
    total += newArray[i];
    for (int j = 0; j < newArray.Length - 1 - i; j++)
    {
        if (newArray[j] > newArray[j + 1])
        {
            temp = newArray[j];
            newArray[j] = newArray[j + 1];
            newArray[j + 1] = temp;
        }
    }
}

int arrayAverage = total / newArray.Length;

Console.WriteLine("\n Kabarcık sıralama ile küçükten büyüğe sıralanmış dizi:");
foreach (var item in newArray)
{
    Console.WriteLine(item);
}

Console.WriteLine($"\nYeni dizinin aritmetik ortalaması: {arrayAverage}");
