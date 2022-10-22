// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 100);

PrintArray(array);

Console.Write("Введите номер строки искомого числа: ");
int UserRow = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите номер столбца искогомго чиса: ");
int UserColumn = int.Parse(Console.ReadLine() ?? "");

int GetUserNumber = FoundNumber(array, UserRow, UserColumn);

if (GetUserNumber != -1) Console.Write($"Искомое число массива = {GetUserNumber}");
else Console.Write("Нет элемента с такими значениями строки и столбца");

//////////////////////// Methods///////////////////////////
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FoundNumber(int[,] inArray, int Row, int Column)
{
    if (Row < inArray.GetLength(0))
    {
        if (Column < inArray.GetLength(1)) ;
        {
            int number = inArray[Row, Column];
            return number;
        }
    }
    return -1;
}