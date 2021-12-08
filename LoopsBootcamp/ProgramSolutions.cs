public static class Solution
{
    public static int SumNumbers(int[] numbers)
    {
        // return numbers.Sum();
        int sum = 0;

        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    public static int[] ReverseArrayOfNumbers(int[] numbers)
    {
        //return numbers.Reverse().ToArray();
        int[] reversed = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            reversed[i] = numbers[numbers.Length - 1 - i];
        }

        return reversed;
    }

    public static void PrintNumbersWithSeperatorSymbol(int[] numbers, char seperatorSymbol)
    {
        var toPrint = String.Join(seperatorSymbol, numbers);
        Console.WriteLine(toPrint);
    }

    public static int[] GenerateAllMultiplesOfTwoUpTo(int max)
    {
        var multiples = new List<int>();
        int currentValue = 2;

        while (currentValue <= max)
        {
            multiples.Add(currentValue);
            currentValue *= 2;
        }

        return multiples.ToArray();
    }

    public static int[] GenerateAllMultiples(int of, int upTo)
    {
        var multiples = new List<int>();
        int currentValue = of;

        while (currentValue <= upTo && currentValue != 0)
        {
            multiples.Add(currentValue);
            currentValue = Math.Clamp(currentValue * of, 0, int.MaxValue);
        }

        return multiples.ToArray();
    }

    public static int[] GenerateUniqueRandomNumbers(int count, int min, int max)
    {
        var generatedNumbers = new List<int>();
        var randomGenerator = new Random();

        while (generatedNumbers.Count < count)
        {
            var rndNum = randomGenerator.Next(min, max);

            if (!generatedNumbers.Contains(rndNum))
                generatedNumbers.Add(rndNum);
        }

        return generatedNumbers.ToArray();
    }

    public static int[] GenerateUniqueRandomNumbersSolution2(int count, int min, int max)
    {
        var allPossibleNumbers = new List<int>(Enumerable.Range(min, max - min + 1));
        var generatedNumbers = new List<int>();
        var randomGenerator = new Random();

        for (int i = 0; i < count; i++)
        {
            int rndIndex = randomGenerator.Next(allPossibleNumbers.Count);
            int rndNum = allPossibleNumbers[rndIndex];

            generatedNumbers.Add(rndNum);
            allPossibleNumbers.RemoveAt(rndIndex);
        }

        return generatedNumbers.ToArray();
    }
}


