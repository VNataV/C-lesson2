int [] a1 = {1, 3, 5, 8, 7, 15, 2};
int [] result = new int[a1.Length / 2 + a1.Length % 2];
int j = 0;

for (int i = 0; i < a1.Length / 2;  i ++)
    {result[j] = a1[i] * a1[a1.Length - i - 1];
    j++;}
if (a1.Length % 2 == 1);
    {result[j] = a1[a1.Length / 2];}
Console.WriteLine(string.Join(" ", result));






