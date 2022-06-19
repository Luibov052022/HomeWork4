// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int prompt(string message)
{
    Console.Write(message);
    string strnumber = Console.ReadLine();
    int number = int.Parse(strnumber);
    return number;
}

int VozvStep(int a, int b)
{
    int resault = 1;
    for (int i = 1; i <= b; i++)
    {   
        resault *= a;
    }
    return resault;
}

int numberA = prompt("Введите число А: ");
int numberB = prompt("Введите число B: ");
Console.WriteLine($"Число {numberA} в степени {numberB} равно {VozvStep(numberA,numberB)}");

