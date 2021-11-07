// Выяснить кратно ли число заданному, если нет – вывести остаток

float number = new Random().Next(10,21);
System.Console.WriteLine("Введи число от 2 до 4 : ");
float numberInput = float.Parse(Console.ReadLine());

if(number % numberInput == 0)
{
    System.Console.WriteLine("Числа кратны");
}
if(number % numberInput != 0)
{
    float ostatok = number % numberInput;
    System.Console.WriteLine("Числа не кратны. Остаток от деления равен: " + ostatok);
}
System.Console.WriteLine("Введённое число: " + numberInput);
System.Console.WriteLine("Рандомное число: " + number);