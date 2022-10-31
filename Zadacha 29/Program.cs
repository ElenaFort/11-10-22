/*Задача 29: Напишите программу, которая задаёт массив
 из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элеменетов через консоль (через запятую.
использовать метод string.Split())*/

Console.WriteLine("Введите числа через запятую");
string str = Console.ReadLine();
string[] array = str.Split(',');
int[] nArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    nArray[i] = int.Parse(array[i]);
}
Console.WriteLine("Наш массив");
for (int i = 0; i < nArray.Length; i++)
{
    if (i == 0)
        Console.Write($"[{nArray[i]},");
    else if (i < nArray.Length - 1)
        Console.Write($"{nArray[i]},");
    else
        Console.Write($"{nArray[i]}]");
}
