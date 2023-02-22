// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int summ = 0;
while (number != 0)
{
    int count = number % 10;
    number = number / 10;
    summ += count;
}
Console.WriteLine($"Сумма цифр равна {summ}");