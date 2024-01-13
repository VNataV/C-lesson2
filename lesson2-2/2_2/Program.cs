using System.Transactions;

Console.WriteLine("Enter Number()");
int a = int.Parse(Console.ReadLine()!);
int secondNum = a / 10 % 10;
int thirdNum = a % 10;
Console.WriteLine(Math.Pow(secondNum,thirdNum));
