// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int prompt(string message)
{
    Console.Write(message);
    string StrNumber = Console.ReadLine();
    int Number = int.Parse(StrNumber);
    return Number;
}

int Sum(int Number)
{
    int sum = 0;
    while(Number > 0)
    {
        sum += Number % 10;
        Number = Number/10;
    }
    return sum;
}

int number = prompt("Введите число: ");
Console.WriteLine($"сумма цифр в числе {number} равна {Sum(number)}");
