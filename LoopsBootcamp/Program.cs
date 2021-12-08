
int SumNumbers(int[] numbers)
{
    // return numbers.Sum();

    int sum = 0;

    foreach (var number in numbers)
    {
        sum += number;
    }

    return sum;
}

int[] ReverseArrayOfNumbers(int[] numbers)
{
    //return numbers.Reverse().ToArray();

    int[] reversed = new int[numbers.Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        reversed[i] = numbers[numbers.Length - 1 - i];
    }

    return reversed;
}

void PrintNumbersWithSeperatorSymbol(int[] numbers, char seperatorSymbol)
{
    var toPrint = String.Join(seperatorSymbol, numbers);
    Console.WriteLine(toPrint);
}

int[] GenerateAllMultiplesOfTwoUpTo(int max)
{
    var multiples = new List<int>();
    int currentValue = 2;

    while (currentValue < max)
    {
        multiples.Add(currentValue);
        currentValue *= 2;
    }

    return multiples.ToArray();
}

int[] GenerateUniqueRandomNumbers(int count, int min, int max)
{
    var generatedNumbers = new List<int>();
    var randomGenerator = new Random();

    while (generatedNumbers.Count < count)
    {
        var rndNum = randomGenerator.Next(min, max);
            
        if(!generatedNumbers.Contains(rndNum))
            generatedNumbers.Add(rndNum);
    }

    return generatedNumbers.ToArray();
}

int[] GenerateUniqueRandomNumbersSolution2(int count, int min, int max)
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

PrintNumbersWithSeperatorSymbol(GenerateAllMultiplesOfTwoUpTo(100000), ';');
