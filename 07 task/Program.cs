//Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает последнюю цифру 
//этого числа.

Console.Write("Введите трехзначное цисло: ");
int num = Convert.ToInt32(Console.ReadLine());
int lastDigits = num % 10;
Console.WriteLine("Последняя цифра числа: " + lastDigits);