// Удалить вторую цифру трёхзначеого числа

int number = new Random().Next(100, 1000);
int secondNumber = ((number - (number % 10)) % 100);
int lastNumber = number - secondNumber;
int removeNumber = secondNumber / 10;
System.Console.WriteLine("Удаляемая средняя цифра: " + removeNumber);
System.Console.WriteLine("Случайное число: " + number);
System.Console.WriteLine("Итоговое число без средней цифры: " + lastNumber);