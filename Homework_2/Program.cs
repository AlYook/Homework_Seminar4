// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter num: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;


for (int temp = 0; num > 0; num /= 10)
{
    temp = num % 10;
    sum = sum + temp;
}
Console.WriteLine(sum);