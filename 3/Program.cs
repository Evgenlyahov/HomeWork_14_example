// По введённому номеру дня недели вывести его название
System.Console.Write("Введи номер дня недели (от 1 до 7) :");
short dayOfWeek = Convert.ToInt16(Console.ReadLine());
if (dayOfWeek == 1) System.Console.WriteLine("Monday");
if (dayOfWeek == 2) System.Console.WriteLine("Tuesday");
if (dayOfWeek == 3) System.Console.WriteLine("Wednesday");
if (dayOfWeek == 4) System.Console.WriteLine("Thursday");
if (dayOfWeek == 5) System.Console.WriteLine("Friday");
if (dayOfWeek == 6) System.Console.WriteLine("Saturday");
if (dayOfWeek == 7) System.Console.WriteLine("Sunday");