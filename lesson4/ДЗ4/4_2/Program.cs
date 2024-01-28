int[] numbers = { 2, 8, 2, 10, 6, 3, 7, 8, 2, 15 };
int count = 0;

foreach (int number in numbers)

{
    if (number % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine(count);
