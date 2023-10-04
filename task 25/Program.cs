// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System.ComponentModel.Design.Serialization;

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int Exponentiation (int a, int b)
{
   int res = 1;
    for (int i = 1; i <= b; i++)
    { 
        res = res * a;

        
    }
    return res;
}

bool ValidNumber(int b)
{
    if(b < 0)
    {
        Console.WriteLine("Ошибка введите положительное значение степени");
        return false;
    }
    return true;
}

int numberA = Prompt("Введите число a = ");
int numberB = Prompt("Введите число b = ");

if (ValidNumber(numberB))
{

Console.WriteLine($"{numberA} в степени {numberB} -> {Exponentiation(numberA, numberB)}");

}
