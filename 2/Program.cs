// Даны 2 числа. Показать большее и меньшее число

// System.Console.WriteLine("Введи первое число: ");
// double number1;
// number1 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Введи второе число: ");
// double number2;
// number2 = Convert.ToDouble(Console.ReadLine());
// double max = 0;
// double min = 9999999;
// if (number1 > number2) max = number1;
// if (number1 > number2) min = number2;
// if (number1 < number2) max = number2;
// if (number1 < number2) min = number1;
// System.Console.WriteLine("Максимальное число - " + max + ", Миниальное число - " + min);

System.Console.WriteLine("Введи первое число: ");
double number1;
number1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введи второе число: ");
double number2;
number2 = Convert.ToDouble(Console.ReadLine());
if (number1 > number2)
System.Console.WriteLine("Максимальное число - " + number1 + ", Минимальное число - " + number2);
else
System.Console.WriteLine("Максимальное число - " + number2 + ", Минимальное число - " + number1);