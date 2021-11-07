// Задача про друзей и собаку. Сколько раз собака пробежит от первого друга ко второму. 
// Между друзьями расстояние 10000. Скорость первого друга 1, скорость второго друга 2, скорость собаки 5
Console.Clear();
System.Console.WriteLine("3");
Thread.Sleep(1000);
System.Console.WriteLine("2");
Thread.Sleep(1000);
System.Console.WriteLine("1");
Thread.Sleep(1000);
System.Console.WriteLine("Start!");
System.Console.WriteLine();

double DistanceFull = 10000;
double distance = 10;
double FirstFriendSpeed = 1;
double SecondFriendSpeed = 2;
double DogSpeed = 5;
int count = 0;
double friend = 2; // Бежим ко второму другу
double time;

while (DistanceFull > distance)
{
    Thread.Sleep(500);
    if (friend == 2)
    {
        time = DistanceFull / (SecondFriendSpeed + DogSpeed);
        friend = 1;
    }
    else
    {
        time = DistanceFull /(FirstFriendSpeed + DogSpeed);
        friend = 2;
    }
    DistanceFull = DistanceFull - (FirstFriendSpeed + SecondFriendSpeed) * time;
    System.Console.WriteLine($"Собака пробежала {count + 1} раз");
    System.Console.WriteLine($"Расстояние составляет - {DistanceFull:F0}");
    count++;

}