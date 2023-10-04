// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System.Runtime.CompilerServices;

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int SumNumbers(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num%10;
        num/=10;
          
        
    }
    return res;
}

int number = Prompt("Введите число  = ");
Console.WriteLine($"{number} -> {SumNumbers(number)}");
