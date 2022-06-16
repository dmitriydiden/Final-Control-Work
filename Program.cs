/* Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задачть на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключитльно массивами*/
//Вариант 1. Решаю задачу без использования метода.
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
/*Вариант 2. Решение задачи с помощью метода.
using System;
Console.Clear();
Console.Write("Введите желаемое количество строк в массиве:");
int l=int.Parse(Console.ReadLine());
string[] array = new string[l];
int count = 0;

Console.WriteLine($"Введите строки массива:");
for (int i = 0; i < l; i++)
{
    array[i] = Console.ReadLine();
    if (array[i].Length < 4)
    {
        count++;
    }
}
string[] newarray=NewArray(array, count);

string[] NewArray(string[] arr, int rows)
{
    string[] newarr = new string[rows];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            newarr[j] = arr[i];
            j++;
        }
    }
    return newarr;
}

Console.Write("[{0}]", string.Join(", ", array));
Console.Write(" -> [{0}]", string.Join(", ", newarray));*/
