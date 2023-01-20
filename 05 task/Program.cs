//5. Напишите программу, которая на вход принимает 
//одно число (N), а на выходе показывает все целые 
//числа в промежутке от -N до N.

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    int count = -num;

    while (count <= num)
    {
        Console.Write(count + " ");
        count++;
    }
}
else
{
    Console.WriteLine("Вы ввели НЕ натуральное число");
}

