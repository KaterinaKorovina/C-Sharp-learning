//Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//второго.

int a;
int b;
Console.WriteLine("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

if (a == b*b)
{
    Console.WriteLine("Первое число является квадратом второго");
}    
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго");
}
