

// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1


void ElementEndStart(int[] Array, int n)
{
    if (n > 0)
    {
        Console.Write(Array[n] + " ");
        ElementEndStart(Array, n - 1);
    }
    else Console.WriteLine(Array[0]);
}

{
    int[] num = { 1, 2, 5, 0, 10, 34 };
    ElementEndStart(num, num.Length - 1);
}



