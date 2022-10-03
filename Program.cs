// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
double number1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
double number2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
double number3 = double.Parse(Console.ReadLine()!);
if(number1 > number2 && number1 > number3)
{
    Console.WriteLine($"{number1} является максимальным числом");
}
else if(number2 > number1 && number2 > number3)
{
    Console.WriteLine($"{number2} является максимальным числом");
}
else if(number3 > number1 && number3 > number2)
{
    Console.WriteLine($"{number3} является максимальным числом");
}