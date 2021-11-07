// Выяснить является ли число чётным

System.Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0 ) System.Console.WriteLine("Число " + number + " чётное");
else
System.Console.WriteLine("Число " + number + " нечётное");