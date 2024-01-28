using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества четных элементов массива
    // numbers - массив, в котором ведется подсчет
    public static int CountEvenItems(int[] numbers)
    {
       void Print(int[] arr) 
{ 
 
for (int i = 0; i < 10; i++) 
{ 
Console.Write($"{arr[i]} "); 
} 
Console.WriteLine(); 
} 
int[] MassNums(int from, int to) 
{ 
int[] arr = new int[10]; 
for (int i = 0; i < 10; i++) 
arr[i] = new Random().Next(from, to + 1); 
return arr; 
} 
int num = int.Parse(Console.ReadLine()!); 
int start = int.Parse(Console.ReadLine()!); 
int stop = int.Parse(Console.ReadLine()!); 
int[] mass = MassNums(num, start, stop); 
Print(mass);

    }
    {
        if (arr[i] % 2 ==0)
        count++;
    }
    public static void PrintResult(int[] array)
    {
        Console.WriteLine(count);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}