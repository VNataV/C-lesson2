Random rnd = new Random();
int value = rnd.Next(10, 99);
int num2 = value % 10;
int num1 = value / 10;
if (num1>num2){Console.WriteLine($"{value} -> {num1}");}
else {Console.WriteLine($"{value} -> {num2}");}


