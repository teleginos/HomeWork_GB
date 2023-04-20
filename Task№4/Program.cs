Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 & number1 > number3) Console.Write($"Максималльное из чисел = {number1}");
if (number2 > number1 & number2 > number3) Console.Write($"Максималльное из чисел = {number2}");
if (number3 > number1 & number3 > number2) Console.Write($"Максималльное из чисел = {number3}");

