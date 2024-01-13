int[] a1 = { 1, 5, 8, 15, 7 };
int a2 = int.Parse(Console.ReadLine()!);
bool b = false;

for (int i = 0; i < a1.Length; i++)
{
    if (a2 == a1[i])
     {b = true;
     break;
     }
}
if (b)
    Console.Write("да");
else
    Console.Write("нет");
