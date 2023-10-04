// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System.Runtime.InteropServices;
using System.Runtime.Serialization;


int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] ArrayEight(int min, int max, int size)
{
    int[] arr = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
}
int minnumber = Prompt("Введите миннимальное значение мссива = ");
int mxnumber = Prompt("Введите максимальное значение массива = ");
int sizenumber = Prompt("Введите длину массива");


int[] array = ArrayEight(minnumber, mxnumber, sizenumber);

PrintArray(array);
Console.Write("-> [");
PrintArray(array);
Console.Write("]");

