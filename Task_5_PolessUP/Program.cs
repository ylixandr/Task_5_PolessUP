//Дан массив целых чисел (неупорядоченный). Реализуйте алгоритм, который находит элемент с максимальным значением. Не используйте LINQ. 
int[] array = { 1, 4, 2, 7, 3, 9, 0, -1 };


static int IndexOfMAx(int[] array)
{
    int max = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        { max = array[i]; }
    }

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == max)
        {
            index = i; break;
        }

    }
    return index;
}

Console.WriteLine(IndexOfMAx(array));