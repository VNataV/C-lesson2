﻿using System.Globalization;

void Print(int[] arr) 
{ 
int size = arr.Length; 
for (int i = 0; i < size; i++) 
{ 
Console.Write($"{arr[i]} "); 
} 
Console.WriteLine(); 
} 
int[] MassNums(int size, int from, int to) 
{ 
int[] arr = new int[size]; 
for (int i = 0; i < size; i++) 
arr[i] = new Random().Next(from, to + 1); 
return arr; 
} 
int num = int.Parse(Console.ReadLine()!); 
int start = int.Parse(Console.ReadLine()!); 
int stop = int.Parse(Console.ReadLine()!); 
int[] mass = MassNums(num, start, stop); 
Print(mass);

int count = 0; 
foreach (int number in mass) 
{ 
    if (number % 2 == 0)
    count++; 
}
Console.WriteLine (count);
