// Показать чётные числа от 1 до N

int[] array = new int[20];
Random random = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(random.Next(-100, 100));
    if(array[i] % 2 == 0 && array[i] > 1)
    {
        System.Console.WriteLine(array[i]);
    }
}