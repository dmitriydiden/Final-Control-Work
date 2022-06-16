
using System;
Console.Clear();
Console.Write("Введите желаемое количество строк в массиве:");
int l=int.Parse(Console.ReadLine());
string[] array = new string[l];
int count = 0;
string[] newarray;

Console.WriteLine($"Введите строки массива:");
for (int i = 0; i < l; i++)
{
    array[i] = Console.ReadLine();
    if (array[i].Length < 4)
    {
        count++;
    }
}
newarray = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        newarray[j] = array[i];
        j++;
    }
}
Console.Write("[{0}]", string.Join(", ", array));
Console.Write(" -> [{0}]", string.Join(", ", newarray));
