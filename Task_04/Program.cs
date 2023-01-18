// Задача 4: 
// 1.Напишите программу, 
// 2. которая принимает на вход три числа и 
// 3. выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


using System; 
namespace main {

    class Program{
        static void Main(string[]args){
            Console.Write("Введите первое число:");
            int numbera = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число:");
            int numberb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число:");
            int numberc = Convert.ToInt32(Console.ReadLine());
            if (numbera>numberb) 
            {
                if(numbera>numberc)
                {
                  Console.WriteLine("Максимальное число:"+ numbera);
                }
                
                else{
               Console.WriteLine("Максимальное число:"+ numberc); 
                } 
            }
            else if (numberc>numberb)
            {
                 Console.WriteLine("Максимальное число:"+ numberc);
            }
            else 
            {
                Console.WriteLine("Максимальное число:"+ numberb); 
            }
            

        }
    }
}