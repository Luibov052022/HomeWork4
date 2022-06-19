// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 

int[] ZapolnenieMassivaRandom(int ChisloElementov)
{
    int[] massiv = new int[ChisloElementov];
    for(int i = 0; i < ChisloElementov; i++)
    {
        massiv[i] = new Random().Next(1, 1000);
    }
    return massiv;
}

void PrintMassiv(int[] massiv)
{
    foreach(int i in massiv)
    {
        Console.Write($"{i} ");
    }
}

int[] array = ZapolnenieMassivaRandom(8);
PrintMassiv(array);