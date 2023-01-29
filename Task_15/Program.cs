/*
Задача 15: 
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int dayNumber = ReadInt("Чтобы узнать день недели наберите число от 1 до 7: ");
Console.WriteLine(Weekday(dayNumber));

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

string Weekday(int numa)
{
    if (numa > 0 && numa < 8)
    {
        if (numa == 7 || numa == 6)
        {
            Console.Write("Под цифрой " + numa + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + numa + " - Рабочий");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное число(1-7):");
    }
    return " день.";
}