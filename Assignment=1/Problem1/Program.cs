Console.WriteLine("Enter The value : ");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
String str = Convert.ToString(value, 2);
Console.WriteLine("Binary representation : " + str);
Console.WriteLine();
Console.WriteLine("Enter rotaion time : ");
int r = Convert.ToInt32(Console.ReadLine());
int Length = str.Length;
int a = Convert.ToInt32(str);
Console.WriteLine("Int representation : " + a);
int[] arr = new int[Length];
for (int i = 0; a != 0; i++)
{
    int xm = a % 10;
    arr[i] = xm;
    a = a / 10;
}
Console.WriteLine("First array : ");
for (int k = 0; k < arr.Length; k++)
{
    Console.Write(arr[k] + " ");
}
Console.WriteLine();
Console.WriteLine(arr.Length);
int len = arr.Length, temp = 0;
int[] arr1 = new int[len];

if (r > len)
{
    temp = r % len;
    int i = 0, j = 0;
    j = temp;
    int p = len - temp;
    for (i = 0; i < p; i++, j++)
    {
        arr1[i] = arr[j];
    }
    int m = len - p;
    for (int x = 0; x < m; x++, i++)
    {
        arr1[i] = arr[x];
    }
    Console.WriteLine("Binary representation after " + r + "times rotation : ");
    for (int z = 0; z < len; z++)
        Console.Write(arr1[z] + " ");
}
else
{
    int i = 0, j = 0;
    temp = len % r;
    j = r;
    for (i = 0; i < len - r; i++, j++)
    {
        arr1[i] = arr[j];
    }
    for (int x = 0; x < r; x++, i++)
    {
        arr1[i] = arr[x];
    }
    Console.WriteLine("Binary representation after " + r + "times rotation : ");
    for (int z = 0; z < len; z++)
        Console.Write(arr1[z] + " ");
}
Console.WriteLine();