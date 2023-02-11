/*Задача 29:
 Напишите программу, которая задаёт массив из
  8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]*/

void MasArray(int[] arr, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
}
string PrintArray(int[] arr)
{
    string res = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        if (res == String.Empty) res += arr[i];
        else res += $",{arr[i]}";
    }
    return res;
}

int[] arrayNumbers = new int[8];
MasArray(arrayNumbers, 0, 100);
Console.Write($"{PrintArray(arrayNumbers)} -> [{PrintArray(arrayNumbers)}]");