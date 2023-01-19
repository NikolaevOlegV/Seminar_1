 /*Задача 8: 
1. Напишите программу, которая на вход принимает число (N), 
2. а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
             
*/


Console.Write(" Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i=2; i<=number; i+=2)
{
    Console.Write(i);
    if(i <= number -2)
    {
       Console.WriteLine(",");
    }
}