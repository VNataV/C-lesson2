int[] arr = new int[7] { 3, 8, 15, 27, 145, 0, 14 };
int i = 0;

for (i = 0; i < arr.Length / 2; i++)
{
    int j = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = j;
}
Console.WriteLine(string.Join(", ", arr));