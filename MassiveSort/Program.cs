// алгоритм сортировки методом выбора/ Отсортировать массив от мин до макс

int [] arr = {1, 5, 7, 3, 7, 9};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j =  i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
System.Console.WriteLine();
PrintArray(arr);
