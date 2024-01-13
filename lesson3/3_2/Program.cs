using System.Collections;

int[] array = { 1, 4, 8, -5, 9, 10, -3, 8, -5, -1, 7 };

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write($"{array[i]} ");
}