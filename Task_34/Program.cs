/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Write("Задайте длинну массива : ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.Write("В массиве: ");
PrintArray(numbers);

void RandonNumbers(int[] numbers)
{
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
int counta = 0;
for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] % 2 == 0)
        counta++;
}
int countb = 0;
for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] % 2 != 0)
        countb++;
}


Console.WriteLine($"из {numbers.Length} чисел, {counta} четных, {countb} нечетных");
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.Write("]");
    Console.WriteLine();
}
