int[][,] Jagger = new int[][,]
{
        new int[, ] {{1, 3}, {5, 7}},
        new int[, ] {{0, 2}, {4, 6}, {8, 10}},
        new int[, ] {{11, 22}, {99, 88}, {0, 9}}
};
for (int one = 0; one < Jagger.Length; one++)
{
    int value = 0;
    for (int two = 0; two < Jagger[one].GetLength(value); two++)
    {
        for (int k = 0; k < Jagger[two].Rank; k++)
            Console.Write("Jagged Array[" + one + "][" + two + ", " + k + "] = "
                                        + Jagger[one][two, k] + "   ");
        Console.WriteLine();
    }
    Console.WriteLine();
    value++;
    Console.WriteLine();
}