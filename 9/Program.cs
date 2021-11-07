// Показать последнюю цифру трёхзначного числа

int number = new Random().Next(100, 1000);

System.Console.WriteLine("Дано трёхзначное число: " + number);

int lostNumber = number % 10;
System.Console.WriteLine("Последняя цифра трёхзначного числа: " + lostNumber);
