int[] numbers = new int[] { 11, 32, 23, 14, 25, 236, 27, 28, 29, 10 };
for (int crap = 0; crap < numbers.Length; crap++)
	Console.Write(numbers[crap] + " ");
Console.WriteLine();
Console.WriteLine();

Array.Reverse(numbers);
for (int i = 0; i < numbers.Length; i++)
	Console.Write(numbers[i] + " ");

Array.Reverse(numbers);

int[] ground = new int[5];
int[] purple = new int[5];
for (int i = 0, j = 0, k = 0; i < numbers.Length; i++)
{
	if (numbers[i] % 2 == 0)
	{
		ground[j] = numbers[i];
		j++;
	}
	else
	{
		purple[k] = numbers[i];
		k++;
	}
}
Console.WriteLine();
Console.WriteLine();


Array.Reverse(ground);
Array.Reverse(purple);

Console.WriteLine();

for (int i = 0; i < ground.Length; i++)
	Console.Write(ground[i] + ", ");
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < purple.Length; i++)
	Console.Write(purple[i] + ", ");
Console.WriteLine();
Console.WriteLine();