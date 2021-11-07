// Дано число из отрезка [10, 99]. Показать наибольшую чифру числа

int interval = new Random().Next(10, 100);
System.Console.WriteLine("Случайное число: " + interval);

int b = interval % 10;
int a = (interval - (interval % 10)) / 10;
if (a > b)
{
    System.Console.WriteLine("Первая цифра: " + a + ", больше второй цифры: " + b);
}
if (a == b)
{
    System.Console.WriteLine("Цифры равны");
}
if (a < b)
{
    System.Console.WriteLine("Вторая цифра: " + b + ", больше первой цифры: " + a);
}