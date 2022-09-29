// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int Sum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}
Console.Write(Sum(number));

