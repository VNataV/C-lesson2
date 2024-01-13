int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
    if (a > b && a > c) return a;
      else if (b > c && b > a) return b;
      else return c;