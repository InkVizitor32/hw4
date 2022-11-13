Console.Clear();
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
                                    //         и возводит число A в натуральную степень B.

                                    // 3, 5 -> 243 (3⁵)
                                    // 2, 4 -> 16


// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());


// SumNumbers(a);
// void SumNumbers(int a)
// {
// int N=1;
// for (int i = 1; i<=b; i++)
// N = a*N;
// Console.WriteLine($" {a} в натуральной степени {b} = {N}");
// }




                        // Задача 27: Напишите программу, которая принимает на вход число
                        //         и выдаёт сумму цифр в числе. Через строку решать нельзя.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = 0;

// SumNumbers(a);
// void SumNumbers(int a)
// {
//  while (a > 0)
//  {
//     b = b +a%10;
//     a = a/10;
// }
// }
// Console.WriteLine($"сумма цифр в числе равна  {b}");
                                            




                                //    Задача 29:               Напишите программу, которая задаёт массив из 8
                                //                             элементов с клавиатуры и выводит массив на экран.

int [] array = new int[8];

FillArray(array);
void FillArray(int[] array)       
{
int lenght = 8;
int index = 0;
while (index<lenght)
{
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());    
array[index] = a;    
index++;
}
}

PrintArray(array);
void PrintArray (int[] array)           
{
    int count = 8;
    for  (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
     Console.WriteLine();
}


