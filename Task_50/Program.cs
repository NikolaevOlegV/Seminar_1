
/*
 Задача 50. Напишите программу, которая на вход 
 принимает позиции элемента в двумерном массиве, и возвращает 
 значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет
 */

int line = ReadInt("Задайте индекс строки: ");
int columns = ReadInt("Задайте индекс столбца: ");
int[,] numbers = new int[4, 4];
FillArray(numbers);
PrintArray(numbers);

if (line < numbers.GetLength(0) && columns < numbers.GetLength(1)) Console.WriteLine(numbers[line, columns]);
else Console.WriteLine($"{line},{columns} -> такого элемента в массиве нет");


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}