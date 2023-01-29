/*Задача 13: 
Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
*/

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(SumArray(number, count));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumArray(int numa, int numb)
{
int result = 0;
    if (numb < 3)
    {
        Console.Write("Введите трехзначное число:");
    }
    else
    {
        int numc = 1;
        for (int i = numb; i > 3; i--)
        {
            numc *= 10;
        }

        result = (numa / numc) % 10;
    }
return result;
}