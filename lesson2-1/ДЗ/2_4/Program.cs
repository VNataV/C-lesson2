int a = int.Parse(Console.ReadLine()!);
string b = "";

b = a % 10 + b;
    a /= 10;

while (a > 0)
{
    b = a % 10 + "," + b;
    a /= 10;
}

Console.WriteLine(b);  
