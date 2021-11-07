// Написать программу вычисления значения функции y=f(a)
// В моей функции будем находить Y после ввода X и Z. y = x * z

System.Console.Write("Введи X : ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введи Z : ");
int z = Convert.ToInt32(Console.ReadLine());
int y = x * z;
System.Console.WriteLine(x + " * " + z + " = " + y);