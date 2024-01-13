Console.WriteLine("Enter a number: ");


int firstNumber = int.Parse(Console.ReadLine()!);
int secondNumber = int.Parse(Console.ReadLine()!);

if (firstNumber == secondNumber)
    Console.WriteLine ($"Введенные числа равны '{firstNumber}'");
    else if (firstNumber < secondNumber) 
        Console.WriteLine($"Первое число '{firstNumber}' меньше чем второе число '{secondNumber}'");
    else Console.WriteLine($"Первое число '{firstNumber}' больше чем второе число '{secondNumber}'");
