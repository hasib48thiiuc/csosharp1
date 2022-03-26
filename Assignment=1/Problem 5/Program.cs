int[,] array = new int[100, 100];
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
for (int m = 0; m < i; m++)
{
    for (int n = 0; n < j; n++)
    {
        array[m, n] = Convert.ToInt32(Console.ReadLine());
    }
}
int sum1 = 0;
for (int m = 0; m < i; m++)
{
    for (int n = 0; n < j; n++)
    {
        if (m == n)
        { sum1 += array[m, n]; }
    }
}
Console.WriteLine(sum1);
int sum2 = 0;
for (int m = 0; m < i; m++)
{
    for (int n = j - 1; n >= 0;)
    {
        sum2 += array[m, n];
        break;
    }
}
Console.WriteLine(sum2);