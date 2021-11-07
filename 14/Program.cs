// Найти третью цифру числа или сообщить, что её нет

int number = new Random().Next(100, 1000);
System.Console.WriteLine("Рандомное трёхзначное число: " + number);

int ostatok = (number % 10);
if (ostatok != 0)
{
    System.Console.WriteLine("Третья цифра: " + ostatok);
}
else
{
    System.Console.WriteLine("Третья цифра равна 0");
}
