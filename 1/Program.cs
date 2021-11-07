// По двум введённым числам проверять является ли первое квадратом второго
System.Console.Write("Введи первое число: ");
float number1;
number1 = float.Parse(Console.ReadLine());
System.Console.Write("Введи второе число: ");
float number2;
number2 = float.Parse(Console.ReadLine());
if (number1 == number2 * number2)
System.Console.WriteLine("Первое число является квадратом второго");
else
{
    System.Console.WriteLine("Первое число не является квадратом второго");
}