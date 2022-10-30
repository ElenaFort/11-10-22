/*Задача 27: Напишите программу, которая принимает на вход
 число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int GetSummNumber(int number)
{
    int summ = 0;
    int ost = 0;
    while (number > 0)
    {
        ost = number % 10;
        summ = summ + ost;
        number = number / 10;
    }
    return summ;
}
int number = GetNumber("Введите число:");
int summ = GetSummNumber(number);

Console.WriteLine($"Сумма цифр в числе {number} = {summ}");
