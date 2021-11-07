// Показать вторую цифру трёхзначного числа

int number = new Random().Next(100, 1000);
System.Console.WriteLine("Дано трёхзначное число: " + number);
int secondNumber = ((number - number % 10) / 10) % 10; 
System.Console.WriteLine("Вторая цифра трёхзначного числа: " + secondNumber);