// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень числа: ");
int B = int.Parse(Console.ReadLine()!);
void move(int A, int B)
{
    int result = Convert.ToInt32(Math.Pow(A,B));
    Console.Write($"Число {A} в степени {B} равно {result}");
}
move(A, B);
