int a = int.Parse(Console.ReadLine()!);
int b;

while (a > 0)
{
    b = a % 10; 
    a = a - b;
}
Console.WriteLine(a);

