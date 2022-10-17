// Задача 3: Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 7, 8

Printer(Fill(8));

int[] Fill(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        int r = new Random().Next(-100, 100);
        array[i] = r;

    }
    return array;
}

void Printer(int[] array)
{
    for (int i = 0; i <= array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}