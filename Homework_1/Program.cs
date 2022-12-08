// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Enter num1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter num2: ");
int num2 = int.Parse(Console.ReadLine());
int pow = num1;

for(int i = 1; i < num2; i++)
{
    pow = pow * num1;
}
Console.WriteLine(pow);