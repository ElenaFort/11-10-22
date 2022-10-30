/*Задача 25: Напишите цикл, который принимает на вход
 два числа (A и B) и возводит число A в натуральную 
 степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int GetTheFirstNumber(string message1)
{
Console.WriteLine(message1);
int result1 = int.Parse(Console.ReadLine());
return result1;

}
int GetTheSecondNumber(string message2)
{
Console.WriteLine(message2);
int result2 = int.Parse(Console.ReadLine());
return result2;

}

int GetExponentiation(int a, int b)
{
int expon = 1;
for (int i = 1; i <= b; i++)
{
    expon = expon * a;
}
return expon;

}
int a = GetTheFirstNumber("Введите число A:");
int b = GetTheSecondNumber("Введите натуральное число B:");

int expon = GetExponentiation(a,b);

Console.WriteLine($"{a} ^ {b} = {expon}");