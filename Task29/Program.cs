// Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
int[] array = Array(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] Array(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(1,9);
    }
    return result;
}