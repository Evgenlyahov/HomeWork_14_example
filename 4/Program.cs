// Найти максимальное из трёх чисел

System.Console.WriteLine("Введи первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
System.Console.WriteLine("Максимальное число - " + max);