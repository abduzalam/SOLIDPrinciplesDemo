// See https://aka.ms/new-console-template for more information
using LSPFinal;

Console.WriteLine("LSPFinal!");
Console.WriteLine();

var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
Calculator sum = new SumCalculator(numbers);
Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
Console.WriteLine();
Calculator evenSum = new EvenNumbersSumCalculator(numbers);
Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");

// By implementing the LSP, we are keeping our functionality intact and still having our subclasses act as a substitute to a base class.