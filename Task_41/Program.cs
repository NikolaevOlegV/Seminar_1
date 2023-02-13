/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223 -> 4
*/

string inputStr = ReadString("Введите числа через запятую:\n ");
int count = 0;
string tmpStr = string.Empty;

for (int i = 0; i < inputStr.Length; i++)
{
    if (inputStr[i] != ',') tmpStr += inputStr[i];
    else
    {
        if (Convert.ToInt32(tmpStr) > 0) count++;
        tmpStr = string.Empty;
    }
}
if (Convert.ToInt32(tmpStr) > 0) count++;

Console.WriteLine($"Введенные числа {inputStr} ->  {count} \nПозиций больше 0 = {count}.");

string ReadString(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}