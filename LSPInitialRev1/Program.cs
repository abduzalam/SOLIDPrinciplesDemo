// See https://aka.ms/new-console-template for more information
using LSPInitialRev1;

Console.WriteLine("LSPInitialRev1!");

Console.WriteLine();

//If we implement LSP, we can make use of any any child class as parent class and get the desired result

var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
SumCalculator sum = new SumCalculator(numbers);
Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
Console.WriteLine();
EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");

// If we modify the code as below, we won't be able to get the correct result
Console.WriteLine();
SumCalculator Evensum = new EvenNumbersSumCalculator(numbers);

Console.WriteLine($"The sum of all the even numbers: {Evensum.Calculate()}"); // This prints 18 which is correct as we need 18 here


// So we modified the code to make it work , but still we modified the base class and derived class to make it work

// Now look at the LSP implementation LSPFinal project

