// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int i = 0;
int result = 1;
while (i < numberB)
{
    result *= numberA;
    i++;
}
Console.WriteLine($"Число {numberA} в степени {numberB} равно {result}");