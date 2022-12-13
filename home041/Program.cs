// задача 29. На входе массив из 8 элементов, вывести его на экран
int [] arr = {1, 2, 5, 7, 19};
void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array [i]}, ");
    }
    Console.WriteLine();
}

PrintArray(arr);


